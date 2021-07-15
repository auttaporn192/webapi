using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using UsersUtil;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class test
    {
        public string value1 { get; set; }
        public string value2 { get; set; }
    }

    public class UsersController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {

            return "value";
        }

        // POST api/<controller>
        public JsonResult<DtoUsers> Post(DtoUsers dtouser)
        {
            int result = 0;
            UsersUtil.UsersUtil users = new UsersUtil.UsersUtil();
            result = users.SYS_LOGIN(dtouser.username, dtouser.systemID, dtouser.password);
            if (result > 0)
            {
                dtouser.result = true;
            }
            else
            {
                dtouser.result = false;
            }
            return Json(dtouser);
           // return Json(new test() { value1 = "pik", value2 = "000" });
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}