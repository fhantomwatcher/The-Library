using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheLibrary.Models
{
    public class UserInfo
{
        public string FullName { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; set; }

        public string EmployeeCode { get; set; }

        public DateTime HireDate { get; set; }

        public string Position { get; set; }

        public string Role { get; set; }

        public int UserID { get; set; }

    }
}
