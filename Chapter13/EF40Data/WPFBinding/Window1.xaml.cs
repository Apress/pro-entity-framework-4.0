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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private EF40Entities context;
        private List<SalesOrderHeader> soh;

        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            context = new EF40Entities();

            soh = context.SalesOrderHeaders.OrderBy(o => o.AccountNumber).ToList();

            System.Windows.Data.CollectionViewSource salesOrderHeaderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("salesOrderHeaderViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // salesOrderHeaderViewSource.Source = [generic data source]
            salesOrderHeaderViewSource.Source = soh;
        }
    }
}
