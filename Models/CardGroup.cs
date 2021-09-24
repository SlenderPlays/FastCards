using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCards.Models
{
	public class CardGroup
	{
		public string DisplayName { get; set; }
		public List<Card> Cards { get; set; } = new List<Card>();
		// Shuffle questions in set, point total, cosmetics
	}
}
