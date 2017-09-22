using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VanSlyke.Survey;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Survey_BOC_ASP
{
    public partial class LandingPage1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDDL();
            }
        }

        protected void btnQuestionCreation_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddQuestions2.aspx");
        }

        protected void btnSurveyCreation_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowSurvey3.aspx");
        }
        
        private void FillDDL()
        {
            //names properties of the survey objects, per index shown in ddl

            foreach (Surveys s in SurveyList.SurveysList)
            {
                ddlPriorSurveys.Items.Add(s.SurveyName);
            }

        }

        protected void btnPriorSurveys_Click(object sender, EventArgs e)
        {
            if (ddlPriorSurveys.SelectedIndex == -1)
            {
                lblError.Text = "You need to create a survey before viewing it!";
            }
            else
            {
                lblError.Text = "";
                int ddlIndex = ddlPriorSurveys.SelectedIndex;  //using the index to get text from ddl.
                int indexID = ddlIndex + 1; //accounting for index numbering.  first entry index = 0, ID = 1
                Session["indexID"] = indexID;  //create to use on page 6
                Response.Redirect("ReadOnlySurvey6.aspx");
            }
                      
        }
    }
}