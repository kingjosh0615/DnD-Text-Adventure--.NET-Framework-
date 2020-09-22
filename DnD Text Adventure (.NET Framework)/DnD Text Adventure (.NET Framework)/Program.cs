using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Text_Adventure__.NET_Framework_
{
    class Program
    {

        public static bool QuestionConfirmationStopper = true;
        public static string userInput;
        public static string[] enemies = { "goblin", "troll", "skeleton", "ghoul", "skeleton" };
        public static string currentEnemy;
        public static int currentEnemyInitiative;
        public static int currentPlayerInitiative;
        public static int currentAIOneInitiative;
        public static int currentAITwoInitiative;

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
        public static string sidearm1;
        public static string name1;
        public static int currentPlayerHealth;

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
        public static string sidearm2;
        public static string name2;
        public static int currentAIOneHealth;

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
        public static string sidearm3;
        public static string name3;
        public static int CurrentAITwoHealth;

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
            PlayersCharacter.sideArm = "hand";
            PlayersCharacter.characterName = "hand";
           
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
            AiCharacterOne.sideArm = "hand";
            AiCharacterOne.characterName = "hand";
           
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
            AiCharacterTwo.sideArm = "hand";
            AiCharacterTwo.characterName = "hand";
           
            maxHealthPoints1 = PlayersCharacter.maxHealthPoints;
            strength1 = PlayersCharacter.strength;
            strengthMod1 = PlayersCharacter.strengthMod;
            dexterity1 = PlayersCharacter.dexterity;
            dexterityMod1 = PlayersCharacter.dexterityMod;
            constitution1 = PlayersCharacter.constitution;
            constitutionMod1 = PlayersCharacter.constitutionMod;
            intelligence1 = PlayersCharacter.intelligence;
            intelligenceMod1 = PlayersCharacter.intelligenceMod;
            wisdom1 = PlayersCharacter.wisdom;
            wisdomMod1 = PlayersCharacter.wisdomMod;
            charisma1 = PlayersCharacter.charisma;
            charismaMod1 = PlayersCharacter.charismaMod;
            initativeModifier1 = PlayersCharacter.initativeModifier;
            sidearm1 = PlayersCharacter.sideArm;
            name1 = PlayersCharacter.characterName;
            currentPlayerHealth = PlayersCharacter.maxHealthPoints;
           
            maxHealthPoints2 = AiCharacterOne.maxHealthPoints;
            strength2 = AiCharacterOne.strength;
            strengthMod2 = AiCharacterOne.strengthMod;
            dexterity2 = AiCharacterOne.dexterity;
            dexterityMod2 = AiCharacterOne.dexterityMod;
            constitution2 = AiCharacterOne.constitution;
            constitutionMod2 = AiCharacterOne.constitutionMod;
            intelligence2 = AiCharacterOne.intelligence;
            intelligenceMod2 = AiCharacterOne.intelligenceMod;
            wisdom2 = AiCharacterOne.wisdom;
            wisdomMod2 = AiCharacterOne.wisdomMod;
            charisma2 = AiCharacterOne.charisma;
            charismaMod2 = AiCharacterOne.charismaMod;
            initativeModifier2 = AiCharacterOne.initativeModifier;
            sidearm2 = AiCharacterOne.sideArm;
            name2 = AiCharacterOne.characterName;
            currentAIOneHealth = AiCharacterOne.maxHealthPoints;

            maxHealthPoints3 = AiCharacterTwo.maxHealthPoints;
            strength3 = AiCharacterTwo.strength;
            strengthMod3 = AiCharacterTwo.strengthMod;
            dexterity3 = AiCharacterTwo.dexterity;
            dexterityMod3 = AiCharacterTwo.dexterityMod;
            constitution3 = AiCharacterTwo.constitution;
            constitutionMod3 = AiCharacterTwo.constitutionMod;
            intelligence3 = AiCharacterTwo.intelligence;
            intelligenceMod3 = AiCharacterTwo.intelligenceMod;
            wisdom3 = AiCharacterTwo.wisdom;
            wisdomMod3 = AiCharacterTwo.wisdomMod;
            charisma3 = AiCharacterTwo.charisma;
            charismaMod3 = AiCharacterTwo.charismaMod;
            initativeModifier3 = AiCharacterTwo.initativeModifier;
            sidearm3 = AiCharacterTwo.sideArm;
            name3 = AiCharacterTwo.characterName;
            CurrentAITwoHealth = AiCharacterTwo.maxHealthPoints;

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
            Console.WriteLine("What is your weapon of choice, A sword, dagger, or blunderbuss?");
            sidearm1 = TripleQuestionConfirmation("sword", "dagger", "blunderbuss");

            AiCharacterOne.characterClass = "Mage";
            AiCharacterTwo.characterClass = "Paladin";
            name2 = "Eric";
            name3 = "Tim";
            AiCharacterOne.characterRace = "Elf";
            AiCharacterTwo.characterRace = "Dwarf";
            sidearm2 = "sword";
            sidearm3 = "warhammer";

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
        
    }
}