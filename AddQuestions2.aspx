<%@ Page Language="C#" MasterPageFile="~/SurveyBOC.Master" AutoEventWireup="true" CodeBehind="AddQuestions2.aspx.cs" Inherits="Survey_BOC_ASP.AddQuestions2" %>

<asp:Content ID="AddQuestions" ContentPlaceHolderID="mainPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div>
            <asp:Label ID="lblQuestion" runat="server" Text="Question: "></asp:Label> &nbsp;
            <asp:TextBox ID="txtNewQuestion" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNewQuestion" runat="server"
                ErrorMessage="You can not submit a question without any text"  
                ControlToValidate="txtNewQuestion"                
                ValidateEmptyText="false"
                Display="Dynamic"
                ValidationGroup="Add">
            </asp:RequiredFieldValidator>
        </div>
        <br />
        <asp:Button ID="btnAddQuestion" runat="server" Text="Add Question" 
            OnClick="btnAddQuestion_Click"
            ValidationGroup="Add" CommandName="Add" CssClass="btn btn-info"
            OnCommand="AddButton_Command"
            /> &nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="Submit"  CssClass="btn btn-primary" OnClick="btnSubmit_Click" /> &nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel"  CssClass="btn btn-danger" OnClick="btnCancel_Click" CausesValidation="false" /> &nbsp;
                </div>
            </div>
        </div>

    </form> 
        <br />
</asp:Content>
