using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Investment.Domain.Entities;
using Investment.ViewModel.Wrappers.ObjectWrappers;

namespace Investment.ViewModel.Wrappers.CollectionWrappers
{
    public class PropertiesVM : BaseClasses.VmCollectionBase<PropertyVM, Property>
    {
        public PropertiesVM(IList<Property> domainCollection)
            : base(domainCollection)
        {
 
        }
    }
}
