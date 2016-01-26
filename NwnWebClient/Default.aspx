<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NwnWebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="lblGetEmployee" runat="server" Text="Get employee by ID"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtGetEmployee" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnGetEmployee" runat="server" OnClick="btnGetEmployee_Click" style="margin-left: 0px" Text="Get employee" />
                    <br />
                    <asp:Label ID="lblEmployee" runat="server" Text="Employee ID"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtEmployeeId" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblLastName" runat="server" Text="Lastname"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtLastName" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblFirstname" runat="server" Text="Firstname"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtFirstName" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblTitle" runat="server" Text="Title"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtTitle" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblCourtesy" runat="server" Text="Title of courtesy"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCourtesy" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblBirthdate" runat="server" Text="Birthdate"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtBirthDate" runat="server" ReadOnly="True" TextMode="DateTime"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblHiredate" runat="server" Text="Hire date"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtHireDate" runat="server" ReadOnly="True" TextMode="DateTime"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtAddress" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCity" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblRegion" runat="server" Text="Region"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRegion" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblPostalCode" runat="server" Text="Postal code"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtPostalCode" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCountry" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblHomePhone" runat="server" Text="Home phone"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtHomePhone" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblGetEmployeeError" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Create Employee by entering data to all inputs:"></asp:Label>
                    <br />
                    <asp:Label ID="lblFirstname0" runat="server" Text="Firstname"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtFirstNameCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblLastName0" runat="server" Text="Lastname"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtLastNameCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblTitle0" runat="server" Text="Title"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtTitleCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblCourtesy0" runat="server" Text="Title of courtesy"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCourtesyCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblBirthdate0" runat="server" Text="Birthdate"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtBirthDateCreate" runat="server" TextMode="DateTime"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblHiredate0" runat="server" Text="Hire date"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtHireDateCreate" runat="server" TextMode="DateTime"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblAddress0" runat="server" Text="Address"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtAddressCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblCity0" runat="server" Text="City"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCityCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblRegion0" runat="server" Text="Region"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRegionCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblPostalCode0" runat="server" Text="Postal code"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtPostalCodeCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblCountry0" runat="server" Text="Country"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtCountryCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblHomePhone0" runat="server" Text="Home phone"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtHomePhoneCreate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnCreateEmployee" runat="server" OnClick="btnCreateEmployee_Click" Text="Create Employee" />
                    <br />
                    <asp:Label ID="lblCreateError" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
