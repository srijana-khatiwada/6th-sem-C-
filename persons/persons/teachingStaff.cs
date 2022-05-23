using System;
namespace persons
{
    class TeachingStaff : Person
    {
        public string course { get; set; } = "";
        public int teacherId { get; set; } = 0;
        public TeachingStaff(string sFName, string sMName, string sLName, string sGender, int iAge, string sCourse, int iTeacherID)
        {
            f_name = sFName; m_name = sMName; l_name = sLName; gender = sGender; age = iAge; course = sCourse; teacherId = iTeacherID;
        }
        public string GetInfo()
        {
            string s = base.GetInfo();
            s += "course:" + course + Environment.NewLine;
            s += "teacher id:" + teacherId + Environment.NewLine;
            s += Environment.NewLine;
            return s;
        }
    }
}

