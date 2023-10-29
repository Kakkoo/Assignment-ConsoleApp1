using System;

using ClassLibrary1;
using ConsoleApp2;

namespace ConsoleApp1
{
	internal class Program
	{
		private static void Main(string[] args)
		{

			//int num1, num2, num3;
			//num1 = 10;
			//num2 = 20;
			//num3 = 30;
			//double sum;
			//sum = Add(num1, num2, num3);
			//double avg;
			//avg = sum / 3;
			//static int Add(int num1, int num2, int num3)
			//{
			//	int sum = num1 + num2 + num3;
			//	return sum;
			//}
			//Console.WriteLine(avg);

			Customer customer = new Customer();
			Console.WriteLine(customer.customerName);

			AssignmentClass instructor = new AssignmentClass();
			
			instructor.Instructor("Suraj", 3, 5, new[] { "Java", ".NET" });
			Console.WriteLine(instructor);

			bool CheckSkill = instructor.CheckSkill("Java");
			Console.WriteLine(CheckSkill);

			bool ValidateEligibility = instructor.validateEligibility();
			Console.WriteLine(ValidateEligibility);
				

			for (int i = 0; i <= 10; i = i + 2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Hello, World!");
		}
	}
	//class Bottle
	//{
	//	int capacity;
	//	int currentVolume;
	//	string color;
	//	string material;

	//	void Fill (int volumeFilled)
	//	{
	//		currentVolume = currentVolume + volumeFilled;
	//		if(currentVolume > capacity)
	//		{
	//			currentVolume = capacity;
	//		}

	//			}
	//	void Drink (int volumeDrank) {
	//	currentVolume = currentVolume - volumeDrank;
	//		if(currentVolume < 0) {
	//			currentVolume = 0;
	//		}
	//	}
	//}

}

