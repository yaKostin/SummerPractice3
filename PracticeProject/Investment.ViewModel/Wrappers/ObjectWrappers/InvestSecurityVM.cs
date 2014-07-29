using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Investment.Domain.Entities;
using Investment.ViewModel.Wrappers.CollectionWrappers;

namespace Investment.ViewModel.Wrappers.ObjectWrappers
{
    public  class InvestSecurityVM : BaseClasses.VmObjectBase<InvestSecurity>
    {
        #region Fields
        private ClientVM p_Client;
        private SecurityVM p_Security;
        //private SecuritiesVM p_Security;
        #endregion

        #region Constructors
        public InvestSecurityVM() 
            : this(new InvestSecurity())
        { }

        public InvestSecurityVM(InvestSecurity domainObject)
            : base(domainObject)
        { }
        #endregion

        #region Bindable properties

        public ClientVM Client
        {
            get
            {
                if (p_Client == null)
                {
                    p_Client = new ClientVM(base.DomainObject.Client);
                }

                // Set return value
                return p_Client;
            }

            set
            {
                p_Client = value;
            }
        }

        public SecurityVM Security
        {
            get
            {
                if (p_Security == null)
                {
                    p_Security = new SecurityVM(base.DomainObject.Security);
                    //p_Security = new SecuritiesVM(base.DomainObject.Security);
                }

                // Set return value
                return p_Security;
            }

            set
            {
                p_Security = value;
            }
        }

        public Decimal Quote
        {
            get { return base.DomainObject.Quote; }
            set
            {
                base.DomainObject.Quote = value;
                RaisePropertyChangedEvent("Quote");
            }
        }

        public DateTime PurchaseTime
        {
            get { return base.DomainObject.PurchaseTime; }
            set
            {
                base.DomainObject.PurchaseTime = value;
                RaisePropertyChangedEvent("PurchaseTime");
            }
        }

        public DateTime SaleTime
        {
            get { return base.DomainObject.SaleTime; }
            set
            {
                base.DomainObject.SaleTime = value;
                RaisePropertyChangedEvent("SaleTime");
            }
        }
        #endregion
    }
}
