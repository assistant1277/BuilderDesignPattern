using CarBuilderApp.Builders;
using CarBuilderApp.Models;
using CarBuilderApp.Presentations;

namespace CarBuilderApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarPresentation.ShowCarDetails();
        }
    }
}

// [*important] why to choose builder design pttern -> builder design pattern is useful when we want to create complex objects step by step means when there are many ways to configure them
//1)assume if you have to build car by specifying everything like engine type,number of seats,airbags all at once in constructor it could get messy and hard to remember
//what each value represents and builder pattern allows us to set each feature step by step like engine,wheels,seats making it clear and easier to read
//2)you might need different types of cars like sport cars,family cars each type of car has different features
//with builder pattern you can easily change or configure car based on what you need without changing much of your code
//you can create sports car with fewer seats and powerful engine or family car with more seats and balanced engine
//3)if you are building something complex like car there are many pieces that need to fit together and builder pattern helps to make sure
//all the parts are set correctly so you do not mistakenly leave out something important like forget to add wheels to car
//4)instead of writing many different classes for every car type or confusing code with many constructors builder pattern helps you to build variations of car in simple and organized way

