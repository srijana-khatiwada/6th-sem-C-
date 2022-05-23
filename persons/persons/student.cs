using System;
namespace persons
{
	class Student : Person
	{
        public string grade { get; set; } = "";
        public int roll_no { get; set; } = 0;
		public Student (string sFName, string sMName, string sLName, string sGender,int iAge,string sGrade,int iRollNo)
        {
            f_name = sFName;m_name = sMName;  l_name = sLName; gender = sGender; age = iAge; grade = sGrade; roll_no = iRollNo;
        }
        public string GetInfo()
        {
            string s = base.GetInfo();
            s += "grade:" + grade + Environment.NewLine;
            s += "rollnum:" + roll_no + Environment.NewLine;
            s += Environment.NewLine;
            return s;
        }
	}
}

