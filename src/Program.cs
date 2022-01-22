﻿using System;

namespace madlibs
{
    class program
    {
        public static void Main(string[] args)
        {
            //           Timo hates it so that's why im making it public into a repo
            //           I could probably make up an array list and yeah it would be faster,
            //           but for now it is what it is. I might update it in the future for more 
            //           optimization or even user created mad libs, but this is it fow now.
            // -Gabriel

            Console.WriteLine("Welcome to madLibz! Generating a new path.");
            Thread.Sleep(1500); //added for some feeling that what you're playing is humanlike
            NewLib();
        }

        public static void NewLib()
        {
            Random rnd = new Random();
            int num = rnd.Next(5);
            Console.WriteLine($"\nTaking path {num}.");
            Thread.Sleep(1000); //again, added for effect
            switch (num)
            {
                case 0:
                    Console.WriteLine("\nEnter an adjective: ");
                    string adj1 = Console.ReadLine();
                    Console.WriteLine("\nEnter an adjective: ");
                    string adj2 = Console.ReadLine();
                    Console.WriteLine("\nEnter a type of bird: ");
                    string bird = Console.ReadLine();
                    Console.WriteLine("\nEnter a room in a house: ");
                    string room = Console.ReadLine();
                    Console.WriteLine("\nEnter a verb in past tense: ");
                    string pastTense = Console.ReadLine();
                    Console.WriteLine("\nEnter a verb: ");
                    string verb = Console.ReadLine();
                    Console.WriteLine("\nEnter a relative's name: ");
                    string relative = Console.ReadLine();
                    Console.WriteLine("\nEnter a noun: ");
                    string noun1 = Console.ReadLine();
                    Console.WriteLine("\nEnter a liquid: ");
                    string liquid = Console.ReadLine();
                    Console.WriteLine("\nEnter a verd ending in -ing: ");
                    string verbIng1 = Console.ReadLine();
                    Console.WriteLine("\nEnter a part of the body, plural: ");
                    string parts = Console.ReadLine();
                    Console.WriteLine("\nEnter a plural noun: ");
                    string pluralNoun = Console.ReadLine();
                    Console.WriteLine("\nEnter a verb ending in -ing: ");
                    string verbIng2 = Console.ReadLine();
                    Console.WriteLine("\nEnter a noun: ");
                    string noun2 = Console.ReadLine();

                    Console.WriteLine($"\nIt was a {adj1}, cold November day. I woke up to the {adj1} smell of {bird} roasting in the {room} downstairs. I {pastTense} down the stairs to see if I could help {verb} the dinner. My mom said, 'See if needs a fresh {noun1}'. So I carried a tray of glasses full of {liquid} into the {verbIng1} room. When I got there, I couldn't beliebe my {parts}! There were {pluralNoun} {verbIng2} on the {noun2}!");
                    askNewLib();
                    break;

                case 1:
                    Console.WriteLine("\nEnter a noun: ");
                    noun1 = Console.ReadLine();
                    Console.WriteLine("\nEnter a plural noun: ");
                    string pluralNoun1 = Console.ReadLine();
                    Console.WriteLine("\nEnter a verb in present tense: ");
                    string presentTense1 = Console.ReadLine();
                    Console.WriteLine("\nEnter a verb in present tense: ");
                    string presentTense2 = Console.ReadLine();
                    Console.WriteLine("\nEnter a part of the body, plural: ");
                    parts = Console.ReadLine(); 
                    Console.WriteLine("\nEnter an adjective: ");
                    adj1 = Console.ReadLine();
                    Console.WriteLine("\nEnter a plural noun: ");
                    string pluralNoun2 = Console.ReadLine();
                    Console.WriteLine("\nEnter an adjective: ");
                    adj2 = Console.ReadLine();

                    Console.WriteLine($"\nToday, every student has a computer small enough to fit into his {noun1}. He can solve any math problem by simply pushing the computer's little {pluralNoun1}. Computers can add, multiply, divide and {presentTense1}. They can also {presentTense2} better than a human. Some computers are {parts}. Others have a/an {adj1} screen that shows all kinds of {pluralNoun2} and {adj2} figures");
                    askNewLib();
                    break;

                case 2:
                    Console.WriteLine("\nThis is a short one! ");
                    Console.WriteLine("\n\nEnter a noun: ");
                    noun1 = Console.ReadLine();
                    Console.WriteLine("\nEnter an adjective: ");
                    adj1 = Console.ReadLine();
                    Console.WriteLine("\nEnter a noun: ");
                    noun2 = Console.ReadLine();

                    Console.WriteLine($"\nAfter hiding the painting in his {noun1} for two years, he grew {adj1} and tried to sell it to a /an {noun2} in Florence, but was caught.");
                    askNewLib();
                    break;

                case 3:
                    Console.WriteLine("\nEnter a silly word: ");
                    string sillyWord = Console.ReadLine();
                    Console.WriteLine("\nEnter a last name: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("\nEnter an illness: ");
                    string illness = Console.ReadLine();
                    Console.WriteLine("\nEnter a plural noun: ");
                    pluralNoun = Console.ReadLine();
                    Console.WriteLine("\nEnter an adjective: ");
                    adj1 = Console.ReadLine();
                    Console.WriteLine("\nEnter an adjective: ");
                    adj2 = Console.ReadLine();
                    Console.WriteLine("\nEnter a silly word: ");
                    string sillyWord2 = Console.ReadLine();
                    Console.WriteLine("\nEnter a place: ");
                    string place = Console.ReadLine();
                    Console.WriteLine("\nEnter a number: ");
                    string number = Console.ReadLine();
                    Console.WriteLine("\nEnter an adjective: ");
                    string adj3 = Console.ReadLine();

                    Console.WriteLine($"\nDear School nurse: {sillyWord} {lastName} will not be attending school today. He/she has come down with a case of the {illness} and has horrible {pluralNoun} and a/an {adj1} fever. We have made an appointment with the {adj2} Dr. {sillyWord2}, who studied for many years in {place} and has {number} degrees in pediatrics. He will send you all the information you need. Thank you! Sincerely, Mrs. {adj3}");
                    askNewLib();
                    break;

                case 4:
                    Console.WriteLine("\nEnter a verb: ");
                    string verb1 = Console.ReadLine();
                    Console.WriteLine("\nEnter an adverb: ");
                    string adverb = Console.ReadLine();
                    Console.WriteLine("\nEnter a verb");
                    string verb2 = Console.ReadLine();
                    Console.WriteLine("\nEnter an adjective: ");
                    adj1 = Console.ReadLine();
                    Console.WriteLine("\nEnter a noun: ");
                    noun1 = Console.ReadLine();
                    Console.WriteLine("\nEnter a verb: ");
                    string verb3 = Console.ReadLine();

                    Console.WriteLine($"I {verb1} {adverb} through the shadowsm, letting them {verb2} me. But nothing seems {adj1}. There's no sign of any kind of {noun1}, no disruption of the needles on the ground. I've stopped for just am oment when I hear it. I have to {verb3} my head around to the side to be sure, but there it is again.");
                    askNewLib();
                    break;

                default:
                    Console.WriteLine("Not sure how this happened, but the program broke.");
                    System.Environment.Exit(1);
                    break;


            }
        }

        public static void askNewLib()
        {
            Console.WriteLine("\nWanna go again? y/n ");
            string answer = Console.ReadLine();
            while (answer != "y" && answer != "n")
            {
                Console.WriteLine($"\n'{answer}' is not y or n. Try again: ");
                Console.WriteLine("\nWanna go again? y/n ");
                answer = Console.ReadLine();
            }
            if (answer == "y")
            {
                NewLib();
            }
            else if (answer == "n")
            {
                Console.WriteLine("\nGoodbye!");
                System.Environment.Exit(0);
            }
        }
    }
}