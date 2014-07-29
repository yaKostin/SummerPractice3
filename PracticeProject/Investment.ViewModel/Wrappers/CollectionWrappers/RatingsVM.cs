using System.Collections.Generic;
using Investment.ViewModel.BaseClasses;
using Investment.Domain.Entities;
using Investment.ViewModel.Wrappers.ObjectWrappers;
namespace Investment.ViewModel.Wrappers.CollectionWrappers
{
    public class RatingsVM : VmCollectionBase<RatingVM, Rating>
    {
        public RatingsVM(IList<Rating> domainCollection)
            : base(domainCollection)
        {

        }
    }
}
