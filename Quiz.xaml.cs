namespace ScottsdaleSchoolScout;

public partial class Quiz : ContentPage
{
	public Quiz()
	{
		InitializeComponent();
        NextQuestion(Quizzing.allquestions[0]);
	}

    private void NextQuestion(Question question)
    {
        if (question == null) { Navigation.PushAsync(new Results()); return; }
        questionLabel.Text = question.questionText;
        if (question.responses.Length >= 1)
        {
            answer1.Text = question.responses[0].text;
            answer1.IsVisible = true;
        }
        else answer1.IsVisible = false;
        if (question.responses.Length >= 2)
        {
            answer2.Text = question.responses[1].text;
            answer2.IsVisible = true;
        }
        else answer2.IsVisible = false;
        if (question.responses.Length >= 3)
        {
            answer3.Text = question.responses[2].text;
            answer3.IsVisible = true;
        }
        else answer3.IsVisible = false;
        if (question.responses.Length >= 4)
        {
            answer4.Text = question.responses[3].text;
            answer4.IsVisible = true;
        }
        else answer4.IsVisible = false;
    }

	private void answer1_Clicked(object sender, EventArgs e)
	{
        NextQuestion(Quizzing.AnswerQuestion(Quizzing.currentQuestion, 0));
	}

    private void answer2_Clicked(object sender, EventArgs e)
    {
        NextQuestion(Quizzing.AnswerQuestion(Quizzing.currentQuestion, 1));
    }

    private void answer3_Clicked(object sender, EventArgs e)
    {
        NextQuestion(Quizzing.AnswerQuestion(Quizzing.currentQuestion, 2));
    }
    private void answer4_Clicked(object sender, EventArgs e)
    {
        NextQuestion(Quizzing.AnswerQuestion(Quizzing.currentQuestion, 3));
    }
}