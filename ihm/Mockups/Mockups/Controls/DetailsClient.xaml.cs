using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mockups
{
    /// <summary>
    /// Interaction logic for DetailsClient.xaml
    /// </summary>
    public partial class DetailsClient : UserControl
    {
        public DetailsClient()
        {
            this.InitializeComponent();

            ListRevenue.Items.Add(new
            {
                Month = "Janvier 2012",
                Amount = "2356 €"
            });

            ListRevenue.Items.Add(new
            {
                Month = "Février 2012",
                Amount = "2266 €"
            });

            ListRevenue.Items.Add(new
            {
                Month = "Mars 2012",
                Amount = "2312 €"
            });

            ListCharges.Items.Add(new
            {
                Month = "Mars 2012",
                Amount = "606 €"
            });

            ListCharges.Items.Add(new
            {
                Month = "Mars 2012",
                Amount = "785 €"
            });

            ListCharges.Items.Add(new
            {
                Month = "Mars 2012",
                Amount = "752 €"
            });
        }
    }
}