using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DatabaseLayer;
using DatabaseLayer.DBOperation;

namespace MVC_ThreeTierArch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        ManageRegistration ManageReg = new ManageRegistration();

        [HttpPost]
        public void AddReg(FormCollection Form)
        {
            RegistrationModel RegModel = new RegistrationModel()
            {
                Address = Form["txtAddress"],
                City = Form["txtCity"],
                Cno = Form["txtCno"],
                DoB = Convert.ToDateTime(Form["txtDoB"]),
                FullName = Form["txtName"],
                Gender = Form["rdbGender"]
            };

            ManageReg.AddReg(RegModel);
            Response.Write("Successfully Saved!");
        }

        public string ListData()
        {
            return ManageReg.ListData();
        }

        public void DeleteReg(int ID)
        {
            ManageReg.DeleteReg(ID);
            Response.Write("Successfully Deleted!");
        }

    }
}