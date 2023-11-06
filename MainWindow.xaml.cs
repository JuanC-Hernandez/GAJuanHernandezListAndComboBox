﻿using System;
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

namespace GAJuanHernandezListAndComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> fName = new List<string> { "Juan", "Carlos", "Gladis", "Gabriel", "Maria"};//Populated list
        List<string> lName = new List<string> { "Hernandez", "Vasquez", "Molina", "Lopez", "Ruiz" };//Populated list

        public MainWindow()
        {
            InitializeComponent();
            cmbFirstName.ItemsSource = fName;//Populate combo box
            lblLastNames.ItemsSource = lName;//Populate list box

        }//MainWindow
    }//MainWindow : Window
}//namespace
