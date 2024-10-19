using CarBuilderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// working of builder design pattern -> it defines all steps required to build car like setting engine,wheels,seats,airbags
//means we need to tell builder what car consists of and how to put it together so this interface gives blueprint

namespace CarBuilderApp.Builders
{
    //below interface defines steps needed to build car
    public interface ICarBuilder
    {
        void SetEngine(string engineType);
        void SetWheels(int numberOfWheels); //set how many wheels car has
        void SetSeats(int numberOfSeats);
        void SetAirbags(bool hasAirbags); //set if car has airbags
        Car BuildCar(); //build and return complete car
    }
}