using System.Windows;
using Investment.ViewModel;
using Investment.Domain.LoadData;

namespace Investment
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            /* We don't want to clutter up the demo with NHibernate code, so we
             * manually create the same type of collections that NHibernate would
             * return to us if we were reading from a database. */

            // Create domain model 
            /*IList<Client> customers = new List<Client>();
            var newCustomer = new Customer("Doe Shipping, Inc.", "John Doe");
            newCustomer.Orders.Add(new Order(new DateTime(2009, 04, 01), 1000));
            newCustomer.Orders.Add(new Order(new DateTime(2009, 04, 15), 750));
            customers.Add(newCustomer);

            newCustomer = new Customer("Roe Salvage, Inc.", "Larry Roe");
            newCustomer.Orders.Add(new Order(new DateTime(2009, 04, 08), 2000));
            newCustomer.Orders.Add(new Order(new DateTime(2009, 04, 22), 1500));
            customers.Add(newCustomer);
            */
            var loader = new DBLoader();
            var db = loader.LoadDB();
            // Create view model
            var mainWindowViewModel = new MainWindowVM(db);

            // Initialize main window
            var mainWindow = new MainWindow();
            mainWindow.DataContext = mainWindowViewModel;
            mainWindow.Show();
        } 
    }
}
