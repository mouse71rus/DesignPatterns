using System;

namespace Chapter7.Facade
{
    public class Screen
    {
        internal void Down()
        {
            Console.WriteLine("Theater screen going down");
        }

        internal void Up()
        {
            Console.WriteLine("Theater screen going up");
        }
    }
}