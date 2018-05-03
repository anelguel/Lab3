using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	/*Lab 3
	 * Task: Display a table of powers.
	 * The application will:
	 * 1. Ask for user input of an interger.
	 * 2. Display a table of squares and cubes from 1 to the value entered.
	 * 3. Prompts the user to continue.
	 * Build specifications:
	 * 1. Assume the user will enter valid data.
	 */
	class Program
	{
		static void Main(string[] args)
		{
			bool run = true;
			while (run == true)
			{
				Console.WriteLine("Learn your squares and cubes! \nPlease enter an interger:");
				int input = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Number" + "\t \t \t" + "Squared" + "\t \t \t" + "Cubed" + "\n" + "======" + "\t \t \t" + "======" + "\t \t \t" + "======");
				for (int i = 1; i < input + 1; i++)

				{
					int number = i;
					int squared = i * i;
					int cubed = i * i * i;
					Console.WriteLine(number + "\t \t \t" + squared + "\t \t \t" + cubed);
				}
				run = Continue();
			}
		}
		public static bool Continue()
		{
			Console.WriteLine("Do you wish to continue? y/n");
			string input = Console.ReadLine();
			input = input.ToLower();
			bool goOn;
			if (input == "y")
			{
				goOn = true;
			}
			else if (input == "n")
			{
				goOn = false;
			}
			else
			{
				Console.WriteLine("I don't understand that, let's try again");
				goOn = Continue();
			}
			return goOn;
		}
	}
}