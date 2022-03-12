using System;

namespace OOP2V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("Securing class from outside impact",
                "You should not give the ability to set the Vote property from the outside, because otherwise",
                "5.3.2022.");
            Console.WriteLine(post.ToString());
            for (int i = 0; i < 10; i++) {
                post.UpVote();
            }
            for (int i = 0; i < 5; i++){
                post.DownVote();
            }
            Console.WriteLine(post.ToString());
            Console.ReadLine();
        }
    }
}
