using System;
using System.Collections.Generic;
using System.Text;
using Pets.Model;

namespace Pets.Service
{
    public class OwnerService : ServiceBase<Owner>
    {
        private const string FileName = "owners.json";
        public OwnerService(string folderPath) : base(folderPath, FileName)
        {
        }
    }
}
