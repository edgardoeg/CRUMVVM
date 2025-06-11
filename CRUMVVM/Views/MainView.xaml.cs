using CRUMVVM.ViewModels;

namespace CRUMVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel viewModel;
	public MainView()
	{
		
		InitializeComponent();
		viewModel = new MainViewModel();
		this.BindingContext = viewModel;
    }
}