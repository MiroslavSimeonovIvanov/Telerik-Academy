/* The statement of the problem:
 * Implement the "Falling Rocks" game in the text console. 
 * A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). 
 * A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
 * Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. 
 * The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
 * Implement collision detection and scoring system.
 */

using System;
using System.Collections.Generic;
using System.Threading;

struct Dwarf
{
    public int x;
    public int y;
    public char c;
    public string dwarfBody;
    public ConsoleColor color;
}
public class FallingRocksGame
{
    static void PrintOnRock(int x, int y, string dwarfBody, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintOnPosition(int x, int y, string dwarfBody, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(dwarfBody);
    }

    public static void Settings()
    {
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 70;
    }

    static void Main()
    {
        int playGroundWidth = 50;
        int livesCount = 5;

        // Dwarf creation.
        Dwarf userDwarf = new Dwarf();
        userDwarf.x = 25;
        userDwarf.y = Console.WindowHeight - 1;
        userDwarf.dwarfBody = "(0)";
        userDwarf.color = ConsoleColor.DarkGray;

        // Random generator. 
        Random randomGenerator = new Random();

        List<Dwarf> rocks = new List<Dwarf>();

        while (true)
        {
            // Add rock.
            Dwarf newRocks = new Dwarf();
            newRocks.color = ConsoleColor.Blue;
            newRocks.x = randomGenerator.Next(0, playGroundWidth);
            newRocks.y = 0;
            newRocks.c = '#';
            rocks.Add(newRocks);

            // Print dwarf.
            PrintOnPosition(userDwarf.x, userDwarf.y, userDwarf.dwarfBody, userDwarf.c, userDwarf.color);

            // Print rocks.
            foreach (Dwarf rock in rocks)
            {
                PrintOnRock(rock.x, rock.y, rock.dwarfBody, rock.c, rock.color);
            }

            // Catch key.
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (userDwarf.x - 1 >= 0)
                    {
                        userDwarf.x = userDwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (userDwarf.x + 1 < playGroundWidth)
                    {
                        userDwarf.x = userDwarf.x + 1;
                    }
                }
            }

            // Check if there is a hit.
            foreach (var rock in rocks)
            {
                if (rock.y == userDwarf.y && rock.x == userDwarf.x)
                {
                    livesCount--;
                }
                else if (rock.y == userDwarf.y && rock.x + 1 == userDwarf.x)
                {
                    livesCount--;
                }
                else if (rock.y == userDwarf.y && rock.x + 2 == userDwarf.x)
                {
                    livesCount--;
                }
            }

            List<Dwarf> newList = new List<Dwarf>();

            for (int i = 0; i < rocks.Count; i++)
            {
                Dwarf oldRock = rocks[i];
                Dwarf newRock = new Dwarf();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;

                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }

            rocks = newList;

            Thread.Sleep(300);
            Console.Clear();

            if (livesCount <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("GAME OVER!");
                break;
            }
        }
    }
}
