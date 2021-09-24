using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCards.Models
{
	public class CardSet
	{
		public string DisplayName { get; set; }
		public List<CardGroup> CardGroups { get; set; } = new List<CardGroup>();
		public List<Card> Cards { get; set; } = new List<Card>();
		// Cosmetic stuff such as Icon, ...
	}
}
