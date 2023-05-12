using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
	public interface IMage : ICharacter
	{
		void ThrowMagicMisile();
		void ThrowFrostNova();
		void Teleport(int x, int y);
	}
}
