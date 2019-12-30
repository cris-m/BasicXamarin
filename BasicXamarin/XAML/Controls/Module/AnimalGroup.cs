using System;
using System.Collections.Generic;
using System.Text;

namespace BasicXamarin.XAML.Controls.Module
{
    public class AnimalGroup:List<Animal>
    {
        public string Name { get; private set; }
        public AnimalGroup(string name, List<Animal> animals):base(animals)
        {
            Name = name;
        }
    }
}
