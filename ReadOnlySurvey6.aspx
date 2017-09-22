<%@ Page Language="C#" MasterPageFile="~/SurveyBOC.Master" AutoEventWireup="true" CodeBehind="ReadOnlySurvey6.aspx.cs" Inherits="Survey_BOC_ASP.ReadOnlySurvey6" %>
<asp:Content ID="ReadOnlySurvey" ContentPlaceHolderID="mainPlaceHolder" runat="server"> 
    <form id="form6" runat="server">
        
        <div class="container">
            <div class="row">
                <div class="col-md-12">

        <div>
            <asp:Label ID="lblSurveyName" runat="server" Font-Bold="True" Font-Underline="True"></asp:Label>
        </div> <br />

        <asp:Label ID="lblSurveyQuestionOne" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lblSurveyAnswerOne" runat="server" Font-Italic="True"></asp:Label>
        <br /><br />
         <asp:Label ID="lblSurveyQuestionTwo" runat="server" Text=""></asp:Label><br />
         <asp:Label ID="lblSurveyAnswerTwo" runat="server" Font-Italic="True"></asp:Label>
        <br /><br />
         <asp:Label ID="lblSurveyQuestionThree" runat="server" Text=""></asp:Label><br />
         <asp:Label ID="lblSurveyAnswerThree" runat="server" Font-Italic="True"></asp:Label>
        <br /><br />
         <asp:Label ID="lblSurveyQuestionFour" runat="server" Text=""></asp:Label><br />
         <asp:Label ID="lblSurveyAnswerFour" runat="server" Font-Italic="True"></asp:Label>
        <br /><br />
        <asp:Label ID="lblSurveyQuestionFive" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lblSurveyAnswerFive" runat="server" Font-Italic="True"></asp:Label>
        <br /><br />
        <asp:Button ID="btnBacktoLanding" runat="server" CssClass="btn btn-success" Text="Back to Landing Page" OnClick="btnBacktoLanding_Click" /> <br />
        <br /><br />
                </div>
            </div>
        </div>   
    </form>
        <br />
</asp:Content>
