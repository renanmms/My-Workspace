using System;

namespace Ajax_Sample.Models
{
    public class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public List<string>? Subjects { get; set; }
        public bool Approved { get; set; }
    }
}