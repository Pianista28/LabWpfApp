using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class ApplicationViewModel : BindableBase
    {
        public ApplicationViewModel()
        {
            Load();
            AddArticleCommand = new DelegateCommand(AddArticleCommandExecute, AddArticleCommandCanExecute);
            AddCommentCommand = new DelegateCommand(AddCommendCommandExecute, AddCommentCommandCanExecute);
        }

        public DelegateCommand AddArticleCommand { get; set; }

        private void AddArticleCommandExecute()
        {
            using (var netContext = new NetContext())
            {
                Repository repository = new Repository(netContext);
                repository.InsertArticle(new Article() { Title = NewArticleTitle, Content = NewArticleText });
            }
            Load();
            MessageBox.Show("Hello");
        }

        private bool AddArticleCommandCanExecute()
        {
            return true;//!String.IsNullOrWhiteSpace(NewArticleText) && !String.IsNullOrWhiteSpace(NewArticleTitle);
        }


        public DelegateCommand AddCommentCommand { get; set; }

        private void AddCommendCommandExecute()
        {
            using (var netContext = new NetContext())
            {
                Repository repository = new Repository(netContext);
                repository.InsertComment(new Comment() { Content = NewCommentText, IdArticle = AddCommentFor.Id});
            }
            Load();
            MessageBox.Show("Hello");
        }

        private bool AddCommentCommandCanExecute()
        {
            return true;//!String.IsNullOrWhiteSpace(NewArticleText) && !String.IsNullOrWhiteSpace(NewArticleTitle);
        }

        private ICollection<Comment> comments;
        public ICollection<Comment> Comments
        {

            get { return comments; }
            set
            {
                comments = value;
                RaisePropertyChanged();
            }
        }

        private ICollection<Article> articles;
        public ICollection<Article> Articles
        {

            get { return articles; }
            set
            {
                articles = value;
                RaisePropertyChanged();
            }
        }

        private bool button_Enabled_Comment;
        public bool Button_Enabled_Comment
        {
            get { return button_Enabled_Comment; }
            set { button_Enabled_Comment = value; }
        }

        private string newCommentText;
        public string NewCommentText
        {
            get { return newCommentText; }
            set { SetProperty(ref newCommentText, value); }
        }

        private string newArticleText;
        public string NewArticleText
        {
            get { return newArticleText; }
            set { SetProperty(ref newArticleText, value); }
        }

        private string newArticleTitle;
        public string NewArticleTitle
        {
            get { return newArticleTitle; }
            set { SetProperty(ref newArticleTitle, value); }
        }

        public Article AddCommentFor { get; set; }

        private Article selectedArticle;
        public Article SelectedArticle
        {
            get { return selectedArticle; }
            set
            {
                SetProperty(ref selectedArticle, value);
                AddCommentFor = selectedArticle;
                using (var netContext = new NetContext())
                {
                    Repository repository = new Repository(netContext);
                    Comments = repository.GetCommentsForArticle(SelectedArticle);
                }
            }
        }

        public void Load()
        {
            using (var netContext = new NetContext())
            {
                Repository repository = new Repository(netContext);
                Articles = repository.GetAllArticles();
            }
        }

    }

}
