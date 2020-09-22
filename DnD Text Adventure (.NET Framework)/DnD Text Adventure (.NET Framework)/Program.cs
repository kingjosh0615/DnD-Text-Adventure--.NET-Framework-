using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Text_Adventure__.NET_Framework_
{
    class Program
    {

        static bool QuestionConfirmationStopper = true;
        static string userInput;
        static string[] enemies = { "goblin", "troll", "skeleton", "ghoul", "skeleton" };
        static string currentEnemy;
        static int currentEnemyInitiative;
        static int currentPlayerInitiative;
        static int currentAIOneInitiative;
        static int currentAITwoInitiative;

        public static int maxHealthPoints1;
        public static int strength1;
        public static int strengthMod1;
        public static int dexterity1;
        public static int dexterityMod1;
        public static int constitution1;
        public static int constitutionMod1;
        public static int intelligence1;
        public static int intelligenceMod1;
        public static int wisdom1;
        public static int wisdomMod1;
        public static int charisma1;
        public static int charismaMod1;
        public static int initativeModifier1;

       public static int maxHealthPoints2;
        public static int strength2;
        public static int strengthMod2;
        public static int dexterity2;
        public static int dexterityMod2;
        public static int constitution2;
        public static int constitutionMod2;
        public static int intelligence2;
        public static int intelligenceMod2;
        public static int wisdom2;
        public static int wisdomMod2;
        public static int charisma2;
        public static int charismaMod2;
        public static int initativeModifier2;

        public static int maxHealthPoints3;
        public static int strength3;
        public static int strengthMod3;
        public static int dexterity3;
        public static int dexterityMod3;
        public static int constitution3;
        public static int constitutionMod3;
        public static int intelligence3;
        public static int intelligenceMod3;
        public static int wisdom3;
        public static int wisdomMod3;
        public static int charisma3;
        public static int charismaMod3;
        public static int initativeModifier3;


        public static void Main(string[] args)
        {

            Random rand = new Random();

            CharacterCreator PlayersCharacter = new CharacterCreator();
            PlayersCharacter.maxHealthPoints = rand.Next(10, 20);
            PlayersCharacter.strength = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.strengthMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.dexterity = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.dexterityMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.dexterity - 10) / 2)));
            PlayersCharacter.constitution = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.constitutionMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.constitution - 10) / 2)));
            PlayersCharacter.intelligence = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.intelligenceMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.intelligence - 10) / 2)));
            PlayersCharacter.wisdom = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.wisdomMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.wisdom - 10) / 2)));
            PlayersCharacter.charisma = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.charismaMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.charisma - 10) / 2)));
            PlayersCharacter.initativeModifier = PlayersCharacter.dexterityMod;

            CharacterCreator AiCharacterOne = new CharacterCreator();
            AiCharacterOne.maxHealthPoints = rand.Next(10, 20);
            AiCharacterOne.strength = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.strengthMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.strength - 10) / 2)));
            AiCharacterOne.dexterity = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.dexterityMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.dexterity - 10) / 2)));
            AiCharacterOne.constitution = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.constitutionMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.constitution - 10) / 2)));
            AiCharacterOne.intelligence = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.intelligenceMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.intelligence - 10) / 2)));
            AiCharacterOne.wisdom = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.wisdomMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.wisdom - 10) / 2)));
            AiCharacterOne.charisma = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.charismaMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.charisma - 10) / 2)));
            AiCharacterOne.initativeModifier = AiCharacterOne.dexterityMod;

            CharacterCreator AiCharacterTwo = new CharacterCreator();
            AiCharacterTwo.maxHealthPoints = rand.Next(10, 20);
            AiCharacterTwo.strength = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.strengthMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.strength - 10) / 2)));
            AiCharacterTwo.dexterity = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.dexterityMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.dexterity - 10) / 2)));
            AiCharacterTwo.constitution = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.constitutionMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.constitution - 10) / 2)));
            AiCharacterTwo.intelligence = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.intelligenceMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.intelligence - 10) / 2)));
            AiCharacterTwo.wisdom = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.wisdomMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.wisdom - 10) / 2)));
            AiCharacterTwo.charisma = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.charismaMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.charisma - 10) / 2)));
            AiCharacterTwo.initativeModifier = AiCharacterTwo.dexterityMod;

             maxHealthPoints1; PlayersCharacter.maxHealthPoints
             strength1 = PlayersCharacter.strength
             strengthMod1 = PlayersCharacter.strengthMod
             dexterity1 = PlayersCharacter.dexterity
             dexterityMod1 = PlayersCharacter.dexterityMod
             constitution1 = PlayersCharacter.constitution
             constitutionMod1 = PlayersCharacter.constitutionMod
             intelligence1 = PlayersCharacter.intelligence
             intelligenceMod1 = PlayersCharacter.intelligenceMod
             wisdom1 = PlayersCharacter.wisdom
             wisdomMod1 PlayersCharacter.wisdomMod
             charisma1 PlayersCharacter.charisma
             charismaMod1 PlayersCharacter.charismaMod
             initativeModifier1 PlayersCharacter.initativeModifier

             maxHealthPoints2;
             strength2;
             strengthMod2;
             dexterity2;
             dexterityMod2;
             constitution2;
             constitutionMod2;
             intelligence2;
             intelligenceMod2;
             wisdom2;
             wisdomMod2;
             charisma2;
             charismaMod2;
             initativeModifier2;

             maxHealthPoints3;
             strength3;
             strengthMod3;
             dexterity3;
             dexterityMod3;
             constitution3;
             constitutionMod3;
             intelligence3;
             intelligenceMod3;
             wisdom3;
             wisdomMod3;
             charisma3;
             charismaMod3;
             initativeModifier3;

        string tempPlayerInput;
            string tempDoubleChoiceSwitch;

            EnemyEncounter();
            Console.WriteLine("You are going over to friend's house to play Dungeons and Dragons. You need to make you character for the campaign before you can play.");
            Console.WriteLine("Input your character's name.");
            PlayersCharacter.characterName = Console.ReadLine();
            Console.WriteLine("Now you need to pick you class. Your friends already picked most of the classes so now you can choose rouge or cleric.");
            PlayersCharacter.characterClass = DoubleQuestionConfirmation("Rouge", "Cleric");
            Console.WriteLine("Time to choose your race. Would you like to be an elf, dwarf, or human?");
            PlayersCharacter.characterRace = TripleQuestionConfirmation("Elf", "Dwarf", "Human");
            Console.WriteLine("What would you like as a sidearm, sword, dagger, or blunderbuss?");
            PlayersCharacter.sideArm = TripleQuestionConfirmation("sword", "dagger", "blunderbuss");

            AiCharacterOne.characterClass = "Mage";
            AiCharacterTwo.characterClass = "Paladin";
            AiCharacterOne.characterName = "Eric";
            AiCharacterTwo.characterName = "Ben";
            AiCharacterOne.characterRace = "Elf";
            AiCharacterTwo.characterRace = "Dwarf";
            AiCharacterOne.sideArm = "sword";
            AiCharacterTwo.sideArm = "warhammer";

            Console.WriteLine($"Alright so you are a {PlayersCharacter.characterRace} {PlayersCharacter.characterClass} named {PlayersCharacter.characterName}. Sounds like a pretty good build to me.");
            Console.WriteLine($"Your friends also made characters! They made a {AiCharacterOne.characterRace} {AiCharacterOne.characterClass} named {AiCharacterOne.characterName} and a {AiCharacterTwo.characterRace} {AiCharacterTwo.characterClass} named {AiCharacterTwo.characterName}.");

            Console.WriteLine("You begin your hunt for the Lich's treasure at the enterance of his labyrinth.");
            


        }
        public static string DoubleQuestionConfirmation(string optionOne, string optionTwo)
        {
                userInput = Console.ReadLine();
                if (userInput.ToLower() == optionOne.ToLower())
                {
                    QuestionConfirmationStopper = false;
                    return optionOne;
                }
                else if (userInput.ToLower() == optionTwo.ToLower())
                {
                    QuestionConfirmationStopper = false;
                    return optionTwo;
                }
                else if (userInput.ToLower() != optionOne.ToLower() || userInput.ToLower() != optionTwo.ToLower())
                {
                    Console.WriteLine("Please input a valid answer.");
                    //QuestionConfirmationStopper = true;
                    DoubleQuestionConfirmation(optionOne, optionTwo);
                    return "error";
                }
                else
                {
                DoubleQuestionConfirmation(optionOne, optionTwo);
                return "error";
                }   
            
        }
        public static string TripleQuestionConfirmation(string optionOne, string optionTwo, string optionThree)
        {
            userInput = Console.ReadLine();
            if (userInput.ToLower() == optionOne.ToLower())
                {
                    QuestionConfirmationStopper = false;
                    return optionOne;
                }
                else if (userInput.ToLower() == optionTwo.ToLower())
                {
                    QuestionConfirmationStopper = false;
                    return optionTwo;
                }
                else if (userInput.ToLower() == optionThree.ToLower())
                {
                    QuestionConfirmationStopper = false;
                    return optionThree;
                }
                else if (userInput.ToLower() != optionOne.ToLower() || userInput.ToLower() != optionTwo.ToLower() || userInput.ToLower() != optionThree.ToLower())
                {

                    Console.WriteLine("Please input a valid answer.");
                    //QuestionConfirmationStopper = true;
                    TripleQuestionConfirmation(optionOne, optionTwo, optionThree);
                    return "error";
                }
                else
                {
                    return "error";
                }
            
        }
        public static void EnemyEncounter()
        {
            Random rand = new Random();

            
            

            Console.WriteLine($"The charisma is {PlayersCharacter.charisma}");
            currentEnemy = enemies[Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 6) - 1)))];
            currentEnemyInitiative = Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 21) - 1)));
            currentPlayerInitiative = Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 21) - 1)));
            currentAIOneInitiative = Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 21) - 1)));
            currentAITwoInitiative = Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 21) - 1)));

            Console.WriteLine($"Oh no! You encountered a {currentEnemy}!");

            Console.WriteLine();
            //while ()
        }
    }
}