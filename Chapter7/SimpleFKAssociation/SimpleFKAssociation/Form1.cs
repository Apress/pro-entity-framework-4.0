using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleFKAssociation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                try
                {
                    DateTime Birthdt = new DateTime(1965, 9, 26);
                    DateTime Hiredt = new DateTime(2010, 1, 1);
                    Contact con = new Contact { Title = "Geek", FirstName = "Scott", LastName = "Klein", 
                        EmailAddress = "ScottKlein@SqlXml.com", EmailPromotion = 0, Phone = "555-55-5555", 
                        PasswordHash = "", PasswordSalt = "", rowguid = System.Guid.NewGuid(), 
                        ModifiedDate = DateTime.Now };
                    Employee emp = new Employee { NationalIDNumber = "1234567890", LoginID = "sklein", 
                        ManagerID = 1, Title = "Geek", BirthDate = Birthdt, MaritalStatus = "M", 
                        Gender = "M", HireDate = Hiredt, SalariedFlag = true, VacationHours = 80, 
                        SickLeaveHours = 40, CurrentFlag = true, rowguid = System.Guid.NewGuid(), 
                        ModifiedDate = DateTime.Now };
                    con.Employees.Add(emp);
                    context.Contacts.AddObject(con);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                try
                {
                    DateTime Birthdt = new DateTime(1965, 9, 26);
                    DateTime Hiredt = new DateTime(2010, 1, 1);
                    Contact con = new Contact { Title = "Geek", FirstName = "Scott", LastName = "Klein", 
                        EmailAddress = "ScottKlein@SqlXml.com", EmailPromotion = 0, Phone = "555-55-5555", 
                        PasswordHash = "", PasswordSalt = "", rowguid = System.Guid.NewGuid(), 
                        ModifiedDate = DateTime.Now };
                    Employee emp = new Employee { ContactID = 19983, NationalIDNumber = "12345678901", 
                        LoginID = "sklein1", ManagerID = 1, Title = "Geek", BirthDate = Birthdt, 
                        MaritalStatus = "M", Gender = "M", HireDate = Hiredt, SalariedFlag = true, 
                        VacationHours = 80, SickLeaveHours = 40, CurrentFlag = true, 
                        rowguid = System.Guid.NewGuid(), ModifiedDate = DateTime.Now };
                    context.Employees.AddObject(emp);
                    context.Contacts.AddObject(con);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                try
                {
                    DateTime Birthdt = new DateTime(1965, 9, 26);
                    DateTime Hiredt = new DateTime(2010, 1, 1);
                    Employee emp = new Employee { ContactID = 19983, NationalIDNumber = "12345678902", 
                        LoginID = "sklein2", ManagerID = 1, Title = "Geek", BirthDate = Birthdt, 
                        MaritalStatus = "M", Gender = "M", HireDate = Hiredt, SalariedFlag = true, 
                        VacationHours = 80, SickLeaveHours = 40, CurrentFlag = true, 
                        rowguid = System.Guid.NewGuid(), ModifiedDate = DateTime.Now };
                    context.Employees.AddObject(emp);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
