using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.PubSubEvents;

namespace AssetsAccounting.Events
{
    internal class AssetsListChangedEvent : CompositePresentationEvent<string>
    {
        private static readonly EventAggregator _EventAggregator;
        private static readonly AssetsListChangedEvent _Event;

        static AssetsListChangedEvent()
        {
            _EventAggregator = new EventAggregator();
            _Event = _EventAggregator.GetEvent<AssetsListChangedEvent>();
        }

        public static AssetsListChangedEvent Instance
        {
            get { return _Event; }
        }
    }
}
