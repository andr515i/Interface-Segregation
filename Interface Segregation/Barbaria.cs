using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
	public class Babarian : IWarrior
	{
		public void Bash()
		{
			Console.WriteLine("I'm bashing someone");
		}

		public void Cleave()
		{
			Console.WriteLine("I'm cleaving someone");
		}

		public void Slash()
		{
			Console.WriteLine("I'm slashing someone");
		}

		public void Die()
		{
			Console.WriteLine("I'm dying");
		}

		public void Heal()
		{
			Console.WriteLine("I'm healing");
		}

		public void Fight()
		{
			Console.WriteLine("I'm Fighting");
		}
	}

}
