using System;
using System.Threading;



namespace exercise_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post();
            Console.WriteLine("Enter title of the post");
            post.title = Console.ReadLine();
            //Console.WriteLine(post.title);
            Console.WriteLine("Enter Description of the post");
            post.description = Console.ReadLine();
            int choice;
            do
            {
                Console.WriteLine("Enter Vote choice 1 for UpVote, 0 for DownVote:") ;
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    var votecount = post.UpVote();
                    Console.WriteLine("Your Upvote is:{0}", votecount);
                }

                if (choice == 0)
                {
                    var downvotecount = post.DownVote();
                    Console.WriteLine("Your Downvote is:{0}", downvotecount);
                }
            } while (choice != 2);
            post.TotalVote();
        }
    }
    public class Post
    {
        public string title;
        public string description;
        public DateTime createdDate;
        private int upVote = 0;
        private int downVote = 0;

        public int UpVote()
        {
            upVote++;
            return upVote;
        }
        public int DownVote()
        {
            downVote++;
            return downVote;
        }
        public void TotalVote()
        {
            Console.WriteLine("Total Up Votes are :{0} \nTotal Down Votes are :{1}", upVote , downVote);
        }
    }
}

