using ExpressoApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ExpressoApi.Controllers
{
    public class MenusController : ApiController
    {
        ExpressoDbContext expressoDbContext = new ExpressoDbContext();

        public IHttpActionResult GetMenus()
        {
           var menus= expressoDbContext.Menus.Include("SubMenus");
            return Ok(menus);
        }
        public IHttpActionResult GetMenu(int id)
        {
            var menu = expressoDbContext.Menus.Include("Submenus").FirstOrDefault(m=>m.Id==id);
            if (menu == null)
            {
                return BadRequest();
            }
            return Ok(menu);
        }
        // GET: Menus
        
    }
}