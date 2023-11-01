using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottsdaleSchoolScout
{
	public static class Quizzing
	{
		public static int currentQuestion = 0;
		public static Question[] allquestions =
		{
            // Question 1
            new Question(1, "What size school do you prefer?", new QuizResponse[]
				  {
					  new QuizResponse("Small", new Dictionary<string, int> {
				  { "Basis Scottsdale", 0 },
				  { "Scottsdale Prep", 0 },
				  { "Desert Mountain High School", 0 },
				  { "Chapparal High School", 0 },
				  { "Cicero Prep", 0 },
				  { "Saguaro High School", 0 },
				  { "Cactus Shadows High School", 0 },
				  { "Horizon High School", 0 },
				  { "Coronado High School", 0 },
				  { "Notre Dame Preparatory", 0 },
				  { "Rancho Solano Preparatory School", 1 }
			  }),
					  new QuizResponse("Medium", new Dictionary<string, int> {
				  { "Basis Scottsdale", 1 },
				  { "Scottsdale Prep", 1 },
				  { "Desert Mountain High School", 0 },
				  { "Chapparal High School", 0 },
				  { "Cicero Prep", 1 },
				  { "Saguaro High School", 0 },
				  { "Cactus Shadows High School", 0 },
				  { "Horizon High School", 0 },
				  { "Coronado High School", 1 },
				  { "Notre Dame Preparatory", 1 },
				  { "Rancho Solano Preparatory School", 0 }
			  }),
					  new QuizResponse("Large", new Dictionary<string, int> {
				  { "Basis Scottsdale", 1 },
				  { "Scottsdale Prep", 0 },
				  { "Desert Mountain High School", 2 },
				  { "Chapparal High School", 2 },
				  { "Cicero Prep", 0 },
				  { "Saguaro High School", 1 },
				  { "Cactus Shadows High School", 1 },
				  { "Horizon High School", 2 },
				  { "Coronado High School", 0 },
				  { "Notre Dame Preparatory", 0 },
				  { "Rancho Solano Preparatory School", 0 }
			  })
				  }),
			new Question(2, "How important are sports to you?", new QuizResponse[]
				  {
					  new QuizResponse("Unimportant", new Dictionary<string, int> {
						  { "Basis Scottsdale", 0 },
						  { "Scottsdale Prep", 0 },
						  { "Desert Mountain High School", 0 },
						  { "Chapparal High School", 0 },
						  { "Cicero Prep", 0 },
						  { "Saguaro High School", 0 },
						  { "Cactus Shadows High School", 0 },
						  { "Horizon High School", 0 },
						  { "Coronado High School", 0 },
						  { "Notre Dame Preparatory", 0 },
						  { "Rancho Solano Preparatory School", 0 }
	  }),
					  new QuizResponse("Moderately", new Dictionary<string, int> {
						  { "Basis Scottsdale", 0 },
						  { "Scottsdale Prep", 1 },
						  { "Desert Mountain High School", 1 },
						  { "Chapparal High School", 1 },
						  { "Cicero Prep", 1 },
						  { "Saguaro High School", 1 },
						  { "Cactus Shadows High School", 0 },
						  { "Horizon High School", 1 },
						  { "Coronado High School", -1 },
						  { "Notre Dame Preparatory", 2 },
						  { "Rancho Solano Preparatory School", 0 }
	  }),
					  new QuizResponse("Very important", new Dictionary<string, int> {
							  { "Basis Scottsdale", -1 },
							  { "Scottsdale Prep", 0 },
							  { "Desert Mountain High School", 2 },
							  { "Chapparal High School", 2 },
							  { "Cicero Prep", 0 },
							  { "Saguaro High School", 1 },
							  { "Cactus Shadows High School", 0 },
							  { "Horizon High School", 0 },
							  { "Coronado High School", -1 },
							  { "Notre Dame Preparatory", 2 },
							  { "Rancho Solano Preparatory School", 0 }
					  })
				  }),
			new Question(3, "Are you interested in participating in an IB Program?", new QuizResponse[]
				  {
					  new QuizResponse("Yes", new Dictionary<string, int> {
						  { "Basis Scottsdale", -1000 },
						  { "Scottsdale Prep", -1000 },
						  { "Desert Mountain High School", 2 },
						  { "Chapparal High School", -1000 },
						  { "Cicero Prep", -1000 },
						  { "Saguaro High School", -1000 },
						  { "Cactus Shadows High School", -1000 },
						  { "Horizon High School", -1000 },
						  { "Coronado High School", -1000 },
						  { "Notre Dame Preparatory", -1000 },
						  { "Rancho Solano Preparatory School", 2 }
					  }),
					  new QuizResponse("No", new Dictionary<string, int> {
					  { "Basis Scottsdale", 0 },
					  { "Scottsdale Prep", 0 },
					  { "Desert Mountain High School", 0 },
					  { "Chapparal High School", 0 },
					  { "Cicero Prep", 0 },
					  { "Saguaro High School", 0 },
					  { "Cactus Shadows High School", 0 },
					  { "Horizon High School", 0 },
					  { "Coronado High School", 0 },
					  { "Notre Dame Preparatory", 0 },
					  { "Rancho Solano Preparatory School", 0 }
	  })
				  }),
			new Question(4, "Are you interested in participating in an AP Program?", new QuizResponse[]
			  {
				  new QuizResponse("Yes", new Dictionary<string, int> {
						  { "Basis Scottsdale", 2 },
						  { "Scottsdale Prep", -1000 },
						  { "Desert Mountain High School", 1 },
						  { "Chapparal High School", 1 },
						  { "Cicero Prep", -1000 },
						  { "Saguaro High School", 1 },
						  { "Cactus Shadows High School", 1 },
						  { "Horizon High School", 1 },
						  { "Coronado High School", 1 },
						  { "Notre Dame Preparatory", 1 },
						  { "Rancho Solano Preparatory School", -1000 }
	  }),
				  new QuizResponse("No", new Dictionary<string, int> {
						  { "Basis Scottsdale", 0 },
						  { "Scottsdale Prep", 0 },
						  { "Desert Mountain High School", 0 },
						  { "Chapparal High School", 0 },
						  { "Cicero Prep", 0 },
						  { "Saguaro High School", 0 },
						  { "Cactus Shadows High School", 0 },
						  { "Horizon High School", 0 },
						  { "Coronado High School", 0 },
						  { "Notre Dame Preparatory", 0 },
						  { "Rancho Solano Preparatory School", 0 }



			  })
		  }),
			new Question(5, "What kind of school are you interested in?", new QuizResponse[]
			  {
				  new QuizResponse("Public", new Dictionary<string, int> {
						  { "Basis Scottsdale", -1000 },
						  { "Scottsdale Prep", -1000 },
						  { "Desert Mountain High School", 1 },
						  { "Chapparal High School", 1 },
						  { "Cicero Prep", -1000 },
						  { "Saguaro High School", 1 },
						  { "Cactus Shadows High School", 1 },
						  { "Horizon High School", 1 },
						  { "Coronado High School", 1 },
						  { "Notre Dame Preparatory", -1000 },
						  { "Rancho Solano Preparatory School", -1000 }
	  }),
				  new QuizResponse("Private", new Dictionary<string, int> {
						  { "Basis Scottsdale", -1000 },
						  { "Scottsdale Prep", -1000 },
						  { "Desert Mountain High School", -1000 },
						  { "Chapparal High School", -1000 },
						  { "Cicero Prep", -1000 },
						  { "Saguaro High School", -1000 },
						  { "Cactus Shadows High School", -1000 },
						  { "Horizon High School", -1000 },
						  { "Coronado High School", -1000 },
						  { "Notre Dame Preparatory", -1000 },
						  { "Rancho Solano Preparatory School", 1 }
	  }),
				  new QuizResponse("Charter", new Dictionary<string, int> {
						  { "Basis Scottsdale", 1 },
						  { "Scottsdale Prep", 1 },
						  { "Desert Mountain High School", -1000 },
						  { "Chapparal High School", -1000 },
						  { "Cicero Prep", 1 },
						  { "Saguaro High School", -1000 },
						  { "Cactus Shadows High School", -1000 },
						  { "Horizon High School", -1000 },
						  { "Coronado High School", -1000 },
						  { "Notre Dame Preparatory", -1000 },
						  { "Rancho Solano Preparatory School", -1000 }
	  }),
				  new QuizResponse("Religious", new Dictionary<string, int> {
						  { "Basis Scottsdale", -1000 },
						  { "Scottsdale Prep", -1000 },
						  { "Desert Mountain High School", -1000 },
						  { "Chapparal High School", -1000 },
						  { "Cicero Prep", -1000 },
						  { "Saguaro High School", -1000 },
						  { "Cactus Shadows High School", -1000 },
						  { "Horizon High School", -1000 },
						  { "Coronado High School", -1000 },
						  { "Notre Dame Preparatory", 1 },
						  { "Rancho Solano Preparatory School", -1000 }
	  })
			  }),
			new Question(6, "How important is an outdoor campus?", new QuizResponse[]
			  {
				  new QuizResponse("Unimportant", new Dictionary<string, int> {
						  { "Basis Scottsdale", 1 },
						  { "Scottsdale Prep", 1 },
						  { "Desert Mountain High School", 0 },
						  { "Chapparal High School", -1 },
						  { "Cicero Prep", 1 },
						  { "Saguaro High School", -1 },
						  { "Cactus Shadows High School", 0 },
						  { "Horizon High School", 1 },
						  { "Coronado High School", 1 },
						  { "Notre Dame Preparatory", -1 },
						  { "Rancho Solano Preparatory School", 0 }
	  }),
				  new QuizResponse("Moderately", new Dictionary<string, int> {
						  { "Basis Scottsdale", 1 },
						  { "Scottsdale Prep", 1 },
						  { "Desert Mountain High School", 0 },
						  { "Chapparal High School", 1 },
						  { "Cicero Prep", 0 },
						  { "Saguaro High School", 1 },
						  { "Cactus Shadows High School", 0 },
						  { "Horizon High School", 0 },
						  { "Coronado High School", -1 },
						  { "Notre Dame Preparatory", 1 },
						  { "Rancho Solano Preparatory School", 1 }
	  }),
				  new QuizResponse("Very Important", new Dictionary<string, int> {
						  { "Basis Scottsdale", 1 },
						  { "Scottsdale Prep", 2 },
						  { "Desert Mountain High School", 0 },
						  { "Chapparal High School", 2 },
						  { "Cicero Prep", -1 },
						  { "Saguaro High School", 1 },
						  { "Cactus Shadows High School", 0 },
						  { "Horizon High School", 0 },
						  { "Coronado High School", -1 },
						  { "Notre Dame Preparatory", 1 },
						  { "Rancho Solano Preparatory School", 2 }
	  })
			  }),
			new Question(7, "How important are extracurricular options to you?", new QuizResponse[]
				{
					new QuizResponse("Unimportant", new Dictionary<string, int> {
						{ "Basis Scottsdale", 0 },
						{ "Scottsdale Prep", 1 },
						{ "Desert Mountain High School", 0 },
						{ "Chapparal High School", 0 },
						{ "Cicero Prep", 1 },
						{ "Saguaro High School", 0 },
						{ "Cactus Shadows High School", 0 },
						{ "Horizon High School", 0 },
						{ "Coronado High School", 0 },
						{ "Notre Dame Preparatory", 0 },
						{ "Rancho Solano Preparatory School", 0 }
	}),
					new QuizResponse("Moderately", new Dictionary<string, int> {
						{ "Basis Scottsdale", 1 },
						{ "Scottsdale Prep", -1 },
						{ "Desert Mountain High School", 1 },
						{ "Chapparal High School", 1 },
						{ "Cicero Prep", -1 },
						{ "Saguaro High School", 1 },
						{ "Cactus Shadows High School", 1 },
						{ "Horizon High School", 1 },
						{ "Coronado High School", 1 },
						{ "Notre Dame Preparatory", 1 },
						{ "Rancho Solano Preparatory School", 1 }
	}),
					new QuizResponse("Very important", new Dictionary<string, int> {
						{ "Basis Scottsdale", 0 },
						{ "Scottsdale Prep", -1 },
						{ "Desert Mountain High School", 2 },
						{ "Chapparal High School", 2 },
						{ "Cicero Prep", -1 },
						{ "Saguaro High School", 1 },
						{ "Cactus Shadows High School", 1 },
						{ "Horizon High School", 2 },
						{ "Coronado High School", 1 },
						{ "Notre Dame Preparatory", 0 },
						{ "Rancho Solano Preparatory School", 0 }
	})
				}),
			new Question(8, "How important is a school's reputation to you?", new QuizResponse[]
				{
					new QuizResponse("Unimportant", new Dictionary<string, int> {
						{ "Basis Scottsdale", 0 },
						{ "Scottsdale Prep", 0 },
						{ "Desert Mountain High School", 0 },
						{ "Chapparal High School", 0 },
						{ "Cicero Prep", 0 },
						{ "Saguaro High School", 0 },
						{ "Cactus Shadows High School", 0 },
						{ "Horizon High School", 0 },
						{ "Coronado High School", 0 },
						{ "Notre Dame Preparatory", 0 },
						{ "Rancho Solano Preparatory School", 0 }
	}),
					new QuizResponse("Moderately", new Dictionary<string, int> {
						{ "Basis Scottsdale", 0 },
						{ "Scottsdale Prep", 0 },
						{ "Desert Mountain High School", -1 },
						{ "Chapparal High School", -1 },
						{ "Cicero Prep", 0 },
						{ "Saguaro High School", 0 },
						{ "Cactus Shadows High School", -1 },
						{ "Horizon High School", 0 },
						{ "Coronado High School", 0 },
						{ "Notre Dame Preparatory", -1 },
						{ "Rancho Solano Preparatory School", -1 }
	}),
					new QuizResponse("Very important", new Dictionary<string, int> {
						{ "Basis Scottsdale", -1 },
						{ "Scottsdale Prep", 0 },
						{ "Desert Mountain High School", -1 },
						{ "Chapparal High School", 0 },
						{ "Cicero Prep", 0 },
						{ "Saguaro High School", 1 },
						{ "Cactus Shadows High School", 0 },
						{ "Horizon High School", 1 },
						{ "Coronado High School", 0 },
						{ "Notre Dame Preparatory", 1 },
						{ "Rancho Solano Preparatory School", 1 }
	})
				}),
			new Question(9, "How important is a safe school environment to you?", new QuizResponse[]
				{
					new QuizResponse("Unimportant", new Dictionary<string, int> {
						{ "Basis Scottsdale", 0 },
						{ "Scottsdale Prep", 0 },
						{ "Desert Mountain High School", 0 },
						{ "Chapparal High School", 0 },
						{ "Cicero Prep", 0 },
						{ "Saguaro High School", 0 },
						{ "Cactus Shadows High School", 0 },
						{ "Horizon High School", 0 },
						{ "Coronado High School", 0 },
						{ "Notre Dame Preparatory", 0 },
						{ "Rancho Solano Preparatory School", 0 }
	}),
					new QuizResponse("Moderately", new Dictionary<string, int> {
						{ "Basis Scottsdale", 1 },
						{ "Scottsdale Prep", 1 },
						{ "Desert Mountain High School", 0 },
						{ "Chapparal High School", 0 },
						{ "Cicero Prep", 0 },
						{ "Saguaro High School", 1 },
						{ "Cactus Shadows High School", 0 },
						{ "Horizon High School", 0 },
						{ "Coronado High School", -1 },
						{ "Notre Dame Preparatory", 1 },
						{ "Rancho Solano Preparatory School", 1 }
	}),
					new QuizResponse("Very important", new Dictionary<string, int> {
						{ "Basis Scottsdale", 1 },
						{ "Scottsdale Prep", 2 },
						{ "Desert Mountain High School", 0 },
						{ "Chapparal High School", 0 },
						{ "Cicero Prep", -1 },
						{ "Saguaro High School", 1 },
						{ "Cactus Shadows High School", 0 },
						{ "Horizon High School", 0 },
						{ "Coronado High School", -1 },
						{ "Notre Dame Preparatory", 1 },
						{ "Rancho Solano Preparatory School", 2 }
	})
				}),
			new Question(10, "Which is more important to you: STEM or the Arts?", new QuizResponse[]
				{
					new QuizResponse("STEM", new Dictionary<string, int> {
						{ "Basis Scottsdale", 2 },
						{ "Scottsdale Prep", 0 },
						{ "Desert Mountain High School", 1 },
						{ "Chapparal High School", 1 },
						{ "Cicero Prep", 0 },
						{ "Saguaro High School", 1 },
						{ "Cactus Shadows High School", 1 },
						{ "Horizon High School", 1 },
						{ "Coronado High School", 1 },
						{ "Notre Dame Preparatory", 0 },
						{ "Rancho Solano Preparatory School", 1 }
	}),
					new QuizResponse("Arts", new Dictionary<string, int> {
						{ "Basis Scottsdale", 0 },
						{ "Scottsdale Prep", 1 },
						{ "Desert Mountain High School", 1 },
						{ "Chapparal High School", 1 },
						{ "Cicero Prep", 1 },
						{ "Saguaro High School", 1 },
						{ "Cactus Shadows High School", 1 },
						{ "Horizon High School", 1 },
						{ "Coronado High School", 1 },
						{ "Notre Dame Preparatory", 1 },
						{ "Rancho Solano Preparatory School", 2 }
	}),
					new QuizResponse("No preference", new Dictionary<string, int> {
						{ "Basis Scottsdale", 0 },
						{ "Scottsdale Prep", 0 },
						{ "Desert Mountain High School", 0 },
						{ "Chapparal High School", 0 },
						{ "Cicero Prep", 0 },
						{ "Saguaro High School", 0 },
						{ "Cactus Shadows High School", 0 },
						{ "Horizon High School", 0 },
						{ "Coronado High School", 0 },
						{ "Notre Dame Preparatory", 0 },
						{ "Rancho Solano Preparatory School", 0 }
	})
				})
		};
		public static Dictionary<string, int> scores = new Dictionary<string, int>
		{
			{"Basis Scottsdale", 0 },
			{ "Scottsdale Prep", 0 },
			{ "Desert Mountain High School", 0},
			{ "Chapparal High School", 0},
			{ "Cicero Prep", 0},
			{ "Saguaro High School", 0},
			{ "Cactus Shadows High School", 0},
			{ "Horizon High School", 0},
			{ "Coronado High School", 0},
			{ "Notre Dame Preparatory", 0},
			{ "Rancho Solano Preparatory School", 0},
		};
		public static Dictionary<string, Result> results = new Dictionary<string, Result>
		{
            {"Basis Scottsdale", new Result("basis.png", "Welcome to BASIS Scottsdale, home of the Bulldogs! Our tuition-free, public charter school serves students in grades 5–12. We are proud to be part of the BASIS Charter Schools network which has been providing world-class education since 1998. Our campuses follow a STEM-infused, liberal arts program designed to propel your student farther than they ever thought possible. Everyone at the Scottsdale campus is here to cultivate a love of learning, natural curiosity, and the desire to excel in your student. Their success is our success.\r\n\r\n") },
            { "Scottsdale Prep", new Result("scottsdaleprep.png", "Welcome to Great Hearts Scottsdale Prep, Serving Grades 6-12. Scottsdale Preparatory Academy is a state-chartered public school providing an honors-level liberal arts curriculum in the tradition of the finest independent private schools. As such, we offer an outstanding opportunity for families who want the very best in a college preparatory institution.\r\n\r\n") },
            { "Desert Mountain High School", new Result("dmhs.png", "Welcome to Desert Mountain High School! Desert Mountain High School is the newest of five high schools in the Scottsdale Unified School District. In 1998, Desert Mountain became an International Baccalaureate Member School and is a magnet program for the Scottsdale Unified School District. Desert Mountain offers students the choice of standard, honors, Advanced Placement and International Baccalaureate classes. Special programs are available for gifted (including Advanced Placement), English Language Learners and Special Education students. Extensive vocational programs are available through a partnership with the East Valley Institute of Technology (EVIT).\r\n\r\n")},
            { "Chapparal High School", new Result("chap.png", "Welcome to Chaparral High School! Chaparral High School is a public school in the Scottsdale Unified School District. Students have the opportunity to take Advanced Placement (AP) coursework and exams.")},
            { "Cicero Prep", new Result("cicero.png", "Welcome to Great Hearts Cicero Prep, serving Grades 6-12! Cicero Preparatory Academy is a state-chartered public school providing an honors-level liberal arts curriculum in the tradition of the finest independent private schools. As such, we offer an outstanding opportunity for families who want the very best in a college preparatory institution.")},
            { "Saguaro High School", new Result("saguaro.png", "Welcome to Saguaro High School! Saguaro High School is a public school in the Scottsdale Unified School District. Students have the opportunity to take Advanced Placement (AP) coursework and exams.")},
            { "Cactus Shadows High School", new Result("cactus.png", "Welcome to Cactus Shadows High School! Cactus Shadows High School has an outstanding reputation for producing highly successful students who are able to move on after high school to make an impact in our community, state, country and the world. Cactus Shadows has many academic opportunities and programs of study for various students with diverse backgrounds. We offer the International Baccalaureate program, Advanced Placement, Dual Enrollment, Honors Education and the Early College Program in partnership with Paradise Valley Community College.\r\n\r\n")},
            { "Horizon High School", new Result("horizon.png", "Welcome to Horizon High School! Horizon High School is a public high school in the Paradise Valley Unified School District. It emerges as an example of excellence in education and athletics. With a strong focus on promoting well-rounded development, Horizon offers a diverse range of athletic and academic programs that cater to the interests and talents of its students.")},
            { "Coronado High School", new Result("coronado.png", "Welcome to Coronado High School! Coronado High School is a public school in the Scottsdale Unified School District. Students have the opportunity to take Advanced Placement (AP) coursework and exams. ")},
            { "Notre Dame Preparatory", new Result("notredame.png", "Welcome to Notre Dame Preparatory! Notre Dame Preparatory is a Diocesan Catholic college preparatory high school in the Diocese of Phoenix. We are a co-ed Catholic high school known for academic excellence, inclusion, Christian service, and strong STEM, athletic, and arts programs. We are committed to strengthening the minds, bodies and souls of high school students by integrating faith into a challenging college preparatory curriculum. We promote academic excellence, instill moral values and encourage lifelong service to others.")},
            { "Rancho Solano Preparatory School", new Result("rancho.png", "Welcome to Rancho Solano Preparatory School! From Pre-K to 12th Grade, we offer students a safe, caring, and rigorous environment where they can excel and be successful. As a school that offers the International Baccalaureate Diploma program, we are inherently global in our thinking and welcome students and families from all over the world. We welcome the different cultures that students bring to the classroom and believe that these differences make us stronger. Our beautiful campuses, experienced faculty, and large course offerings make Rancho the best school for students to explore their passions and interests in depth. ")},
        };

		public static Question AnswerQuestion(int questionNumber, int responseNumber)
		{
			// Returns the next question if quiz isn't complete
			//Returns null if the quiz is complete

			QuizResponse response = allquestions[questionNumber].responses[responseNumber];
			foreach (string s in response.influence.Keys)
			{
				scores[s] += response.influence[s];
			}
            currentQuestion++;
			if (currentQuestion >= allquestions.Length) return null;
			else return allquestions[questionNumber + 1];
        }
	}
}
