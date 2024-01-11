using Project1;
using static System.Formats.Asn1.AsnWriter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Collections;
using System.Collections.Immutable;

namespace Project1
{    
    public class Player
    {
        public int level { get; set; }
        public string name { get; set; }
        public string job { get; set; }
        public int attack { get; set; }
        public int patk {  get; set; }
        public int defense { get; set; }
        public int pdef {  get; set; }
        public int health { get; set; }
        public int money { get; set; }

        public Player(int Lv, string Name, string Job, int atk, int Patk, int def, int Pdef, int hp, int gold)
        {
            level = Lv;
            name = Name;
            job = Job;
            attack = atk;
            patk = Patk;
            defense = def;
            pdef = Pdef;
            health = hp;
            money = gold;
        }
    }

    public class Enemy
    {
        public int Level { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int EnemyNum { get; set; }

        public Enemy(int level, string name, int hp, int atk, int enemynum)
        {
            Level = level;
            Name = name;
            Hp = hp;
            Atk = atk;
            EnemyNum = enemynum;
        }
    }

    public class EnemyList
    {
        public List<Enemy> enemyList;

        public EnemyList()
        {
            enemyList = new List<Enemy>();
        }

        public void AddEnemy(Enemy enemies)
        {
            enemyList.Add(enemies);
        }
    }

    public class Inven
    {
        public List<Item> equipItems;        

        public Inven()
        {
            equipItems = new List<Item>();
        }
        public void EIT(Item etem)
        {            
            equipItems.Add(etem);
        }       
    }
    


    public class Item
    {        
        public string iEquip {  get; set; }
        public string  iName{ get; set; }
        public string iAbilityType { get; set; }
        public int iAbilityPoint { get; set; }        
        public string iinformation { get; set; }
        public int iPrice { get; set; }
        public string iSoldout {  get; set; }        
        public int invenSellingPrice { get; set; }
        public string iEquipmentType { get; set; }

        public Item(string _iequip, string _iname, string _equipmenttype, string _iabilitytype, int _iabilitypoint, string _iinformation, int _isp)
        {
            iEquip = _iequip;
            iName = _iname;
            iAbilityType = _iabilitytype;
            iAbilityPoint = _iabilitypoint;
            iinformation = _iinformation;
            invenSellingPrice = _isp;
            iEquipmentType = _equipmenttype;
        }

        public Item(string _iequip, string _iname, string _equipmenttype, string _iabilitytype, int _iabilitypoint, string _iinformation, int _iprice, string _isoldout)
        {
            iEquip = _iequip;
            iName = _iname;
            iAbilityType = _iabilitytype;
            iAbilityPoint = _iabilitypoint;
            iinformation = _iinformation;
            iPrice = _iprice;
            iSoldout = _isoldout;
            iEquipmentType = _equipmenttype;
        }  
        
        public static int GetPrintableLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                if(char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter)
                {
                    length += 2;
                }
                else
                {
                    length += 1;
                }
            }

            return length;
        }

        public static string PadRightForMixedText(string str, int totalLength)
        {
            int currenLength = GetPrintableLength(str);
            int padding = totalLength - currenLength;
            return str.PadRight(str.Length + padding);
        }
    }

    public class Store
    {
        public List<Item> bsItems;
        public Store()
        {
            bsItems = new List<Item>();
        }
        public void SIT(Item bsingItem)
        {
            bsItems.Add(bsingItem);
        }        
    }    


    internal class Program
    {
        public static Player player;
        public static Item Item1;
        public static Item Item2;
        public static Item Item3;
        public static Inven inven;
        public static Store store;
        public static Item sitem1;
        public static Item sitem2;
        public static Item sitem3;
        public static Item sitem4;
        public static Item sitem5;
        public static Item sitem6;
        public static Item sitem7;
        public static Item sitem8;
        public static EnemyList eList;
        public static Enemy enemy1;
        public static Enemy enemy2;
        public static Enemy enemy3;

        public static void Main (string[] args)
        {
            player = new Player(1, "Chad", "전사", 10, 0, 5, 0, 100, 150000);
            Item1 = new Item("", "무쇠 갑옷", "방어구", "방어력", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 0);
            Item2 = new Item("", "스파르타의 창", "무기", "공격력", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 0);
            Item3 = new Item("", "낡은 검", "무기", "공격력", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 0);
            inven = new Inven();
            inven.EIT(Item1);
            inven.EIT(Item2);
            inven.EIT(Item3);
            sitem1 = new Item("", "수련자 갑옷", "방어구", "방어력", 5, "수련에 도움을 주는 갑옷입니다.", 1000, "구매완료");
            sitem2 = new Item("", "무쇠 갑옷", "방어구", "방어력", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 1800, "구매완료");
            sitem3 = new Item("", "스파르타의 갑옷", "방어구", "방어력", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500, "구매완료");
            sitem4 = new Item("", "낡은 검", "무기", "공격력", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 600, "구매완료");
            sitem5 = new Item("", "청동 도끼", "무기", "공격력", 5, "어디선가 사용됐던거 같은 도끼입니다.", 1500, "구매완료");
            sitem6 = new Item("", "스파르타의 창", "무기", "공격력", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 2700, "구매완료");
            sitem7 = new Item("", "무쇠 오함마", "무기", "공격력", 12, "상점 구석에 쳐박혀 있던 오함마입니다.", 3000, "구매완료");
            sitem8 = new Item("", "소가죽 갑옷", "방어구", "방어력", 7, "소가죽으로 대충만든 갑옷입니다.", 1400, "구매완료");
            store = new Store();
            store.SIT(sitem1);
            store.SIT(sitem2);
            store.SIT(sitem3);
            store.SIT(sitem4);
            store.SIT(sitem5);
            store.SIT(sitem6);
            store.SIT(sitem7);
            store.SIT(sitem8);
            enemy1 = new Enemy(2, "미니언", 15, 5, 0);
            enemy2 = new Enemy(3, "공허충", 10, 9, 0);
            enemy3 = new Enemy(5, "대포미니언", 25, 8, 0);
            eList = new EnemyList();
            eList.AddEnemy(enemy1);
            eList.AddEnemy(enemy2);
            eList.AddEnemy(enemy3);

                
            while (true)
            {
                mainMenu();               
                string input = Console.ReadLine();
                

                if (input == "1")
                {
                    while (true)
                    {
                        playerCondition();
                        string backInput = Console.ReadLine();
                        if (backInput == "0")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            wrongInput();
                        }
                    }                    
                }
                else if (input == "2")
                {
                    inventory();
                    string backInput = Console.ReadLine();                    
                    if (backInput == "0")
                    {
                        Console.Clear();
                    }
                    else if (backInput == "1")
                    {
                        while (true)
                        {                            
                            inventoryEquipment();
                            string selectNum = Console.ReadLine();
                            int selectNumInput = int.Parse(selectNum);

                            if (selectNumInput == 0)
                            {
                                Console.Clear();
                                break;
                            }
                            else if (selectNumInput <= inven.equipItems.Count && selectNumInput >= 0)
                            {

                                if (inven.equipItems[selectNumInput - 1].iEquip.Contains("[E]"))
                                {
                                    inven.equipItems[selectNumInput - 1].iEquip = "";
                                    if (inven.equipItems[selectNumInput - 1].iAbilityType == "공격력")
                                    {
                                        player.attack -= inven.equipItems[selectNumInput - 1].iAbilityPoint;
                                        player.patk -= inven.equipItems[selectNumInput - 1].iAbilityPoint;
                                    }
                                    else
                                    {
                                        player.defense -= inven.equipItems[selectNumInput - 1].iAbilityPoint;
                                        player.pdef -= inven.equipItems[selectNumInput - 1].iAbilityPoint;
                                    }                                    
                                }
                                else if (inven.equipItems[selectNumInput - 1].iEquip.Contains(""))
                                {
                                    inven.equipItems[selectNumInput - 1].iEquip = "[E]";
                                    if (inven.equipItems[selectNumInput - 1].iAbilityType == "공격력")
                                    {
                                        player.attack += inven.equipItems[selectNumInput - 1].iAbilityPoint;
                                        player.patk += inven.equipItems[selectNumInput - 1].iAbilityPoint;
                                    }
                                    else
                                    {
                                        player.defense += inven.equipItems[selectNumInput - 1].iAbilityPoint;
                                        player.pdef += inven.equipItems[selectNumInput - 1].iAbilityPoint;
                                    }                                                                    
                                }

                            }
                            else
                            {
                                wrongInput();
                            }

                        }
                    }
                    else
                    {
                        wrongInput();
                        Console.Clear();                        
                    }
                                                                                                                                                                                                                      
                }
                else if (input == "3")
                {

                    storeMenu();
                    string backInput= Console.ReadLine();
                    
                    if (backInput == "0")
                    {
                        Console.Clear();
                    }
                    else if(backInput == "1")
                    {
                        while (true)
                        {
                            storeBuyMenu();

                            string inputKey = Console.ReadLine();
                            int inputKeyInt = int.Parse(inputKey);
                            if (inputKeyInt == 0)
                            {
                                Console.Clear();
                                break;
                            }

                            Item invenSame = inven.equipItems.Find(x => x.iName.Equals(store.bsItems[inputKeyInt - 1].iName));

                            if (player.money >= store.bsItems[inputKeyInt - 1].iPrice)
                            {                                
                                if (invenSame != null)
                                {
                                    Console.WriteLine("이미 구매한 아이템입니다.");
                                    Thread.Sleep(1000);
                                }                                
                                else
                                {
                                    Console.WriteLine("구매를 완료했습니다.");
                                    player.money -= store.bsItems[inputKeyInt - 1].iPrice;
                                    inven.equipItems.Add(store.bsItems[inputKeyInt - 1]);
                                    Thread.Sleep(1000);
                                }
                            }
                            else if (player.money < store.bsItems[inputKeyInt - 1].iPrice)
                            {                                
                                if (invenSame != null)
                                {
                                    Console.WriteLine("이미 구매한 아이템입니다.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Console.WriteLine("Gold 가 부족합니다.");
                                    Thread.Sleep(1000);
                                }
                            }                                                        
                        }                                                                                              
                    }
                    else if(backInput == "2")
                    {
                        while (true)
                        {
                            for (int i = 0; i < store.bsItems.Count; i++)
                            {
                                for (int j =0; j <inven.equipItems.Count; j++)
                                {
                                    if (store.bsItems[i].iName == inven.equipItems[j].iName)
                                    {
                                        inven.equipItems[j].invenSellingPrice = (int)(store.bsItems[i].iPrice * 0.85);
                                    }
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("상점 - 아이템 판매");
                            Console.WriteLine("소지한 아이템을 판매할 수 있는 상점입니다.");
                            Console.WriteLine();
                            Console.WriteLine("[보유 골드]");
                            Console.WriteLine("{0} G", player.money);
                            Console.WriteLine();
                            Console.WriteLine("[아이템 목록]");
                            int sellItemNum = 0;
                            for (sellItemNum = 0; sellItemNum < inven.equipItems.Count; sellItemNum++)
                            {
                                Console.WriteLine($"- {sellItemNum + 1} {inven.equipItems[sellItemNum].iEquip}{inven.equipItems[sellItemNum].iName}      | {inven.equipItems[sellItemNum].iAbilityType} +{inven.equipItems[sellItemNum].iAbilityPoint} | {inven.equipItems[sellItemNum].iinformation} | {inven.equipItems[sellItemNum].invenSellingPrice} G");
                            }
                            Console.WriteLine();
                            Console.WriteLine("0. 나가기");
                            Console.WriteLine();
                            Console.WriteLine("원하시는 행동을 입력해주세요.");
                            Console.Write(">>");
                            
                            int inputKey = int.Parse(Console.ReadLine());

                            if (inputKey == 0)
                            {
                                Console.Clear();
                                break;
                            }

                            int sellP = inven.equipItems[inputKey - 1].invenSellingPrice;

                            if (inven.equipItems[inputKey -1] != null)
                            {
                                if (inven.equipItems[inputKey - 1].iEquip.Contains("[E]"))
                                {
                                    inven.equipItems[inputKey - 1].iEquip = "";
                                    if (inven.equipItems[inputKey - 1].iAbilityType == "공격력")
                                    {
                                        player.attack -= inven.equipItems[inputKey - 1].iAbilityPoint;
                                        player.patk -= inven.equipItems[inputKey - 1].iAbilityPoint;
                                    }
                                    else
                                    {
                                        player.defense -= inven.equipItems[inputKey - 1].iAbilityPoint;
                                        player.pdef -= inven.equipItems[inputKey - 1].iAbilityPoint;
                                    }
                                }

                                inven.equipItems.Remove(inven.equipItems[inputKey - 1]);
                                player.money += sellP;                               
                            }
                        }                                                
                    }
                }
                else if(input == "4")
                {
                    Random random = new Random();
                    int ranInput2 = random.Next(1, 5);
                    int ranInput = random.Next(3);                                        
                    List<int> enemyR = new List<int>();  
                    
                    while (true)
                    {                       
                        string eNum = eList.enemyList[ranInput].EnemyNum.ToString();
                        string eNumR = eNum.Replace("0", "");

                        for (int i = 0; i < ranInput2; i++)
                        {
                            enemyR.Add(ranInput);
                            ranInput = random.Next(3);
                        }
                                                
                        Console.Clear();
                        Console.WriteLine("Battle!!");
                        Console.WriteLine();
                        
                        for (int i = 0;i < ranInput2; i++)
                        {
                            ranInput = enemyR[i];
                            if (ranInput >= 0 && ranInput <= 2)
                            {                                
                                Console.WriteLine($"{eNumR}Lv.{eList.enemyList[ranInput].Level} {eList.enemyList[ranInput].Name} HP {eList.enemyList[ranInput].Hp}");
                            }                            
                        }
                       
                        Console.WriteLine();
                        Console.WriteLine("[내정보]");
                        Console.WriteLine($"Lv.{player.level} {player.name} ({player.job})");
                        Console.WriteLine($"HP {player.health}");
                        Console.WriteLine();                        
                        Console.WriteLine("1. 공격");
                        Console.WriteLine();                        
                        Console.WriteLine("원하시는 행동을 입력해주세요.");
                        Console.WriteLine(">>");

                        string inputKey = Console.ReadLine();
                        if (inputKey == "0")
                        {
                            Console.Clear();
                            break;
                        }
                        else if (inputKey == "1")
                        {                            
                            while (true)
                            {                               
                                Console.Clear();
                                Console.WriteLine("Battle!!");
                                Console.WriteLine();
                                
                                for (int i = 0; i < ranInput2; i++)
                                {
                                    eNum = (eList.enemyList[ranInput].EnemyNum + 1 + i).ToString();
                                    ranInput = enemyR[i];
                                    if (ranInput >= 0 && ranInput <= 2)
                                    {
                                        Console.WriteLine($"{eNum} Lv.{eList.enemyList[ranInput].Level} {eList.enemyList[ranInput].Name} HP {eList.enemyList[ranInput].Hp}");
                                    }                                                                        
                                }

                                Console.WriteLine();
                                Console.WriteLine("[내정보]");
                                Console.WriteLine($"Lv.{player.level} {player.name} ({player.job})");
                                Console.WriteLine($"HP {player.health}");
                                Console.WriteLine();                                
                                Console.WriteLine("0. 취소");
                                Console.WriteLine();                                
                                Console.WriteLine("대상을 선택해주세요.");
                                Console.WriteLine(">>");

                                string inputKey2 = Console.ReadLine();                                
                                if (inputKey2 == "0")
                                {
                                    break;
                                }
                                //else if (eList.enemyList[int.Parse(inputKey2) - 1].Name == eList.enemyList[ranInput].Name)
                                //{
                                //    Random playerAtkR = new Random();
                                //    int playerAtkRange = playerAtkR.Next((int)(player.attack * 0.9), (int)(player.attack * 1.1));
                                //    eList.enemyList[ranInput].Hp -= playerAtkRange;
                                //    Console.WriteLine(playerAtkRange);
                                //    if (eList.enemyList[int.Parse(inputKey2)].Hp <= 0)
                                //    {
                                //        string enemyD = eList.enemyList[int.Parse(inputKey2)].Hp.ToString();



                                //    }
                                //}
                                else
                                {
                                    Console.WriteLine("잘못된 입력입니다.");
                                    Thread.Sleep(1000);
                                }
                            }
                            
                            
                        }
                    }                    
                }
                else if (input == "5")
                {
                    break;
                }
                else
                {
                    wrongInput();
                    Console.Clear();
                }
            }

        }

        static void mainMenu()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("4. 전투 시작");
            Console.WriteLine("5. 게임종료");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
        }

        static void playerCondition()
        {
            Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine("Lv. {0}", player.level.ToString("X2"));
            Console.WriteLine("{0} ( {1} )", player.name, player.job);
            Console.Write("공격력 : {0}", player.attack);
            if (player.patk > 0)
            {
                Console.WriteLine(" (+{0})", player.patk);
            }

            if (player.patk == 0)
            {
                Console.WriteLine();
            }
            Console.Write("방어력 : {0}", player.defense);
            if (player.pdef > 0)
            {
                Console.WriteLine(" (+{0})", player.pdef);
            }

            if (player.pdef == 0)
            {
                Console.WriteLine();
            }
            Console.WriteLine("체력 : {0}", player.health);
            Console.WriteLine("Gold : {0} G", player.money);
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">>");
        }

        static void wrongInput()
        {
            Console.WriteLine("잘못된 입력입니다.");
            Thread.Sleep(1000);
        }

        static void inventory()
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            
            for (int i = 0; i < inven.equipItems.Count; i++)
            {
                int nameLength = inven.equipItems[i].iName.Length;
                Console.Write("- {0}", inven.equipItems[i].iEquip);
                Console.Write("{0}",inven.equipItems[i].iName.PadRight(20 - nameLength) + "| ");
                Console.WriteLine($"{inven.equipItems[i].iAbilityType} +{inven.equipItems[i].iAbilityPoint} | {inven.equipItems[i].iinformation}");
            }
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">>");
        }

        static void inventoryEquipment()
        {
            Console.Clear();
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < inven.equipItems.Count; i++)
            {
                int nameLength = inven.equipItems[i].iName.Length;
                Console.Write("- {0}", inven.equipItems[i].iEquip);
                Console.Write("{0}", inven.equipItems[i].iName.PadRight(20 - nameLength) + "| ");
                Console.WriteLine($"{inven.equipItems[i].iAbilityType} +{inven.equipItems[i].iAbilityPoint} | {inven.equipItems[i].iinformation}");
            }
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("장착하거나 해지하고 싶은 아이템의 번호를 입력하거나 나가기 0번을 눌러주세요.");
            Console.Write(">>");
        }

        static void storeMenu()
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine("{0} G", player.money);
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            for (int i = 0; i < store.bsItems.Count; i++)
            {
                bool soldoutItem = false;
                int nameLength = store.bsItems[i].iName.Length;
                int informationLength = store.bsItems[i].iinformation.Length;
                Console.Write("{0}", store.bsItems[i].iName.PadRight(20 - nameLength) + "|  ");

                Console.Write("{0}", store.bsItems[i].iAbilityType);
                Console.Write(string.Format(" +{0}", store.bsItems[i].iAbilityPoint).PadRight(5) + "| ");
                Console.Write("{0}", store.bsItems[i].iinformation.PadRight(50 - informationLength) + "| ");
                for (int j = 0; j < inven.equipItems.Count; j++)
                {
                    if (store.bsItems[i].iName == inven.equipItems[j].iName)
                    {
                        soldoutItem = true;
                        Console.WriteLine(" {0} ", store.bsItems[i].iSoldout);
                    }

                }

                if (soldoutItem == false)
                {
                    Console.WriteLine(" {0} G", store.bsItems[i].iPrice);
                }

            }

            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
        }

        static void storeBuyMenu()
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine("{0} G", player.money);
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");

            for (int i = 0; i < store.bsItems.Count; i++)
            {
                bool soldoutItem = false;
                string storeListP = $"- {i + 1} {store.bsItems[i].iName}      | {store.bsItems[i].iAbilityType} +{store.bsItems[i].iAbilityPoint} | {store.bsItems[i].iinformation}       | {store.bsItems[i].iPrice} G ";
                string storeListS = storeListP.Replace($"{store.bsItems[i].iPrice} G ", store.bsItems[i].iSoldout);


                for (int j = 0; j < inven.equipItems.Count; j++)
                {
                    if (store.bsItems[i].iName == inven.equipItems[j].iName)
                    {
                        soldoutItem = true;
                        Console.WriteLine(storeListS);
                    }
                }

                if (soldoutItem == false)
                {
                    Console.WriteLine(storeListP);
                }
            }

            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("구입하고싶은 아이템의 번호를 입력하거나 나가기 0번을 입력해주세요.");
            Console.Write(">>");
        }        
    }         
}
