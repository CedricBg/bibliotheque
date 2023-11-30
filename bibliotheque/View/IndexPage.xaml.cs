using bibliotheque.ViewModel;

namespace bibliotheque.View;

public partial class IndexPage : ContentPage
{
	public IndexPage(IndexPageviewModel indexPageviewModel)
	{
		InitializeComponent();
		BindingContext = indexPageviewModel;
	}
}