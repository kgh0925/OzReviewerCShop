/*using System;

namespace Project4
{
    internal class Program
    {
        public enum playAge
        {
            All,
            Teen,
            Adult
        }

        public struct dataBase
        {
            public string title;
            public playAge age;
            public int sell;
            public float rating;
            public Tuple<string, string, string> significant;
        }

        private static void Main(string[] args)
        {
            dataBase game = new dataBase
            {
                title = "게임 제목",
                age = playAge.Teen,
                sell = 1000,
                rating = 4.5f,
                significant = Tuple.Create(
                    "DLC 곧 나온다.",
                    "최적화 좋지 않다.",
                    "버그 매우 많음")
            };

            Console.WriteLine("특이사항");
            Console.WriteLine("1. " + game.significant.Item1);
            Console.WriteLine("2. " + game.significant.Item2);
            Console.WriteLine("3. " + game.significant.Item3);
        }
    }
}
*/
