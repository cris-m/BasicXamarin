using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarin.XAML.Controls.Module
{
    public class ProductGroup:List<Product>
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public ProductGroup(string name, string shortname)
        {
            Name = name;
            ShortName = shortname;
        }
    }
}
