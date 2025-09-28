namespace yongjy_WellnessScore;

public partial class Wellness_Result : ContentPage
{
    string gender = "no gender found";
	string status = "error: status not found";
    public Wellness_Result(int score, string gender)
    {
        InitializeComponent();
        this.Padding = new Thickness(0, DeviceInfo.Platform == DevicePlatform.iOS ? 44 : 0, 0, 0);
        this.gender = gender;
        LblScore.Text = score.ToString();

        if (score < 40)
        { // Poor Condition
            status = "Poor";
        }
        else if (score < 60)
        { // Fair Condition
            status = "Fair";
        }
        else if (score < 80)
        { // Good Condition
            status = "Good";
        }
        else
        { // Excellent Condition
            status = "Excellent";
        }

        LblStatus.Text = status; 
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Wellness_Rec(status, gender));   
    }

    async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}