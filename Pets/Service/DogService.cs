using System.Collections.Generic;
using Pets.Model;

namespace Pets.Service
{
    public class DogService : ServiceBase<Dog>
    {
        private readonly string _folderPath;
        private const string FileName = "dogs.json";
        private OwnerService _ownerService;
        private OwnerService OwnerService => _ownerService ?? (_ownerService = new OwnerService(_folderPath));

        public List<Dog> Dogs => Entities;

        public DogService() : this("folderPath")
        {
        }

        public DogService(string folderPath) : base(folderPath, FileName)
        {
            _folderPath = folderPath;
        }

    }
}
