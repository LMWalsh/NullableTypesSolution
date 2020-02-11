using System;

namespace NullableTypesProject {
    class Program {
        static void Main(string[] args) {

            var math = new Major { Id = 1, Description = "Math", MinSat = 900 };

        var larry = new Students {
                Id = 1,
                Name = "Larry Smith",
                SAT = null,
                GPA = 3.2,
                MajorId = math.Id,
                Major = math
                
        } ;
        var kim = new Students{
                Id = 2,
                Name = "Kim Cole",
                SAT = 1170,
                GPA = 3.1 };

        var michael = new Students {
                Id = 3,
                name = "Michael Ward",
                SAT = null,
                GPA = 2.2 };

        var sue = new Students {
                Id = 4,
                Name = "Sue Ready",
                GPA = 1300,
                SAT = 3.9 };


                    

        }




}
    }
}
