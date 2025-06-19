using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AnimalsV2.Controlers;

namespace AnimalsV2.Data
{
    public class Animalsbd : DbContext
    {
        public Animalsbd() : base("Animalsbd")
        {

        }
        public DbSet<AnimalType> AnimalTypes { get; set; }

        public DbSet<BreedType> BreedTypes { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
