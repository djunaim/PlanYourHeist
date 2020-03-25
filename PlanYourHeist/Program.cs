using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            var teamMember1 = new TeamMember();

            Console.WriteLine("Please enter a team member's first name.");
            teamMember1.Name = Console.ReadLine();

            Console.WriteLine("Please enter team member's skill level between 0 to 10.");
            teamMember1.SkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter team member's courage factor between 0.0 to 2.0.");
            teamMember1.CourageFactor = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{teamMember1.Name} has a skill level of {teamMember1.SkillLevel} and courage factor of {teamMember1.CourageFactor}");
        }
    }
}
