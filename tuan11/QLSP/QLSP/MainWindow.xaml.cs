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
using QLSP.models;


namespace QLSP
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
        QLSANPHAMContext db = new QLSANPHAMContext();
        private void show_Click(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.Sps

                        select sp;
                    
            dssp.ItemsSource = query.ToList();
        }
    }
}
