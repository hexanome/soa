﻿using System;
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
    /// Interaction logic for DetailsRdv.xaml
    /// </summary>
    public partial class DetailsRdv : UserControl
    {
        public DetailsRdv()
        {
            this.InitializeComponent();
        }

        private void RdvChoixClient_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            (new SelectionAgent()).ShowDialog();
        }
    }
}