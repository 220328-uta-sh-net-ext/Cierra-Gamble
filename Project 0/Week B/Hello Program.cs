//Predefined namespace
global using System;

//user defined namespace
namespace HelloWorld{

    //Types (Class, Enum, Structs, Interface, Delegates)
    public class Program{
        //Main Entry Point - Can only have one entry point in a program
        public static void Main(){
            // See https://aka.ms/new-console-template for more information
            // Console.WriteLine("Hello Ol No Name"); //comment for what's written in parentheses
            // var name=Console.ReadLine(); //takes input in string format as UD or SD variable i.e name
            // var currentDate = DateTime.Now;
           
        //  Console.WriteLine($"{Environment.NewLine}Current Date: {currentDate:d} \nJellyfish Fields, {name}!");
            Mathematics.AdditionWithFilter();
        }

    }
}
