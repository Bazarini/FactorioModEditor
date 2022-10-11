using FactorioModEditor.Tools;

namespace FactorioModEditor.Core.Entities
{
    public class Recipe
    {
        private string _name;
        private string _description;
        private string _localizedName;
        private string _localizedDescription;
        private bool _enabled;
        private string _category;
        private IList<IIngredient> _ingredients;
        private IList<IProduct> _products;
        private bool _hidden;
        private bool _hiddenFromFlowStats;
        private double _energy;
        private string _order;
        private Group _group;
        private Group _subGroup;
        private object _force;
        private bool _valid;
        private string _objectName;

        public string Name { get => _name; set => _name = value; }

        public string Description { get => _description; set => _description = value; }

        [LuaPropertyName("localized_name")]
        public string LocalizedName { get => _localizedName; set => _localizedName = value; }

        [LuaPropertyName("localized_description")]
        public string LocalizedDescription { get => _localizedDescription; set => _localizedDescription = value; }

        public bool Enabled { get => _enabled; set => _enabled = value; }

        public string Category { get => _category; set => _category = value; }

        public IList<IIngredient> Ingredients { get => _ingredients; set => _ingredients = value; }

        public IList<IProduct> Products { get => _products; set => _products = value; }

        public bool Hidden { get => _hidden; set => _hidden = value; }

        [LuaPropertyName("hidden_from_flow_stats")]
        public bool HiddenFromFlowStats { get => _hiddenFromFlowStats; set => _hiddenFromFlowStats = value; }

        public double Energy { get => _energy; set => _energy = value; }

        public string Order { get => _order; set => _order = value; }

        public Group Group { get => _group; set => _group = value; }

        public Group SubGroup { get => _subGroup; set => _subGroup = value; }

        public object Force { get => _force; set => _force = value; }

        public bool Valid { get => _valid; set => _valid = value; }

        [LuaPropertyName("object_name")]
        public string ObjectName { get => _objectName; set => _objectName = value; }
    }
}