using System;
using System.Text.RegularExpressions;

namespace regvur
{
    public class Program : Timetable
    {
        static void Main(string[] args)
        {

            Timetable one = new Timetable();
            one.uTimetable();
            Console.ReadLine();
        }
    }
}