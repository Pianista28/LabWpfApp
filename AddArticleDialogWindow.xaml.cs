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
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AddArticleDialogWindow.xaml
    /// </summary>
    public partial class AddArticleDialogWindow : Window
    {
        public Button mainWindowArticleButton;
        public ApplicationViewModel mainVM;
        public ApplicationViewModel vm;

        public AddArticleDialogWindow()
        {
            InitializeComponent();
            vm = this.DataContext as ApplicationViewModel;
        }

        private void Button_Click_Anuluj(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            mainWindowArticleButton.IsEnabled = true;
            mainVM.SelectedArticle = vm.SelectedArticle;
            mainVM.Load();
            base.OnClosing(e);
        }
    }
}
