using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarPanelAppWF
{
    public class User
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int roleId { get; set; }
        public string roleName { get; set; }
        public int errorCode { get; set; }
    }
}
