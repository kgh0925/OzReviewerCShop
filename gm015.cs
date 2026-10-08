/*using System;

namespace Project4
{
    internal class Program
    {
        public int[] monsterDeck = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        private readonly Random random = new Random();

        private static void Main(string[] args)
        {
            Program deckManager = new Program();
            deckManager.Run();
        }

        private void Run()
        {
            Console.WriteLine("=== 몬스터 카드 덱 매니저 ===");
            Console.WriteLine("[W] 첫 카드와 마지막 카드 교체");
            Console.WriteLine("[S] 전체 덱 섞기");
            Console.WriteLine("[Space] 카드 뽑기 및 보스와 대결");
            Console.WriteLine("[Q] 종료");

            ShowDeck();

            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("\n키를 입력하세요: ");
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.W:
                        SwapFirstAndLast();
                        break;

                    case ConsoleKey.S:
                        Shuffle();
                        Console.WriteLine("덱을 섞었습니다!");
                        ShowDeck();
                        break;

                    case ConsoleKey.Spacebar:
                        PlayGame();
                        break;

                    case ConsoleKey.Q:
                        isRunning = false;
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;

                    default:
                        Console.WriteLine("W, S, Space, Q 중 하나를 눌러 주세요.");
                        break;
                }
            }
        }

        private void SwapFirstAndLast()
        {
            int lastIndex = monsterDeck.Length - 1;
            int temp = monsterDeck[0];

            monsterDeck[0] = monsterDeck[lastIndex];
            monsterDeck[lastIndex] = temp;

            Console.WriteLine("첫 번째 카드와 마지막 카드를 교체했습니다!");
            ShowDeck();
        }

        private void Shuffle()
        {
            for (int i = 0; i < monsterDeck.Length; i++)
            {
                int randomIndex = random.Next(0, monsterDeck.Length);
                int temp = monsterDeck[i];

                monsterDeck[i] = monsterDeck[randomIndex];
                monsterDeck[randomIndex] = temp;
            }
        }

        private void PlayGame()
        {
            int bossPower = random.Next(1, 11);
            int myCardPower = monsterDeck[0];

            Console.WriteLine("내 카드 공격력: {0}", myCardPower);
            Console.WriteLine("보스 공격력: {0}", bossPower);

            if (myCardPower > bossPower)
            {
                Console.WriteLine("승리했습니다!");
            }
            else if (myCardPower < bossPower)
            {
                Console.WriteLine("패배했습니다!");
            }
            else
            {
                Console.WriteLine("무승부입니다!");
            }

            Shuffle();
            Console.WriteLine("다음 대결을 위해 덱을 다시 섞었습니다.");
            ShowDeck();
        }

        private void ShowDeck()
        {
            Console.Write("현재 덱: ");

            for (int i = 0; i < monsterDeck.Length; i++)
            {
                Console.Write(monsterDeck[i]);

                if (i < monsterDeck.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}
*/