using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.PubSubEvents;

namespace AssetsAccounting.Events
{
    internal class AssetTypesListChangedEvent : CompositePresentationEvent<string>
    {
        private static readonly AssetTypesListChangedEvent Event;

        static AssetTypesListChangedEvent()
        {
            var eventAggregator = new EventAggregator();
            Event = eventAggregator.GetEvent<AssetTypesListChangedEvent>();
        }

        public static AssetTypesListChangedEvent Instance
        {
            get { return Event; }
        }
    }
}
