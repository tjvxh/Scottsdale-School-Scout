namespace ScottsdaleSchoolScout;

public partial class Results : ContentPage
{
	public Results()
	{
		InitializeComponent();
		int highestScore = -1000;
		string highestScoringSchool = "";
		foreach (string school in Quizzing.scores.Keys)
		{
			if (Quizzing.scores[school] > highestScore) { highestScore = Quizzing.scores[school]; highestScoringSchool = school; }
        }
		schoolName.Text = highestScoringSchool;
		schoolDescription.Text = Quizzing.results[highestScoringSchool].description;
        schoolLogo.Source = ImageSource.FromFile(Quizzing.results[highestScoringSchool].imageName);
	}

	private void backToStart_Clicked(object sender, EventArgs e)
	{
		Quizzing.scores = new Dictionary<string, int>
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
        Quizzing.currentQuestion = 0;
        Navigation.PopToRootAsync();
    }
}