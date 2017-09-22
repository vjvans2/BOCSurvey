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
    public partial class ShowSurvey3 : System.Web.UI.Page
    {
        int counter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            FillDDLOne();
            FillDDLTwo();
            FillDDLThree();
            FillDDLFour();
            FillDDLFive();
        }

        protected void btnAddQuestions_Click(object sender, EventArgs e)
        {            
            Response.Redirect("AddQuestions2.aspx");
        }

        protected void btnSubmitSurvey_Click(object sender, EventArgs e)
        {
            Surveys s1 = new Surveys();
            s1.SurveyName = txtName.Text;
            s1.QuestionOne = ddlQuestionOne.Text;
            s1.QuestionTwo = ddlQuestionTwo.Text;
            s1.QuestionThree = ddlQuestionThree.Text;
            s1.QuestionFour = ddlQuestionFour.Text;
            s1.QuestionFive = ddlQuestionFive.Text;
            s1.SurveyNumber = counter;
            SurveyList.AddToList(s1);
            Session["createdSurvey"] = s1;
            counter++;
            AddContentToDB();
            
            Response.Redirect("FinalSurvey4.aspx");            
        }

        public void FillDDLOne()
        {
            foreach (Questions q in QuestionList.QuestionsList)
            {
                ddlQuestionOne.Items.Add(q.QuestionContent);
            }
        }
        public void FillDDLTwo()
        {
            foreach (Questions q in QuestionList.QuestionsList)
            {
                ddlQuestionTwo.Items.Add(q.QuestionContent);
            }
        }
        public void FillDDLThree()
        {
            foreach (Questions q in QuestionList.QuestionsList)
            {
                ddlQuestionThree.Items.Add(q.QuestionContent);
            }
        }
        public void FillDDLFour()
        {
            foreach (Questions q in QuestionList.QuestionsList)
            {
                ddlQuestionFour.Items.Add(q.QuestionContent);
            }
        }
        public void FillDDLFive()
        {
            foreach (Questions q in QuestionList.QuestionsList)
            {
                ddlQuestionFive.Items.Add(q.QuestionContent);
            }
        }

        public void AddContentToDB()
        {
            Surveys currentSurvey = (Surveys)Session["createdSurvey"];

            //get ID's
            int SurveyID = GetSurveyID(currentSurvey);
            Session["SurveyID"] = SurveyID;  //create to use on page 4
            int QuestionID1 = GetQuestionID1(currentSurvey);
            int QuestionID2 = GetQuestionID2(currentSurvey);
            int QuestionID3 = GetQuestionID3(currentSurvey);
            int QuestionID4 = GetQuestionID4(currentSurvey);
            int QuestionID5 = GetQuestionID5(currentSurvey);

            // add to junction tables here
            using (SqlConnection con = new SqlConnection(GetConnectionString()))  
            {
                string sqlJunction1 = "INSERT INTO SurveyQuestionPractice (QuestionID, SurveyID) VALUES (@questionID, @surveyID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction1, con))
                {
                    cmd.Parameters.AddWithValue("@questionID", QuestionID1);
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - Q1
            using (SqlConnection con = new SqlConnection(GetConnectionString()))  
            {
                string sqlJunction2 = "INSERT INTO SurveyQuestionPractice (QuestionID, SurveyID) VALUES (@questionID, @surveyID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction2, con))
                {
                    cmd.Parameters.AddWithValue("@questionID", QuestionID2);
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - Q2
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlJunction3 = "INSERT INTO SurveyQuestionPractice (QuestionID, SurveyID) VALUES (@questionID, @surveyID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction3, con))
                {
                    cmd.Parameters.AddWithValue("@questionID", QuestionID3);
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - Q3
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlJunction4 = "INSERT INTO SurveyQuestionPractice (QuestionID, SurveyID) VALUES (@questionID, @surveyID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction4, con))
                {
                    cmd.Parameters.AddWithValue("@questionID", QuestionID4);
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - Q4
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlJunction5 = "INSERT INTO SurveyQuestionPractice (QuestionID, SurveyID) VALUES (@questionID, @surveyID)";
                using (SqlCommand cmd = new SqlCommand(sqlJunction5, con))
                {
                    cmd.Parameters.AddWithValue("@questionID", QuestionID5);
                    cmd.Parameters.AddWithValue("@surveyID", SurveyID);
                    con.Open();
                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Console.WriteLine("Error with Name");
                    }
                    con.Close();
                }
            }//junction S1 - Q5
        }
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings
                ["SurveyBOCPracticeConnectionString"].ConnectionString;
        }

        //getting the ID's includes storing the data 

        public static int GetSurveyID(Surveys s)
        {
            //Surveys currentSurvey = (Surveys)Session["createdSurvey"];
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlSurveyNames = "INSERT INTO SurveysPractice (SurveyName) VALUES (@surveyName)";
                using (SqlCommand cmd = new SqlCommand(sqlSurveyNames, con))
                {
                    cmd.Parameters.AddWithValue("@surveyName", s.SurveyName);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlSurveyID = "SELECT IDENT_CURRENT('SurveysPractice') FROM SurveysPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlSurveyID, con);
                        int surveyID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return surveyID;
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
        public static int GetQuestionID1(Surveys s)
        {
            //Surveys currentSurvey = (Surveys)Session["createdSurvey"];
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlQuestionContent = "INSERT INTO QuestionsPractice (QuestionContent) VALUES (@questionContent)";
                using (SqlCommand cmd = new SqlCommand(sqlQuestionContent, con))
                {
                    cmd.Parameters.AddWithValue("@questionContent", s.QuestionOne);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('QuestionsPractice') FROM QuestionsPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int questionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return questionID;
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
        public static int GetQuestionID2(Surveys s)
        {
            //Surveys currentSurvey = (Surveys)Session["createdSurvey"];
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlQuestionContent = "INSERT INTO QuestionsPractice (QuestionContent) VALUES (@questionContent)";
                using (SqlCommand cmd = new SqlCommand(sqlQuestionContent, con))
                {
                    cmd.Parameters.AddWithValue("@questionContent", s.QuestionTwo);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('QuestionsPractice') FROM QuestionsPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int questionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return questionID;
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
        public static int GetQuestionID3(Surveys s)
        {
            //Surveys currentSurvey = (Surveys)Session["createdSurvey"];
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlQuestionContent = "INSERT INTO QuestionsPractice (QuestionContent) VALUES (@questionContent)";
                using (SqlCommand cmd = new SqlCommand(sqlQuestionContent, con))
                {
                    cmd.Parameters.AddWithValue("@questionContent", s.QuestionThree);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('QuestionsPractice') FROM QuestionsPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int questionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return questionID;
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
        public static int GetQuestionID4(Surveys s)
        {
            //Surveys currentSurvey = (Surveys)Session["createdSurvey"];
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlQuestionContent = "INSERT INTO QuestionsPractice (QuestionContent) VALUES (@questionContent)";
                using (SqlCommand cmd = new SqlCommand(sqlQuestionContent, con))
                {
                    cmd.Parameters.AddWithValue("@questionContent", s.QuestionFour);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('QuestionsPractice') FROM QuestionsPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int questionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return questionID;
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
        public static int GetQuestionID5(Surveys s)
        {
            //Surveys currentSurvey = (Surveys)Session["createdSurvey"];
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                string sqlQuestionContent = "INSERT INTO QuestionsPractice (QuestionContent) VALUES (@questionContent)";
                using (SqlCommand cmd = new SqlCommand(sqlQuestionContent, con))
                {
                    cmd.Parameters.AddWithValue("@questionContent", s.QuestionFive);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        string sqlQuestionID = "SELECT IDENT_CURRENT('QuestionsPractice') FROM QuestionsPractice";
                        SqlCommand selectCommand = new SqlCommand(sqlQuestionID, con);
                        int questionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return questionID;
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

