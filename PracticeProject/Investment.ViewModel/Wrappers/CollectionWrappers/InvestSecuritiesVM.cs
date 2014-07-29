using System.Collections.Generic;
using Investment.Domain.Entities;
using Investment.ViewModel.Wrappers.ObjectWrappers;

namespace Investment.ViewModel.Wrappers.CollectionWrappers
{
    public class InvestSecuritiesVM : BaseClasses.VmCollectionBase<InvestSecurityVM, InvestSecurity>
    {
        public InvestSecuritiesVM(IList<InvestSecurity> domainCollection)
            : base(domainCollection)
        { }
    }
}
