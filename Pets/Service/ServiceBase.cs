using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Pets.Model;

namespace Pets.Service
{
    public abstract class ServiceBase<T> : IDisposable where T : IEntity
    {
        public List<T> Entities { get; }

        protected ServiceBase(string folderPath, string fileName)
        {
            //get file
            var jsonData = "";
            Entities = JsonConvert.DeserializeObject<List<T>>(jsonData);
        }
        
        public void Dispose()
        {
            var entitiesSerialized = JsonConvert.SerializeObject(Entities);
            //save file
        }
    }
}
