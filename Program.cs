using System;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;

            // Max heart rate is 220 - age
            int max_heart;
            age = 46;
            height = 51;
            max_heart = 220 - age;

            // I am ### years old, my max heart rate is ## and i am inches

            Console.WriteLine("I am " +age+ " years old, my heart rate is " +max_heart + " and i am " + height + " inches tall");
        }
    }
}
