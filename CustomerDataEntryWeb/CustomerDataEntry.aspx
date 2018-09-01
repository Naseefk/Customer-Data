<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDataEntry.aspx.cs" Inherits="CustomerDataEntryWeb.CustomerDataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" OnTextChanged="txtCustomerName_TextChanged"></asp:TextBox>
        <p>
            <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
            <asp:DropDownList ID="ddlCountryName" runat="server">
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>England</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:RadioButton ID="radioBtnMale" runat="server" GroupName="Gender" Text="Male" />
        <asp:RadioButton ID="radioBtnFemale" runat="server" GroupName="Gender" Text="Female" />
        <p>
            <asp:CheckBox ID="CheckReading" runat="server" Text="Reading" OnCheckedChanged="CheckReading_CheckedChanged" />
            <asp:CheckBox ID="CheckPainting" runat="server" Text="Painting" OnCheckedChanged="CheckPainting_CheckedChanged" />
        </p>
        <asp:RadioButton ID="radioBtnMarried" runat="server" GroupName="Status" Text="Married" />
        <asp:RadioButton ID="radioBtnUnmarried" runat="server" GroupName="Status" Text="Unmarried" />
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:GridView ID="gridCustomers" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gridCustomers_SelectedIndexChanged">
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
