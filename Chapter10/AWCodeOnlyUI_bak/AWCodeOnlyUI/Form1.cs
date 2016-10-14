using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Objects;
using System.Data.EntityClient;
using System.Data.SqlClient;

namespace AWCodeOnlyUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection("Data Source=SCOTT-LAPTOP;Initial Catalog=EF40;User ID=sa;PWD=Yamahayz1;MultipleActiveResultSets=True;");

                var builder = new ContextBuilder<AWModel>();
                Registerconfig(builder);
                var context = builder.Create(conn);

                //var query = from r in context.SalesTerritory
                //            select r;

                //foreach (var per in query)
                //{
                //    listBox1.Items.Add(per.Name);
                //}

                var query = from emp in context.Employee
                            select emp;

                foreach (var empl in query)
                {
                    listBox1.Items.Add(empl.LoginID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message.ToString());
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
    }


}
