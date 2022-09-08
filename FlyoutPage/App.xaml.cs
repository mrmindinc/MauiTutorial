using MindMap.Pages;

namespace MindMap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppFlyout();
        }
    }
}