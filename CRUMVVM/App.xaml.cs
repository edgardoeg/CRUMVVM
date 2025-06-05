using CRUMVVM.Views;

namespace CRUMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // DEBEMOS escribir el navigation page sin eso no nos va a cambiar de vista
            // NavigationPage es una clase que nos permite navegar entre vistas
            MainPage = new NavigationPage (new MainView());
        }
    }
}
