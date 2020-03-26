using System;
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

            while (true)
            {
                Console.WriteLine("Please enter a team member's first name.");
                var teamMemberName = Console.ReadLine();
                if (teamMemberName == "") break;

                Console.WriteLine("Please enter team member's skill level between 0 to 50.");
                var teamMemberSkillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter team member's courage factor between 0.0 to 2.0.");
                var teamMemberCourageFactor = decimal.Parse(Console.ReadLine());

                var teamMember = new TeamMember
                {
                    Name = teamMemberName,
                    SkillLevel = teamMemberSkillLevel,
                    CourageFactor = teamMemberCourageFactor
                };

                teamMembers.Add(teamMember);

            }

            var numOfMembers = teamMembers.Count();
            Console.WriteLine($"there are {numOfMembers} members");

            //foreach (var teamMember in teamMembers)
            //{
            //    Console.WriteLine($"{teamMember.Name} has a skill level of {teamMember.SkillLevel} and courage factor of {teamMember.CourageFactor}");
            //}

            var sumOfMembersSkill = 0;
            foreach (var teamMember in teamMembers)
            {
                sumOfMembersSkill += teamMember.SkillLevel;
            }

            if (sumOfMembersSkill >= difficultyLevel.BankDifficultyLevel)
            {
                Console.WriteLine("You have conquered the bank!");
            }
            else
            {
                Console.WriteLine("Try again");
            }

        }
    }
}
