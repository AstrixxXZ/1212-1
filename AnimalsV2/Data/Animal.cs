using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsV2.Data
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public int BreedTypeId { get; set; }
        public BreedType BreedTypes { get; set; }
        public string AnimalType { get; set; } // <-- Добавете това свойство
    }
}
