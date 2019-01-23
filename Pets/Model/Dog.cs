using System;
using System.Collections.Generic;
using System.Text;

namespace Pets.Model
{
    public class Dog : AnimalBase
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Owner Owner { get; set; }
        
    }
}
