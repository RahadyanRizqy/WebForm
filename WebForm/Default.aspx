<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<table>  
    <tr>  
        <td colspan="2">  
            <h1>Registration Form</h1>  
        </td>  
    </tr>
    <tr>
        <td>Student ID</td>
        <td>:</td>
        <td>
            <asp:Textbox ID="txtStudID" runat="server"></asp:Textbox>
        </td>
    </tr>
    <tr>  
        <td>Student Name</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtStudName" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Student Username</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtStudUname" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Student Password</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtStudPword" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Student Email</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtStudEmail" runat="server"></asp:TextBox>  
        </td>  
    </tr>
    <tr>
        <td>Student Address</td>
        <td>:</td>
        <td>
            <asp:TextBox ID="txtStudAddr" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>  
        <td colspan="2">  
            <asp:Button ID="btnInsertion" runat="server" Text="Insert" OnClick="btnInsertion_Click" Style="width: 48px" />
            <asp:Button ID="btnUpdation" runat="server" Text="Update" OnClick="btnUpdation_Click" />
            <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>  
        </td>  
    </tr>  
</table>
<table>  
    <tr>  
        <td>  
            <h1>View Students Data</h1>  
        </td>  
    </tr>  
    <tr>  
        <td>  
            <asp:Button ID="btnSelection" runat="server" Text="Select All Data" OnClick="btnSelection_Click" />  
        </td>  
    </tr>  
    <tr>  
        <td>  
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>  
        </td>  
    </tr>
</table>
<table>  
    <tr>  
        <td colspan="3">  
            <h1>Delete Students Data</h1>  
        </td>  
    </tr>  
    <tr>  
        <td>Student ID</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr >  
        <td colspan="3">  
            <asp:Button ID="btnDeletion" runat="server" Text="Delete" OnClick="btnDeletion_Click" />  
            <asp:Label ID="lblmessage" runat="server" ForeColor="Red"></asp:Label>  
        </td>  
    </tr>  
</table>

</asp:Content>
