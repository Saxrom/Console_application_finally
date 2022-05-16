using System;
using System.Collections.Generic;
using Console_Application_Courses.Enum;

namespace Console_Application_Courses.Models
{
    class Group
    {
        public string No;
        public bool IsOnline;
        public  byte Limit;
        public Categories Category;
        public List<Student> Students ;
        public static byte Count;


        static Group()
        {
            Count = 10;
        }

        public Group(bool isOnline,Categories category)
        {
            switch (category)
            {
                case Categories.Programming:
                    No = $"PR-" + Count;
                    break;
                case Categories.Design:
                    No = $"DN-" + Count;
                    break;
                case Categories.System_administration:
                    No = $"SA-" + Count;
                    break;
                default:
                    break;
            }
            Count++;
            Category = category;
            IsOnline = isOnline;
            if (IsOnline)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }
            Students = new List<Student>();
        }

        public override string ToString()
        {
            return $"Group no:{No},Group type:{(IsOnline? "Online": "Ofline")},Student count:{Students.Count},Group limit:{Limit}";
        }
    }
}
