// student fname, m name, lname , address, district
/*using System;
namespace oop
{
    class OOP
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
        }
        public class Student
        {
            public Student()  // constructor of the class Student. default value assign garne
            {
                Console.WriteLine("Enter the first name: ");
                this.first_name = Console.ReadLine();
                Console.WriteLine("Enter the middle name: ");
                this.middle_name = Console.ReadLine();
                Console.WriteLine("Enter the last name: ");
                this.last_name = Console.ReadLine();
                Console.WriteLine("Enter the address name: ");
                this.address = Console.ReadLine();
                Console.WriteLine("Enter the district name: ");
                this.district = Console.ReadLine();
                Print();
            }
            public void Print()
            {
                Console.WriteLine("\nThe details given are:- ");
                Console.WriteLine(this.first_name);
                Console.WriteLine(this.middle_name);
                Console.WriteLine(this.last_name);
                Console.WriteLine(this.address);
                Console.WriteLine(this.district);
            }

            private string first_name { get; set; }  //prefer snake_case.
            private string middle_name { get; set; }
            private string last_name { get; set; }
            private string address { get; set; }
            private string district { get; set; }
        }


    }
}*/


/*using System;
namespace oop
{
    class OOP
    {
        public static void Main()
        {
            Student s = new Student(1, 14, "Ram", "Kumar","Basnet", "Male", "Kadaghari", "Kathmandu");
            Console.WriteLine(s.Display());
        }

        class Student
        {
            public int id { get; set;}
            public int roll_no { get; set; }
            public string f_name { get; set; }  //prefer snake_case.
            public string m_name { get; set; }
            public string l_name { get; set; }
            public string gender { get; set; }
            public string address { get; set; }
            public string district { get; set; }

            public Student()  // constructor of the class Student. esma default value assign garne
            {
                id = 0; roll_no = 0;
                f_name = ""; m_name = ""; l_name = "";
                gender = ""; address = ""; district = "";

            }
            //read only property
            public string full_name
            {
                get
                {
                    return f_name + " " + (m_name.Trim().Length > 0 ? m_name + " ": " ") + l_name; //using ternary operator (condition ? true:false)
                }
            }
            public Student(int iId, int iRollNo, string sFName, string sMName, string sLName,string sGender, string sAddress,string sDistrict)  // constructor of the class Student.
            {
                id = iId; roll_no = iRollNo; f_name = sFName; m_name = sMName; l_name = sLName;
                gender = sGender; address = sAddress; district = sDistrict;
            }
            public string Display()
            {
                return $"ID:{ id + Environment.NewLine}RollNO : {roll_no + Environment.NewLine}Name: {full_name + Environment.NewLine}" +
                        $"Gender:{ gender + Environment.NewLine}Address : {address + Environment.NewLine}" + $"Disctrict: {district}";
            }
        }
    }
}*/


//length breadh and height wala class banau ani area nikala


/*using System;
namespace Program
{
    class Oop
    {
        public static void Main()
        {
            Shapes l = new Shapes(2,3,4);
            Console.WriteLine(l.Display());
        }
        class Shapes
        {
            public int length { get; set; }
            public int breadth { get; set; }
            public int height { get; set; }  //prefer snake_case.
            // public int radius { get; set; }

            public Shapes()  // constructor of the class Student. esma default value assign garne
            {
                length = 0; breadth = 0; height = 0; 

            }
            //read only property
            public double Rectangle
            {
                get
                {
                    return length * breadth * height;
                }
            }
            public double Square
            {
                get
                {
                    return length * length;
                }
            }
            /*public double Circle
            {
                get
                {
                    return 3.14 * radius * radius;
                }
            }*/
/* public Shapes(int len, int brea, int hei)  // constructor of the class Student.
 {
     length = len;
     breadth = brea; height = hei; 

 }
 public string Display()
 {
     return $"Area of rectangle:{ Rectangle + Environment.NewLine}Area of square: {Square + Environment.NewLine}";

 }

}
}
}*/

using System;
namespace Program
{
    class Oop
    {
        public static void Main()
        {
            Shapes l = new Shapes(2, 3, 0);
            Console.WriteLine(l.Display());
        }
        class Shapes
        {
            public string choice { get; set; }
            public int length { get; set; }
            public int breadth { get; set; }
            public int height { get; set; }  //prefer snake_case.
            

            public Shapes() 
            {
                length = 0; breadth = 0; height = 0;

            }
            //read only property
            public float Area()
            {
                Console.WriteLine("choose rectangle or square or cube");
                this.choice = Console.ReadLine();
                float a = 0;
                if (choice == "rectangle")
                {
                    a = length * breadth;
                    return a;
                }
                else if (choice == "cube" && height != 0)
                {
                    a = 2 * (length * breadth) + 2 * (length * height) + 2 * (breadth * height);
                    return a;
                }
                else if (choice == "square")
                {
                    return length*length;
                }
                else
                {
                    return a;
                }
            }
            
            public Shapes(int len, int brea, int hei) 
            {
                length = len;
                breadth = brea; height = hei;

            }
            public string Display()
            {
                return $"Area:{Area()}";

            }

        }
    }
}