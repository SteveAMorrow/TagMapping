using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace TagMappingEdit
{
    public class MappingReader
    {

        //NEW this is specific to tagmapping
        public TagClassMappingHelper TagClassMappingHelper { get; set; }

        //already in existing code, used here to simulate
        private IDictionary<string, Mapping> TagClassMappingConfig { get; set; }
        private JsonDeserializer m_mappingDeserializer = null;
        private MappingConfiguration systemMapping = null;
        private string m_usercfg = null;
        public MappingReader(string systemCfg, string usercfg, bool useUserCfg)
        {
            m_mappingDeserializer = new JsonDeserializer();
            m_usercfg = usercfg;
            if (useUserCfg)
            {
                if (File.Exists(usercfg))
                    systemCfg = usercfg;
                else
                {
                    Console.Write("User cfg was specified, but that files does not exist, copying system to user");
                    File.Copy(systemCfg, usercfg);
                }
            }

            systemMapping = m_mappingDeserializer.DeserializeConfiguration(systemCfg);
            SetTagMapping(systemMapping);

            //NEW this is specific to tagmapping
            //this call would be intergrated into existing code
            TagClassMappingHelper = new TagClassMappingHelper(TagClassMappingConfig, m_usercfg);
        }

        private void SetTagMapping(MappingConfiguration systemMapping)
        {
            TagClassMappingConfig = new Dictionary<string, Mapping>();
            foreach (Mapping map in systemMapping.MappingsTagClass)
            {
                if (map.Source == null)
                    continue;
                string key = map.Source.Trim().ToLower();
                if (string.IsNullOrEmpty(key) || TagClassMappingConfig.ContainsKey(key))
                    continue;

                TagClassMappingConfig.Add(key, map);
            }
        }

    }

    //already in existing code, used here to simulate
    public class JsonDeserializer
    {
        /// <summary>Deserializes the configuration.</summary>
        /// <param name="configFile">The configuration file.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public MappingConfiguration DeserializeConfiguration(string configFile)
        {
            if (String.IsNullOrEmpty(configFile) || !System.IO.File.Exists(configFile))
                return null;

            try
            {
                JObject jsonData = JObject.Parse(System.IO.File.ReadAllText(configFile));

                return jsonData.ToObject<MappingConfiguration>();
            }
            catch (Exception ex)
            {
                throw new Exception("error", ex);
            }
        }

    }

    //already in existing code, used here to simulate
    public class Mapping
    {
        /// <summary>Gets or sets the source.</summary>
        /// <value>The source.</value>
        public string Source { get; set; }
        /// <summary>Gets or sets the display.</summary>
        /// <value>The display.</value>
        public string Display { get; set; }
        /// <summary>Gets or sets the category.</summary>
        /// <value>The category.</value>
        public string Category { get; set; }
        /// <summary>Gets or sets the mapped targets.</summary>
        /// <value>The mapped targets.</value>
        public IList<string> MappedTargets { get; set; }
        /// <summary>Gets or sets the exclude targets.</summary>
        /// <value>The exclude targets.</value>
        public IList<string> ExcludeTargets { get; set; }
        /// <summary>Gets or sets the matched relationships.</summary>
        /// <value>The matched relationships.</value>
        public IList<string> MatchedRelationships { get; set; }
        /// <summary>Gets or sets the match relationship required.</summary>
        /// <value>The match relationship required.</value>
        public bool? MatchRelationshipRequired { get; set; }
        /// <summary>Gets or sets the is polymorphic.</summary>
        /// <value>The is polymorphic.</value>
        public bool? IsPolymorphic { get; set; }
        /// <summary>Gets or sets a value indicating whether [use source as filter].</summary>
        /// <value>
        ///   <c>true</c> if [use source as filter]; otherwise, <c>false</c>.</value>
        public bool UseSourceAsFilter { get; set; } = false;
        /// <summary>Gets or sets the filter by property.</summary>
        /// <value>The filter by property.</value>
        public string FilterByProperty { get; set; } = string.Empty;
        /// <summary>Gets or sets the shared property display.</summary>
        /// <value>The shared property display.</value>
        public string SharedPropertyDisplay { get; set; } = string.Empty;
        /// <summary>Gets or sets the property match relationship.</summary>
        /// <value>The property match relationship.</value>
        public string PropertyMatchRelationship { get; set; }
        /// <summary>Gets or sets the property matches.</summary>
        /// <value>The property matches.</value>
        public IList<string> PropertyMatches { get; set; }
        /// <summary>Gets or sets a value indicating whether [allow browse].</summary>
        /// <value>
        ///   <c>true</c> if [allow browse]; otherwise, <c>false</c>.</value>
        public bool AllowBrowse { get; set; } = true;

        //used with right click
        //formats the placement display
        //"{0} {1}"
        //"{0} {1}, then do this"
        //"Create for work {0} {1}, then do this"
        public string PlacementFormat { get; set; } = string.Empty;

        public IList<string> GetMappingQueryClasses(string mappingKey)
        {
            return MappedTargets;
        }

    }

    //already in existing code, used here to simulate
    public class MappingConfiguration
    {
        public IList<Mapping> MappingsTagClass { get; set; }
    }

    //NEW this is specific to tagmapping
    public enum TagMapType
    {
        Map2D,
        Map3D,
        MapBase,
        Unknown
    }
   

    public class TagClassMappingHelper
    {
        public const string Mapping2DPrefix = "oppid";
        public const string Mapping3DPrefix = "op3d";

        public IDictionary<string, Mapping> TagClassMappingConfig { get; set; }
        private string m_usercfg = null;
        public TagClassMappingHelper(IDictionary<string, Mapping> tagClassMappingConfig, string userCfg)
        {
            TagClassMappingConfig = tagClassMappingConfig;
            m_usercfg = userCfg;
        }
        public void Save()
        {
            try
            {
                MappingConfiguration mp = new MappingConfiguration();
                mp.MappingsTagClass = TagClassMappingConfig.Values.ToList();

                string dirName = Path.GetDirectoryName(m_usercfg);
                if (!Directory.Exists(dirName))
                    Directory.CreateDirectory(dirName);

                using (TextWriter tw = new StreamWriter(m_usercfg, false))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(tw, mp);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        public void Populate(RadListView list2D, RadListView list3D)
        {
            list2D.Items.Clear();
            list3D.Items.Clear();
            foreach (Mapping map in TagClassMappingConfig.Values)
            {
                string prefix = string.Empty;
                string clsName = string.Empty;

                TagMapType tm = GetPrefix(map.Source, out prefix, out clsName);
                if (tm == TagMapType.Unknown)
                    continue;

                ListViewDataItem lv = new ListViewDataItem(clsName);
                lv.Tag = map;

                switch (tm)
                {
                    case TagMapType.Map2D:
                        list2D.Items.Add(lv);
                        break;
                    case TagMapType.Map3D:
                        list3D.Items.Add(lv);
                        break;
                    case TagMapType.MapBase:
                        break;
                }
            }
        }

        public bool AlreadyDefined(string source)
        {
            foreach (Mapping map in TagClassMappingConfig.Values)
            {
                if (map.Source.Equals(source, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }

        private TagMapType GetPrefix(string classNameWithSchemaPrefix, out string prefix, out string clsName)
        {
            prefix = string.Empty;
            clsName = string.Empty;

            string[] parse = classNameWithSchemaPrefix.Split(':');
            if (parse.Length <= 1)
                return TagMapType.Unknown;

            prefix = parse[0].ToLower();
            clsName = parse[1];

            switch (prefix)
            {
                case "oppid":
                    return TagMapType.Map2D;
                case "op3d":
                    return TagMapType.Map3D;
                case "op":
                    return TagMapType.MapBase;

            }
            return TagMapType.Unknown;
        }

        //private IECClass GetClassFromSchemaPrefix(IECSchema schema, string classNameWithSchemaPrefix)
        //    {
        //    string[] parse = classNameWithSchemaPrefix.Split (':');
        //    if (parse.Length <= 1)
        //        return schema.GetClass (classNameWithSchemaPrefix);

        //    string prefix = parse[0];
        //    string clsName = parse[1];

        //    IList<IECSchema> schemas = ECObjects.ECObjects.FindAllSchemasInGraph (schema);
        //    foreach (IECSchema sch in schemas)
        //        {
        //        if(sch.NamespacePrefix.Equals (prefix, StringComparison.InvariantCultureIgnoreCase))
        //            return sch.GetClass (clsName);
        //        }

        //    DisplayDebugToMessageCenter (string.Format ("Class name '{0}' not found in any schema", classNameWithSchemaPrefix), string.Empty, false);
        //    return null;
        //    }

        public Mapping Clone(Mapping mapping)
        {
            Mapping clone = new Mapping();
            clone.MappedTargets = mapping.MappedTargets;
            clone.Source = mapping.Source;
            clone.IsPolymorphic = mapping.IsPolymorphic;
            clone.Category = mapping.Category;
            clone.AllowBrowse = mapping.AllowBrowse;
            clone.Display = mapping.Display;
            return clone;
        }

        public DialogResult InputBox(string title, ref string value)
        {
            InputDialog createNewMapping = new InputDialog(title, ref value);
            DialogResult dialogResult = createNewMapping.ShowDialog();
            value = createNewMapping.ClassName;
            return dialogResult;
        }
    }
}

