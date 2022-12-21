using System;
using System.Threading;

namespace Walls_And_Mines
{
    class Program
    {
        static void walls(int x , int y , int pattern,int[,] block)
        {
            switch (pattern)
            {
                case 0:
                    Console.SetCursorPosition(y, x);
                    Console.Write("####");
                    block[x, y] = 1; block[x, y+1] = 1; block[x, y+2] = 1; block[x, y+3] = 1;

                    break;
                case 1:
                    Console.SetCursorPosition(y, x);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x+1);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x+2);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x+3);
                    Console.Write("#   ");
                    block[x, y] = 1; block[x+1, y] = 1; block[x+2, y] = 1; block[x+3, y] = 1;
                    break;
                case 2:
                    Console.SetCursorPosition(y, x+3);
                    Console.Write("####");
                    block[x+3, y] = 1; block[x+3, y + 1] = 1; block[x+3, y + 2] = 1; block[x+3, y + 3] = 1;
                    break;
                case 3:
                    Console.SetCursorPosition(y, x);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("   #");
                    block[x, y+3] = 1; block[x + 1, y+3] = 1; block[x + 2, y+3] = 1; block[x + 3, y+3] = 1;
                    break;
                case 4:
                    Console.SetCursorPosition(y, x);
                    Console.Write("####");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("#   ");
                    block[x, y] = 1; block[x, y + 1] = 1; block[x, y + 2] = 1; block[x, y + 3] = 1;
                    block[x, y] = 1; block[x + 1, y] = 1; block[x + 2, y] = 1; block[x + 3, y] = 1;
                    break;
                case 5:
                    Console.SetCursorPosition(y, x);
                    Console.Write("#  #");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("#  #");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("#  #");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("#  #");
                    block[x, y] = 1; block[x + 1, y] = 1; block[x + 2, y] = 1; block[x + 3, y] = 1;
                    block[x, y + 3] = 1; block[x + 1, y + 3] = 1; block[x + 2, y + 3] = 1; block[x + 3, y + 3] = 1;
                    break;
                case 6:
                    Console.SetCursorPosition(y, x);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("####");
                    block[x, y] = 1; block[x + 1, y] = 1; block[x + 2, y] = 1; block[x + 3, y] = 1;
                    block[x + 3, y] = 1; block[x + 3, y + 1] = 1; block[x + 3, y + 2] = 1; block[x + 3, y + 3] = 1;
                    break;
                case 7:
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("####");
                    Console.SetCursorPosition(y, x);
                    Console.Write("####");
                    block[x + 3, y] = 1; block[x + 3, y + 1] = 1; block[x + 3, y + 2] = 1; block[x + 3, y + 3] = 1;
                    block[x, y] = 1; block[x, y + 1] = 1; block[x, y + 2] = 1; block[x, y + 3] = 1;
                    break;
                case 8:
                    Console.SetCursorPosition(y, x);
                    Console.Write("####");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("   #");
                    block[x, y] = 1; block[x, y + 1] = 1; block[x, y + 2] = 1; block[x, y + 3] = 1;
                    block[x, y + 3] = 1; block[x + 1, y + 3] = 1; block[x + 2, y + 3] = 1; block[x + 3, y + 3] = 1;
                    break;
                case 9:
                    Console.SetCursorPosition(y, x);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("####");
                    block[x, y + 3] = 1; block[x + 1, y + 3] = 1; block[x + 2, y + 3] = 1; block[x + 3, y + 3] = 1;
                    block[x + 3, y] = 1; block[x + 3, y + 1] = 1; block[x + 3, y + 2] = 1; block[x + 3, y + 3] = 1;
                    break;
                case 10:
                    Console.SetCursorPosition(y, x);
                    Console.Write("####");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("#  #");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("#  #");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("#  #");
                    block[x, y] = 1; block[x, y + 1] = 1; block[x, y + 2] = 1; block[x, y + 3] = 1;
                    block[x, y] = 1; block[x + 1, y] = 1; block[x + 2, y] = 1; block[x + 3, y] = 1;
                    block[x, y + 3] = 1; block[x + 1, y + 3] = 1; block[x + 2, y + 3] = 1; block[x + 3, y + 3] = 1;
                    break;
                case 11:
                    Console.SetCursorPosition(y, x);
                    Console.Write("####");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("#   ");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("####");
                    block[x, y] = 1; block[x, y + 1] = 1; block[x, y + 2] = 1; block[x, y + 3] = 1;
                    block[x, y] = 1; block[x + 1, y] = 1; block[x + 2, y] = 1; block[x + 3, y] = 1;
                    block[x + 3, y] = 1; block[x + 3, y + 1] = 1; block[x + 3, y + 2] = 1; block[x + 3, y + 3] = 1;
                    break;
                case 12:
                    Console.SetCursorPosition(y, x);
                    Console.Write("#  #");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("#  #");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("#  #");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("####");
                    block[x, y] = 1; block[x + 1, y] = 1; block[x + 2, y] = 1; block[x + 3, y] = 1;
                    block[x + 3, y] = 1; block[x + 3, y + 1] = 1; block[x + 3, y + 2] = 1; block[x + 3, y + 3] = 1;
                    block[x, y + 3] = 1; block[x + 1, y + 3] = 1; block[x + 2, y + 3] = 1; block[x + 3, y + 3] = 1;
                    break;
                case 13:
                    Console.SetCursorPosition(y, x);
                    Console.Write("####");
                    Console.SetCursorPosition(y, x + 1);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 2);
                    Console.Write("   #");
                    Console.SetCursorPosition(y, x + 3);
                    Console.Write("####");
                    block[x, y] = 1; block[x, y + 1] = 1; block[x, y + 2] = 1; block[x, y + 3] = 1;
                    block[x, y + 3] = 1; block[x + 1, y + 3] = 1; block[x + 2, y + 3] = 1; block[x + 3, y + 3] = 1;
                    block[x + 3, y] = 1; block[x + 3, y + 1] = 1; block[x + 3, y + 2] = 1; block[x + 3, y + 3] = 1;
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("##################################################### Time   :  ");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   # Score  :");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   # Energy :");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   # Mine   :" );
            Console.WriteLine("#                                                   #") ;
            Console.WriteLine("#                                                   #"); 
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #"); 
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#                                                   #");
            Console.WriteLine("#####################################################");

            int cursorx = 2, cursory = 1;   // position of cursor
            ConsoleKeyInfo cki;               // required for readkey
            

            int[,] block = new int[23,53];

            for (int i = 0; i < block.GetLength(0); i++)
            {
                for (int k = 0; k < block.GetLength(1); k++)
                {
                    block[i, k] = 0;
                }
            }
            for (int i = 0; i < block.GetLength(1); i++)
            {
                block[0, i] = 1;
                block[22, i] = 1;
            }
            for (int i = 0; i < block.GetLength(0); i++)
            {
                block[i,0]= 1;
                block[i, 52] = 1;
            }
            

            for (int i = 2; i < 22; i=i+5)
            {
                for (int k = 2; k < 52; k=k+5)
                {
                    Random rnd = new Random();
                    int pattern = rnd.Next(0,14);
                    walls(i,k,pattern,block);
                }
                
            }
            Console.SetCursorPosition(0,25);
            for (int i = 0; i < block.GetLength(0); i++)
            {
                for (int k = 0; k < block.GetLength(1); k++)
                {
                    Console.Write(block[i, k]); 
                }
                Console.WriteLine();
            }


            while (true)
            {
                if (Console.KeyAvailable)
                {       // true: there is a key in keyboard buffer
                    cki = Console.ReadKey(true);       // true: do not write character 

                    if (cki.Key == ConsoleKey.RightArrow && block[cursory,cursorx+1]!=1 )
                    {   // key and boundary control
                        Console.SetCursorPosition(cursorx, cursory);           // delete X (old position)
                        Console.WriteLine(" ");
                        cursorx++;
                    }
                    if (cki.Key == ConsoleKey.LeftArrow && block[cursory,cursorx-1]!=1)
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.WriteLine(" ");
                        cursorx--;
                    }
                    if (cki.Key == ConsoleKey.UpArrow && block[cursory-1,cursorx]!=1)
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.WriteLine(" ");
                        cursory--;
                    }
                    if (cki.Key == ConsoleKey.DownArrow && block[cursory+1,cursorx]!=1)
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.WriteLine(" ");
                        cursory++;
                    }
                    if (cki.Key == ConsoleKey.Escape) break;
                }


                Console.SetCursorPosition(cursorx, cursory);    // refresh X (current position)
                Console.WriteLine("X");

                
                Thread.Sleep(50);     // sleep 50 ms
            }


        }
    }
}
