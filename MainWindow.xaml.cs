/*
 Aiden Jolley Ruhn
 U2AidenJTXTMSG
 March 27, 2018
 User inputs a acronym and the program outputs the meaning
 
 */
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

namespace U2AidenJTXTMSG
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

        private void sndtxt_Click(object sender, RoutedEventArgs e)
        {
            string input = txt.Text.Substring(0, txt.Text.IndexOf("TTYL"));
            //MessageBox.Show(txt.Text.Substring(1,5));

            input = input.Replace("CU", "see you");
            input = input.Replace(":-)", "I'm Happy");
            input = input.Replace(":-(", "I'm Unhappy");
            input = input.Replace(";-)", "Wink");
            input = input.Replace(":-P", "Stick out my tongue");
            input = input.Replace("(˜.˜)", "Sleepy");
            input = input.Replace("TA", "Totally Awesome");
            input = input.Replace("CCC", "Canadian Computing Competition");
            input = input.Replace("TY", "Thank-You");
            input = input.Replace("YW", "You're Welcome");
            content.Content = (input);
            //txt.Text(out )

            
            




        }
    }
}
