using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.PubSubEvents;

namespace AssetsAccounting.Events
{
    internal class ProvidersListChangedEvent : CompositePresentationEvent<string>
    {
        private static readonly EventAggregator _EventAggregator;
        private static readonly ProvidersListChangedEvent _Event;

        static ProvidersListChangedEvent()
        {
            _EventAggregator = new EventAggregator();
            _Event = _EventAggregator.GetEvent<ProvidersListChangedEvent>();
        }

        public static ProvidersListChangedEvent Instance
        {
            get { return _Event; }
        }
    }
}
