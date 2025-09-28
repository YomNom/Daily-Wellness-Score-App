namespace yongjy_WellnessScore;

public partial class WellnessScore : ContentPage
{
	public WellnessScore()
	{
		InitializeComponent();
	}

    string choice = "Male";

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        choice = "Male";
        FrameMale.Stroke = Color.FromArgb("#0a0e29");
        FrameFemale.Stroke = Color.FromArgb("#fdfdfd");
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        choice = "Female";
        FrameMale.Stroke = Color.FromArgb("#fdfdfd");
        FrameFemale.Stroke = Color.FromArgb("#0a0e29");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        int sleep = int.Parse(LblSleep.Text);
        int stress = int.Parse(LblStress.Text);
        int activity = int.Parse(LblActivity.Text);
        int wellness_score = (sleep * 8) - (stress * 5) + (activity/2);

        // Cap wellness score between 0 and 100
        if (wellness_score > 100)
        {
            wellness_score = 100;
        }
        if (wellness_score < 0)
        {
            wellness_score = 0;
        }

        Navigation.PushAsync(new Wellness_Result(wellness_score, choice));
    }

}