using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VanSlyke.Survey;

namespace Survey_BOC_ASP
{
    public partial class AddQuestions2 : System.Web.UI.Page
    {
        List<Questions> questionList = new List<Questions>();
        int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                txtNewQuestion.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowSurvey3.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("LandingPage1.aspx");
        }

        protected void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Questions q1 = new Questions(); 
                q1.QuestionContent = txtNewQuestion.Text;
                q1.QuestionID = counter;
                QuestionList.AddToList(q1);
                counter++;  //something is funky with the counter.  it isn't incrementing per click.  Something to do with the postback of the page.  
                txtNewQuestion.Text = "New Question";
                txtNewQuestion.Attributes.Add("onfocus", "this.select();");
                txtNewQuestion.Focus();                
            }
        }

        protected void AddButton_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Add")
            {
                Page.Validate("Add");
            }
        }
    }
}