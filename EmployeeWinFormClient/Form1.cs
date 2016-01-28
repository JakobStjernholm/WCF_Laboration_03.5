using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeWinFormClient.ServiceReference1;

namespace EmployeeWinFormClient
{
    public partial class btnAdd : Form
    {
        public btnAdd()
        {
            InitializeComponent();
        }

        private void btnGetEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                lblErrorMessageGet.Text = "";
                listView1.Clear();
                EmployeeServiceClient client = new EmployeeServiceClient();
                List<Employee> result = new List<Employee>();
                result.Add(client.GetEmployee((int)numericUpDown1.Value));
                client.GetEmployee((int)numericUpDown1.Value);


                foreach (var i in result)
                {
                    listView1.Items.Add(i.EmployeeID.ToString());
                    listView1.Items.Add(i.Address);
                    listView1.Items.Add(i.City);
                    listView1.Items.Add(i.Country);
                    listView1.Items.Add(i.PostalCode);
                    listView1.Items.Add(i.FirstName);
                    listView1.Items.Add(i.LastName);
                    listView1.Items.Add(i.HomePhone);
                    listView1.Items.Add(i.Region);
                    listView1.Items.Add(i.Title);
                    listView1.Items.Add(i.TitleOfCourtesy);
                    listView1.Items.Add(i.HireDate.ToString());
                    listView1.Items.Add(i.BirthDate.ToString());

                }
            }
            catch (FaultException ex)
            {
                lblErrorMessageGet.Text = $"FaultException: {ex.Message}";
            }
            catch (Exception exception)
            {
                lblErrorMessageGet.Text = exception.Message;
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblErrorMessage.Text = "";

                if (DateTime.Parse(textBoxBirthdate.Text) >= new DateTime(1753, 01, 01) &&
                    DateTime.Parse(textBoxHiredate.Text) >= new DateTime(1753, 01, 01))
                {
                    EmployeeServiceClient client = new EmployeeServiceClient();
                    Employee employee = new Employee
                    {
                        Address = textBoxAddress.Text,
                        BirthDate = DateTime.Parse(textBoxBirthdate.Text),
                        City = textBoxCity.Text,
                        Country = textBoxCountry.Text,
                        FirstName = textBoxFirstname.Text,
                        HireDate = DateTime.Parse(textBoxHiredate.Text),
                        HomePhone = textBoxHomePhone.Text,
                        LastName = textBoxLastname.Text,
                        PostalCode = textBoxPostalCode.Text,
                        Region = textBoxRegion.Text,
                        Title = textBoxTitle.Text,
                        TitleOfCourtesy = textBoxCourtesy.Text
                    };
                    client.AddEmployee(employee);
                    ClearTextboxes();
                }
                else
                {
                    lblErrorMessage.Text = "Date can not that early!";
                }
            }
            catch (FaultException ex)
            {
                lblErrorMessage.Text = $"FaultException: {ex.Message}";
            }
            catch (Exception exception)
            {
                lblErrorMessage.Text = exception.Message;
            }

        }

        private void ClearTextboxes()
        {
            textBoxBirthdate.Clear();
            textBoxAddress.Clear();
            textBoxCity.Clear();
            textBoxCountry.Clear();
            textBoxFirstname.Clear();
            textBoxLastname.Clear();
            textBoxHiredate.Clear();
            textBoxHomePhone.Clear();
            textBoxPostalCode.Clear();
            textBoxRegion.Clear();
            textBoxTitle.Clear();
            textBoxCourtesy.Clear();
        }
    }
}
