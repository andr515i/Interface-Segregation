using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
	public class Witch : IPaladin
	{
		public void Teleport(int x, int y)
		{
			Console.WriteLine("I'm teleporting to " + x + " " + y);
		}

		public void RaiseShield()
		{
			Console.WriteLine("I'm raising my shield");
		}

		public void ShieldGlare()
		{
			Console.WriteLine("I'm throwing shield glare");
		}

		public void Die()
		{
			Console.WriteLine("I'm dying");
		}
		public void Fight()
		{
			Console.WriteLine("I'm Fighting");
		}

		public void Heal()
		{
			Console.WriteLine("I'm healing");
		}
	}
}
