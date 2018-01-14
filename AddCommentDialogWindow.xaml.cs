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
    /// Interaction logic for AddCommentDialogWindow.xaml
    /// </summary>
    public partial class AddCommentDialogWindow : Window
    {
        public Button mainWindowCommentButton;
        public ApplicationViewModel vm;
        public ApplicationViewModel mainVM;
        public AddCommentDialogWindow()
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
            mainWindowCommentButton.IsEnabled = true;
            mainVM.SelectedArticle = vm.SelectedArticle;
            mainVM.Load();
            base.OnClosing(e);
        }
    }
}
