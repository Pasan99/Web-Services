using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using _2019410websrvice.model;

namespace _2019410websrvice.model
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Student> GetStudent()
        {
            List<Student> studen; // for xml array list
            WebServiceEntities db = new WebServiceEntities();// get access to the databse
            studen = db.Students.ToList();
            db.Dispose();
            return studen;
        }

        [WebMethod]
        public Boolean AddStudent(Student s)
        {
            WebServiceEntities db = new WebServiceEntities();
            db.Students.Add(s);
            db.SaveChanges();
            db.Dispose();
            return  true;
        }

        [WebMethod]
        public Boolean UpdateStudent(Student s )
        {
            WebServiceEntities db = new WebServiceEntities();
            Student std = db.Students.Where(x => x.Student_ID == s.Student_ID).FirstOrDefault();
            std.Student_Name = s.Student_Name;
            std.Address = s.Address;
            std.Age = s.Age;
            db.SaveChanges();
            db.Dispose();
            return true;
        }

        [WebMethod]
        public Boolean DeleteStudent(int studentID)
        {
            WebServiceEntities db = new WebServiceEntities();
            Student std = db.Students.Where(x => x.Student_ID == studentID).FirstOrDefault();
            db.Students.Remove(std);
            db.SaveChanges();
            db.Dispose();
            return true;
        }

    }
}
