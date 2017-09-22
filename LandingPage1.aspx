<%@ Page Language="C#" MasterPageFile="~/SurveyBOC.Master" AutoEventWireup="true" CodeBehind="LandingPage1.aspx.cs" Inherits="Survey_BOC_ASP.LandingPage1" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BOC Survey</title>
    
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-3.1.1.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/overrides.css" rel="stylesheet" />
</head>
<body>  --%>
    
<%--    <header>
        <div class="jumbotron">
            <br />
        </div>
    </header> --%>  
    
<asp:Content ID="LandingPage" ContentPlaceHolderID="mainPlaceHolder" runat="server">  
    <form id="form1" runat="server">
        <div class="container">
          <div class="row">
             <div class="col-md-12">
        <div>
            <asp:Label ID="lblSelect" runat="server" Text="Please select which form to start on."></asp:Label>
        </div>
        <br />
        <asp:Button ID="btnQuestionCreation" runat="server" CssClass="btn btn-primary" Text="Question Creation" OnClick="btnQuestionCreation_Click" /> &nbsp;
        <asp:Button ID="btnSurveyCreation" runat="server" CssClass="btn btn-primary" Text="Survey Creation" OnClick="btnSurveyCreation_Click" />
       

        <br /><br />
        <hr /><hr />                                
        <br />
              
        <asp:Label ID="lblPriorSurveys" runat="server"
            server="" Text="If you have already created a survey please select it by name from the list below">
        </asp:Label> 
        <br /><br />
        <asp:DropDownList ID="ddlPriorSurveys" runat="server" DataSourceID="sqlDistinctNamesView" DataTextField="SurveyName" DataValueField="SurveyName"></asp:DropDownList>
                 <asp:SqlDataSource ID="sqlDistinctNamesView" runat="server" ConnectionString='<%$ ConnectionStrings:SurveyBOCPracticeConnectionString %>' 
                     SelectCommand="spDistinctNamesQuery" SelectCommandType="StoredProcedure">
                 </asp:SqlDataSource>   
                 <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br /><br />
        <asp:Button ID="btnPriorSurveys" runat="server" CssClass="btn btn-info" Text="Go To Prior Survey" OnClick="btnPriorSurveys_Click" />
             </div>
          </div>
        </div>   
    </form>

    <br />
</asp:Content>
<%--    <footer>
        <div class="text-center">
            &copy; BOC Survey Project July Class
        </div>
    </footer>--%>


<%--</body>
</html>--%>
