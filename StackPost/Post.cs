using System;
using System.Collections.Generic;
using System.Text;

namespace StackPost
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        private int _upVote;
        private int _downVote;

        public int UpVote()
        {
            _upVote++;

            return _upVote;
        }

        public int DownVote()
        {
            _downVote++;

            return _downVote;
        }

    }
}
