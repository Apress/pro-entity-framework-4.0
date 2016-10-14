using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsBinding
{
    public partial class Form1 : Form
    {
        EF40Data.EF40Entities context;
        EF40Data.ProductModel prodMods;
        bool isNew;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new EF40Data.EF40Entities();

            ObjectResult<EF40Data.ProductModel> pm = 
                context.ProductModels.Execute(MergeOption.AppendOnly);

            productModelBindingSource.DataSource = pm;

            productModelBindingNavigator.AddNewItem.Enabled = true;
            productModelBindingNavigator.DeleteItem.Enabled = true;
        }

        private void productsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var prod = (EF40Data.Product)(productsBindingSource[e.RowIndex]);

            var grid = productsDataGridView;

            grid.Rows[e.RowIndex].Cells[ProductModelName.Index].Value = prod.ProductModel.Name;
            grid.Rows[e.RowIndex].Cells[ProductSubCategoryName.Index].Value = prod.ProductSubcategory.Name;
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void productModelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                try
                {
                    if (nameTextBox.Text.Length > 0)
                    {
                        productModelBindingSource.EndEdit();
                        prodMods = new EF40Data.ProductModel();
                        prodMods.Name = nameTextBox.Text;
                        context.ProductModels.AddObject(prodMods);
                        context.SaveChanges();
                        isNew = false;
                    }
                }
                catch (Exception ex)
                {
                    if (ex.InnerException != null)
                        MessageBox.Show(ex.InnerException.Message.ToString());
                    else
                        MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                productModelBindingSource.EndEdit();
                context.SaveChanges();
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void productModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //
        }

        private void productModelBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            isNew = true;
        }

    }
}
