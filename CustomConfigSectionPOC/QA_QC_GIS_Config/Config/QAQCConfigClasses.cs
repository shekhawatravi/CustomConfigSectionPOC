using System;
using System.Configuration;

namespace QA_QC_GIS_Config.Config
{
    public class QAQCConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("bundles", IsDefaultCollection = true)]
        public BundleElementCollection Bundles
        {
            get
            {
                BundleElementCollection bundleCollection = (BundleElementCollection)base["bundles"];
                return bundleCollection;
            }
        }
    }

    public class BundleElementCollection : ConfigurationElementCollection
    {
        public new BundleElement this[string name]
        {
            get
            {
                if (IndexOf(name) < 0) return null;
                return (BundleElement)BaseGet(name);
            }
        }

        public BundleElement this[int index]
        {
            get { return (BundleElement)BaseGet(index); }
        }

        public int IndexOf(string name)
        {
            name = name.ToLower();

            for (int idx = 0; idx < base.Count; idx++)
            {
                if (this[idx].Name.ToLower() == name)
                    return idx;
            }
            return -1;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new BundleElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((BundleElement)element).Name;
        }

        protected override string ElementName
        {
            get { return "bundle"; }
        }
    }
    public class BundleElement : ConfigurationElement
    {
        public BundleElement()
        {
        }

        public BundleElement(string name, string alias)
        {
            this.Name = name;
            this.Alias = alias;
        }

        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("alias", IsRequired = true)]
        public string Alias
        {
            get { return (string)this["alias"]; }
            set { this["alias"] = value; }
        }

        [ConfigurationProperty("layers", IsDefaultCollection = true)]
        public LayerElementCollection Layers
        {
            get
            {
                LayerElementCollection layerCollection = (LayerElementCollection)base["layers"];
                return layerCollection;
            }
        }
    }


    public class LayerElementCollection : ConfigurationElementCollection
    {
        public new LayerElement this[string name]
        {
            get
            {
                if (IndexOf(name) < 0) return null;
                return (LayerElement)BaseGet(name);
            }
        }

        public LayerElement this[int index]
        {
            get { return (LayerElement)BaseGet(index); }
        }

        public int IndexOf(string name)
        {
            name = name.ToLower();

            for (int idx = 0; idx < base.Count; idx++)
            {
                if (this[idx].Name.ToLower() == name)
                    return idx;
            }
            return -1;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new LayerElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((LayerElement)element).Name;
        }

        protected override string ElementName
        {
            get { return "layer"; }
        }
    }
    public class LayerElement : ConfigurationElement
    {
        public LayerElement()
        {
        }

        public LayerElement(string name)
        {
            this.Name = name;
        }

        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("fields", IsDefaultCollection = true)]
        public FieldElementCollection Fields
        {
            get
            {
                FieldElementCollection fieldCollection = (FieldElementCollection)base["fields"];
                return fieldCollection;
            }
        }
    }


    public class FieldElementCollection : ConfigurationElementCollection
    {
        public new FieldElement this[string name]
        {
            get
            {
                if (IndexOf(name) < 0) return null;
                return (FieldElement)BaseGet(name);
            }
        }

        public FieldElement this[int index]
        {
            get { return (FieldElement)BaseGet(index); }
        }

        public int IndexOf(string name)
        {
            name = name.ToLower();

            for (int idx = 0; idx < base.Count; idx++)
            {
                if (this[idx].Key.ToLower() == name)
                    return idx;
            }
            return -1;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMap; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new FieldElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FieldElement)element).Key;
        }

        protected override string ElementName
        {
            get { return "field"; }
        }
    }
    public class FieldElement : ConfigurationElement
    {
        public FieldElement()
        {
        }

        public FieldElement(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        [ConfigurationProperty("key", IsRequired = true, IsKey = true)]
        public string Key
        {
            get { return (string)this["key"]; }
            set { this["key"] = value; }
        }

        [ConfigurationProperty("value", IsRequired = true, IsKey = false)]
        public string Value
        {
            get { return (string)this["value"]; }
            set { this["value"] = value; }
        }
    }

}
