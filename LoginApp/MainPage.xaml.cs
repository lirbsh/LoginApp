using LoginApp.ViewModels;

namespace LoginApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageVM();
        }
    }
}
