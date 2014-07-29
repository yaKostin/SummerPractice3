using System.Collections.Generic;
using Investment.Domain.Entities;
using Investment.ViewModel.BaseClasses;
using Investment.ViewModel.Wrappers.ObjectWrappers;

namespace Investment.ViewModel.Wrappers.CollectionWrappers
{
    public class SecuritiesVM : VmCollectionBase<SecurityVM, Security>
    {
        public SecuritiesVM(IList<Security> domainCollection)
            : base(domainCollection)
        {
 
        }
    }
}
