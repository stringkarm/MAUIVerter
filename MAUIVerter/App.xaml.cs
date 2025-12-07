using MAUIVerter.Models; 

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