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
        private static readonly EventAggregator _EventAggregator;
        private static readonly ResponsiblesListChangedEvent _Event;

        static ResponsiblesListChangedEvent()
        {
            _EventAggregator = new EventAggregator();
            _Event = _EventAggregator.GetEvent<ResponsiblesListChangedEvent>();
        }

        public static ResponsiblesListChangedEvent Instance
        {
            get { return _Event; }
        }
    }
}
