using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace StudentMinMax
{
    public static class Program
    {
        public static void Main()
        {
            string filePath = @"studentdata.txt";
            
            List<string> students = File.ReadAllLines(filePath).ToList();


            foreach (var student in students)
            {
                Console.WriteLine(student);
                //Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }

            Console.ReadLine();
        }
    }
}