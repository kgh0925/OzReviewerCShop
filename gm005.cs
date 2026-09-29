/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //Test_One();
            Test_Two();

        }

        private static void Test_One()
        {
            int count = 0;
            while (count < 3)
            {
                Console.Write("알고 싶은 달을 입력하세요 : ");
                int value = int.Parse(Console.ReadLine());
                if (value < 1 || value > 12)
                {
                    Console.WriteLine("1월부터 12월까지만 입력해주세요.");
                    continue;
                }
                count++;
                switch (value)
                {
                    case 1:
                        Console.WriteLine("1월은 31일까지입니다.");
                        break;
                    case 2:
                        Console.WriteLine("2월은 28일까지입니다.");
                        break;
                    case 3:
                        Console.WriteLine("3월은 31일까지입니다.");
                        break;
                    case 4:
                        Console.WriteLine("4월은 30일까지입니다.");
                        break;
                    case 5:
                        Console.WriteLine("5월은 31일까지입니다.");
                        break;
                    case 6:
                        Console.WriteLine("6월은 30일까지입니다.");
                        break;
                    case 7:
                        Console.WriteLine("7월은 31일까지입니다.");
                        break;
                    case 8:
                        Console.WriteLine("8월은 31일까지입니다.");
                        break;
                    case 9:
                        Console.WriteLine("9월은 30일까지입니다.");
                        break;
                    case 10:
                        Console.WriteLine("10월은 31일까지입니다.");
                        break;
                    case 11:
                        Console.WriteLine("11월은 30일까지입니다.");
                        break;
                    case 12:
                        Console.WriteLine("12월은 31일까지입니다.");
                        break;

                }
            }
        }

        private static void Test_Two()
        {
            const int MinimumBet = 1000;
            int money = 10000;
            int round = 0;
            Random random = new Random();

            Console.WriteLine("===== 가위바위보 배팅 게임 =====");
            Console.WriteLine("승리: 배팅액 x 3 획득");
            Console.WriteLine("패배: 배팅액 x 7 손실");
            Console.WriteLine("무승부: 배팅액 x 5 획득");

            while (round < 5 && money >= MinimumBet)
            {
                Console.WriteLine();
                Console.WriteLine("[ {0}판 / 5판 ] 현재 소지금: {1}원", round + 1, money);

                int bet;
                while (true)
                {
                    Console.Write("배팅 금액을 입력하세요(최소 1,000원): ");

                    if (!int.TryParse(Console.ReadLine(), out bet))
                    {
                        Console.WriteLine("숫자만 입력해주세요.");
                    }
                    else if (bet < MinimumBet)
                    {
                        Console.WriteLine("최소 배팅 금액은 1,000원입니다.");
                    }
                    else if (bet > money)
                    {
                        Console.WriteLine("소지금보다 많이 배팅할 수 없습니다.");
                    }
                    else
                    {
                        break;
                    }
                }

                int computer = random.Next(1, 4);

                Console.Write("패를 선택하세요 (1.가위 / 2.바위 / 3.보): ");
                int player;

                while (!int.TryParse(Console.ReadLine(), out player) ||
                       (player != 1 && player != 2 && player != 3))
                {
                    Console.Write("1, 2, 3 중에서 입력해주세요: ");
                }

                Console.WriteLine("나: {0} / 컴퓨터: {1}",
                    GetHandName(player), GetHandName(computer));

                int result;

                // 1: 승리, 0: 무승부, -1: 패배
                switch (player)
                {
                    case 1: // 가위
                        result = computer == 3 ? 1 : computer == 1 ? 0 : -1;
                        break;
                    case 2: // 바위
                        result = computer == 1 ? 1 : computer == 2 ? 0 : -1;
                        break;
                    case 3: // 보
                        result = computer == 2 ? 1 : computer == 3 ? 0 : -1;
                        break;
                    default:
                        result = 0;
                        break;
                }

                switch (result)
                {
                    case 1:
                        money += bet * 3;
                        Console.WriteLine("승리! {0}원을 얻었습니다.", bet * 3);
                        break;
                    case -1:
                        money -= bet * 7;
                        if (money < 0)
                        {
                            money = 0;
                        }
                        Console.WriteLine("패배! 배팅액의 7배를 잃었습니다.");
                        break;
                    case 0:
                        money += bet * 5;
                        Console.WriteLine("무승부! {0}원을 얻었습니다.", bet * 5);
                        break;
                }

                round++;
                Console.WriteLine("남은 소지금: {0}원", money);
            }

            Console.WriteLine();
            if (money < MinimumBet)
            {
                Console.WriteLine("배팅할 돈이 부족하여 게임을 종료합니다.");
            }
            else
            {
                Console.WriteLine("5판이 끝났습니다.");
            }

            Console.WriteLine("최종 소지금: {0:N0}원", money);
        }

        private static string GetHandName(int hand)
        {
            switch (hand)
            {
                case 1:
                    return "가위";
                case 2:
                    return "바위";
                case 3:
                    return "보";
                default:
                    return "알 수 없음";
            }
        }
    }
}
*/