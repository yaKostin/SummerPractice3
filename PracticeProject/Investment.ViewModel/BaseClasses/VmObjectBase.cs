
namespace Investment.ViewModel.BaseClasses
{
    public abstract class VmObjectBase<DM> : ViewModelBase
    {
        #region Constructor

        protected VmObjectBase(DM domainObject)
        {
            this.DomainObject = domainObject;
        }

        #endregion

        #region Properties

        internal DM DomainObject { get; set; }

        #endregion
    }
}
