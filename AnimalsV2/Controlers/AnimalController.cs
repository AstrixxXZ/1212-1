using AnimalsV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsV2.Controlers
{
    internal class AnimalController
    {
        private static readonly Animalsbd db = new Animalsbd();

        internal static Animal Get(int findId)
        {
            using (var context = new Animalsbd())
            {
                return context.Animals
                    .Include("BreedTypes")
                    .Where(delegate (Animal a) { return a.Id == findId; })
                    .FirstOrDefault();
            }
        }

        internal static bool IsDuplicate(Animal animal)
        {
            using (var context = new Animalsbd())
            {
                return context.Animals.Any(a => 
                    a.Name.Trim().Equals(animal.Name.Trim(), StringComparison.OrdinalIgnoreCase) &&
                    a.Age == animal.Age &&
                    a.BreedTypeId == animal.BreedTypeId);
            }
        }

        internal static Animal GetDuplicate(Animal animal)
        {
            using (var context = new Animalsbd())
            {
                return context.Animals
                    .Include("BreedTypes")
                    .FirstOrDefault(a => 
                        a.Name.Trim().Equals(animal.Name.Trim(), StringComparison.OrdinalIgnoreCase) &&
                        a.Age == animal.Age &&
                        a.BreedTypeId == animal.BreedTypeId);
            }
        }

        internal static void Create(Animal animal)
        {
            using (var context = new Animalsbd())
            {
                if (IsDuplicate(animal))
                {
                    throw new InvalidOperationException("Вече съществува животно със същите данни!");
                }
                
                context.Animals.Add(animal);
                context.SaveChanges();
            }
        }
    
        internal static List<Animal> GetAll()
        {
            using (var context = new Animalsbd())
            {
                return context.Animals
                    .Include("BreedTypes") // Using string-based Include for EF6
                    .ToList();
            }
        }

        internal static void Update(int findId, Animal updatedAnimal)
        {
            using (var context = new Animalsbd())
            {
                var existingAnimal = context.Animals.Find(findId);
                if (existingAnimal != null)
                {
                    existingAnimal.Name = updatedAnimal.Name;
                    existingAnimal.Age = updatedAnimal.Age;
                    existingAnimal.BreedTypeId = updatedAnimal.BreedTypeId;
                    existingAnimal.Description = updatedAnimal.Description;
                    context.SaveChanges();
                }
            }
        }

        internal static void Delete(int findId)
        {
            using (var context = new Animalsbd())
            {
                var animal = context.Animals.Find(findId);
                if (animal != null)
                {
                    context.Animals.Remove(animal);
                    context.SaveChanges();
                }
            }
        }
    }
}