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
using System.Windows.Shapes;

namespace Mockups
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            // Insert code required on object creation below this point.
            this.GridDashboard.Visibility = System.Windows.Visibility.Hidden;
            this.BorderLogin.Visibility = System.Windows.Visibility.Visible;
        }

        private void Windows_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ListContacts.Items.Add(new
            {
                Name = "Matthieu Coquet",
                Motif = "Prêt",
                Date = "22/03/2012",
                Assigne = "Oui"
            });

            ListContacts.Items.Add(new
            {
                Name = "Xavier Sauvagnat",
                Motif = "Ouverture de compte",
                Date = "21/03/2012",
                Assigne = "Non"
            });

            ListClients.Items.Add(new
            {
                Name = "Matthieu Coquet"
            });
            ListClients.Items.Add(new
            {
                Name = "Xavier Sauvagnat"
            });
            ListClients.Items.Add(new
            {
                Name = "Alexandre Lefoulon"
            });
            ListClients.Items.Add(new
            {
                Name = "Quentin Calvez"
            });
            ListClients.Items.Add(new
            {
                Name = "Jan Keromnes"
            });
            ListClients.Items.Add(new
            {
                Name = "Thaddée Tyl"
            });
        }

        private void BtContactSpontanne_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var contactSpontanne = new ContactSpontanne();
            contactSpontanne.ShowDialog();
        }

        private void CalendarTabs_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl)
            {
                StackCalendarAgentSelect.Visibility = (TcCalendars.SelectedIndex == 0) ? Visibility.Visible : Visibility.Hidden;
                StackCalendarWeek.Visibility = (TcCalendars.SelectedIndex == 0) ? Visibility.Visible : Visibility.Collapsed;
                StackCalendarDate.Visibility = (TcCalendars.SelectedIndex == 1) ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private void BtConnexion_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            GridDashboard.Visibility = System.Windows.Visibility.Visible;
            BorderLogin.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void LinkCalendarSelectAgent(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            (new SelectionAgent()).ShowDialog();
        }
    }
}