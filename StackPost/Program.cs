using System;

namespace StackPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();

            var upVote = post.UpVote();
            upVote = post.UpVote();

            var downVote = post.DownVote();

            Console.WriteLine("Total Up Votes: " + upVote);
            Console.WriteLine("Total Down Votes: " + downVote);
            Console.ReadLine();
        }
    }
}
