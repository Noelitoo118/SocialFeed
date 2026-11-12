using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public class Comment : IReportable
    {
        private string _author;
        private string _text;
        private Post _parentPost;
        private int _reports;
        private List<Comment> _comments;
        public string Author { get { return _author;} set { value = _author; } }

        public string Text { get { return _text; } set { _text = value; } }

        public Post ParentPost { get { return _parentPost; } }

        public Comment(string author, string text, Post parentPost)
        {
            _author = author;
            _text = text;
            _parentPost = parentPost;
        }
        public void Report()
        {
            _reports++;
        }
        public int ReportCount()
        {
            return _reports;
        }
        public string GetDescription()
        {
            return $"{_author} hozzászólása" + $"{_parentPost.Autor} bejegyzés:{_text}";
        }
    }
}
