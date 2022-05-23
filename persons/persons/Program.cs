using System;
using System.Collections;
using System.Collections.Generic;
namespace persons
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person[] person = 
            {
                new Student ("Aanchal"," ","Ghimire","Female",21,"Bachelor 3rd year",10),
                new Student ("Susan","Prasad","Poudel","Male",22,"11",23),
                new TeachingStaff ("Ravi"," ","Shrestha","Male",30,"Dot Net",002)
            }; */

            List<Person> person = new List<Person>();
            foreach (var p in person)
            {
                if (p is Student s)
                {
                    Console.WriteLine(s.GetInfo());
                    continue;
                }
                if (p is TeachingStaff t)
                {
                    Console.WriteLine(t.GetInfo());
                    continue;
                }
            }
        }

    }
}

