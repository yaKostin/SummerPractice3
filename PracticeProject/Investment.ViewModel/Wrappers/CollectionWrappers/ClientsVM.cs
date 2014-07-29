using System.Collections.Generic;
using Investment.Domain.Entities;
using Investment.ViewModel.Wrappers.ObjectWrappers;

namespace Investment.ViewModel.Wrappers.CollectionWrappers
{
    public class ClientsVM : BaseClasses.VmCollectionBase<ClientVM, Client>
    {
        public ClientsVM(IList<Client> domainCollection)
            : base(domainCollection)
        { }
    }
}
