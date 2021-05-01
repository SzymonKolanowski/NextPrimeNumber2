using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PrimeNamberTest
{
	public class PrimeTest
	{
		[Fact]
		public void ShouldShowGreetingMessage_WithTestableOutputInput()
		{
			var testableOutput = new TestabelOutputWriter();
			var testableInput = new TestabelInputReader();
            var primenumber = new PrimeNumber(testableOutput, testableInput);

			primenumber.number();
			Assert.Equal("podaj jak¹œ liczbê dodatni¹", testableOutput.Outputs.First());

		}
	}

	//internal class PrimeNumber
	//{
	//	private TestabelOutputWriter testableOutput;
	//	private TestabelInputReader testableInput;

	//	public PrimeNumber(TestabelOutputWriter testableOutput, TestabelInputReader testableInput)
	//	{
	//		this.testableOutput = testableOutput;
	//		this.testableInput = testableInput;
	//	}

	//	internal void number()
	//	{
	//		throw new NotImplementedException();
	//	}
	//}

	public class TestabelOutputWriter : IOutputWriter
	{
		private readonly List<string> outputs = new List<string>();
		public IEnumerable<string> Outputs
		{
			get
			{
				return outputs;
			}
		}

		public void SendToOutput(string output)
        {
            outputs.Add(output);
        }
    }

	public interface IOutputWriter
	{
	}

	public class TestabelInputReader : IInputReader
    {
        public string Input { get; set; }
        public string GetInput()
        {
            return Input;
        }
    }

	public interface IInputReader
	{
	}
}
