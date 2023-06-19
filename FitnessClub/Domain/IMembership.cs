using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Domain
{
	internal interface IMembership
	{
		string Name { get; }

		string Description { get; set; }

		decimal GetPrice();
	}
}
