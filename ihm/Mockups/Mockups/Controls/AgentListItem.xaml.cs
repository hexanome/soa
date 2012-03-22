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
    /// Interaction logic for AgentListItem.xaml
    /// </summary>
    public partial class AgentListItem : UserControl
    {
        public AgentListItem()
        {
            this.InitializeComponent();
        }

        public string AgentName
        {
            get { return (string)GetValue(AgentNameProperty); }
            set { SetValue(AgentNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AgentName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgentNameProperty =
            DependencyProperty.Register("AgentName", typeof(string), typeof(AgentListItem), new UIPropertyMetadata(string.Empty));   
    }
}