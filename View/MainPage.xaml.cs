using ToDoList.ViewModel;

namespace ToDoList.View;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel mainPage)
	{
		InitializeComponent();
		BindingContext = mainPage;
	}
}