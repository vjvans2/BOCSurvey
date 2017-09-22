<%@ Page Language="C#" MasterPageFile="~/SurveyBOC.Master" AutoEventWireup="true" CodeBehind="FinalSurvey4.aspx.cs" Inherits="Survey_BOC_ASP.FinalSurvey4" %>

<asp:Content ID="FinalSurvey" ContentPlaceHolderID="mainPlaceHolder" runat="server"> 
    <form id="form1" runat="server">
        
        <div class="container">
            <div class="row">
                <div class="col-md-12">

        <div>
            <asp:Label ID="lblSurveyName" runat="server" Font-Bold="True" Font-Underline="True"></asp:Label>
        </div> <br />

        <asp:Label ID="lblSurveyQuestionOne" runat="server" Text=""></asp:Label>
        <asp:RadioButtonList ID="rblSurveyQuestionOne" runat="server" RepeatDirection="Horizontal" CssClass="radiopad">
            <asp:ListItem  Selected="True">Yes&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>Unsure&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>No&nbsp;&nbsp;</asp:ListItem>
        </asp:RadioButtonList>
        <br />
         <asp:Label ID="lblSurveyQuestionTwo" runat="server" Text=""></asp:Label>
        <asp:RadioButtonList ID="rblSurveyQuestionTwo" runat="server" RepeatDirection="Horizontal" CssClass="radiopad">
            <asp:ListItem Selected="True">Yes&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>Unsure&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>No&nbsp;&nbsp;</asp:ListItem>
        </asp:RadioButtonList>
        <br />
         <asp:Label ID="lblSurveyQuestionThree" runat="server" Text="">
         </asp:Label>
        <asp:RadioButtonList ID="rblSurveyQuestionThree" runat="server" RepeatDirection="Horizontal" CssClass="radiopad">
            <asp:ListItem Selected="True">Yes&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>Unsure&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>No&nbsp;&nbsp;</asp:ListItem>
        </asp:RadioButtonList>
        <br />
         <asp:Label ID="lblSurveyQuestionFour" runat="server" Text=""></asp:Label>
        <asp:RadioButtonList ID="rblSurveyQuestionFour" runat="server" RepeatDirection="Horizontal" CssClass="radiopad">
            <asp:ListItem Selected="True">Yes&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>Unsure&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>No&nbsp;&nbsp;</asp:ListItem>
        </asp:RadioButtonList>
        <br />
         <asp:Label ID="lblSurveyQuestionFive" runat="server" Text=""></asp:Label>
        <asp:RadioButtonList ID="rblSurveyQuestionFive" runat="server" RepeatDirection="Horizontal" CssClass="radiopad">
            <asp:ListItem Selected="True">Yes&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>Unsure&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem>No&nbsp;&nbsp;</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="btnSubmitAnswers" runat="server" CssClass="btn btn-success" Text="Submit Answers" OnClick="btnSubmitAnswers_Click" /> <br />
        <br />
<%--        <asp:Button ID="btnBackToSurvey" runat="server" CssClass="btn btn-info" Text="Back to Survey" OnClick="btnBackToSurvey_Click" /> &nbsp;
        <asp:Button ID="btnBacktoQuestions" runat="server" CssClass="btn btn-primary" Text="Back to Questions" OnClick="btnBacktoQuestions_Click" /> &nbsp;
        <asp:Button ID="btnBacktoLanding" runat="server" CssClass="btn btn-info" Text="Back to Landing Page" OnClick="btnBacktoLanding_Click" />--%>

        <br />
                </div>
            </div>
        </div>   
    </form>
        <br />
</asp:Content>

