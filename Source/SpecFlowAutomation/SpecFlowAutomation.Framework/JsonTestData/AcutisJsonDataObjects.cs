using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Framework.JsonTestData
{
    public class AcutisJsonDataObjects
    {
        public JsonLogin? JsonLogin { get; set; }
        public UserDetails? UserDetails { get; set; }
        public UserRole? UserRole { get; set; }

    }
    public class JsonLogin
    {
        public string? URL { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
    public class UserRole
    {
        public string? RoleName { get; set; }
        public string? Description { get; set; }
        public string? LandingPage { get; set; }
        public string? EditRoleName { get; set; }
    }
    public class UserDetails
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? UserRole { get; set; }
        public string? EditFirstName { get; set; }
        public string? EditLastName { get; set; }

        
    }


}
