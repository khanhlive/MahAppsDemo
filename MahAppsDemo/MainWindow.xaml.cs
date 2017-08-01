using MahApps.Metro.Controls;
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
using MahApps.Metro.Controls.Dialogs;

namespace MahAppsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            var db = new Models.ISOEntities();
            this.Admins = db.ChiPhis.ToList();
            InitializeComponent();
            
        }

        public List<Models.ChiPhi> Admins
        {
            get;set;
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
            LoginDialogData result = await this.ShowLoginAsync("Thông báo", "This is message");
            
        }
    }
}
