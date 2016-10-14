using EF40Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.Objects;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EF40Entities context;
        private List<SalesOrderHeader> soh;
        private List<SalesPerson> sp;
        private List<Contact> con;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context = new EF40Entities();

            soh = context.SalesOrderHeaders.OrderBy(o => o.AccountNumber).ToList();

            listBox1.ItemsSource = soh;

            //combo
            sp = context.SalesPersons.OrderBy(s => s.SalesPersonID).ToList();
            comboBox1.ItemsSource = sp;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 frm = new Window1();
            frm.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }
    }
}
