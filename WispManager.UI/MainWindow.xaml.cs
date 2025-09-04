using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WispManager.UI.Views;

namespace WispManager.UI
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavView.ItemInvoked += OnItemInvoked;

            NavView.SelectedItem = NavView.MenuItems[0];
            ContentFrame.Navigate(typeof(HomePage));
        }

        private void OnItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
                return;
            }

            var tag = (args.InvokedItemContainer as NavigationViewItem)?.Tag?.ToString();
            switch (tag)
            {
                case "home":
                    ContentFrame.Navigate(typeof(HomePage)); break;
                case "clients":
                    ContentFrame.Navigate(typeof(ClientsPage)); break;
                case "plans":
                    ContentFrame.Navigate(typeof(PlansPage)); break;
                case "inventory":
                    ContentFrame.Navigate(typeof(InventoryPage)); break;
                case "routers":
                    ContentFrame.Navigate(typeof(RouterPage)); break;
            }
        }
    }
}
