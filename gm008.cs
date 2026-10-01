//using System;

//namespace Project4
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {

//            string[] cardSuit = new string[52];
//            int[] cardNumber = new int[52];
//            string[] suits = { "♠", "♦", "♣", "♥" };
//            int index = 0;


//            for (int suit = 0; suit < 4; suit++)
//            {
//                for (int number = 1; number <= 13; number++)
//                {
//                    cardSuit[index] = suits[suit];
//                    cardNumber[index] = number;
//                    index++;
//                }
//            }


//            Random random = new Random();
//            for (int i = 51; i > 0; i--)
//            {
//                int randomIndex = random.Next(0, i + 1);

//                string tempSuit = cardSuit[i];
//                cardSuit[i] = cardSuit[randomIndex];
//                cardSuit[randomIndex] = tempSuit;

//                int tempNumber = cardNumber[i];
//                cardNumber[i] = cardNumber[randomIndex];
//                cardNumber[randomIndex] = tempNumber;
//            }

//            int money = 10000;
//            int nextCard = 0;
//            int round = 1;

//            Console.WriteLine("===== 월남뽕 게임 =====");
//            Console.WriteLine("시작 소지금: 10,000원");
//            Console.WriteLine("최소 배팅 금액: 1,000원");


//            while (money > 0 && nextCard + 2 < 52)
//            {
//                int left = nextCard;
//                int hidden = nextCard + 1;
//                int right = nextCard + 2;

//                Console.WriteLine();
//                Console.WriteLine("----- " + round + "판 -----");
//                Console.WriteLine("소지금: " + money.ToString("N0") + "원");
//                Console.WriteLine(cardSuit[left] + " " + CardText(cardNumber[left]) +
//                                  " / ? / " + cardSuit[right] + " " + CardText(cardNumber[right]));


//                Console.WriteLine("[상시 치트] 가운데 카드: " + cardSuit[hidden] +
//                                  " " + CardText(cardNumber[hidden]));

//                // 키 입력 치트
//                while (true)
//                {
//                    Console.Write("치트(1: 다음 판 카드 1장, 2: 남은 카드 전체, Enter: 계속): ");
//                    string cheat = Console.ReadLine();

//                    if (cheat == "1")
//                    {
//                        int preview = nextCard + 3;
//                        if (preview < 52)
//                        {
//                            Console.WriteLine("[치트 1] 다음 판 첫 카드: " + cardSuit[preview] +
//                                              " " + CardText(cardNumber[preview]));
//                        }
//                        else
//                        {
//                            Console.WriteLine("다음 판에 사용할 카드가 없습니다.");
//                        }
//                    }
//                    else if (cheat == "2")
//                    {
//                        Console.WriteLine("[치트 2] 현재 남아 있는 카드 목록");
//                        for (int i = nextCard; i < 52; i++)
//                        {
//                            Console.Write(cardSuit[i] + " " + CardText(cardNumber[i]) + "  ");
//                        }
//                        Console.WriteLine();
//                    }
//                    else if (cheat == "")
//                    {
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("1, 2 또는 Enter를 입력하세요.");
//                    }
//                }


//                if (cardNumber[left] == cardNumber[right])
//                {
//                    Console.WriteLine("양쪽 숫자가 같아서 무조건 패배합니다.");
//                    money = money - 1000;
//                    Console.WriteLine("1,000원을 잃었습니다.");
//                }
//                else
//                {
//                    int bet = 0;
//                    bool folded = false;


//                    while (true)
//                    {
//                        Console.Write("배팅 금액을 입력하세요(fold 입력 시 포기): ");
//                        string input = Console.ReadLine();

//                        if (input.ToLower() == "fold")
//                        {
//                            folded = true;
//                            break;
//                        }

//                        bool isNumber = int.TryParse(input, out bet);
//                        if (isNumber == false)
//                        {
//                            Console.WriteLine("숫자 또는 fold를 입력하세요.");
//                        }
//                        else if (bet < 1000)
//                        {
//                            Console.WriteLine("최소 배팅 금액은 1,000원입니다.");
//                        }
//                        else if (bet > money)
//                        {
//                            Console.WriteLine("소지금보다 많이 배팅할 수 없습니다.");
//                        }
//                        else
//                        {
//                            break;
//                        }
//                    }

//                    if (folded == true)
//                    {
//                        Console.WriteLine("이번 판을 포기했습니다.");
//                    }
//                    else
//                    {

//                        money = money - bet;
//                        Console.WriteLine("가운데 카드 공개: " + cardSuit[hidden] +
//                                          " " + CardText(cardNumber[hidden]));

//                        int smallNumber;
//                        int bigNumber;

//                        if (cardNumber[left] < cardNumber[right])
//                        {
//                            smallNumber = cardNumber[left];
//                            bigNumber = cardNumber[right];
//                        }
//                        else
//                        {
//                            smallNumber = cardNumber[right];
//                            bigNumber = cardNumber[left];
//                        }


//                        if (cardNumber[hidden] > smallNumber && cardNumber[hidden] < bigNumber)
//                        {
//                            money = money + bet * 2;
//                            Console.WriteLine("승리! 배팅금의 2배를 받았습니다.");
//                        }
//                        else
//                        {
//                            Console.WriteLine("패배! 배팅금을 잃었습니다.");
//                        }
//                    }
//                }


//                nextCard = nextCard + 3;
//                round = round + 1;
//            }

//            Console.WriteLine();
//            Console.WriteLine("===== 게임 종료 =====");
//            if (money <= 0)
//            {
//                Console.WriteLine("소지금이 0원이 되어 게임을 종료합니다.");
//            }
//            else
//            {
//                Console.WriteLine("다음 판에 필요한 카드 3장이 부족합니다.");
//            }

//            Console.WriteLine("최종 소지금: " + money.ToString("N0") + "원");
//            Console.WriteLine("진행한 판 수: " + (round - 1) + "판");
//        }

//        private static string CardText(int number)
//        {
//            if (number == 1) return "A";
//            if (number == 11) return "J";
//            if (number == 12) return "Q";
//            if (number == 13) return "K";
//            return number.ToString();
//        }
//    }
//}
