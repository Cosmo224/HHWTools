using HHW.Tools.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HHW.Tools.TrackMaker
{
    partial class MainWindow : Window
    {
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void NewStorm_Click(object sender, RoutedEventArgs e)
        {
            AddNewStorm addNewStorm = new AddNewStorm(); // create the new storm window class
            addNewStorm.Show();
        }
    }

}
