using AnimalsV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsV2.Controlers
{
    public class BreedTypeController
    {
        AnimalsContext db = new AnimalsContext();

        public  List<BreedType> GetAllBreeds()
        {
            return db.BreedTypes.ToList();
        }

        public void Create(BreedType breed)
        {
            db.BreedTypes.Add(breed);
            db.SaveChanges();


        }
    }
}
