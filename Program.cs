using System;

namespace NextPrimeNumber
{
	class Program
	{
		static bool isPrime(int liczba)
		{
			if (liczba == 1)
			{
				return false;
			}

			for (int i = 2; i < liczba; i++)
			{
				if (liczba % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		static void Main(string[] args)
		{
			//program myta się o liczbę i wyświetla najbliższą liczbę pierwszą.
			//Dla 8 wynik to 7,
			//Dla 10 wynik to 11,
			//Dla 9 wynik to 11 powiedzmy że jeśli różnica jest taka sama to pokazujesz większą liczbę
			//Napisz do tego testy
			//Program ma działać tak długo, aż podasz komendę stop	
			//Program powinien wyświetlać wynik na konsoli oraz zapisywać do pliku
			
			Console.WriteLine("podaj jakąś liczbę dodatnią");
			string text = Console.ReadLine();
			
			while (text != "stop")
			{
				int liczba = int.Parse(text);
				bool pierwsza = isPrime(liczba);
				if (pierwsza == false)
				{
					liczba++;
					Console.WriteLine("Najbliższa liczba pierwsza to " + liczba);
					Console.WriteLine("podaj następną liczbę lub napisz 'stop' jeśli chcesz skończyć");
					text = Console.ReadLine();
					
				}
				else 
				{
					Console.WriteLine("Najbliższa liczba pierwsza to " + liczba);
					Console.WriteLine("podaj następną liczbę lub napisz 'stop' jeśli chcesz skończyć");
					text = Console.ReadLine();
					
				}

				var consoleOutput = new ConsoleOutputWriter();
				var consoleInput = new ConsoleInputReader();
				var primenumber = new PrimeNumber(consoleOutput, consoleInput);

				primenumber.number();

			}
			
		}
	}

}
	

