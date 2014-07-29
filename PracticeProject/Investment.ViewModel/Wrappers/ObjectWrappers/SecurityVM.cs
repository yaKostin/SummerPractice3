using Investment.ViewModel.BaseClasses;
using Investment.Domain.Entities;
using Investment.ViewModel.Wrappers.CollectionWrappers;
using System;

namespace Investment.ViewModel.Wrappers.ObjectWrappers
{
    public class SecurityVM : VmObjectBase<Security>
    {
        #region Fields

        // Property variables
        private RatingVM p_Rating;

        #endregion

        #region Constructors

        public SecurityVM() 
            : this(new Security())
        { }

        public SecurityVM(Security domainObject)
            : base(domainObject)
        { }

        #endregion

        #region Bindable Properties

        public String Info
        {
            get { return base.DomainObject.Info; }
            set
            {
                base.DomainObject.Info = value;
                RaisePropertyChangedEvent("Info");
            }
        }

        public Decimal Revenue
        {
            get { return base.DomainObject.Revenue; }
            set
            {
                base.DomainObject.Revenue = value;
                RaisePropertyChangedEvent("Revenue");
            }
        }
        public Decimal MinTransaction
        {
            get { return base.DomainObject.MinTransaction; }
            set
            {
                base.DomainObject.MinTransaction = value;
                RaisePropertyChangedEvent("MinTransaction");
            }
        }

        public RatingVM Rating
        {
            get 
            {
                if (p_Rating == null)
                {
                    p_Rating = new RatingVM(base.DomainObject.Rating);
                }

                return p_Rating;
            }
            set
            {
                p_Rating = value;
            }
        }

        #endregion

    }
}
