<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentDetails.aspx.cs" Inherits="COMP2007_Lesson4A.StudentDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Student Details</h1>
                <h5>All fields are required</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="LastNameTextBox">My label</label>
                    <asp:TextBox runat="server" class="form-control" ID="LastNameTextBox" placeholder="Last Name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="FirstNameTextBox">My label</label>
                    <asp:TextBox runat="server" class="form-control" ID="FirstNameTextBox" placeholder="First Name" required="true"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label class="control-label" for="EnrollmentDateTextBox">My label</label>
                    <asp:TextBox runat="server" type="Date" class="form-control" ID="EnrollmentDateTextBox" placeholder="Enrollment Date" required="true"></asp:TextBox>
                </div>
                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" UseSubmitBehavior="false" CausesValidation="false" runat="server" OnClick="CancelButton_Click"/>
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" UseSubmitBehavior="false" CausesValidation="false" runat="server" OnClick="SaveButton_Click"/>
                 </div>
            </div>
        </div>
    </div>
</asp:Content>
