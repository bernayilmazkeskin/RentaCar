using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar
{
    public class CarsDal
    {
        public List<Car> GetAll( ) {
            using (ECarsContext context = new ECarsContext())
            {
                return context.car.ToList();
            }
        }
        public List<Car> GetByPlaka(string key) {
            using (ECarsContext context = new ECarsContext())
            {
                return context.car.Where(c => c.Plaka.Contains(key)).ToList();
            }
        }
        public List<Car> GetByMarka(string key)
        {
            using (ECarsContext context = new ECarsContext())
            {
                return context.car.Where(c => c.Marka.Contains(key)).ToList();
            }
        }
        public List<Car> GetByModel(string key)
        {
            using (ECarsContext context = new ECarsContext())
            {
                return context.car.Where(c => c.Model.Contains(key)).ToList();
            }
        }
        public void AddCar(Car car) {
            using (ECarsContext context = new ECarsContext())
            {
               var entity=context.Entry(car);
                entity.State=EntityState.Added;
                context.SaveChanges();

            }
            
        }
        public void UpdateCar(Car car)
        {
            using (ECarsContext context = new ECarsContext())
            {
                var entity = context.Entry(car);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }

        }
        public void DeleteCar(Car car)
        {
            using (ECarsContext context = new ECarsContext())
            {
                var entity = context.Entry(car);
                entity.State = EntityState.Deleted;
                context.SaveChanges();

            }

        }
    }
}
