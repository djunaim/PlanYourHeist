using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanYourHeist
{
    class Bank
    {
        public int BankDifficultyLevel { get; set; }

        // bank should own RobBank method instead of just in Program.cs
        public bool RobBank(List<TeamMember> teamMembers)
        {
            //var sumOfMembersSkill = 0;

            //foreach (var teamMember in teamMembers)
            //{
            //    sumOfMembersSkill += teamMember.SkillLevel;
            //}

            Random rnd = new Random();
            var luckValue = rnd.Next(-10, 10);

            var newDifficultyLevelWithLuck = BankDifficultyLevel + luckValue;

            var sumOfMembersSkill = teamMembers.Sum(teamMember => teamMember.SkillLevel);

            Console.WriteLine($"The team's combined skill level is {sumOfMembersSkill} and the bank's difficulty level {newDifficultyLevelWithLuck}");

            if (sumOfMembersSkill >= newDifficultyLevelWithLuck)
            {
                Console.WriteLine("You have conquered the bank!");
                return true;
            }
            else
            {
                Console.WriteLine("Try again");
                return false;
            }

        }
    }
}
