using FitnessClub.Factories;

namespace MyApp // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(">>> Welcome to FitnessClub CRM<<<\n");
			Console.WriteLine(">Enter the membership type you want to create: ");

			Console.WriteLine("> G - Gym");
			Console.WriteLine("> P - Gym + Pool");

			Console.WriteLine("> T - Personal Training");

			string membershipName = Console.ReadLine();

			var factory = GetMembershipFactory(membershipName);
			var membership = factory.GetMembership();

			Console.WriteLine("\n> Membership you've just created: \n");
			Console.WriteLine(
				$"\tName:\t\t{membership.Name}\n" +
				$"\tDescription:\t{membership.Description}\n" +
				$"\tPrice:\t\t{membership.GetPrice()}");

			Console.ReadLine();
		}

		private static MembershipFactory GetMembershipFactory(string membershipType) =>
			membershipType.ToLower() switch
			{
				"g" => new GymMemberShipFactory(100, "Basic membership"),
				"p" => new GymPlusPoolMembershipFactory(250, "Good price membership"),
				"t" => new PersonalTrainingMembershipFactory(400, "Best for proffesionals"),
				_ => null
			};
	}
}