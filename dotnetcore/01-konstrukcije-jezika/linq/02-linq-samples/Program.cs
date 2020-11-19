/*
 */

using System;
using System.Collections.Generic;
using System.Linq;

IList<Student> studentList = new List<Student>() {
    new Student() { StudentId = 1, StudentName = "John", Age = 18, StandardId = 1 } ,
    new Student() { StudentId = 2, StudentName = "Steve",  Age = 21, StandardId = 1 } ,
    new Student() { StudentId = 3, StudentName = "Bill",  Age = 18, StandardId = 2 } ,
    new Student() { StudentId = 4, StudentName = "Ram" , Age = 20, StandardId = 2 } ,
    new Student() { StudentId = 5, StudentName = "Ron" , Age = 21 }
};

IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardId = 1, StandardName="Standard 1"},
    new Standard(){ StandardId = 2, StandardName="Standard 2"},
    new Standard(){ StandardId = 3, StandardName="Standard 3"}
};

var studentNames = studentList.Where(s => s.Age > 18)
    .Select(s => s)
    .Where(st => st.StandardId > 0)
    .Select(s => s.StudentName);
foreach (string name in studentNames)
    Console.WriteLine(name);
Console.WriteLine("---");

var teenStudentsName = from s in studentList
    where s.Age > 12 && s.Age < 20
    select new { StudentName = s.StudentName };
teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
Console.WriteLine("---");

teenStudentsName = studentList.Where( s => s.Age > 12 && s.Age < 20 )
    .Select( s=> new { StudentName = s.StudentName });
teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));
Console.WriteLine("---");




