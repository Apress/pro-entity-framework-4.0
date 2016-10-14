using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    using ServiceReference1;

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdventureWorksEntities svc = new AdventureWorksEntities(new Uri("http://localhost:1089/AWService.svc"));

                foreach (Employee emp in svc.Employees)
                {
                    listBox1.Items.Add(string.Format("{0} {1}", emp.ContactID, emp.Title));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                AdventureWorksEntities svc = new AdventureWorksEntities(new Uri("http://localhost:1089/AWService.svc"));

                var query = from c in svc.Contacts
                            where c.LastName.StartsWith("K")
                            orderby c.LastName
                            select c;

                foreach (var con in query)
                {
                    listBox1.Items.Add(string.Format("{0} {1}", con.FirstName, con.LastName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
