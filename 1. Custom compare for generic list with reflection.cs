using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCSharp
{
    class Item : IEquatable<Item>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(Item other)
        {
            return other != null && (Id == other.Id && Name == other.Name);
        }
    }
    class Program
    {
        public void merge<T>(List<T> list1, List<T> list2)
        {
            foreach (var i in list2)
            {
                if(!list1.Contains(i))
                    list1.Add(i);
            }

            foreach (var i in list1)
            {
                foreach (var j in i.GetType().GetProperties())
                {
                    Console.Write("{0} - {1}, ", j.Name, j.GetValue(i));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            List<Item> list1 = new List<Item>
            {
                new Item { Id = 1, Name = "abc"},
                new Item { Id = 2, Name = "def"},
                new Item { Id = 3, Name = "ghi"},
                new Item { Id = 4, Name = "jkl"}
            };

            List<Item> list2 = new List<Item>
            {
                new Item { Id = 1, Name = "abc"},
                new Item { Id = 2, Name = "def"}
            };

            Program p = new Program();
            p.merge(list1,list2);
        }
    }
}
