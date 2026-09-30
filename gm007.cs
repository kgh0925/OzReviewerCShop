/*using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
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
            bool godMode = false;
            bool m_Skill_Active = false;
            int monsterHp = 200;
            int playerHp = 100;
            int critical = 5; // 퍼센트 앞자리 표시 ex) 5 : 50%, 10 : 100%

            int[] skill = { 10, 50, 75, 100 };
            int m_Skill_Dam = 10;

            while (monsterHp >= 0 || playerHp >= 0)
            {
                Console.Write("당신의 턴입니다. 할 행동을 입력하세요 " +
                    "( 1 : 기본 공격, 2 : 가로베기, 3 : 세로베기, 4 : 사선베기, 5 : 무적 On/Off, 6 : 즉사 ) : ");
                int playerInput = int.Parse(Console.ReadLine());
                switch (playerInput)
                {
                    case 1:
                        monsterHp -= skill[playerInput - 1];
                        break;
                    case 2:
                        monsterHp -= skill[playerInput - 1];
                        break;
                    case 3:
                        monsterHp -= skill[playerInput - 1];
                        break;
                    case 4:
                        monsterHp -= skill[playerInput - 1];
                        break;
                    case 5:
                        godMode = !godMode;
                        break;
                    case 6:
                        monsterHp = 0;
                        break;
                }
                Console.WriteLine($"플레이어 턴 종료 | 플레이어 체력 : {playerHp} | 몬스터 체력 : {monsterHp}");
                if (monsterHp <= 0 || playerHp <= 0)
                {
                    break;
                }
                Random random = new Random();
                int t_Critical = random.Next(1, 11);
                if (m_Skill_Active)
                {
                    if (!godMode)
                    {
                        if (t_Critical <= critical)
                        {
                            playerHp -= (int)((m_Skill_Dam * 1.5) * 2);
                        }
                        else
                        {
                            playerHp -= (int)(m_Skill_Dam * 1.5);
                        }

                    }
                    m_Skill_Active = false;
                    Console.WriteLine($"몬스터 턴 종료(기모으기 공격) | 플레이어 체력 : {playerHp} | 몬스터 체력 : {monsterHp}");
                }
                else
                {

                    int m_turn = random.Next(0, 2);
                    switch (m_turn)
                    {
                        case 0:
                            if (!godMode)
                            {
                                if (t_Critical <= critical)
                                {
                                    playerHp -= (m_Skill_Dam * 2);
                                }
                                else
                                {
                                    playerHp -= m_Skill_Dam;
                                }

                            }
                            break;
                        case 1:
                            m_Skill_Active = true;
                            Console.WriteLine("몬스터 기모으기 시작!");
                            break;
                    }
                    Console.WriteLine($"몬스터 턴 종료 | 플레이어 체력 : {playerHp} | 몬스터 체력 : {monsterHp}");
                }


            }
            if (playerHp > 0 && monsterHp <= 0)
            {
                Console.WriteLine($"플레이어 승리 | 플레이어 체력 : {playerHp} | 몬스터 체력 : {monsterHp}");
            }
            else
            {
                Console.WriteLine($"플레이어 몬스터 승리 | 플레이어 체력 : {playerHp} | 몬스터 체력 : {monsterHp}");
            }
        }
    }


}
*/