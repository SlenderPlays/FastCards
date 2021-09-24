using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCards.Models.Questions
{
	public class SingleChoice : Question<int>
	{
		public SingleChoice()
		{
			Type = QuestionType.CHOICE_SINGLE;
		}

		public bool Shuffle { get; set; }
		public List<string> Choices { get; set; } = new List<string>();
		public int CorrectAnswer { get; set; } = -1;

		public override bool CheckAnswer(int answer) => answer == CorrectAnswer;
	}
}
