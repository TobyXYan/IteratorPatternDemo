using System;

namespace IteratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Preparation
            var forest = new Forest();
            forest.Add(new Tree() { Name = "Apple Tree"});
            forest.Add(new Tree() { Name = "Banana Tree" });
            forest.Add(new Tree() { Name = "Orange Tree" });
            #endregion

            var iterator = forest.GetIterator();
            while(iterator.HasNext())
            {
                Console.WriteLine(iterator.Current().Name);
                iterator.Next();
            }

            Console.ReadLine();
        }
    }
}
