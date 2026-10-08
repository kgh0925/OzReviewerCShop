/*using System;

namespace Project4
{
    internal class Program
    {
        private static readonly string[] inventory = new string[5];
        private static readonly string[] fieldItems =
        {
            "물약", "녹슨 검", "금화", "독사과", "방패"
        };

        private static int fieldIndex = 0;

        private static void Main(string[] args)
        {
            InitializeInventory();

            Console.WriteLine("[I] 인벤토리 확인  [G] 아이템 획득  [U] 1번 슬롯 사용  [S] 독사과 버리기  [Q] 종료");

            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("\n키를 입력하세요: ");
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.I:
                        ShowInventory();
                        break;

                    case ConsoleKey.G:
                        PickUpItem();
                        break;

                    case ConsoleKey.U:
                        UseFirstItem();
                        break;

                    case ConsoleKey.S:
                        DiscardPoisonApples();
                        break;

                    case ConsoleKey.Q:
                        isRunning = false;
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;

                    default:
                        Console.WriteLine("I, G, U, S, Q 중 하나를 눌러 주세요.");
                        break;
                }
            }
        }

        private static void InitializeInventory()
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                inventory[i] = "비어있음";
            }
        }

        private static void ShowInventory()
        {
            Console.WriteLine("=== 인벤토리 ===");

            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine("[{0}번 슬롯] : {1}", i + 1, inventory[i]);
            }
        }

        private static void PickUpItem()
        {
            if (fieldIndex >= fieldItems.Length)
            {
                Console.WriteLine("필드에 남은 아이템이 없습니다!");
                return;
            }

            bool foundEmptySlot = false;

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "비어있음")
                {
                    inventory[i] = fieldItems[fieldIndex];
                    Console.WriteLine("{0}(을)를 획득했습니다!", fieldItems[fieldIndex]);

                    fieldIndex++;
                    foundEmptySlot = true;
                    break;
                }
            }

            if (!foundEmptySlot)
            {
                Console.WriteLine("가방이 가득 찼습니다!");
            }
        }

        private static void UseFirstItem()
        {
            if (inventory[0] == "비어있음")
            {
                Console.WriteLine("1번 슬롯이 비어있습니다!");
                return;
            }

            Console.WriteLine("{0}(을)를 사용했습니다!", inventory[0]);

            for (int i = 0; i < inventory.Length - 1; i++)
            {
                inventory[i] = inventory[i + 1];
            }

            inventory[inventory.Length - 1] = "비어있음";
        }

        private static void DiscardPoisonApples()
        {
            bool discarded = false;

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "독사과")
                {
                    inventory[i] = "비어있음";
                    Console.WriteLine("[{0}번 슬롯]의 독사과를 버렸습니다!", i + 1);
                    discarded = true;
                }
            }

            if (!discarded)
            {
                Console.WriteLine("인벤토리에 독사과가 없습니다!");
            }
        }
    }
}
*/