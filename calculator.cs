using System;
					
public class Program
{
	public static void Main()
	{	

		// CALCULATOR FUNCTIONS
		static void Add() {
			Console.WriteLine("--- ADDITION ---");
			Console.WriteLine("Enter the first number");
			decimal num1 = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("Enter the second nubmer");
			decimal num2 = Convert.ToDecimal(Console.ReadLine());
			decimal ans = num1 + num2;
			Console.WriteLine($"\nAnswer: {ans}");
			Menu();
		}
		
		static void Subtract() {
			Console.WriteLine("--- SUBTRACTION ---");
			Console.WriteLine("Enter the first number");
			decimal num1 = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("Enter the second number");
			decimal num2 = Convert.ToDecimal(Console.ReadLine());
			decimal ans = num1 - num2;
			Console.WriteLine($"\nAnswer: {ans}");
			Menu();
		}
		
		static void Multiplication() {
			Console.WriteLine("--- MULTIPLICATION ---");
			Console.WriteLine("Enter the first number");
			decimal num1 = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("Enter the second number");
			decimal num2 = Convert.ToDecimal(Console.ReadLine());
			decimal ans = num1 * num2;
			Console.WriteLine($"\nAnswer: {ans}");
			Menu();
		}
		
		static void Division() {
			Console.WriteLine("---DIVISION ---");
			Console.WriteLine("Enter the first number");
			decimal num1 = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("Enter the second number");
			decimal num2 = Convert.ToDecimal(Console.ReadLine());
			decimal ans = num1 / num2;
			Console.WriteLine($"\nAnswer: {ans}");
			Menu();
		}

    // CALCULATOR MENU
		static void Menu() {
			Console.WriteLine("\n\n--- CALCULATOR ---");
			Console.WriteLine("[1] Addition \n[2] Subtraction \n[3] Multiplication \n[4] Division");
			string choice = Console.ReadLine();
			if (choice == "1") {
				Add();
			}
			else if (choice == "2") {
				Subtract();
			}
			else if (choice == "3") {
				Multiplication();
			}
			else if (choice == "4") {
				Division();
			}
		}

		// MAIN LOOP
		Menu();
	}
}
