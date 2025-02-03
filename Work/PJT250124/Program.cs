namespace PJT250124
{
    internal class Program
    {
        public class Something
        {
            public void Project1()
            {
                string? readLineString = Console.ReadLine();
                int number = 0;
                while (readLineString == null || !int.TryParse(readLineString, out number))
                {
                    Console.WriteLine("숫자를 입력해주세요.");
                    readLineString = Console.ReadLine();
                }

                if (number != 0 && number % 4 == 0)
                {
                    Console.WriteLine($"{number} 은/는 4의 배수입니다.");
                }
                else
                {
                    Console.WriteLine($"{number} 은/는 4의 배수가 아닙니다.");
                }
            }

            public void Project2()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            public void Project3()
            {
                int odd = 0;
                int even = 0;
                int total = 0;

                for (int i = 0; i <= 100; i += 2)
                {
                    even += i;
                    //total += i;

                    //if (i % 2 == 0)
                    //{
                    //    even += i;
                    //}
                    //else
                    //{
                    //    odd += i;
                    //}
                }

                Console.WriteLine(odd);
                Console.WriteLine(even);
                Console.WriteLine(total);
            }

            public void Project4()
            {
                char wall = '*';
                char floor = ' ';
                int[,] map =
                    {
                        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
                    };
                int playerX = 1;
                int playerY = 1;

                int monsterCount = 0;
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        if (map[y, x] == 4)
                        {
                            monsterCount++;
                        }
                    }
                }

                bool playing = true;
                while (playing)
                {
                    Console.Clear();
                    for (int y = 0; y < map.GetLength(0); y++)
                    {
                        for (int x = 0; x < map.GetLength(1); x++)
                        {
                            if (x == playerX && y == playerY)
                            {
                                Console.Write('P');
                                if (map[y, x] == 4)
                                {
                                    map[y, x] = 0;
                                    monsterCount--;
                                }
                            }
                            else if (map[y, x] == 1)
                            {
                                Console.Write(wall);
                            }
                            else if (map[y, x] == 0)
                            {
                                Console.Write(floor);
                            }
                            else if (map[y, x] == 4)
                            {
                                Console.Write('M');
                            }
                        }
                        Console.WriteLine();
                    }
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        playerY--;
                    }
                    else if (keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        playerY++;
                    }
                    else if (keyInfo.Key == ConsoleKey.D || keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        playerX++;
                    }
                    else if (keyInfo.Key == ConsoleKey.A || keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        playerX--;
                    }
                    else if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        playing = false;
                    }

                    if (monsterCount == 0)
                    {
                        playing = false;
                    }
                }

                Console.Clear();
                Console.WriteLine("GAME OVER");
            }

            static void Main(string[] args)
            {
                Something something = new Something();

                //something.Project1();
                //something.Project2();
                //something.Project3();
                something.Project4();
            }
        }
    }
}
