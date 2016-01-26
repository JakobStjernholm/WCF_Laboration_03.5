using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeWinFormClient.ServiceReference1;

namespace EmployeeWinFormClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeServiceClient client = new EmployeeServiceClient();
            List<Employee> result = new List<Employee>();
            result.Add(client.GetEmployee((int)numericUpDown1.Value));
                 client.GetEmployee((int) numericUpDown1.Value);
        
           
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
    }
}
