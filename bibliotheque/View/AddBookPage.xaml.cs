using bibliotheque.ViewModel;

namespace bibliotheque.View;

public partial class AddBookPage : ContentPage
{
	public AddBookPage(AddBookPageViewModel addBookPageViewModel )
	{
		InitializeComponent();
		BindingContext = addBookPageViewModel;
	}
}