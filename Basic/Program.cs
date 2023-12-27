using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Basic
{
    internal class Program { 
class Car
{
    string color = "red";
    int maxspeed = 200;

    static void Main(string[]args ){
    Car myObj = new Car();

    Console.WriteLine(myObj.color);
    Console.WriteLine(myObj.maxspeed);
    }
}
    }
}