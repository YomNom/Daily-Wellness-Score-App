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

        // Default Message
        // If shown, means message hasn't been properly changed
        string message = "Error: Message not loaded"; 

        if (wellness_score < 40) { // Poor Condition
            if (choice == "Male")
            {
                message = "You are in Poor Condition\n- Rest today\n- Avoid strenuous workouts\n- Focus on hydration and 20–30 min of gentle walking.";
            } else
            {
                message = "You are in Poor Condition\n- Prioritize rest and self-care\n- Consider a short nap if possible\n- Gentle yoga/stretching only.";
            }
        } else if (wellness_score < 60) // Fair Condition
        {
            if (choice == "Male")
            {
                message = "You are in Fair Condition\n- Aim for +1 hour of sleep\n- Reduce caffeine after noon\n- Schedule light mobility or an easy walk.";
            } else
            {
                message = "You are in Fair Condition\n- Increase sleep consistency\n-Reduce evening screen time\n- Include calming routines like meditation or journaling.";
            }
        } else if (wellness_score < 80) // Good Condition
        {
            if (choice == "Male")
            {
                message = "You are in Good Condition\n- Improve recovery with an earlier bedtime\n- Add 15 min of light cardio or stretching\n- Keep hydration steady.";
            }
            else
            {
                message = "You are in Good Condition\n- Boost energy with a balanced breakfast\n- Add 15 min of walking\n- Focus on iron-rich foods if feeling low.";
            }
        }
        else // Excellent Condition
        {
            if (choice == "Male")
            {
                message = "You are in Excellent Condition\n- Maintain routine\n- Include resistance training 2–3× per week\n- Ensure protein intake across meals.";
            }
            else
            {
                message = "You are in Excellent Condition\n- Keep strong habits\n- Add yoga/pilates for recovery\n- Prioritize calcium + vitamin D intake.";
            }
        }
            DisplayAlert("Daily Wellness Report", $"Wellness Score: {wellness_score}\n\n{message}", "OK");
    }

}