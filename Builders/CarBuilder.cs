using CarBuilderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//working of builder design pattern -> this class implement ICarBuilder interface and builds car by implementing
//each step means set engine,set wheels,etc and this is actual worker that builds car step by step

namespace CarBuilderApp.Builders
{
    //below CarBuilder class implements ICarBuilder interface and builds car step by step
    public class CarBuilder:ICarBuilder
    {
        private Car _car;

        //constructor initializes new car object
        public CarBuilder()
        {
            _car = new Car(); //initialize car object means start building new car
        }

        //set engine for car
        public void SetEngine(string engineType)
        {
            _car.Engine = engineType;
        }

        public void SetWheels(int numberOfWheels)
        {
            _car.Wheels = numberOfWheels;
        }

        //set number of seats for car
        public void SetSeats(int numberOfSeats)
        {
            _car.Seats = numberOfSeats;
        }

        public void SetAirbags(bool hasAirbags)
        {
            _car.HasAirbags = hasAirbags;
        }

        //return fully built car
        public Car BuildCar()
        {
            return _car; //return constructed car means return car that was built step by step
        }
    }
}