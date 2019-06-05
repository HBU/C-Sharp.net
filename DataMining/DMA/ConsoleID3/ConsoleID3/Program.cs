using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleID3
{
    class Program
    {
        static void Main(string[] args)
        {
            var da = new string[,]
            {
                {"youth","high","no","fair","no"},
                {"youth","high","no","excellent","no"},
                {"middle_aged","high","no","fair","yes"},
                {"senior","medium","no","fair","yes"},
                {"senior","low","yes","fair","yes"},
                {"senior","low","yes","excellent","no"},
                {"middle_aged","low","yes","excellent","yes"},
                {"youth","medium","no","fair","no"},
                {"youth","low","yes","fair","yes"},
                {"senior","medium","yes","fair","yes"},
                {"youth","medium","yes","excellent","yes"},
                {"middle_aged","medium","no","excellent","yes"},
                {"middle_aged","high","yes","fair","yes"},
                {"senior","medium","no","excellent","no"}
            };
            var names = new string[] { "age", "income", "student", "credit_rating", "Class: buys_computer" };
            var tree = new DecisionTreeID3<string>(da, names, new string[] { "yes", "no" });
            tree.Learn();
            Console.ReadKey();
        }
    }
}
