using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var parties = new List<Party>();
            parties.Add(new Company { Id = 1, Name = "Delfi", RegNo = "12313" });
            parties.Add(new Person { Id = 2, Firstname = "Siim", Lastname = "Tiilen", RegNo = "32978129821879132789387912789132" });
            parties.Add(new Person { Id = 3, Firstname = "Siim", Lastname = "Tiilen", RegNo = "32978129821879132789387912789131" });



            foreach (var party in parties)
            {
                Console.WriteLine(party.DisplayName + " (" + party.RegNo + ")");
            }

            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        public abstract class Party
        {
            public int Id { get; set; }
            public string RegNo { get; set; }
            public abstract string DisplayName { get;}
        }

        public class Person : Party
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }

            public override string DisplayName { get { return Lastname + " , " + Firstname; } }


        }

        public class Company : Party
        {
            public string Name { get; set; }

            public override string DisplayName { get { return Name; } }
        }

    }
}
