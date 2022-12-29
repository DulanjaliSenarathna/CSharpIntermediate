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

namespace WpfApp1Downcasting
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if we type sender. , we can't see any members define in the button class. 
            var btn = sender as Button;//now we can see all members in Button class 

            if(btn != null)
            {
                MessageBox.Show(btn.ActualHeight.ToString()); ;
            }
           
            MessageBox.Show("Hello");
        }
    }
}
