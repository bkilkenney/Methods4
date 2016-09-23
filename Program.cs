using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUsersFavoriteNumber();//Always need to call the method in main if you want something to happen, otherwise nothing happens!!!!!!!!!
        }
        static int GetUsersFavoriteNumber()  //This will be red squiggled until there is a return
        {
            int usersFavNum = 0; 

            while (usersFavNum < 1 || usersFavNum > 10)
            {
                Console.WriteLine("Enter your favorite number between 1 and 10.");
                int usersAnswer = int.Parse(Console.ReadLine());
            }
            return usersFavNum;
        }
    }
}
