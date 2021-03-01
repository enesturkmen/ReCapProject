using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 120, Description = "Renault Symbol"},
            new Car{CarId = 2, BrandId = 1, ColorId = 1, ModelYear = 2021, DailyPrice = 140, Description = "Renault Clio"},
            new Car{CarId = 3, BrandId = 3, ColorId = 2, ModelYear = 2019, DailyPrice = 150, Description = "Ford Focus"},
            new Car{CarId = 4, BrandId = 4, ColorId = 2, ModelYear = 2017, DailyPrice = 130, Description = "Fiat Egea"},
            new Car{CarId = 5, BrandId = 5, ColorId = 2, ModelYear = 2020, DailyPrice = 150, Description = "Toyota Corolla"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
