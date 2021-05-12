using Pair_Programming.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming
{

    public class DungeonGame
    {
        bool roomOne = true;
        bool roomTwo = false;
        bool roomThree = false;
        bool roomFour = false;
        bool roomFive = false;

        public string NavRoomOne()
        {
            
            while (roomOne)
            {

                Console.WriteLine();
                Console.WriteLine("1. Go to door on left.\n" +
                "2. Go to door on right\n" +
                "3. Search Room");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You open the door");
                        roomOne = false;
                        roomTwo = true;
                        NavRoomTwo();
                        break;
                    case "2":
                        Console.WriteLine("You open the door");
                        break;
                    case "3":
                        Console.WriteLine("The door on the right has a sign saying \n" +
                            "BEWARE");
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }

            }
        }

        public string NavRoomTwo()
        {

            while (roomTwo)
            {

                Console.WriteLine(RoomOne.RoomDescription);
                Console.WriteLine("1. Go to door straight ahead.\n" +
                "2. Search Room");


                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You open the door");
                        roomTwo = false;
                        roomThree = true;
                        NavRoomThree();
                        break;
                    case "2":
                        Console.WriteLine("You search the room, but dont find anything");
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }

            }
        }

    }
