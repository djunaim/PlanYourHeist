﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            List<TeamMember> teamMembers = new List<TeamMember>();
            var difficultyLevel = new Bank();
            
            Console.WriteLine("Enter the difficulty level for the bank.");
            difficultyLevel.BankDifficultyLevel = int.Parse(Console.ReadLine());

            while (true)
            {

                Console.WriteLine("Please enter a team member's first name.");
                var teamMemberName = Console.ReadLine();
                if (teamMemberName == "") break;

                Console.WriteLine("Please enter team member's skill level between 0 to 50.");
                var teamMemberSkillLevel = int.Parse(Console.ReadLine());
                while (teamMemberSkillLevel < 0)
                {
                    Console.WriteLine("Sorry, please enter a skill level between 0 to 50.");
                    teamMemberSkillLevel = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Please enter team member's courage factor between 0.0 to 2.0.");
                var teamMemberCourageFactor = decimal.Parse(Console.ReadLine());
                while (teamMemberCourageFactor < 0.0m || teamMemberCourageFactor > 2.0m)
                {
                    Console.WriteLine("Sorry, please enter a skill level between 0.0 to 2.0.");
                    teamMemberCourageFactor = decimal.Parse(Console.ReadLine());
                }

                var teamMember = new TeamMember
                {
                    Name = teamMemberName,
                    SkillLevel = teamMemberSkillLevel,
                    CourageFactor = teamMemberCourageFactor
                };

                teamMembers.Add(teamMember);
            }
            
            Console.WriteLine("Please enter number of trial runs.");
            var trialRuns = int.Parse(Console.ReadLine());

            var successfulRuns = 0;
            var failedRuns = 0;

            for (int i = 0; i < trialRuns; i++)
            {   

                var outcome = difficultyLevel.RobBank(teamMembers);
                if (outcome)
                {
                    successfulRuns += 1;
                }
                else
                {
                    failedRuns += 1;
                }

            }

            Console.WriteLine($"There have been a {successfulRuns} number of successful runs and {failedRuns} number of failed runs.");

            var numOfMembers = teamMembers.Count();
            Console.WriteLine($"there are {numOfMembers} members");

            //foreach (var teamMember in teamMembers)
            //{
            //    Console.WriteLine($"{teamMember.Name} has a skill level of {teamMember.SkillLevel} and courage factor of {teamMember.CourageFactor}");
            //}        

        }
        
        //public static bool RobBank(Bank difficultyLevel, List<TeamMember> teamMembers)
        //{
        //    //var sumOfMembersSkill = 0;

        //    //foreach (var teamMember in teamMembers)
        //    //{
        //    //    sumOfMembersSkill += teamMember.SkillLevel;
        //    //}

        //    Random rnd = new Random();
        //    var luckValue = rnd.Next(-10, 10);

        //    var newDifficultyLevelWithLuck = difficultyLevel.BankDifficultyLevel + luckValue;

        //    var sumOfMembersSkill = teamMembers.Sum(teamMember => teamMember.SkillLevel);

        //    Console.WriteLine($"The team's combined skill level is {sumOfMembersSkill} and the bank's difficulty level {newDifficultyLevelWithLuck}");

        //    if (sumOfMembersSkill >= newDifficultyLevelWithLuck)
        //    {
        //        Console.WriteLine("You have conquered the bank!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Try again");
        //        return false;
        //    }

        //}

    }
}
