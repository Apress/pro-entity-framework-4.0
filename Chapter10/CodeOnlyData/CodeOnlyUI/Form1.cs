using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.Objects;

namespace CodeOnlyUI
{
    public partial class Form1 : Form
    {
        bool isLoaded = false;
        SqlConnection conn;
        ContextBuilder<AWModel> builder;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection("Data Source=SCOTT-LAPTOP;Initial Catalog=EF40;User ID=sa;PWD=Yamahayz1;MultipleActiveResultSets=True;");

                builder = new ContextBuilder<AWModel>();
                Registerconfig(builder);
                var context = builder.Create(conn);
                context.ContextOptions.LazyLoadingEnabled = true;

                var query = from c in context.Contact
                            join emp in context.Employee on c.ContactID equals emp.Contact.ContactID
                            //where c.LastName.StartsWith("G")
                            orderby c.FirstName
                            select new { c.ContactID, c.FirstName, c.LastName };

                isLoaded = false;
                listBox1.DataSource = query;
                listBox1.DisplayMember = "FirstName";
                listBox1.ValueMember = "ContactID";
                isLoaded = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }
        static void Registerconfig(ContextBuilder<AWModel> builder)
        {
            builder.Configurations.Add(new ContactConfiguration(builder));
            builder.Configurations.Add(new EmployeeConfiguration(builder));
            //builder.Configurations.Add(new EmployeeAddressConfiguration(builder));
            //builder.Configurations.Add(new AddressConfiguration(builder));
            //builder.Configurations.Add(new SalesPersonConfiguration(builder));
            //builder.Configurations.Add(new SalesTerritoryConfiguration(builder));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (isLoaded == true)
                {
                    var context = builder.Create(conn);
                    context.ContextOptions.LazyLoadingEnabled = true;
                    
                    int id = (int)listBox1.SelectedValue;
                    label1.Text = id.ToString();

                    var query = from emp in context.Employee
                                where emp.Contact.ContactID == id
                                select emp;

                    dataGridView1.DataSource = query;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }
    }
}
