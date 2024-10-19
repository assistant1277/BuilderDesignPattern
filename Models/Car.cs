using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//working of builder design pattern -> here is final object that gets built by CarBuilder it have properties like engine,wheels,seats,airbags
//this is object we want at the end of complete car

namespace CarBuilderApp.Models
{
    //below class represents actual car with its properties
    public class Car
    {
        public string Engine { get; set; } //stores type of engine car has
        public int Wheels { get; set; }
        public int Seats { get; set; } //stores number of seats
        public bool HasAirbags { get; set; }

        //below method override default behavior to return nicely/clean formatted car detail
        public override string ToString()
        {
            return $"Car details are -> \n"+
                $"engine -> {Engine}\n"+
                $"wheels -> {Wheels}\n"+
                $"seats -> {Seats}\n"+
                $"airbags -> {(HasAirbags ? "yes" : "no")}";
        }
    }
}