using Microsoft.Practices.Unity;
using Prism.Unity;
using OgreEdit.Views;
using System.Windows;

namespace OgreEdit
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            //Container.RegisterTypeForNavigation<Characters>("Characters");
        }
    }
}
