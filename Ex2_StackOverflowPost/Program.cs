using System;

namespace Ex2_StackOverflowPost
{

    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("Concerning Bob","Bob Canny Code for shizzle");

            for (int i = 0; i <= 9; i++)
                post.Upvote();

            for (int i = 0; i <= 4; i++)
                post.Downvote();

            Console.WriteLine(post.SeeVoteValue());            

            Console.ReadLine();
        }
    }
}
