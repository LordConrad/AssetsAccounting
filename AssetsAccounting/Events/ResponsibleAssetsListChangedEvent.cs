using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.PubSubEvents;

namespace AssetsAccounting.Events
{
    internal class ResponsibleAssetsListChangedEvent : CompositePresentationEvent<string>
    {
        static ResponsibleAssetsListChangedEvent Event;

        static ResponsibleAssetsListChangedEvent()
        {
            var eventAggregator = new EventAggregator();
            Event = eventAggregator.GetEvent<ResponsibleAssetsListChangedEvent>();
        }

        public static ResponsibleAssetsListChangedEvent Instance
        {
            get { return Event; }
        }
    }
}
