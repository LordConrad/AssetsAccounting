using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.PubSubEvents;

namespace AssetsAccounting.Events
{
    internal class ResponsiblesListChangedEvent : CompositePresentationEvent<string>
    {
        private static readonly ResponsiblesListChangedEvent Event;

        static ResponsiblesListChangedEvent()
        {
            EventAggregator eventAggregator = new EventAggregator();
            Event = eventAggregator.GetEvent<ResponsiblesListChangedEvent>();
        }

        public static ResponsiblesListChangedEvent Instance
        {
            get { return Event; }
        }
    }
}
