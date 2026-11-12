using System;

namespace SocialFeed
{
    public abstract class Post
    {
        private string _autor;
        private int _likes;
        private int _reports;
        private List<Comment> _comments;

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public List<Comment> comments { get { return _comments; } set { _comments = value; } }
        public int Likes
        {
            get { return _likes; }
        }

        public Post(string autor)
        {
            Autor = autor;
            _likes = 0;
            _comments = new List<Comment>();
        }

        public virtual bool Like()
        {
            _likes++;
            return true;
        }

        public virtual string GetDescription()
        {
            return $"{Autor}, {Likes} kedveles";
        }

        public abstract int Score();
        public Comment AddComment(string author,string text)
        {
            Comment comment = new Comment(author, text, this);
            _comments.Add(comment);
            return comment;
        }
    }
}

