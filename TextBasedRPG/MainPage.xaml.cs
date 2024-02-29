namespace TextBasedRPG;

public partial class MainPage : ContentPage
{
  //------------------------------------------------------------------------------------------------

	public MainPage()
	{
		InitializeComponent();
	}

  //------------------------------------------------------------------------------------------------

  private void OnMenuStartButtonClicked(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new GamePage();
  }

  //------------------------------------------------------------------------------------------------
  
  private void OnMenuSettingsButtonClicked(object sender, EventArgs args)
  {
    frameSettings.IsVisible = true;
  }

  //------------------------------------------------------------------------------------------------

  private void OnMenuAboutButtonClicked(object sender, EventArgs args)
  {
    frameAbout.IsVisible = true;
  }

  //------------------------------------------------------------------------------------------------

  private void OnDismissSettingsButtonClicked(object sender, EventArgs args)
  {
    frameSettings.IsVisible = false;
  }

  //------------------------------------------------------------------------------------------------

  private void OnDismissAboutButtonClicked(object sender, EventArgs args)
  {
    frameAbout.IsVisible = false;
  }

  //------------------------------------------------------------------------------------------------
}

