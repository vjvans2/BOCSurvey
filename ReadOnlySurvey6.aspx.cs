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
    public partial class ReadOnlySurvey6 : System.Web.UI.Page
    {
        public int indexID;

        protected void Page_Load(object sender, EventArgs e)
        {
            FillReadOnlySurvey();

        }
        public void FillReadOnlySurvey()
        {
            List<string> surveyQuestions = GetQuestions();
            List<string> surveyAnswers = GetAnswers();
            lblSurveyQuestionOne.Text = surveyQuestions[0];
            lblSurveyQuestionTwo.Text = surveyQuestions[1];
            lblSurveyQuestionThree.Text = surveyQuestions[2];
            lblSurveyQuestionFour.Text = surveyQuestions[3];
            lblSurveyQuestionFive.Text = surveyQuestions[4];
            // --------
            lblSurveyAnswerOne.Text = surveyAnswers[0];
            lblSurveyAnswerTwo.Text = surveyAnswers[1];
            lblSurveyAnswerThree.Text = surveyAnswers[2];
            lblSurveyAnswerFour.Text = surveyAnswers[3];
            lblSurveyAnswerFive.Text = surveyAnswers[4];

            switch (surveyAnswers[0])
            {
                case "3":
                    lblSurveyAnswerOne.Text = "Yes";
                    break;
                case "2":
                    lblSurveyAnswerOne.Text = "Unsure";
                    break;
                case "1":
                    lblSurveyAnswerOne.Text = "No";
                    break;
            }
            switch (surveyAnswers[1])
            {
                case "3":
                    lblSurveyAnswerTwo.Text = "Yes";
                    break;
                case "2":
                    lblSurveyAnswerTwo.Text = "Unsure";
                    break;
                case "1":
                    lblSurveyAnswerTwo.Text = "No";
                    break;
            }
            switch (surveyAnswers[2])
            {
                case "3":
                    lblSurveyAnswerThree.Text = "Yes";
                    break;
                case "2":
                    lblSurveyAnswerThree.Text = "Unsure";
                    break;
                case "1":
                    lblSurveyAnswerThree.Text = "No";
                    break;
            }
            switch (surveyAnswers[3])
            {
                case "3":
                    lblSurveyAnswerFour.Text = "Yes";
                    break;
                case "2":
                    lblSurveyAnswerFour.Text = "Unsure";
                    break;
                case "1":
                    lblSurveyAnswerFour.Text = "No";
                    break;
            }
            switch (surveyAnswers[4])
            {
                case "3":
                    lblSurveyAnswerFive.Text = "Yes";
                    break;
                case "2":
                    lblSurveyAnswerFive.Text = "Unsure";
                    break;
                case "1":
                    lblSurveyAnswerFive.Text = "No";
                    break;
            }
        }

        public List<string> GetQuestions()
        {
            List<string> retrievedQuestionsFromDB = new List<string>();
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                int indexID = (int)Session["indexID"];
                string sqlGetQuestions =
                    "SELECT QuestionContent FROM dbo.fnBaseJunctionQuery(@indexID)";
                using (SqlCommand cmd = new SqlCommand(sqlGetQuestions, con))
                {//stick a try here
                    cmd.Parameters.AddWithValue("@indexID", indexID);                    
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        string x = ((string)dr["QuestionContent"]);
                        retrievedQuestionsFromDB.Add(x);
                    }
                    dr.Close();
                }
            }
            return retrievedQuestionsFromDB;
        }

        public List<string> GetAnswers()
        {
            List<string> retrievedAnswersFromDB = new List<string>();
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                int indexID = (int)Session["indexID"];
                string sqlGetAnswers =
                    "SELECT AnswerContent FROM dbo.fnBaseJunctionQuery(@indexID)";
                using (SqlCommand cmd = new SqlCommand(sqlGetAnswers, con))
                {//stick a try here
                    cmd.Parameters.AddWithValue("@indexID", indexID);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string x = ((string)dr["AnswerContent"]);
                        retrievedAnswersFromDB.Add(x);
                    }
                    dr.Close();
                }
            }
            return retrievedAnswersFromDB;
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["SurveyBOCPracticeConnectionString"].ConnectionString;
        }

        protected void btnBacktoLanding_Click(object sender, EventArgs e)
        {
            Response.Redirect("LandingPage1.aspx");
        }
    }
}