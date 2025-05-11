using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project3.Models
{
    //json to c# classes for Undergraduate and Graduate degrees
    public class Undergraduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
    }
    public class Graduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
        public List<string> availableCertificates { get; set; }
    }
    public class DegreesRootModel
    {
        public List<Undergraduate> undergraduate { get; set; }
        public List<Graduate> graduate { get; set; }
    }
}
