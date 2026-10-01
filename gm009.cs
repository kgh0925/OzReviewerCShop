/*using System;
using System.Linq;

namespace Project4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] userNumbers = new int[6];
            int menu = 0;
            Random random = new Random();

            Console.WriteLine("===== 로또 당첨기 =====");
            Console.WriteLine("1. 사용자 입력");
            Console.WriteLine("2. 자동");

            while (true)
            {
                Console.Write("선택: ");
                string menuInput = Console.ReadLine();
                bool isNumber = int.TryParse(menuInput, out menu);

                if (isNumber == false)
                {
                    Console.WriteLine("숫자를 입력해주세요.");
                }
                else if (menu != 1 && menu != 2)
                {
                    Console.WriteLine("1 또는 2를 입력해주세요.");
                }
                else
                {
                    break;
                }
            }

            if (menu == 1)
            {
                Console.WriteLine();
                Console.WriteLine("1부터 45까지의 숫자 6개를 입력해주세요.");

                for (int i = 0; i < 6; i++)
                {
                    while (true)
                    {
                        Console.Write((i + 1) + "번째 숫자: ");
                        string input = Console.ReadLine();
                        int number;
                        bool isNumber = int.TryParse(input, out number);

                        if (isNumber == false)
                        {
                            Console.WriteLine("숫자만 입력할 수 있습니다.");
                            continue;
                        }

                        if (number < 1 || number > 45)
                        {
                            Console.WriteLine("1부터 45까지의 숫자만 입력할 수 있습니다.");
                            continue;
                        }
                        bool isDuplicate = false;

                        for (int j = 0; j < i; j++)
                        {
                            if (userNumbers[j] == number)
                            {
                                isDuplicate = true;
                                break;
                            }
                        }

                        if (isDuplicate == true)
                        {
                            Console.WriteLine("이미 입력한 숫자입니다.");
                            continue;
                        }

                        userNumbers[i] = number;
                        break;
                    }
                }
            }
            else
            {


                for (int i = 0; i < 6; i++)
                {
                    while (true)
                    {
                        int number = random.Next(1, 46);
                        bool isDuplicate = false;

                        for (int j = 0; j < i; j++)
                        {
                            if (userNumbers[j] == number)
                            {
                                isDuplicate = true;
                                break;
                            }
                        }

                        if (isDuplicate == false)
                        {
                            userNumbers[i] = number;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.Write("선택한 로또 번호: ");

            for (int i = 0; i < 6; i++)
            {
                Console.Write(userNumbers[i]);

                if (i < 5)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();

            int[] lotto = new int[6];
            int bonusNum = 0;
            for (int i = 0; i < 7; i++)
            {
                while (true)
                {
                    int number = random.Next(1, 46);
                    bool isDuplicate = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (lotto[j] == number)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (isDuplicate == false)
                    {
                        if (i == 6)
                        {
                            bonusNum = number;
                            break;
                        }
                        lotto[i] = number;
                        break;
                    }
                }
            }

            Console.Write("당첨 로또 번호: ");

            for (int i = 0; i < 6; i++)
            {
                Console.Write(lotto[i]);

                if (i < 5)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"보너스 번호: {bonusNum}");

            int clear_num = 0;
            for (int i = 0; i < 6; i++)
            {
                if (lotto.Contains(userNumbers[i]))
                {
                    clear_num++;
                }
            }
            switch (clear_num)
            {
                case 6:
                    Console.WriteLine("1등 당첨");
                    break;
                case 5:
                    if (userNumbers.Contains(bonusNum))
                    {
                        Console.WriteLine("2등 당첨");
                    }
                    else
                    {
                        Console.WriteLine("3등 당첨");
                    }
                    break;
                case 4:
                    Console.WriteLine("4등 당첨");
                    break;
                case 3:
                    Console.WriteLine("5등 당첨");
                    break;
                default:
                    Console.WriteLine($"낙첨 : {clear_num}개 맞춤");
                    break;

            }

        }
    }
}
*/