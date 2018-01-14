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
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = this.DataContext as ApplicationViewModel;
        }
        private void Button_Click_Article(object sender, RoutedEventArgs e)
        {
            AddArticleDialogWindow myDialog = new AddArticleDialogWindow();
            CommentButton.IsEnabled = false;
            myDialog.mainWindowArticleButton = CommentButton;
            myDialog.ShowDialog();
        }

        private void Button_Click_Comment(object sender, RoutedEventArgs e)
        {
            AddCommentDialogWindow myDialog = new AddCommentDialogWindow();
            ArticleButton.IsEnabled = false;
            myDialog.vm.AddCommentFor = this.vm.AddCommentFor;
            myDialog.mainWindowCommentButton = ArticleButton;
            myDialog.ShowDialog();
        }
    }
}
