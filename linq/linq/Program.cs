using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Staff
    {
        static void Main()
        {


            List<Employees> employee = new List<Employees>();
            employee.Add(new Employees("Ram", "kumar", "basnet", "male", 23, 090, Designamtion.HR));
            Console.WriteLine(employee);
            foreach (var e in employee)
            {
                Console.WriteLine(e.);
            }

        }

        public enum Designamtion
        {
            CEO,
            Director,
            HR,
            Manager,
            Staff
        }
        public struct Employees
        {
            string f_name { get; set; }
            string m_name { get; set; }
            string l_name { get; set; }
            string gender { get; set; }
            int age { get; set; }
            int id { get; set; }
            Designamtion position { get; set; }

        public Employees(string f,string m, string l, string g, int a, int i, Designamtion pos)
            {
                f_name = f;
                m_name = m;
                l_name = l;
                gender = g;
                age = a;
                id = i;
                position = pos;
            }
        }
    }
    }


