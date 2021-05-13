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
        public class Game
        {
            static void Main(string[] args)
            {
                DungeonGame gameClass = new DungeonGame();
                gameClass.Intro();
            }
        }

        //which room player is in
        bool roomOne = true;
        bool roomTwo = false;
        bool roomThree = false;
        bool roomFour = false;
        bool roomFive = false;
        bool roomSix = false;

        //if the player has item or not
        bool hasKey = false;
        bool hasBroom = false;
        bool hasPlate = false;
        bool hasButterKnife = false;
        bool hasMug = false;

        public void Intro()
        {
            Console.WriteLine("insert game name here\n" +
                "\n" +
                "Press any key to begin");

            Console.ReadKey();

            NavRoomOne();
        }

        //roomNavigations
        public void NavRoomOne()
        {
            Console.Clear();
            RoomOne firstRoom = new RoomOne();
            while (roomOne)
            {
                Console.WriteLine(firstRoom.RoomDescription);
                Console.WriteLine("1. Go to door on left.\n" +
                "2. Go to door on right\n" +
                "3. Go to door straight ahead\n" +
                "4. Search Room");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        roomOne = false;
                        roomTwo = true;
                        NavRoomTwo();
                        break;
                    case "2":
                        roomOne = false;
                        roomThree = true;
                        NavRoomThree();
                        break;
                    case "3":
                        Exit();
                        break;
                    case "4":
                        roomOneSearch();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        public void NavRoomTwo()
        {
            Console.Clear();
            RoomTwo secondRoom = new RoomTwo();
            while (roomTwo)
            {
                Console.WriteLine(secondRoom.RoomDescription);
                Console.WriteLine("1. Go to door.\n" +
                "2. search room \n" +
                "3. Go back to entrance.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You open the door");
                        roomTwo = false;
                        roomFour = true;
                        NavRoomFour();
                        break;
                    case "2":
                        roomTwoSearch();
                        break;
                    case "3":
                        roomTwo = false;
                        roomOne = true;
                        NavRoomOne();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        public void NavRoomThree()
        {
            Console.Clear();
            RoomThree thirdRoom = new RoomThree();
            while (roomThree)
            {
                Console.WriteLine(thirdRoom.RoomDescription);
                Console.WriteLine("1. Go to door.\n" +
                    "2. Move shelf and enter wall opening\n" +
                    "3. search room \n" +
                    "4. Go back.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You open the door");
                        roomThree = false;
                        roomFive = true;
                        NavRoomFive();
                        break;
                    case "2":
                        roomThree = false;
                        roomSix = true;
                        NavRoomSix();
                        break;
                    case "3":
                        roomThreeSearch();
                        break;
                    case "4":
                        roomThree = false;
                        roomOne = true;
                        NavRoomOne();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        public void NavRoomFour()
        {
            Console.Clear();
            RoomFour fourthRoom = new RoomFour();
            while (roomFour)
            {
                Console.WriteLine(fourthRoom.RoomDescription);
                Console.WriteLine("1. Stay.\n" +
                "2. Leave");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //Poisoned();
                        break;
                    case "2":
                        roomFour = false;
                        roomTwo = true;
                        NavRoomTwo();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        public void NavRoomFive()
        {
            Console.Clear();
            RoomFive fifthRoom = new RoomFive();
            while (roomFive)
            {
                Console.WriteLine(fifthRoom.RoomDescription);
                Console.WriteLine("1. Stay and fight.\n" +
                "2. Come back when you're ready");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //BattleSequence();
                        break;
                    case "2":
                        roomFive = false;
                        roomThree = true;
                        NavRoomThree();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        public void NavRoomSix()
        {
            Console.Clear();
            RoomSix sixthRoom = new RoomSix();
            while (roomSix)
            {
                Console.WriteLine(sixthRoom.RoomDescription);
                Console.WriteLine("1. Approach fountain\n" +
                "2. Go back");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //Fountain();
                        break;
                    case "2":
                        roomSix = false;
                        roomThree = true;
                        NavRoomThree();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        //RoomSearchOptions
        public void roomOneSearch() 
        {
            Console.Clear();
            Console.WriteLine("You don't really find anything of interest\n" +
                "But you did see a heafty broom sitting in the corner.\n" +
                "It might be useful should you need to protect yourself.\n" +
                "\n" +
                "Take the broom? (y/n)");

            string yninput = Console.ReadLine();

            switch (yninput.ToLower())
            {
                case "y":
                    Console.WriteLine("You take the broom.\n" +
                        "\n" +
                        "Press any key to continue.");
                    hasBroom = true;
                    Console.ReadKey();
                    break;
                case "n":
                    Console.WriteLine("You leave the broom. You don't think you'll need it.\n" +
                        " \n" +
                        "Press any key to continue.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }
            Console.Clear();
        }

        public void roomTwoSearch() 
        {
            Console.Clear();
            Console.WriteLine("You see an open journal sitting on the desk, \n" +
                "and a faded sign on the door at the end of room.\n" +
                "\n" +
                "Which would you like to look at?\n" +
                "1. Journal\n" +
                "2. Sign\n" +
                "3. Neither\n" +
                " ");

            string roomTwoInput = Console.ReadLine();

            switch (roomTwoInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("You read the journal.\n" +
                        " \n" +
                        "My experiments have failed. Unfortunately the lab is completely unusable and has filled with a toxic gas. \n" +
                        "Fortunately there isn't anything important in there. \n" +
                        "I've put up a sign for now, in case a random adventurer should attempt to enter.\n" +
                        " \n" +
                        "press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("You notice a faded sign on the door. You can barely make the word BEWARE out.\n" +
                        " \n" +
                        "Press any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    NavRoomTwo();
                    break;
                default:
                    Console.WriteLine("not a valid input");
                    break;
            }
        }

        public void roomThreeSearch() 
        {
            Console.Clear();
            Console.WriteLine("You see a bunch of dishes and utensils on the table.\n" +
                "\n" +
                "Would you like to take one?\n" +
                "1. Take Plate\n" +
                "2. Take butter knife\n" +
                "3. Take mug");
            string utensilInput = Console.ReadLine();
            switch (utensilInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("You take the Plate.. You dont know how useful this will be.\n" +
                        "\n" +
                        "Press any key to continue..");

                    hasPlate = true;
                    hasButterKnife = false;
                    hasMug = false;

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("You take the butter knife.. You dont know how useful this will be.\n" +
                        "\n" +
                        "Press any key to continue..");

                    hasPlate = false;
                    hasButterKnife = true;
                    hasMug = false;

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("You take the mug.. You could really use a drink right now.\n" +
                        "\n" +
                        "Press any key to continue..");

                    hasPlate = false;
                    hasButterKnife = false;
                    hasMug = true;

                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        public void roomFiveSearch() { }
        public void roomSixSearch() { }




        public void Exit()
        {
            Console.Clear();
            if (hasKey == true)
            {
                Console.WriteLine("You managed to escape the dungeon!\n" +
                    "...What took you so long?");
            }
            else
            {
                Console.WriteLine("The door is locked.. You might be able to find a key somewhere \n" +
                    " \n" +
                    "Press any key to continue.");
                Console.ReadKey();
                NavRoomOne();
            }
        }



    }
}

