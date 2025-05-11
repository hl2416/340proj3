using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project3.Models
{
    //json to c# classes for Minors
    public class UgMinors
    {
        public string name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> courses { get; set; }
        public string note { get; set; }
    }
    public class Courses
    {
        public string courseID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
    public class UgMinorsRootModel
    {
        public List<UgMinors> ugMinors { get; set; }
        public Courses courses { get; set; }
    }
}
