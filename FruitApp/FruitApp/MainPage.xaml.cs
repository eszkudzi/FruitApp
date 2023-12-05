namespace FruitApp;

public partial class MainPage : ContentPage
{
	public List<string> fruitsList = new List<string>()
	{
		"Apple", "Banana", "Mango", "Kiwi", "Watermelon", "Guava", "Peach", "Grapes"
	};

	public MainPage()
	{
		InitializeComponent();
		LvFruit.ItemsSource = fruitsList;
	}

}


