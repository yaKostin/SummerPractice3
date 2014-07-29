using Investment.ViewModel.BaseClasses;
using Investment.Domain.Entities;

namespace Investment.ViewModel.Wrappers.ObjectWrappers
{
    public class RatingVM : VmObjectBase<Rating>
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
        public RatingVM() : this(new Rating())
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
        public RatingVM(Rating domainObject) : base(domainObject)
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
