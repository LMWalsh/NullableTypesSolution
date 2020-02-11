using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypesProject {
    public class Major {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set;}
        public int? SAT { get; set; }

        //public int? MajorId {get; set;}

    }
}
