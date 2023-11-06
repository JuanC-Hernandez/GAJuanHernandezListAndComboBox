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

        private void btnDisplayFullName_Click(object sender, RoutedEventArgs e)
        {
            int firstNameIndex = cmbFirstName.SelectedIndex;

            int lastNameIndex = lblLastNames.SelectedIndex;

            string firstName = fName[firstNameIndex];

            string lastName = lName[lastNameIndex];

            string fullName = firstName + " " + lastName;

            MessageBox.Show(fullName);//Display

        }//btnDisplayFullName_Click

        private void btnAddNames_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtfName.Text; 

            string lastName = txtlName.Text; 

            fName.Add(firstName); 
            lName.Add(lastName); 

            cmbFirstName.Items.Refresh();
            lblLastNames.Items.Refresh();

        }//btnAddNames_Click

        private void btnRemoveStudentAtIndex_Click(object sender, RoutedEventArgs e)
        {
            int firstNameIndex = cmbFirstName.SelectedIndex;

            int lastNameIndex = lblLastNames.SelectedIndex;

            fName.RemoveAt(firstNameIndex); 
            lName.RemoveAt(lastNameIndex); 

            cmbFirstName.Items.Refresh();
            lblLastNames.Items.Refresh();

        }//btnRemoveStudentAtIndex_Click
    }//MainWindow : Window
}//namespace
