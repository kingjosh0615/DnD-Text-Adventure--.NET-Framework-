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
        static void Main(string[] args)
        {
            Random rand = new Random();

            CharacterCreator PlayersCharacter = new CharacterCreator();
            PlayersCharacter.healthPoints = rand.Next(10, 20);
            PlayersCharacter.strength = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.strengthMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.dexterity = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.dexterityMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.constitution = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.constitutionMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.intelligence = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.intelligenceMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.wisdom = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.wisdomMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.charisma = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.charismaMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.initativeModifier = PlayersCharacter.dexterityMod;

            CharacterCreator AiCharacterOne = new CharacterCreator();
            AiCharacterOne.healthPoints = rand.Next(10, 20);
            AiCharacterOne.strength = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.strengthMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.strength - 10) / 2)));
            AiCharacterOne.dexterity = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.dexterityMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.strength - 10) / 2)));
            AiCharacterOne.constitution = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.constitutionMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.strength - 10) / 2)));
            AiCharacterOne.intelligence = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.intelligenceMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.strength - 10) / 2)));
            AiCharacterOne.wisdom = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.wisdomMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.strength - 10) / 2)));
            AiCharacterOne.charisma = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterOne.charismaMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterOne.strength - 10) / 2)));
            AiCharacterOne.initativeModifier = AiCharacterOne.dexterityMod;

            CharacterCreator AiCharacterTwo = new CharacterCreator();
            PlayersCharacter.healthPoints = rand.Next(10, 20);
            AiCharacterTwo.strength = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.strengthMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.strength - 10) / 2)));
            AiCharacterTwo.dexterity = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.dexterityMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.strength - 10) / 2)));
            AiCharacterTwo.constitution = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.constitutionMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.strength - 10) / 2)));
            AiCharacterTwo.intelligence = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.intelligenceMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.strength - 10) / 2)));
            AiCharacterTwo.wisdom = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.wisdomMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.strength - 10) / 2)));
            AiCharacterTwo.charisma = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            AiCharacterTwo.charismaMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((AiCharacterTwo.strength - 10) / 2)));
            AiCharacterTwo.initativeModifier = AiCharacterTwo.dexterityMod;

            string[] enemies = {"goblin", "troll", "skeleton", "ghoul", "skeleton"};

            string tempPlayerInput;
            string tempDoubleChoiceSwitch;

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

        }
    }
}