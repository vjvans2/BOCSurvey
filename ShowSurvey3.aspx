<%@ Page Language="C#" MasterPageFile="~/SurveyBOC.Master" AutoEventWireup="true" CodeBehind="ShowSurvey3.aspx.cs" Inherits="Survey_BOC_ASP.ShowSurvey3" %>


<asp:Content ID="ShowSurvey" ContentPlaceHolderID="mainPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12">

        <div>
            <asp:ValidationSummary ID="ValidationSummary" runat="server" CssClass="text-danger"
                HeaderText="Please correct these entries." />
<!----------------------------------Name--------------------------------------------------->  
            <asp:Label ID="lblSurveyName" runat="server" Text="Survey Name:"></asp:Label>
            <asp:TextBox ID="txtName" MaxLength="20" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                ControlToValidate="txtName"
                ErrorMessage="You must name the survey"
                Display="Dynamic">*
            </asp:RequiredFieldValidator>
        </div>
        <br />
<!-------------------------------------Q1-------------------------------------------------->
        <asp:Label ID="lblQuestionOne" runat="server" Text="Question 1:"></asp:Label> &nbsp; &nbsp;
        <asp:DropDownList ID="ddlQuestionOne" runat="server">
        </asp:DropDownList>
        <asp:CompareValidator ID="cvQuestionOnetoTwo" runat="server"
            ControlToValidate="ddlQuestionOne" CssClass="text-danger"            
            Type="String"
            Operator="NotEqual" 
            Display="Dynamic"
            ControlToCompare="ddlQuestionTwo"
            ErrorMessage="Question 1 and Question 2 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:CompareValidator ID="cvQuestionOnetoThree" runat="server"
            ControlToValidate="ddlQuestionOne" CssClass="text-danger"            
            Type="String"
            Operator="NotEqual"
            Display="Dynamic"
            ControlToCompare="ddlQuestionThree"
            ErrorMessage="Question 1 and Question 3 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:CompareValidator ID="cvQuestionOnetoFour" runat="server"
            ControlToValidate="ddlQuestionOne" CssClass="text-danger"            
            Type="String"
            Operator="NotEqual"
            Display="Dynamic"
            ControlToCompare="ddlQuestionFour"
            ErrorMessage="Question 1 and Question 4 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:CompareValidator ID="cvQuestionOnetoFive" runat="server"
            ControlToValidate="ddlQuestionOne" CssClass="text-danger"            
            Type="String"
            Operator="NotEqual"
            Display="Dynamic"
            ControlToCompare="ddlQuestionFive"
            ErrorMessage="Question 1 and Question 5 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:RequiredFieldValidator ID="rfvDDLQuestionOne" runat="server" 
            ControlToValidate="ddlQuestionOne"
            ErrorMessage="You must create questions before submitting a survey">*
        </asp:RequiredFieldValidator>
        <br /><br />
<!-------------------------------------Q2-------------------------------------------------->
        <asp:Label ID="lblQuestionTwo" runat="server" Text="Question 2:"></asp:Label> &nbsp; &nbsp;
        <asp:DropDownList ID="ddlQuestionTwo" runat="server">
        </asp:DropDownList>
        <asp:CompareValidator ID="cvQuestionTwotoThree" runat="server"
            ControlToValidate="ddlQuestionTwo" CssClass="text-danger"
            Type="String"
            Operator="NotEqual"
            Display="Dynamic"
            ControlToCompare="ddlQuestionThree"
            ErrorMessage="Question 2 and Question 3 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:CompareValidator ID="cvQuestionTwotoFour" runat="server"
            ControlToValidate="ddlQuestionTwo" CssClass="text-danger"
            Type="String"
            Operator="NotEqual"
            Display="Dynamic"
            ControlToCompare="ddlQuestionFour"
            ErrorMessage="Question 2 and Question 4 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:CompareValidator ID="cvQuestionTwotoFive" runat="server"
            ControlToValidate="ddlQuestionTwo" CssClass="text-danger"
            Type="String"
            Operator="NotEqual" 
            Display="Dynamic"
            ControlToCompare="ddlQuestionFive"
            ErrorMessage="Question 2 and Question 5 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:RequiredFieldValidator ID="rfvDDLQuestionTwo" runat="server" 
            ControlToValidate="ddlQuestionTwo"
            ErrorMessage="You must create questions before submitting a survey">*
        </asp:RequiredFieldValidator>
        <br /><br />
<!-------------------------------------Q3-------------------------------------------------->
        <asp:Label ID="lblQuestionThree" runat="server" Text="Question 3:"></asp:Label>&nbsp; &nbsp;
        <asp:DropDownList ID="ddlQuestionThree" runat="server">
        </asp:DropDownList>
        <asp:CompareValidator ID="cvQuestionThreetoFour" runat="server"
            ControlToValidate="ddlQuestionThree" CssClass="text-danger"
            Type="String"
            Operator="NotEqual"  
            Display="Dynamic"
            ControlToCompare="ddlQuestionFour"
            ErrorMessage="Question 3 and Question 4 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:CompareValidator ID="cvQuestionThreetoFive" runat="server"
            ControlToValidate="ddlQuestionThree" CssClass="text-danger"
            Type="String"
            Operator="NotEqual"    
            Display="Dynamic"
            ControlToCompare="ddlQuestionFive"
            ErrorMessage="Question 3 and Question 5 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:RequiredFieldValidator ID="rfvDDLQuestionThree" runat="server" 
            ControlToValidate="ddlQuestionThree"
            ErrorMessage="You must create questions before submitting a survey">*
        </asp:RequiredFieldValidator>
        <br /><br />
<!-------------------------------------Q4-------------------------------------------------->
        <asp:Label ID="lblQuestionFour" runat="server" Text="Question 4:"></asp:Label>&nbsp; &nbsp;
        <asp:DropDownList ID="ddlQuestionFour" runat="server">
        </asp:DropDownList>
        <asp:CompareValidator ID="cvQuestionFourtoFive" runat="server"
            ControlToValidate="ddlQuestionFour" CssClass="text-danger"
            Type="String"
            Operator="NotEqual"  
            Display="Dynamic"
            ControlToCompare="ddlQuestionFive"
            ErrorMessage="Question 4 and Question 5 must be different">*
        </asp:CompareValidator>
<!-------------->
        <asp:RequiredFieldValidator ID="rfvDDLQuestionFour" runat="server" 
            ControlToValidate="ddlQuestionFour"            
            ErrorMessage="You must create questions before submitting a survey">*
        </asp:RequiredFieldValidator>
        <br /><br />
<!-------------------------------------Q5-------------------------------------------------->
        <asp:Label ID="lblQuestionFive" runat="server" Text="Question 5:"></asp:Label>&nbsp; &nbsp;
        <asp:DropDownList ID="ddlQuestionFive" runat="server">
        </asp:DropDownList>
<%--        <asp:CompareValidator ID="cvQuestionFive" runat="server"
            ControlToValidate="ddlQuestionFive" CssClass="text-danger"
            InitialValue="Choose a question"
            Type="String"
            Operator="Equal"
            ControlToCompare="ddlQuestionOne, ddlQuestionTwo, ddlQuestionThree, ddlQuestionFour"
            ErrorMessage="Questions must all be different">
        </asp:CompareValidator>--%>
<!-------------->
        <asp:RequiredFieldValidator ID="rfvDDLQuestionFive" runat="server" 
            ControlToValidate="ddlQuestionFive"            
            ErrorMessage="You must create questions before submitting a survey">*
        </asp:RequiredFieldValidator>
        <br />
        <asp:SqlDataSource ID="sqlQuestions" runat="server" ConnectionString="<%$ ConnectionStrings:SurveyBOCPracticeConnectionString %>" 
            SelectCommand="SELECT [QuestionContent] FROM [QuestionsPractice]">
        </asp:SqlDataSource>
        <br />
<!--------------------------------------------------------------------------------------->
        <asp:Button ID="btnAddQuestions" runat="server" CssClass="btn btn-primary" Text="Add More Questions" OnClick="btnAddQuestions_Click" CausesValidation="false" /> &nbsp;
        <asp:Button ID="btnSubmitSurvey" runat="server" CssClass="btn btn-info" Text="Submit Survey" OnClick="btnSubmitSurvey_Click"
            />
                </div>
            </div>
        </div>        
    </form>
        <br />
</asp:Content>
