using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
	public interface ICharacter
	{
		void Heal();
		void Fight();
		void Die();
	}
}
