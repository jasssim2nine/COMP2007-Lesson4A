using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using COMP2007_Lesson4A.Models;
using System.Web.ModelBinding;

namespace COMP2007_Lesson4A
{
    public partial class StudentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Students.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            //use EF to connect to the servier
            using (DefaultConnection db = new DefaultConnection())
            {
                Student newStudent = new Student();
                newStudent.LastName = LastNameTextBox.Text;
                newStudent.FirstMidName = FirstNameTextBox.Text;
                newStudent.EnrollmentDate = Convert.ToDateTime(EnrollmentDateTextBox.Text);

                db.Students.Add(newStudent);

                db.SaveChanges();

                Response.Redirect("~/Students.aspx");
            }
        }
    }
}