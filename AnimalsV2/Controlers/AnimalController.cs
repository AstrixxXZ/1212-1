using AnimalsV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalsV2.Controlers
{
    internal class AnimalController
    {
<<<<<<< HEAD
        private static readonly Animalsbd db = new Animalsbd();
=======
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
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29

        internal static List<Animal> SelectAll()
        {
<<<<<<< HEAD
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
=======
            using (var context = new AnimalsContext())
            {
                return context.Animals.ToList();
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            }
        }

        internal static void Update(int findId, Animal updatedAnimal)
        {
<<<<<<< HEAD
            using (var context = new Animalsbd())
            {
                var existingAnimal = context.Animals.Find(findId);
                if (existingAnimal != null)
                {
                    existingAnimal.Name = updatedAnimal.Name;
                    existingAnimal.Age = updatedAnimal.Age;
                    existingAnimal.BreedTypeId = updatedAnimal.BreedTypeId;
                    existingAnimal.Description = updatedAnimal.Description;
=======
            using (var context = new AnimalsContext())
            {
                var animal = context.Animals.Find(findId);
                if (animal != null)
                {
                    animal.Name = updatedAnimal.Name;
                    animal.BreedTypes = updatedAnimal.BreedTypes;
                    animal.Age = updatedAnimal.Age;

>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
                    context.SaveChanges();
                }
            }
        }

<<<<<<< HEAD
        internal static void Delete(int findId)
        {
            using (var context = new Animalsbd())
=======
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
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            {
                var animal = context.Animals.Find(findId);
                if (animal != null)
                {
                    context.Animals.Remove(animal);
                    context.SaveChanges();
                }
            }
        }
<<<<<<< HEAD
        internal static void InsertAnimal(int id, string name, int age, int breedTypeId, string animalType)
        {
            using (var db = new Animalsbd())
            {
                var animal = new Animal
                {
                    Id = id,
                    Name = name,
                    Age = age,
                    BreedTypeId = breedTypeId
                };

                // Динамично добавяне на AnimalType, ако колоната съществува
                db.Database.ExecuteSqlCommand(
                    "INSERT INTO Animals (Id, Name, Age, BreedTypeId, AnimalType) VALUES (@p0, @p1, @p2, @p3, @p4)",
                    id, name, age, breedTypeId, animalType);

                db.SaveChanges();
=======

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
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            }
        }
    }
}