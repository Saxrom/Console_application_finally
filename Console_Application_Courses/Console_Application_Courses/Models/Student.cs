using System;
namespace Console_Application_Courses.Models
{
    class Student
    {
        public string FullName;
        public bool Type;
        public byte Id;
        public static byte count;

        static Student()
        {
            count = 0;
        }

        public Student(string fullname,bool type)
        {
            FullName = fullname;
            Type = type;
            Id = ++count;
        }

        public override string ToString()
        {
            return $"Student's fullname:{FullName},Id:{Id},Type:{(Type? "Zamanetli" :"Zamanetsiz")}";
        }
    }
}
