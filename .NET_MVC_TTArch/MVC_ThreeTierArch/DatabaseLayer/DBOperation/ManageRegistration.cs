using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Newtonsoft.Json;

namespace DatabaseLayer.DBOperation
{
    public class ManageRegistration
    {
        public void AddReg(RegistrationModel RegModel)
        {
            using (var DB = new MYDBEntities())
            {
                Registration Reg = new Registration()
                {
                    Address = RegModel.Address,
                    City = RegModel.City,
                    Cno = RegModel.Cno,
                    DoB = RegModel.DoB,
                    FullName = RegModel.FullName,
                    Gender = RegModel.Gender
                };
                DB.Registrations.Add(Reg);
                DB.SaveChanges();
            }
        }

        public string ListData()
        {
            using (var DB = new MYDBEntities())
            {

                var Data = DB.Registrations.ToList();
                var Json = JsonConvert.SerializeObject(Data);
                return Json;
            }
        }

        public void DeleteReg(int ID)
        {
            using (var DB = new MYDBEntities())
            {
                var Data = DB.Registrations.Find(ID);
                if (Data != null)
                {
                    DB.Registrations.Remove(Data);
                    DB.SaveChanges();
                }
            }

        }
    }
}
