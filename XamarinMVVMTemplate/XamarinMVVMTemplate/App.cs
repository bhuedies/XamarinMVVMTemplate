using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using Xamarin.Forms;
using XamarinMVVMTemplate.Views;
using XamarinMVVMTemplate.ViewModels;

namespace XamarinMVVMTemplate
{
    public class App : FormsApplication
    {
        private readonly SimpleContainer container;

        public App(SimpleContainer container)
        {
            Initialize();

            this.container = container;

            container.PerRequest<HomeViewModel>();

            DisplayRootView<HomeView>();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }
    }
}
