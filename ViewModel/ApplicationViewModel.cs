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
            AddArticleCommand = new DelegateCommand<Window>(AddArticleCommandExecute, AddArticleCommandCanExecute);
            AddCommentCommand = new DelegateCommand<Window>(AddCommendCommandExecute, AddCommentCommandCanExecute);
        }

        public DelegateCommand<Window> AddArticleCommand { get; set; }

        private void AddArticleCommandExecute(Window window)
        {
            using (var netContext = new NetContext())
            {
                Repository repository = new Repository(netContext);
                repository.InsertArticle(new Article() { Title = NewArticleTitle, Content = NewArticleText });
            }
            window.Close();
            Load();
        }

        private bool AddArticleCommandCanExecute(Window window)
        {
            if(!String.IsNullOrWhiteSpace(NewArticleText) && !String.IsNullOrWhiteSpace(NewArticleTitle))
                return NewArticleTitle.Length >= 3;
            return false;
        }


        public DelegateCommand<Window> AddCommentCommand { get; set; }

        private void AddCommendCommandExecute(Window window)
        {
            using (var netContext = new NetContext())
            {
                Repository repository = new Repository(netContext);
                repository.InsertComment(new Comment() { Content = NewCommentText, IdArticle = SelectedArticle.Id});
            }
            window.Close();
            Load();
        }

        private bool AddCommentCommandCanExecute(Window window)
        {
            return !String.IsNullOrWhiteSpace(NewCommentText);
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
            set
            {
                SetProperty(ref newCommentText, value);
                AddCommentCommand.RaiseCanExecuteChanged();
            }
        }

        private string newArticleText;
        public string NewArticleText
        {
            get { return newArticleText; }
            set
            {
                SetProperty(ref newArticleText, value);
                AddArticleCommand.RaiseCanExecuteChanged();
            }
        }

        private string newArticleTitle;
        public string NewArticleTitle
        {
            get { return newArticleTitle; }
            set
            {
                SetProperty(ref newArticleTitle, value);
                AddArticleCommand.RaiseCanExecuteChanged();
            }
        }

        public Article AddCommentFor { get; set; }

        private Article selectedArticle;
        public Article SelectedArticle
        {
            get { return selectedArticle; }
            set
            {
                SetProperty(ref selectedArticle, value);
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
                int selectedId = -1;
                if (selectedArticle != null)
                    selectedId = SelectedArticle.Id;
                Articles = repository.GetAllArticles();
                SelectedArticle = Articles.FirstOrDefault(x => x.Id == selectedId);
                if (selectedArticle != null)
                    Comments = repository.GetCommentsForArticle(selectedArticle);
            }
        }

    }

}
