﻿using System;
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
        private static readonly ProvidersListChangedEvent Event;

        static ProvidersListChangedEvent()
        {
            EventAggregator eventAggregator = new EventAggregator();
            Event = eventAggregator.GetEvent<ProvidersListChangedEvent>();
        }

        public static ProvidersListChangedEvent Instance
        {
            get { return Event; }
        }
    }
}
