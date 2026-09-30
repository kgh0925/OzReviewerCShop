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

            Test_One();

        }

        private static void Test_One()
        {
            Random random = new Random();
            int[] num = new int[3];
            int count = num.Length;
            while (count > 0)
            {
                int temp = random.Next(1, 10);
                if (num.Contains(temp))
                {
                    continue;
                }
                num[num.Length - count] = temp;
                count--;
            }

            Console.WriteLine("0을 입력하면 치트 상태로 시작합니다. ( 치트 입력 시 컴퓨터 숫자 3 6 9 고정 )");
            int bug = int.Parse(Console.ReadLine());
            if (bug == 0)
            {
                num[0] = 3;
                num[1] = 6;
                num[2] = 9;
            }
            int game_count = 0;
            bool endgame = false;
            while (!endgame)
            {
                int[] playerNumbers = new int[3];
                int strike = 0;
                int bol = 0;
                int out_ = 0;
                while (true)
                {
                    Console.Write("정수 3개를 공백으로 구분해 입력하세요 (예: 1 2 3): ");
                    string[] inputs = Console.ReadLine().Split(
                        new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (inputs.Length != 3)
                    {
                        Console.WriteLine("정확히 3개를 입력해주세요.");
                        continue;
                    }

                    bool validInput = true;

                    for (int i = 0; i < playerNumbers.Length; i++)
                    {
                        if (!int.TryParse(inputs[i], out playerNumbers[i]))
                        {
                            validInput = false;
                            break;
                        }
                    }

                    if (validInput)
                    {
                        break;
                    }

                    Console.WriteLine("정수만 입력해주세요.");
                }

                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] == playerNumbers[i])
                    {
                        strike++;
                    }
                    else if (num.Contains(playerNumbers[i]))
                    {
                        bol++;
                    }
                    else
                    {
                        out_++;
                    }
                }

                Console.WriteLine("{0}S , {1}B, {2}O", strike, bol, out_);
                game_count++;
                if (strike == 3)
                {
                    Console.WriteLine("게임을 클리어하였습니다. 다시 시작하실거면 0, 종료하실거면 1, 치트로 재시작 할거면 2를 입력해주세요");
                    while (true)
                    {
                        int endinput = int.Parse(Console.ReadLine());

                        if (endinput == 0)
                        {
                            num = new int[3];
                            count = num.Length;
                            while (count > 0)
                            {
                                int temp = random.Next(1, 10);
                                if (num.Equals(temp))
                                {
                                    continue;
                                }
                                num[num.Length - count] = temp;
                                count--;
                            }

                            Console.WriteLine("게임이 다시 시작됩니다.");
                        }
                        else if (endinput == 1)
                        {
                            endgame = true;
                        }
                        else if (endinput == 2)
                        {
                            num[0] = 3;
                            num[1] = 6;
                            num[2] = 9;
                        }
                    }
                }

            }

        }
    }


}
*/