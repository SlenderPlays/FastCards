using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCards.Models.Questions
{
	public class TrueOrFalse : Question<bool>
	{
		public TrueOrFalse()
		{
			Type = QuestionType.TRUE_OR_FALSE;
		}

		public bool CorrectAnswer { get; set; }
		public override bool CheckAnswer(bool answer) => answer == CorrectAnswer;
	}
}
