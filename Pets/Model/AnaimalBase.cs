using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Pets.Model
{
    public abstract class AnimalBase : IEntity
    {
        public int Id { get; set; }

        public bool Save()
        {
            return false;
        }
    }
}
