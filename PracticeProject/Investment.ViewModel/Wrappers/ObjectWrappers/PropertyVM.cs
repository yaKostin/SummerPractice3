using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Investment.Domain.Entities;

namespace Investment.ViewModel.Wrappers.ObjectWrappers
{
    public class PropertyVM : BaseClasses.VmObjectBase<Property>
    {
        #region Fields
        
        // Property variables

        #endregion

        #region Constructors
        
        /// <summary>
        /// Constructor that creates a new domain object and wraps it in 
        /// a view model wrapper.
        /// </summary>
        /// <remarks>
        /// This constructor is used when a view model object is created
        /// by a XAML data binding operation.
        /// </remarks>
        public PropertyVM() : this(new Property())
        {
        }

        /// <summary>
        /// Constructor that wraps an existing domain object in a view 
        /// model wrapper.
        /// </summary>
        /// <remarks>
        /// This constructor is used when a view model object is created
        /// as part of the initialization of a view model.
        /// </remarks>
        public PropertyVM(Property domainObject) : base(domainObject)
        {
        }

        #endregion

        #region Bindable Properties

        public string Name
        {
            get { return base.DomainObject.Name; }

            set
            {
                base.DomainObject.Name = value;
                base.RaisePropertyChangedEvent("Name");
            }
        }

        #endregion
    }
}
