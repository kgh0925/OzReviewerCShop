/*using System;
using System.Text;

namespace Project4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                PrintMenu();
                Console.Write("메뉴 선택: ");
                string menu = Console.ReadLine();
                Console.WriteLine();

                switch (menu)
                {
                    case "1":
                        ReverseString();
                        break;
                    case "2":
                        ReverseEvenPositionCharacters();
                        break;
                    case "3":
                        PrintOnlyNumbers();
                        break;
                    case "4":
                        CountCharacter();
                        break;
                    case "5":
                        RemoveHyphenFromResidentNumber();
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;
                    default:
                        Console.WriteLine("0부터 5까지의 메뉴 번호를 입력해 주세요.");
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine();
                    Console.WriteLine("계속하려면 Enter 키를 누르세요.");
                    Console.ReadLine();
                    Console.WriteLine();
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("========== 문자열 활용 프로그램 ==========");
            Console.WriteLine("1. 문자열 거꾸로 출력");
            Console.WriteLine("2. 짝수 위치의 문자만 거꾸로 출력");
            Console.WriteLine("3. 문자열에서 숫자만 출력");
            Console.WriteLine("4. 문자열 안의 특정 문자 개수 출력");
            Console.WriteLine("5. 주민등록번호에서 하이픈(-) 제거");
            Console.WriteLine("0. 종료");
            Console.WriteLine("==========================================");
        }

        private static void ReverseString()
        {
            Console.Write("문자열을 입력하세요: ");
            string input = Console.ReadLine() ?? "";

            Console.Write("결과: ");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }

        private static void ReverseEvenPositionCharacters()
        {
            Console.Write("문자열을 입력하세요: ");
            string input = Console.ReadLine() ?? "";
            char[] result = input.ToCharArray();
            int rightEvenIndex;

            if (input.Length % 2 == 0)
            {
                rightEvenIndex = input.Length - 1;
            }
            else
            {
                rightEvenIndex = input.Length - 2;
            }

            for (int leftEvenIndex = 1; leftEvenIndex < rightEvenIndex; leftEvenIndex += 2)
            {
                char temporary = result[leftEvenIndex];
                result[leftEvenIndex] = result[rightEvenIndex];
                result[rightEvenIndex] = temporary;
                rightEvenIndex -= 2;
            }

            Console.WriteLine("결과: " + new string(result));
        }

        private static void PrintOnlyNumbers()
        {
            Console.Write("문자열을 입력하세요: ");
            string input = Console.ReadLine() ?? "";
            StringBuilder numbers = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Append(input[i]);
                }
            }

            if (numbers.Length == 0)
            {
                Console.WriteLine("결과: 숫자가 없습니다.");
            }
            else
            {
                Console.WriteLine("결과: " + numbers);
            }
        }

        private static void CountCharacter()
        {
            Console.Write("문자열을 입력하세요: ");
            string input = Console.ReadLine() ?? "";

            char target;
            while (true)
            {
                Console.Write("찾을 문자 한 개를 입력하세요: ");
                string characterInput = Console.ReadLine() ?? "";

                if (characterInput.Length == 1)
                {
                    target = characterInput[0];
                    break;
                }

                Console.WriteLine("반드시 문자 한 개만 입력해야 합니다.");
            }

            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == target)
                {
                    count++;
                }
            }

            Console.WriteLine("결과: '" + target + "' 문자는 " + count + "개 있습니다.");
        }

        private static void RemoveHyphenFromResidentNumber()
        {
            Console.Write("주민등록번호를 입력하세요: ");
            string input = Console.ReadLine() ?? "";
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '-')
                {
                    result.Append(input[i]);
                }
            }

            Console.WriteLine("결과: " + result);
        }
    }
}
*/
