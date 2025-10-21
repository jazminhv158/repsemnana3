namespace s3jherreraclase
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            /*navigationPage PARA NAVEGAR ENTRE PAGINAS*/
            return new Window(new NavigationPage (new Views.vUno()));
        }
    }
}