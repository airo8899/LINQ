using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Sex { get; set; }
            public int Balance { get; set; }
        }

        static void Main(string[] args)
        {
            List<User> people = new List<User>
            {
                new User {Name = "Ivan", Age = 31, Sex = "Male", Balance = 400},
                new User {Name = "Jenya", Age = 24, Sex = "Male", Balance = 21000},
                new User {Name = "Dasha", Age = 22, Sex = "Female", Balance = 570},
                new User {Name = "Lesha", Age = 25, Sex = "Male", Balance = 14758},
                new User {Name = "Sonya", Age = 27, Sex = "Female", Balance = 4792}
            };

            var old = people.Where(x => x.Age == people.Max(p => p.Age));
            foreach(User user in old)
            {
                Console.WriteLine("Самый старший - {0}", user.Name);
            }

            Console.WriteLine();

            var rich = people.OrderByDescending(x => x.Balance).First();
            Console.WriteLine("Самый богатый - {0}", rich.Name);

            Console.WriteLine();

            var oldAndRich = people.OrderBy(x => x.Age).ThenByDescending(x => x.Balance).Last();
            Console.WriteLine("Самый старший и богатый - {0}", oldAndRich.Name);

            Console.WriteLine();

            var richUsers = people.Where(x => x.Balance > 4000).Count();
            Console.WriteLine("Количество людей с более 4000 на балансе - {0}", richUsers);

            Console.WriteLine();

            Console.WriteLine("Сортировка по возросту");
            var sortedByAge = people.OrderBy(x => x.Age);
            foreach (User user in sortedByAge)
            {
                Console.WriteLine("{0} - {1}", user.Name, user.Age);
            }

            Console.WriteLine();

            Console.WriteLine("Сортировка по полу");
            var sortedBySex = people.OrderBy(x => x.Sex);
            foreach (User user in sortedBySex)
            {
                Console.WriteLine("{0} - {1}", user.Name, user.Sex);
            }

            Console.WriteLine();

            Console.WriteLine("Сортировка по балансу");
            var sortedByBalance = people.OrderBy(x => x.Balance);
            foreach (User user in sortedByBalance)
            {
                Console.WriteLine("{0} - {1}", user.Name, user.Balance);
            }

            Console.ReadKey();
        }
    }
}
