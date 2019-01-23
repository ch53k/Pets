using System;
using System.Collections.Generic;
using System.Text;

namespace Pets.Model
{
    public class Owner : IEntity
    {
        public int Id { get; set; }
        public List<int> Dogs { get; set; }
    }
}
