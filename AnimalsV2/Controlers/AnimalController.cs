using AnimalsV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalsV2.Controlers
{
    internal class AnimalController
    {
        internal static void Add(Animal newAnimal)
        {
            using (var context = new AnimalsContext())
            {
                context.Animals.Add(newAnimal);
                context.SaveChanges();
            }
        }

        internal static Animal Find(int findId)
        {
            using (var context = new AnimalsContext())
            {
                return context.Animals.Find(findId);
            }
        }

        internal static void Delete(int findId)
        {
            using (var context = new AnimalsContext())
            {
                var animal = context.Animals.Find(findId);
                if (animal != null)
                {
                    context.Animals.Remove(animal);
                    context.SaveChanges();
                }
            }
        }

        internal static List<Animal> SelectAll()
        {
            using (var context = new AnimalsContext())
            {
                return context.Animals.ToList();
            }
        }

        internal static void Update(int findId, Animal updatedAnimal)
        {
            using (var context = new AnimalsContext())
            {
                var animal = context.Animals.Find(findId);
                if (animal != null)
                {
                    animal.Name = updatedAnimal.Name;
                    animal.BreedTypes = updatedAnimal.BreedTypes;
                    animal.Age = updatedAnimal.Age;

                    context.SaveChanges();
                }
            }
        }

        internal static void Create(Animal newAnimal)
        {
            using (var context = new AnimalsContext())
            {
                context.Animals.Add(newAnimal);
                context.SaveChanges();
            }
        }

        internal static void DeleteAnimal(int findId)
        {
            using (var context = new AnimalsContext())
            {
                var animal = context.Animals.Find(findId);
                if (animal != null)
                {
                    context.Animals.Remove(animal);
                    context.SaveChanges();
                }
            }
        }

        internal static Animal Get(int findId)
        {
            using (var context = new AnimalsContext())
            {
                return context.Animals.Find(findId);
            }
        }

        internal static List<Animal> GetAll()
        {
            using (var context = new AnimalsContext())
            {
                return context.Animals.ToList();
            }
        }

        internal static void UpdateAnimal(int findId, Animal updatedAnimal)
        {
            using (var context = new AnimalsContext())
            {
                var animal = context.Animals.Find(findId);
                if (animal != null)
                {
                    animal.Name = updatedAnimal.Name;
                    animal.BreedTypes = updatedAnimal.BreedTypes;
                    animal.Age = updatedAnimal.Age;

                    context.SaveChanges();
                }
            }
        }
    }
}
