using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCards.Models.Questions
{
	public class Card : Question<bool>
	{
		public Card()
		{
			Type = QuestionType.CARD;
		}

		public string CorrectAnswer { get; set; }
		public override bool CheckAnswer(bool answer) => answer;
	}
}
