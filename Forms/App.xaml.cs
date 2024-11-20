using Form;
using Xamarin.Forms;

namespace Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Configurar la página inicial
            MainPage = new MainPage();
        }
    }
}
