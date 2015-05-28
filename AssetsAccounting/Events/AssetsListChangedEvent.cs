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
        private static readonly AssetsListChangedEvent Event;

        static AssetsListChangedEvent()
        {
            EventAggregator eventAggregator = new EventAggregator();
            Event = eventAggregator.GetEvent<AssetsListChangedEvent>();
        }

        public static AssetsListChangedEvent Instance
        {
            get { return Event; }
        }
    }
}
