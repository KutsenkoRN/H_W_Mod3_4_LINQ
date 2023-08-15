using System.Linq;
namespace H_W_Mod3_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<User> phoneBook = new List<User>()
            {
                new User() { Name = "Sergey", PhoneNumber = "+38(050)8459391" },
                new User() { Name = "Anatoly", PhoneNumber = "+38(098)5578256" },
                new User() { Name = "Ivan", PhoneNumber = "+38(063)4090690" },
                new User() { Name = "Antonina", PhoneNumber = "+38(066)7872267" },
                new User() { Name = "Natali", PhoneNumber = "+38(098)4361152" },
                new User() { Name = "Alex", PhoneNumber = "+4(207)4211370" }

            };

            foreach (User user in phoneBook)
            {
                Console.WriteLine(user.ToString());
            }

            var someUser = phoneBook.FirstOrDefault(x => x.PhoneNumber.Contains("+4"));
            if (someUser != null)
            {
                Console.WriteLine($"Guy from the Czech Republic: {someUser}");
                phoneBook.Remove(someUser);
            }

            var j = phoneBook.OrderBy(x => x.Name).Where(x => x.Name.Contains("A")).ToList();
            if (j != null)
            {
                Console.WriteLine(Environment.NewLine + "Users you found: ");
                foreach (User user in j)
                {
                    Console.WriteLine(user.ToString());
                }
            }

            var value = phoneBook.Select((User x) => x.PhoneNumber.Contains("(098)")).ToList();
            for (int i = 0; i < value.Count; i++)
            {
                if (value[i])
                {
                    Console.WriteLine("This is Kyivstar: " + phoneBook[i].ToString());
                }
            }
        }
    }
}