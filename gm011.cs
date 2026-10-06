/*using System;

namespace Project4
{
    internal class Program
    {
        private static readonly Random random = new Random();

        private static void Main(string[] args)
        {
            int gameCount = 0;
            while (gameCount < 3)
            {
                int birthYear = ReadBirthYear();
                int birthMonth = ReadMonth();
                int birthDay = ReadDay(birthMonth);
                int gender = ReadGender();
                int backNum = randomNum();

                while (backNum / 100000 == gender)
                {
                    backNum = randomNum();
                }

                Console.WriteLine("입력한 생년월일: " + birthYear + "년 " +
                                  birthMonth + "월 " + birthDay + "일");
                Console.WriteLine("출력 결과: " + (birthYear % 100).ToString("D2") +
                                  birthMonth.ToString("D2") +
                                  birthDay.ToString("D2") + "-" +
                                  gender + backNum.ToString("D6"));


                while (true)
                {
                    Console.Write("다시 생성 하기 ( Y / N ) : ");
                    string input = Console.ReadLine() ?? "";
                    if (input.ToUpper() == "Y")
                    {
                        gameCount++;
                        if (gameCount == 3) return;
                        break;
                    }
                    else if (input.ToUpper() == "N")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Y or N만 입력해주세요");
                    }
                }

            }

        }

        private static int ReadBirthYear()
        {
            while (true)
            {
                Console.Write("생년(2자리 또는 4자리) 입력: ");
                string input = Console.ReadLine() ?? "";
                int year;

                if ((input.Length != 2 && input.Length != 4) ||
                    !int.TryParse(input, out year))
                {
                    Console.WriteLine("생년은 숫자 2자리 또는 4자리로 입력해 주세요.");
                    continue;
                }

                if (input.Length == 4)
                {
                    return year;
                }

                int nineteenHundreds = 1900 + year;
                int twoThousands = 2000 + year;

                Console.WriteLine("1. " + nineteenHundreds);
                Console.WriteLine("2. " + twoThousands);

                while (true)
                {
                    Console.Write("선택: ");
                    string selection = Console.ReadLine() ?? "";

                    if (selection == "1")
                    {
                        return nineteenHundreds;
                    }

                    if (selection == "2")
                    {
                        return twoThousands;
                    }

                    Console.WriteLine("1 또는 2를 입력해 주세요.");
                }
            }
        }

        private static int ReadMonth()
        {
            while (true)
            {
                Console.Write("월 입력: ");
                string input = Console.ReadLine() ?? "";
                int month;

                if ((input.Length == 1 || input.Length == 2) &&
                    int.TryParse(input, out month) &&
                    month >= 1 && month <= 12)
                {
                    return month;
                }

                Console.WriteLine("월은 1부터 12까지 입력해 주세요.");
            }
        }

        private static int ReadDay(int month)
        {
            int maximumDay = GetMaximumDay(month);

            while (true)
            {
                Console.Write("일 입력: ");
                string input = Console.ReadLine() ?? "";
                int day;

                if ((input.Length == 1 || input.Length == 2) &&
                    int.TryParse(input, out day) &&
                    day >= 1 && day <= maximumDay)
                {
                    return day;
                }

                Console.WriteLine(month + "월은 1일부터 " + maximumDay +
                                  "일까지 입력할 수 있습니다.");
            }
        }

        private static int GetMaximumDay(int month)
        {
            if (month == 2)
            {
                return 28;
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }

            return 31;
        }

        private static int ReadGender()
        {
            Console.Write("성별 선택 ( 남자 : 1,3 | 여자 : 2,4 ) : ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int gender))
            {
                if (gender > 0 && gender < 5)
                {
                    return gender;
                }
            }
            gender = random.Next(1, 5);
            return gender;
        }

        private static int randomNum()
        {
            int result = 0;
            int previousNumber = 0;

            for (int i = 0; i < 6; i++)
            {
                int number;

                do
                {
                    number = random.Next(1, 10);
                }
                while (number == previousNumber);

                result = result * 10 + number;
                previousNumber = number;
            }

            return result;
        }
    }
}
*/