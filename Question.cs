using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottsdaleSchoolScout
{
	public class Question
	{
		public int questionNumber;
		public string questionText;
		public QuizResponse[] responses;
		public Question(int questionNumber, string questionText, QuizResponse[] responses) 
		{
			this.questionNumber = questionNumber;
			this.questionText = questionText;
			this.responses = responses;
		}
	}
}
