using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCards.Models.Questions
{
	public abstract class Question { }

	public abstract class Question<T> : Question
	{
		public string Text { get; set; }
		public QuestionType Type { get; protected set; }
		public abstract bool CheckAnswer(T answer);
	}

	public enum QuestionType
	{
		NONE = 0,
		CARD = 1,
		CHOICE_SINGLE = 2,
		CHOICE_MULTIPLE = 3,
		SHORT_ANSWER = 4,
		TRUE_OR_FALSE = 5
	}
}
