using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
	public class Wizard : IMage
	{
		public void ThrowMagicMisile()
		{
			Console.WriteLine("I'm throwing a magic missile");
		}

		public void ThrowFrostNova()
		{
			Console.WriteLine("I'm throwing my frost nova");
		}

		public void Teleport(int x, int y)
		{
			Console.WriteLine("I'm teleporting to " + x + " " + y);
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
			Console.WriteLine("I'm fighting");
		}
	}
}
