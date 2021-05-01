using System;
using System.Collections.Generic;
using System.Text;

namespace NextPrimeNumber
{
	public class PrimeNumber
	{
		private readonly IOutputWriter outputWriter;
		private readonly IInputReader inputReader;

		public PrimeNumber(IOutputWriter outputWriter, IInputReader inputReader)
		{
			this.outputWriter = outputWriter;
			this.inputReader = inputReader;
		}

		public string PlayerNumber { get; private set; }

		public void number()
		{
			outputWriter.SendToOutput("podaj jakąś liczbę dodatnią");
			PlayerNumber = inputReader.GetInput();
			outputWriter.SendToOutput("Najbliższa liczba pierwsza to " + PlayerNumber);
		}
	}
	public interface IOutputWriter
	{
		void SendToOutput(string output);
	}

	public interface IInputReader
	{
		string GetInput();
	}

	public class ConsoleOutputWriter : IOutputWriter
	{
		public void SendToOutput(string output)
		{
			Console.WriteLine(output);
		}
	}

	public class ConsoleInputReader : IInputReader
	{
		public string GetInput()
		{
			return Console.ReadLine();
		}
	}
}
