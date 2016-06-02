using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//required for connecting EF db
using COMP2007_Lesson4A.Models;
using System.Web.ModelBinding;
namespace COMP2007_Lesson4A
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading the page for the first time
            if(!IsPostBack)
            {
                //Get students from EF db
                this.GetStudents();

            }
        }
        protected void GetStudents()
        {
            //connect to EF
            using (DefaultConnection db = new DefaultConnection())
            {
                //query Students table using EF and LINQ
                var Students = (from allStudents in db.Students
                                select allStudents);
                //bind the results to the GridView
                StudentGridView.DataSource = Students.ToList();
                StudentGridView.DataBind();
            }
        }
    }
}