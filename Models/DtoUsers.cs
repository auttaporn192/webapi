using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class DtoUsers
    {
        public string username { get; set; }
        public string password { get; set; }
        public string systemID { get; set; }
        public string role { get; set; }
        public bool result { get; set; }
    }
}