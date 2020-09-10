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

namespace Participation_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnGo_MouseEnter(object sender, MouseEventArgs e)
        {
           
            
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string name;
            name = txtName.Text;
            DatePicker date;

            string age;
            age = txtAge.Text;

            /*int age;
            age = date / 365;
            could not figure out the conversion from date picker to days
            lecutre not found on Teams - wasn't in the usual place
            insert age after "is" */
            MessageBox.Show($"Welcome {name} who is {age} ");

        }
    }
}
