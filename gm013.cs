/*using System;

namespace Project4
{
    internal class Program
    {
        private static int playerHP = 100;
        private static int playerAtk = 10;
        private static int gold = 0;
        private static int trainingCount = 0;
        private static bool isBossDefeated = false;
        private static int explorationProgress = 0;

        private static readonly Random random = new Random();

        private static void Main(string[] args)
        {
            Console.WriteLine("=== 반복문 RPG ===");
            Console.WriteLine("[Space] 아침 훈련  [H] 황야 탐험  [B] 보스전  [R] 상태 확인  [Q] 종료");

            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("\n행동을 선택하세요: ");
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.Spacebar:
                        MorningTraining();
                        break;
                    case ConsoleKey.H:
                        ExploreWilderness();
                        break;
                    case ConsoleKey.B:
                        FightBoss();
                        break;
                    case ConsoleKey.R:
                        ShowStatus();
                        break;
                    case ConsoleKey.Q:
                        isRunning = false;
                        Console.WriteLine("게임을 종료합니다.");
                        break;
                    default:
                        Console.WriteLine("Space, H, B, R, Q 중 하나를 눌러 주세요.");
                        break;
                }
            }
        }

        private static void MorningTraining()
        {
            if (trainingCount >= 3)
            {
                Console.WriteLine("오늘은 더 이상 훈련할 수 없습니다. (하루 최대 3회)");
                return;
            }

            trainingCount++;
            Console.WriteLine("아침 훈련을 시작합니다. ({0}/3회)", trainingCount);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("칼을 휘두릅니다! ({0}회)", i);
            }

            playerAtk += 5;
            Console.WriteLine("훈련 완료! 현재 공격력: {0}", playerAtk);
        }

        private static void ExploreWilderness()
        {
            explorationProgress = 0;
            Console.WriteLine("황야 탐험을 시작합니다.");

            while (explorationProgress < 100)
            {
                explorationProgress += 20;
                Console.WriteLine("탐험 진행도: {0}%", explorationProgress);

                if (random.Next(100) < 20)
                {
                    playerHP -= 10;
                    Console.WriteLine("함정에 걸렸습니다! HP가 10 감소합니다. 현재 HP: {0}", playerHP);
                }

                if (playerHP <= 0)
                {
                    Console.WriteLine("탐험 실패!");
                    break;
                }
            }

            if (explorationProgress >= 100 && playerHP > 0)
            {
                gold += 50;
                Console.WriteLine("탐험 성공! 골드 50을 획득했습니다. 현재 골드: {0}", gold);
            }
        }

        private static void FightBoss()
        {
            if (isBossDefeated)
            {
                Console.WriteLine("보스는 이미 처치했습니다.");
                return;
            }

            int bossHP = 100;
            bool isFirstAttack = true;
            Console.WriteLine("보스 최후의 결전을 시작합니다!");

            do
            {


                if (isFirstAttack && bossHP <= 0)
                {
                    bossHP = 1;
                }



                if (isFirstAttack)
                {
                    Console.WriteLine("보스의 방어막이 첫 타격을 버텨냈습니다!");
                    isFirstAttack = false;
                }
                else
                {
                    bossHP -= playerAtk;
                    Console.WriteLine("보스에게 {0}의 데미지! 보스 HP: {1}", playerAtk, bossHP);

                }

                Console.WriteLine("보스가 반격합니다!");
                playerHP -= 20;
                Console.WriteLine("플레이어가 20의 데미지를 받았습니다. 현재 HP: {0}", playerHP);
            }
            while (bossHP > 0 && playerHP > 0);

            if (bossHP <= 0)
            {
                isBossDefeated = true;
                Console.WriteLine("보스를 처치했습니다!");
            }
            else
            {
                Console.WriteLine("보스전에서 패배했습니다!");
            }
        }

        private static void ShowStatus()
        {
            Console.WriteLine("현재 상태 - HP: {0}, 공격력: {1}, 골드: {2}", playerHP, playerAtk, gold);

            if (playerHP <= 20)
            {
                Console.WriteLine("휴식이 절실합니다...");
            }
        }
    }
}
*/