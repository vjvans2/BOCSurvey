<%@ Page Language="C#" MasterPageFile="~/SurveyBOC.Master" AutoEventWireup="true" CodeBehind="EndingForm5.aspx.cs" Inherits="Survey_BOC_ASP.EndingForm5" %>

 <asp:Content ID="EndingForm" ContentPlaceHolderID="mainPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12">

        <div>
            <asp:Label ID="lblThanks" runat="server" Text="Thank you for taking the survey!"></asp:Label>
            <br /><br />
            <asp:Label ID="lblScoreResults" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <asp:Button ID="btnCreateAnother" runat="server" CssClass="btn btn-primary" Text="Create Another Survey?" OnClick="btnCreateAnother_Click" /> &nbsp;
        <asp:Button ID="btnLandingPage" runat="server" CssClass="btn btn-info" Text="Go Back To Landing Page" OnClick="btnLandingPage_Click" />
                </div>
            </div>
        </div>

    </form>
        <br />
</asp:Content>

