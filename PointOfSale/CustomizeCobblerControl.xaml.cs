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
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        private void IcereamButton_Click(object sender, RoutedEventArgs e)
        {
            Cobbler cobbler = new Cobbler();
            cobbler.WithIceCream = true;
        }

        private void PeachFilling_Click(object sender, RoutedEventArgs e)
        {
            Cobbler cobbler = new Cobbler();
            cobbler.Fruit = FruitFilling.Peach;
        }

        private void CherryFilling_Click(object sender, RoutedEventArgs e)
        {
            Cobbler cobbler = new Cobbler();
            cobbler.Fruit = FruitFilling.Cherry;
        }

        private void BlueberryFilling_Click(object sender, RoutedEventArgs e)
        {
            Cobbler cobbler = new Cobbler();
            cobbler.Fruit = FruitFilling.Blueberry;
        }
    }
}
