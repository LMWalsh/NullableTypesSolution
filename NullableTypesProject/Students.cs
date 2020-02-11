using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypesProject {
    public class Students {

        public int id; {get; set;}
        public string name; {get; set;}
        public int? sat; {get; set;}
        public double gpa; {get; set;}

        public int? MajorId { get; set; }
        public Major? Major { get; set; }

        

    }
}
