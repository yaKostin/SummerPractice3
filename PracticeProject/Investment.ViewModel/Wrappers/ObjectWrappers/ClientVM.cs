using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Investment.Domain.Entities;
using Investment.ViewModel.Wrappers.CollectionWrappers;

namespace Investment.ViewModel.Wrappers.ObjectWrappers
{
    public class ClientVM : BaseClasses.VmObjectBase<Client>
    {
        #region Fields
        private PropertyVM p_Property;
        private InvestSecuritiesVM p_Investment;
        #endregion

        #region Constructors
        public ClientVM() 
            : this(new Client())
        { }

        public ClientVM(Client domainObject)
            : base(domainObject)
        { }
        #endregion

        #region Bindable properties

        public String FirstName
        {
            get { return base.DomainObject.FirstName; }
            set 
            {
                base.DomainObject.FirstName = value;
                RaisePropertyChangedEvent("FirstName");
            }
        }

        public String LastName
        {
            get { return base.DomainObject.LastName; }
            set
            {
                base.DomainObject.LastName = value;
                RaisePropertyChangedEvent("LastName");
            }
        }

        public String Address
        {
            get { return base.DomainObject.Address; }
            set
            {
                base.DomainObject.Address = value;
                RaisePropertyChangedEvent("Address");
            }
        }

        public String TelNum
        {
            get { return base.DomainObject.TelNum; }
            set
            {
                base.DomainObject.TelNum = value;
                RaisePropertyChangedEvent("TelNum");
            }
        }

        public PropertyVM Property
        {
            get 
            {
                if (p_Property == null)
                {
                    p_Property = new PropertyVM(base.DomainObject.Property);
                }
                return p_Property;
            }
            set
            {
                p_Property = value;
            }
        }

        public InvestSecuritiesVM Investment
        {
            get 
            {
                if (p_Investment == null)
                {
                    p_Investment = new InvestSecuritiesVM(base.DomainObject.Investmenst);
                }
                return p_Investment;
            }
            set
            {
                p_Investment = value;
            }
        }
        #endregion
    }
}
