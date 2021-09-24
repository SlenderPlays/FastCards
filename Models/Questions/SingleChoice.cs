using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCards.Models.Questions
{
	public class MultipleChoice : Question<IEnumerable<int>>
	{
		public MultipleChoice()
		{
			Type = QuestionType.CHOICE_MULTIPLE;
		}

		public bool Shuffle { get; set; }
		public List<string> Choices { get; set; } = new List<string>();
		public List<int> CorrectAnswers { get; set; } = new List<int>();

		public override bool CheckAnswer(IEnumerable<int> answer)
		{
			var correct = new HashSet<int>(CorrectAnswers);
			return correct.SetEquals(answer);
		}
	}
}
