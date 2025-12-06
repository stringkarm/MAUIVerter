// MAUIVerter/App.xaml.cs

using MAUIVerter.Views; // <-- ADD THIS LINE

namespace MAUIVerter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           
            MainPage = new NavigationPage(new FirstPage());
        }
    }
}