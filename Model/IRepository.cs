using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public interface IRepository
    {
        void InsertComment(Comment comment);
        void InsertArticle(Article article);
        ICollection<Comment> GetAllComments();
        ICollection<Article> GetAllArticles();
        Comment GetCommentById(int Id);
        Article GetArticleById(int Id);
        ICollection<Comment> GetCommentsForArticle(Article article);
        void Save();
    }
    
}
