/*using System;
using System.Collections.Generic;

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
            public double rating;
            public Tuple<string> significant;

            public dataBase(string t, playAge a, int s, double r, Tuple<string> sig)
            {
                title = t;
                age = a;
                sell = s;
                rating = r;
                significant = sig;
            }
        }

        private static void Main(string[] args)
        {
            List<dataBase> games = new List<dataBase>();

            dataBase game1 = new dataBase("게임1", playAge.All, 10000, 5.3, Tuple.Create("DLC 곧 나옴"));
            dataBase game2 = new dataBase("게임2", playAge.Teen, 20000, 8.1, Tuple.Create("최적화 불량"));
            dataBase game3 = new dataBase("게임3", playAge.All, 30000, 9.5, Tuple.Create("엔딩"));
            dataBase game4 = new dataBase("게임4", playAge.Adult, 40000, 9.1, Tuple.Create("완벽한 스토리"));
            games.Add(game1);
            games.Add(game2);
            games.Add(game3);
            games.Add(game4);
            for (int i = 0; i < games.Count; i++)
            {
                gameList(games[i]);
            }

            while (true)
            {
                Console.Write("[ 1 : 평점 9.0 이상 게임 | 2 : Adult 등급 게임 ] : ");
                string input = Console.ReadLine() ?? "";
                if (int.TryParse(input, out int answer))
                {
                    if (answer == 1)
                    {
                        Console.WriteLine("평점 9.0 이상 게임 리스트를 출력합니다.");
                        for (int i = 0; i < games.Count; i++)
                        {
                            if (games[i].rating >= 9.0)
                            {
                                gameList(games[i]);
                            }

                        }
                    }
                    else if (answer == 2)
                    {
                        Console.WriteLine("Adult 등급의 게임 리스트를 출력합니다.");
                        for (int i = 0; i < games.Count; i++)
                        {
                            if (games[i].age == playAge.Adult)
                            {
                                gameList(games[i]);
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("게임 리스트 출력을 종료합니다.");
                        return;
                    }
                }

            }
        }

        private static void gameList(dataBase game)
        {
            Console.WriteLine($"========== {game.title} ==========");
            Console.WriteLine($"연령 제한 : {game.age}");
            Console.WriteLine($"게임 가격 : {game.sell}");
            Console.WriteLine($"게임 평점 : {game.rating}");
            Console.WriteLine($"게임 특이사항 : {game.significant}");
            Console.WriteLine($"========== {game.title} ==========");
            Console.WriteLine();
        }
    }
}
*/