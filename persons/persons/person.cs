using System;
namespace persons
{

    class Person
    {
        public string f_name { get; set; } = "";//properties; constructor sidai defined as ""=defualt value
        public string m_name { get; set; } = "";
        public string l_name { get; set; } = "";
        public string gender { get; set; } = "";
        public int age { get; set; } = 0;

        public string full_name //method
        {
            get { return f_name + " " + m_name + " " + l_name; }
        }
        public string GetInfo()
        {
            string s = "full name:" + full_name + Environment.NewLine;
            s += "gender:" + gender + Environment.NewLine;
            s += "age:" + age + Environment.NewLine;
            return s;
        }
    }
}