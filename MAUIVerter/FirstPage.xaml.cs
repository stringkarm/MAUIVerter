namespace MAUIVerter;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

    private void Start_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }
}