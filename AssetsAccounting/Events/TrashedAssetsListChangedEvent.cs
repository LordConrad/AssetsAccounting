using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.PubSubEvents;

namespace AssetsAccounting.Events
{
    internal class TrashedAssetsListChangedEvent : CompositePresentationEvent<string>
    {
        private static TrashedAssetsListChangedEvent Event;

        static TrashedAssetsListChangedEvent()
        {
            EventAggregator eventAggregator = new EventAggregator();
            Event = eventAggregator.GetEvent<TrashedAssetsListChangedEvent>();
        }

        public static TrashedAssetsListChangedEvent Instance
        {
            get { return Event; }
        }
    }
}
