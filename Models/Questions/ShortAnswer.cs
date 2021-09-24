using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCards.Models.Questions
{
	public class ShortAnswer : Question<string>
	{
		public ShortAnswer()
		{
			Type = QuestionType.SHORT_ANSWER;
		}

		public List<string> CorrectAnswers { get; set; } = new List<string>();
		public override bool CheckAnswer(string answer)
		{
			answer = answer.Replace("\n", "")
						   .Replace("\r", "")
						   .Trim();

			return CorrectAnswers.Contains(answer);
		}
	}
}
