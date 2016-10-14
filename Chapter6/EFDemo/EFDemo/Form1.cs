using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFDemo
{
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
                using (var context = new AdventureWorks2008Entities())
                {
                    var busent = context.BusinessEntities.Where(p => p.BusinessEntityID == 292).First();
                    var per = new Person();
                    per.PersonType = "SC";
                    per.NameStyle = true;
                    per.Title = "Geek";
                    per.FirstName = "Scott";
                    per.MiddleName = "L";
                    per.LastName = "Klein";
                    per.Suffix = "Mr";
                    per.EmailPromotion = 1;
                    per.rowguid = Guid.NewGuid();
                    per.ModifiedDate = DateTime.Now;
                    busent.Person = per;
                    context.SaveChanges();
                    MessageBox.Show("record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AdventureWorks2008Entities())
                {
                    var per = context.People.Where(p => p.BusinessEntityID == 292).First();
                    per.Title = "Head Geek";
                    per.ModifiedDate = DateTime.Now;
                    per.PersonType = "EM";
                    context.SaveChanges();
                    MessageBox.Show("record updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AdventureWorks2008Entities())
                {
                    var per = context.People.Where(p => p.BusinessEntityID == 292).First();
                    context.DeleteObject(per);
                    context.SaveChanges();
                    MessageBox.Show("record deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new AdventureWorks2008Entities())
            {
                //var query = from p in context.SelectPeople()
                //            where p.LastName.StartsWith("Kl")
                //            select p;

                //foreach (var per in query)
                //{
                //    listBox1.Items.Add(string.Format("{0} {1}", per.FirstName, per.LastName));
                //}
                //where p.BusinessEntityID == 8
                var query = (from p in context.People
                             where p.LastName.StartsWith("K")
                             select new { p.LastName, p.FirstName, p.MiddleName, p.BusinessEntityID }).Count();

                //foreach (var per in query)
                //{
                //    listBox1.Items.Add(string.Format("{0} {1}", per.FirstName, per.LastName));
                //}

                //var secondquery = query.Where(p => p.BusinessEntityID == 8);
                //foreach (var per in secondquery)
                //{
                //    //listBox1.Items.Add(string.Format("{0} {1}", per.FirstName, per.LastName));
                //    textBox1.Text = per.FirstName + " " + per.LastName;
                //}
            }
        }
    }
}
