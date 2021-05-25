using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Text_Adventure__.NET_Framework_
{

    class Enemy_Encounter
    {
        public static void EnemyEncounterEvent()
        {
            Random rand = new Random();





            Program.currentEnemy = Program.enemies[Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 6) - 1)))];
            Program.currentEnemyInitiative = Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 21) - 1)));
            Program.currentPlayerInitiative = Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 21) - 1)));
            Program.currentAIOneInitiative = Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 21) - 1)));
            Program.currentAITwoInitiative = Convert.ToInt32(Math.Floor(Convert.ToDouble(rand.Next(1, 21) - 1)));

            Console.WriteLine($"Oh no! You encountered a {Program.currentEnemy}!");

            Console.WriteLine($"You and your friends begin to roll for initiative.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"You roll a {Program.currentPlayerInitiative}, {Program.name2} rolls a {Program.currentAIOneInitiative}, {Program.name3} rolls a {Program.currentAITwoInitiative}, and the {Program.currentEnemy} rolls a {Program.currentEnemyInitiative}");


            //while (cu)
        }
    }
}
