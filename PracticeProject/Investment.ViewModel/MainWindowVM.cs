using Investment.ViewModel.BaseClasses;
using Investment.Domain.Entities;
using System.Collections.Generic;
using Investment.ViewModel.Wrappers.CollectionWrappers;
using System;
using System.Windows.Input;
using Investment.Domain.LoadData;

namespace Investment.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {
        #region Fields

        // Property variables
        private int p_SelectedClientIndex;
        private int p_SelectedOrder;

        #endregion

        #region Constructor

        public MainWindowVM (InvestmentDB investmentDB)
        {
            // Initialize commands
            /*this.AddCustomer = new AddCustomerCommand(this);
            this.AddOrder = new AddOrderCommand(this);
            this.ChangeCustomerName = new ChangeCustomerNameCommand(this);
            this.ChangeOrderAmount = new ChangeOrderAmountCommand(this);
            this.RemoveCustomer = new RemoveCustomerCommand(this);
            this.RemoveOrder = new RemoveOrderCommand(this);*/

            // Initialize collections
            /*this.Customers = new CustomersVM(clients);
            this.DomainCustomers = clients;*/
            this.Clients = new ClientsVM(investmentDB.clients);
            this.Securities = new SecuritiesVM(investmentDB.securities);
            //this.InvestSecurities = new InvestSecuritiesVM(investmentDB.investSecurities);
        }

        #endregion

        #region Command Properties

        /// <summary>
        /// Adds a customer.
        /// </summary>
        public ICommand AddCustomer { get; set; }

        /// <summary>
        /// Adds an order to the current customer.
        /// </summary>
        public ICommand AddOrder { get; set; }

        /// <summary>
        /// Changes a customer's name.
        /// </summary>
        public ICommand ChangeCustomerName { get; set; }

        /// <summary>
        /// Changes an order amount.
        /// </summary>
        public ICommand ChangeOrderAmount { get; set; }

        /// <summary>
        /// Removes a customer.
        /// </summary>
        public ICommand RemoveCustomer { get; set; }

        /// <summary>
        /// Removes an order from the current customer.
        /// </summary>
        public ICommand RemoveOrder { get; set; }

        #endregion

        #region Bindable Properties

        /// <summary>
        /// A clients list.
        /// </summary>
        public ClientsVM Clients { get; set; }
        public SecuritiesVM Securities { get; set; }
        public InvestSecuritiesVM InvestSecurities { get; set; }

        /// <summary>
        /// The index in the VM collection of the currently selected customer.
        /// </summary>
        /// <remarks>The RemoveOrderCommand class uses this property to determine 
        /// whether to enable the 'Remove Order' button.</remarks>
        public Int32 SelectedClientIndex
        {
            get { return p_SelectedClientIndex; }

            set
            {
                p_SelectedClientIndex = value;
                this.RaisePropertyChangedEvent("SelectedClientIndex");
            }
        }

        /// <summary>
        /// The index of the currently selected order.
        /// </summary>
        public int SelectedOrder
        {
            get { return p_SelectedOrder; }

            set
            {
                p_SelectedOrder = value;
                this.RaisePropertyChangedEvent("SelectedOrder");
            }
        }

        #endregion

        #region Internal Properties

        /// <summary>
        /// The domain collection wrapped by the Curtomers property.
        /// </summary>
        /// <remarks>Note that we strongly recommend *against* including any domain 
        /// collection in the properties of the view model. The wrapper classes should 
        /// provide sole access to the domain collection. We break that rule here only 
        /// to demonstrate that changes have been pushed out from the view model wrappers 
        /// to the domain collection.</remarks>
        public IList<Client> DomainClients { get; set; }

        #endregion
    }
}
