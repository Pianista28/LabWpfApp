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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddArticleDialogWindow.xaml
    /// </summary>
    public partial class AddArticleDialogWindow : Window
    {
        public Button mainWindowArticleButton;
        public AddArticleDialogWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Anuluj(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            mainWindowArticleButton.IsEnabled = true;

            base.OnClosing(e);
        }
    }
}
