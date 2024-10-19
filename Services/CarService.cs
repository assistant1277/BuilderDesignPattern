using CarBuilderApp.Builders;
using CarBuilderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//working of builder design pattern -> it controls building process it knows what sport car should look like means powerful engine,fewer seats,airbags
//and what family car should look like balanced engine and more seats means istead of manually telling builder
//every time how to build different cars and CarService knows exactly what configurations are needed

namespace CarBuilderApp.Services
{
    //below class is responsible for creating specific types of cars using builder
    public class CarService
    {
        private readonly ICarBuilder _carBuilder;

        //constructor accepts any car builder like sports car or family car
        public CarService(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder; //we store car builder
        }

        //below method sets up and builds sports car
        public Car BuildSportCar()
        {
            _carBuilder.SetEngine("v12"); //set powerful v12 engine
            _carBuilder.SetWheels(4); //set 4 wheels
            _carBuilder.SetSeats(2);
            _carBuilder.SetAirbags(true);
            return _carBuilder.BuildCar(); //return full built sports car 
        }

        //below method sets up and builds a family car
        public Car BuildFamilyCar()
        {
            _carBuilder.SetEngine("v6"); //set less powerful but decent v6 engine
            _carBuilder.SetWheels(4);
            _carBuilder.SetSeats(5); //set 5 seats for family cars
            _carBuilder.SetAirbags(false); //no airbags in this case
            return _carBuilder.BuildCar(); //return full built family car
        }
    }
}