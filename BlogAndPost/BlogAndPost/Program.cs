using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAndPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Create Blog\n2.CreatePost\n3.List All blogs\n4.List specific blog\n0.End\nPlease enter your choice:");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        CreateBlog();
                        break;
                    case 2:
                        CreatePost();
                        break;
                    case 3:
                        ListAllBlogs();
                        break;
                    case 4:
                        ListSpecificBlog();
                        break;
                }
                Console.WriteLine(
                    "1.Create Blog\n2.CreatePost\n3.List All blogs\n4.List specific Blog\n0.End\nPlease enter your choice:");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void ListSpecificBlog()
        {
            throw new NotImplementedException();
        }

        private static void ListAllBlogs()
        {
            throw new NotImplementedException();
        }

        private static void CreatePost()
        {
            throw new NotImplementedException();
        }

        private static void CreateBlog()
        {
            throw new NotImplementedException();
        }
    }
}
