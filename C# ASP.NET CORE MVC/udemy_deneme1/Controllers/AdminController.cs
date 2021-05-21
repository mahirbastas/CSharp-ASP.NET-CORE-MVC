using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace udemy_deneme1.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("save")]
        [Route("~/save")]
        public string Save()
        {
            return "Saved";
        }
        [Route("update")]
        public string Update()
        {
            return "Updated";
        }
        [Route("delete/{id?}")]
        public string Delete(int id=0)
        {
            return String.Format("Deleted {0}", id);
        }
    }
}
