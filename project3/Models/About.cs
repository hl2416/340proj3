using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project3.Models
{
    //json to c# classes for About
    public class About
    {
        public string title { get; set; }
        public string description { get; set; }
        public string quote { get; set; }
        public string quoteAuthor { get; set; }
    }
    public class AboutRootModel
    {
        public About About { get; set; }
    }
}
