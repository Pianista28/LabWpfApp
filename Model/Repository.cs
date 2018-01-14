using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Repository : IRepository
    {
        NetContext context;

        public Repository(NetContext context)
        {
            this.context = context;
        }

        public ICollection<Article> GetAllArticles()
        {
            return context.Articles.ToList();
        }

        public ICollection<Comment> GetAllComments()
        {
            return context.Comments.ToList();
        }

        public Article GetArticleById(int Id)
        {
            return context.Articles.Find(Id);
        }

        public Comment GetCommentById(int Id)
        {
            return context.Comments.Find(Id);
        }

        public ICollection<Comment> GetCommentsForArticle(Article article)
        {
            return article == null ? new List<Comment>() :  context.Comments.Where(comment => comment.IdArticle == article.Id).ToList();
        }

        public void InsertArticle(Article article)
        {
            context.Articles.Add(article);
            Save();
        }

        public void InsertComment(Comment comment)
        {
            context.Comments.Add(comment);
            Save();
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
