using Android.Speech.Tts;

namespace yongjy_WellnessScore;

public partial class Wellness_Rec : ContentPage
{
	string gender = "No Gender Found";
	string status = "No Status Found";
	public Wellness_Rec(string status, string gender)
	{
		InitializeComponent();

		this.status = status;
		this.gender = gender;

        LblCondition.Text = status + " Condition"; 
        string message = "";

        if (gender == "Female")
        {
            if (status == "Poor")
            {
                message = "It is recommended that you:\n- Prioritize rest and self-care\n- Consider a short nap if possible\n- Gentle yoga/stretching only.";
            }
            else if (status == "Fair")
            {
                message = "It is recommended that you:\n- Increase sleep consistency\n-Reduce evening screen time\n- Include calming routines like meditation or journaling.";
            }
            else if (status == "Good")
            {
                message = "It is recommended that you:\n- Boost energy with a balanced breakfast\n- Add 15 min of walking\n- Focus on iron-rich foods if feeling low.";
            }
            else if (status == "Excellent")
            {
                message = "It is recommended that you:\n- Keep strong habits\n- Add yoga/pilates for recovery\n- Prioritize calcium + vitamin D intake.";
            }
        } else if (gender == "Male")         {
            if (status == "Poor")
            {
                message = "It is recommended that you:\n- Rest today\n- Avoid strenuous workouts\n- Focus on hydration and 20–30 min of gentle walking.";
            }
            else if (status == "Fair")
            {
                message = "It is recommended that you:\n- Aim for +1 hour of sleep\n- Reduce caffeine after noon\n- Schedule light mobility or an easy walk.";
            }
            else if (status == "Good")
            {
                message = "It is recommended that you:\n- Improve recovery with an earlier bedtime\n- Add 15 min of light cardio or stretching\n- Keep hydration steady.";
            }
            else if (status == "Excellent")
            {
                message = "It is recommended that you:\n- Maintain routine\n- Include resistance training 2–3× per week\n- Ensure protein intake across meals.";
            }
        } else { message = "Error: Message not loaded"; }

        LblRec.Text = message;
    }

    async void Back_Results(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void Go_Home(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WellnessScore());
    }
}