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
    public partial class FinalSurvey4 : System.Web.UI.Page
    {
        public  int scoreAssignment1;
        public  int scoreAssignment2;
        public  int scoreAssignment3;
        public  int scoreAssignment4;
        public  int scoreAssignment5;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillSurvey();
            }                                         
        }             

        protected void btnSubmitAnswers_Click(object sender, EventArgs e)
        {
         string responseQ1x = rblSurveyQuestionOne.SelectedValue;
            string responseQ1 = responseQ1x.Trim();
         string responseQ2x = rblSurveyQuestionTwo.SelectedValue;
            string responseQ2 = responseQ2x.Trim();
         string responseQ3x = rblSurveyQuestionThree.SelectedValue;
            string responseQ3 = responseQ3x.Trim();
         string responseQ4x = rblSurveyQuestionFour.SelectedValue;
            string responseQ4 = responseQ4x.Trim();
         string responseQ5x = rblSurveyQuestionFive.SelectedValue;
            string responseQ5 = responseQ5x.Trim();

            switch (responseQ1)
            {
                case "Yes":
                    scoreAssignment1 = 3;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment1);
                    break;
                case "Unsure":
                    scoreAssignment1 = 2;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment1);
                    break;
                case "No":
                    scoreAssignment1 = 1;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment1);
                    break;               
            }
            switch (responseQ2)
            {
                case "Yes":
                    scoreAssignment2 = 3;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment2);
                    break;
                case "Unsure":
                    scoreAssignment2 = 2;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment2);
                    break;
                case "No":
                    scoreAssignment2 = 1;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment2);
                    break;
            }
            switch (responseQ3)
            {
                case "Yes":
                    scoreAssignment3 = 3;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment3);
                    break;
                case "Unsure":
                    scoreAssignment3 = 2;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment3);
                    break;
                case "No":
                    scoreAssignment3 = 1;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment3);
                    break;
            }
            switch (responseQ4)
            {
                case "Yes":
                    scoreAssignment4 = 3;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment4);
                    break;
                case "Unsure":
                    scoreAssignment4 = 2;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment4);
                    break;
                case "No":
                    scoreAssignment4 = 1;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment4);
                    break;
            }            
            switch (responseQ5)
            {
                case "Yes":
                    scoreAssignment5 = 3;                    
                    AnswerScoreList.AnswerScores.Add(scoreAssignment5);
                    break;
                case "Unsure":
                    scoreAssignment5 = 2;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment5);
                    break;
                case "No":
                    scoreAssignment5 = 1;
                    AnswerScoreList.AnswerScores.Add(scoreAssignment5);
                    break;
            }

            AddAnswersToDB();

            Response.Redirect("EndingForm5.aspx");
        }

        //Deprecated Movement Buttons
        //protected void btnBackToSurvey_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("ShowSurvey3.aspx");
        //}

        //protected void btnBacktoQuestions_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("AddQuestions2.aspx");
        //}

        //protected void btnBacktoLanding_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("LandingPage1.aspx");
        //}

        public void FillSurvey()
        {
            Surveys currentSurvey = (Surveys)Session["createdSurvey"];
            //only need one Session object because the object is rewritten on every reinstancing
            lblSurveyName.Text = currentSurvey.SurveyName;
            lblSurveyQuestionOne.Text = currentSurvey.QuestionOne;
            lblSurveyQuestionTwo.Text = currentSurvey.QuestionTwo;
            lblSurveyQuestionThree.Text = currentSurvey.QuestionThree;
            lblSurveyQuestionFour.Text = currentSurvey.QuestionFour;
            lblSurveyQuestionFive.Text = currentSurvey.QuestionFive;    
        }

        public void AddAnswersToDB()  
        {
            //get ID's
            int SurveyID = (int)Session["SurveyID"];
            int AnswerID1 = GetAnswerID1(scoreAssignment1);
            int AnswerID2 = GetAnswerID1(scoreAssignment2);
            int AnswerID3 = GetAnswerID1(scoreAssignment3);
            int AnswerID4 = GetAnswerID1(scoreAssignment4);
            int AnswerID5 = GetAnswerID1(scoreAssignment5);

            //create junction tables
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlJunction1 = "INSERT INTO SurveyAnswerPractice (SurveyID, AnswerID) VALUES (@surveyID, @answerID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction1, con))
                {
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    cmd.Parameters.AddWithValue("@answerID", AnswerID1);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - A1
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlJunction2 = "INSERT INTO SurveyAnswerPractice (SurveyID, AnswerID) VALUES (@surveyID, @answerID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction2, con))
                {
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    cmd.Parameters.AddWithValue("@answerID", AnswerID2);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - A2
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlJunction3 = "INSERT INTO SurveyAnswerPractice (SurveyID, AnswerID) VALUES (@surveyID, @answerID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction3, con))
                {
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    cmd.Parameters.AddWithValue("@answerID", AnswerID3);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - A3
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlJunction4 = "INSERT INTO SurveyAnswerPractice (SurveyID, AnswerID) VALUES (@surveyID, @answerID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction4, con))
                {
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    cmd.Parameters.AddWithValue("@answerID", AnswerID4);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - A4
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlJunction5 = "INSERT INTO SurveyAnswerPractice (SurveyID, AnswerID) VALUES (@surveyID, @answerID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction5, con))
                {
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    cmd.Parameters.AddWithValue("@answerID", AnswerID5);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - A5
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["SurveyBOCPracticeConnectionString"].ConnectionString;
        }

        //getting the ID's includes storing the data 

        public static int GetAnswerID1(int i) //pass in scoreAssignments
        {
            //Surveys currentSurvey = (Surveys)Session["createdSurvey"];
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlAnswerContent1 = "INSERT INTO AnswersPractice (AnswerContent) VALUES (@answerContent)";
                using (SqlCommand cmd = new SqlCommand(sqlAnswerContent1, con))
                {
                    cmd.Parameters.AddWithValue("@answerContent", i);  //scoreAssignment1
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('AnswersPractice') FROM AnswersPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int answerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return answerID;
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }
        public static int GetAnswerID2(int i) 
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlAnswerContent2 = "INSERT INTO AnswersPractice (AnswerContent) VALUES (@answerContent)";
                using (SqlCommand cmd = new SqlCommand(sqlAnswerContent2, con))
                {
                    cmd.Parameters.AddWithValue("@answerContent", i);  //scoreAssignment2
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('AnswersPractice') FROM AnswersPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int answerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return answerID;
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }
        public static int GetAnswerID3(int i)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlAnswerContent3 = "INSERT INTO AnswersPractice (AnswerContent) VALUES (@answerContent)";
                using (SqlCommand cmd = new SqlCommand(sqlAnswerContent3, con))
                {
                    cmd.Parameters.AddWithValue("@answerContent", i);  //scoreAssignment3
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('AnswersPractice') FROM AnswersPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int answerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return answerID;
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }
        public static int GetAnswerID4(int i)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlAnswerContent4 = "INSERT INTO AnswersPractice (AnswerContent) VALUES (@answerContent)";
                using (SqlCommand cmd = new SqlCommand(sqlAnswerContent4, con))
                {
                    cmd.Parameters.AddWithValue("@answerContent", i);  //scoreAssignment4
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('AnswersPractice') FROM AnswersPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int answerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return answerID;
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }
        public static int GetAnswerID5(int i)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlAnswerContent5 = "INSERT INTO AnswersPractice (AnswerContent) VALUES (@answerContent)";
                using (SqlCommand cmd = new SqlCommand(sqlAnswerContent5, con))
                {
                    cmd.Parameters.AddWithValue("@answerContent", i);  //scoreAssignment5
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('AnswersPractice') FROM AnswersPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int answerID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return answerID;
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }
    }
    
}
