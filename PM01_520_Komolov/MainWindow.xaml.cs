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

namespace PM01_520_Komolov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {

            using (PM01_520_KomolovEntities1 entities2 = PM01_520_KomolovEntities1.GetEntities1())
            {
                var events = entities2.Event.ToList();


                foreach (var ev in events)
                {
                    DataGridOsn.Items.Add(ev);
                }
            }


        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
