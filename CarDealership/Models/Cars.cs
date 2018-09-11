using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
    public class Car
    {
        private string _makeModel;
        private int _price;
        private int _miles;
        private static List<Car> _instances = new List<Car> {};

        public void SetMakeModel(string input)
        {
            _makeModel = input;
        }

        public string GetMakeModel()
        {
            return _makeModel;
        }

        public void SetPrice(int input)
        {
            _price = input;
        }

        public int GetPrice()
        {
            return _price;
        }

        public void SetMiles(int input)
        {
            _miles = input;
        }
        public int GetMiles()
        {
            return _miles;
        }

        public void SaveCar()
        {
            _instances.Add(this);
        }

        public static List<Car> GetAllCars()
        {
            return _instances;
        }
    }
}
