using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       private string filepath;
        public MainWindow()
        {
            InitializeComponent();


            lstLines.Items.Clear();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, RoutedEventArgs e)
        {
           filepath = txtFilePath.Text;

            if (File.Exists(filepath) ==true)
            {
                btnProcess.IsEnabled = true;

            }
            else
            {
                MessageBox.Show("Invalid file. Please try again", "Error", MessageBoxButton.OK);
                txtFilePath.Focus();
            }

        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            var lines = File.ReadAllLines(filepath);

            /*foreach (var line in lines)
            {
                lstLines.Items.Add(line);
            }*/
            double sum = 0;
            for (int i = 1; i < lines.Length; i++)
            {
                var pieces = lines[i].Split(',');
                double val = 0;
                bool success = double.TryParse(pieces[2], out val);
                if (success == false)
                {
                    MessageBox.Show("Error on line " + i);
                }
                else
                {
                    sum += val;
                }

                //sum += Convert.ToDouble(pieces[2]);
                lstLines.Items.Add(pieces[1]);
            }
            MessageBox.Show($"The total sum of price is {sum.ToString("C2")}!");
        }

        private void lstLines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
