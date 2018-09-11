using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
    public class Car
    {
        private string _makeModel;
        private int _miles;
        private int _price;
        private static List<Car> _instances = new List<Car> {};

        public Car(string makeModel, string miles, string price)
        {
            _makeModel = makeModel;
            _miles = int.Parse(miles);
            _price = int.Parse(price);
        }

        // public void SetMakeModel(string input)
        // {
        //     _makeModel = input;
        // }

        public string GetMakeModel()
        {
            return _makeModel;
        }

        // public void SetPrice(string input)
        // {
        //     _price = int.Parse(input);
        // }

        public int GetPrice()
        {
            return _price;
        }

        // public void SetMiles(string input)
        // {
        //     _miles = int.Parse(input);
        // }

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
