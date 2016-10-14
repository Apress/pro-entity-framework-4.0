using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EF40Data;
using System.Data.Entity;

namespace EFUI
{
    public partial class Form1 : Form, IDisposable
    {
        EF40Entities context;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (EF40Entities context = new EF40Entities())
            {
                //
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                context = new EF40Entities();
                var query = from con in context.Contacts
                            select con;

                foreach (var asdf in query)
                {
                    listBox1.Items.Add(asdf.FirstName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                context = null;
            }
        }
        void Dispose()
        {
            //
        }
    }
}
