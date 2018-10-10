using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************");
            QueryOverStrigs();
            Console.ReadLine();
        }


        static void QueryOverStrigs()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter","System Shock 2" };
            IEnumerable<string> subset = from g in currentVideoGames where g.Contains(" ") orderby g select g;//从currentVideoGames字符串集合中，选出包含空格的字符串放到g集合。最后将g集合升序排序。

            foreach (string s in subset)
            {
                Console.WriteLine(s);
            }

            ReflectQueryOverResults(subset);
        }

        static void ReflectQueryOverResults(object resultSet)
        {
            Console.WriteLine(resultSet.GetType().Name);
            Console.WriteLine(resultSet.GetType().Assembly.GetName().Name);
        }
    }
}
