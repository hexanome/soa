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
    /// Interaction logic for DetailsContacts.xaml
    /// </summary>
    public partial class DetailsContacts : UserControl
    {
        public DetailsContacts()
        {
            this.InitializeComponent();
        }

        private void BtCancel_Click(object sender, System.EventArgs e)
        {
            var annulationContact = new AnnulationContact();
            annulationContact.ShowDialog();
        }

        private void BtPrendreRdv_Click(object sender, System.EventArgs e)
        {
            var priseRdv = new PriseRDV();
            priseRdv.ShowDialog();
        }
    }
}