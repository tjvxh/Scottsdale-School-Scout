using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottsdaleSchoolScout
{
	public class QuizResponse
	{
		public string text;
		public Dictionary<string, int> influence;
		public QuizResponse(string text, Dictionary<string, int> influence) 
		{
			this.text = text;
			this.influence = influence;
		}
	}
}
