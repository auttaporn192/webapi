using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class Company
    {
        public string Name { get; set; }
        public string Department { get; set; }

    }
    public class TestController : ApiController
    {
        public IHttpActionResult GetAllCompanys()
        {
            IList<Company> companys = new List<Company>();
            Company c1 = new Company();
            c1.Department = "Business Management";
            c1.Name = "Thai Yazaki";
            companys.Add(c1);

            if (companys.Count == 0)
            {
                return NotFound();
            }

            return Ok(companys);
        }
           }
}
