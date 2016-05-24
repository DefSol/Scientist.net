using GitHub;
using POC.Contracts;
using System;

namespace POC
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserClass
            //UserService
            //ProcessUser
            //InitialiseUser
            IUserService userService = new UserService();

            Console.WriteLine("What is your userID");
            Console.ReadLine();

            User user = ProcessUserExperiment(6);

            Console.WriteLine(string.Format(@"Welcome user {0}", user.UserName));

            if (user.IsValid)
                Console.WriteLine(string.Format(@"User {0} {1} is valid", user.FirstName, user.LastName));

            if (user.IsSecure)
                Console.WriteLine(string.Format(@"User {0} {1} is on a secure connection", user.FirstName, user.LastName));            


            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }


        private static User ProcessUserExperiment(int userID)
        {
            var userService = new UserService();

            var user = Scientist.Science<User>("ProcessUserExperiment", experiment =>
            {
                experiment.Use(() => userService.ProcessUser(userID));
                experiment.Try(() => userService.InitialiseUser(userID));
            });

            return user;
        }
    }
}

