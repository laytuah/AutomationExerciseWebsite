using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExerciseWebsite.Models
{
    public class SignUpModel
    {
        public string Name { get; set; }
        public string SignUpEmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string MobileNumber { get; set; }

    }

    public class LogInModel
    {
        public string LoginEmailAddress { get; set; }
        public string LoginPassword { get; set; }
    }
}
