using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Console_Application_Courses.Enum;
using Console_Application_Courses.Models;
using Group = Console_Application_Courses.Models.Group;

namespace Console_Application_Courses.Interfaces
{
    interface ICoursesManagment
    {
        public List<Group> Groups { get; }
        string CreateGroup(Categories category,bool isOnline);

        void ShowListOfGroups();

        void EditGroup(string oldGroup, string newGroup);

        void ShowAllStudentsInGroup(string groupNo);

        void ShowAllOfStudents();

        string CreateStudent(Student student, string groupNo);
        
        string DeleateStudent(byte id, string groupNo);
    }
}
