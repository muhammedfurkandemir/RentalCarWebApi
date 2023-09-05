﻿using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=500,Description="Toyota Auris , Beyaz Renk"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2015,DailyPrice=750,Description="Toyota Corolla , Gri Renk"},
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear=2012,DailyPrice=600,Description="Fiat Egea , Beyaz Renk"},
                new Car{Id=4,BrandId=2,ColorId=3,ModelYear=2015,DailyPrice=700,Description="Fiat Doblo , Siyah Renk"},
                new Car{Id=5,BrandId=3,ColorId=1,ModelYear=2020,DailyPrice=1000,Description="Hyundai Accent , Beyaz Renk"}
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            
            Car carToDelete=_cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
           return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.DailyPrice= car.DailyPrice;
            carToUpdate.Description=car.Description;
        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        
    }
}
