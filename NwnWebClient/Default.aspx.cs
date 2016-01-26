using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NwnWebClient.ServiceReference1;

namespace NwnWebClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            lblGetEmployeeError.Text = "";
            try
            {
                NwnWebClient.ServiceReference1.EmployeeServiceClient client = new EmployeeServiceClient();
                var result = client.GetEmployee(int.Parse(txtGetEmployee.Text));
                txtAddress.Text = result.Address;
                txtBirthDate.Text = result.BirthDate.ToString();
                txtCity.Text = result.City;
                txtCountry.Text = result.Country;
                txtCourtesy.Text = result.TitleOfCourtesy;
                txtEmployeeId.Text = result.EmployeeID.ToString();
                txtFirstName.Text = result.FirstName;
                txtLastName.Text = result.LastName;
                txtHireDate.Text = result.HireDate.ToString();
                txtHomePhone.Text = result.HomePhone;
                txtTitle.Text = result.Title;
                txtPostalCode.Text = result.PostalCode;
                txtRegion.Text = result.Region;

            }
            catch (Exception)
            {

                lblGetEmployeeError.Text = "Some data could not be found, either you entered any letters or the ID doesn't exist!";
                lblGetEmployeeError.ForeColor = Color.Red;
            }

        }

        protected void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Parse(txtBirthDateCreate.Text) >= new DateTime(1753, 01, 01) && DateTime.Parse(txtHireDateCreate.Text) >= new DateTime(1753, 01, 01))
                {


                    EmployeeServiceClient client = new EmployeeServiceClient();
                    Employee employee = new Employee
                    {
                        Address = txtAddressCreate.Text,
                        BirthDate = DateTime.Parse(txtBirthDateCreate.Text),
                        City = txtCityCreate.Text,
                        Country = txtCountryCreate.Text,
                        FirstName = txtFirstNameCreate.Text,
                        HireDate = DateTime.Parse(txtHireDateCreate.Text),
                        HomePhone = txtHomePhoneCreate.Text,
                        LastName = txtLastNameCreate.Text,
                        PostalCode = txtPostalCodeCreate.Text,
                        Region = txtRegionCreate.Text,
                        Title = txtTitleCreate.Text,
                        TitleOfCourtesy = txtCourtesyCreate.Text

                    };

                    client.AddEmployee(employee);
                }
                else
                {
                    lblCreateError.Text = "Date must be after 1 January 1753!";
                }

            }
            catch (Exception)
            {

                lblCreateError.Text = "All inputs must have values!";
                lblCreateError.ForeColor = Color.Red;
            }
        }
    }
}