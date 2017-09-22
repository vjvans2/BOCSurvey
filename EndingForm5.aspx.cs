using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VanSlyke.Survey;

namespace Survey_BOC_ASP
{
    public partial class EndingForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string scores = "";
                //foreach (int i in AnswerScoreList.AnswerScores)
                //{
                //    scores += i + " ";
                //}

                //lblScoreResults.Text = scores;
            }            
        }

        protected void btnCreateAnother_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddQuestions2.aspx");
        }

        protected void btnLandingPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("LandingPage1.aspx");
        }
    }
}