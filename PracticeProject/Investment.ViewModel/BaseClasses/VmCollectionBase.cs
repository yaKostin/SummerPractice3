using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Investment.ViewModel.BaseClasses
{
    public abstract class VmCollectionBase<VM, DM> : ObservableCollection<VM>
    {
        #region Fields

        // Member variables
        private IList<DM> m_DomainCollection;
        private bool m_EventsDisabled;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="domainCollection">The domain collection to be wrapped.</param>
        public VmCollectionBase(IList<DM> domainCollection)
        {
            // Set the domain collection
            m_DomainCollection = domainCollection;

            // Disable events
            m_EventsDisabled = true;

            /* Note that we can't simply new-up a VM object, because new() will
             * not let us use a paramaterized constructor on a generic type. See
             * http://msdn.microsoft.com/en-us/library/tass7xkw.aspx. So, we use 
             * Activator.CreateInstance() instead. */

            // Populate this collection with VM objects
            foreach (var domainObject in domainCollection)
            {
                var paramList = new object[] { domainObject };
                var wrapperObject = (VM)Activator.CreateInstance(typeof(VM), paramList);
                this.Add(wrapperObject);
            }

            // Re-enable events
            m_EventsDisabled = false;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Updates the domain collection when the view model collection changes.
        /// </summary>
        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            // Call base
            base.OnCollectionChanged(e);

            // Exit if events are disabled
            if (m_EventsDisabled) return;

            // Push change out to domain collection
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.AddDomainObjects(e);
                    break;

                case NotifyCollectionChangedAction.Remove:
                    RemoveDomainObjects(e);
                    break;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Pushes an addition to the VM collection out to the domain collection.
        /// </summary>
        private void AddDomainObjects(NotifyCollectionChangedEventArgs e)
        {
            // Push addition out to view model
            foreach (VmObjectBase<DM> wrapperObject in e.NewItems)
            {
                var domainObject = wrapperObject.DomainObject;
                m_DomainCollection.Add(domainObject);
            }
        }

        /// <summary>
        /// Pushes a removal from the VM collection out to the domain collection.
        /// </summary>
        private void RemoveDomainObjects(NotifyCollectionChangedEventArgs e)
        {
            // Push removal out to view model
            foreach (VmObjectBase<DM> wrapperObject in e.OldItems)
            {
                var domainObject = wrapperObject.DomainObject;
                m_DomainCollection.Remove(domainObject);
            }
        }

        #endregion
    }
}
