using CarBuilderApp.Builders;
using CarBuilderApp.Models;
using CarBuilderApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//working of builder design pattern -> this class coordinates everything means it asks CarService to build both
//sports car and family car and after cars are built it displays details using Console.WriteLine

namespace CarBuilderApp.Presentations
{
    public class CarPresentation
    {
        public static void ShowCarDetails()
        {
            Console.WriteLine("***** Welcome to Builder Design Pattern program *****\n");

            //create builder object to build cars
            ICarBuilder carBuilder = new CarBuilder();

            //create CarService instance means create CarService to build cars using builder
            CarService carService = new CarService(carBuilder);

            //build and show sports car
            Car sportsCar = carService.BuildSportCar();
            ShowCarDetails("1) Sport car", sportsCar);  

            //build and show family car
            Car familyCar = carService.BuildFamilyCar();
            ShowCarDetails("2) Family car", familyCar);
        }

        //display type of car and its details in neat format
        public static void ShowCarDetails(string carType, Car car)
        {
            Console.WriteLine($"{carType} =>");
            Console.WriteLine(car);
            Console.WriteLine();
        }
    }
}