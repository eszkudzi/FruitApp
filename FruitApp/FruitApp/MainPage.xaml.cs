namespace FruitApp;

public partial class MainPage : ContentPage
{
	public List<Fruit> fruitsList = new List<Fruit>()
	{
		new Fruit(){Name="Apple", ImageName="apple.png", Sentence="To jest jabłko!"},
		new Fruit(){Name="Apricot", ImageName="apricot.png", Sentence="To jest brzoskwinia!"},
        new Fruit(){Name="Banana", ImageName="banana.png", Sentence="To jest banan!"},
        new Fruit(){Name="Grapes", ImageName="grapes.png", Sentence="To jest winogrono!"},
        new Fruit(){Name="Guava", ImageName="guava.png", Sentence="To jest gujana!"},
        new Fruit(){Name="Kiwi", ImageName="kiwi.png", Sentence="To jest kiwi!"},
        new Fruit(){Name="Mango", ImageName="mango.png", Sentence="To jest mango!"},
        new Fruit(){Name="Orange", ImageName="orange.png", Sentence="To jest pomarańcza!"},
        new Fruit(){Name="Peach", ImageName="peach.png", Sentence="To jest brzoskwinia!"},
        new Fruit(){Name="Pineapple", ImageName="pineapple.png", Sentence="To jest ananas!"},
        new Fruit(){Name="Strawberry", ImageName="strawberry.png", Sentence="To jest truskawka!"},
        new Fruit(){Name="Watermelon", ImageName="watermelon.png", Sentence="To jest arbuz!"}
    };

	public MainPage()
	{
		InitializeComponent();
		LvFruit.ItemsSource = fruitsList;
	}

    void LvFruit_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Fruit;
        if (selectedItem == null) return;
        Navigation.PushAsync(new FruitDetailPage(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }

    /*void LvFruit_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        var selectedItem = e.SelectedItem as Fruit;
        if (selectedItem == null) return;
        Navigation.PushAsync(new FruitDetailPage(selectedItem));
        ((ListView)sender).SelectedItem = null;
    }*/
}


