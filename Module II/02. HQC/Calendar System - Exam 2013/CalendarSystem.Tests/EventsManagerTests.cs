using NUnit.Framework;
using System;
using System.Linq;

namespace CalendarSystem.Tests
{
    [TestFixture]
    public class EventsManagerTests
    {
        Event testEvent = new Event
        {
            Date = DateTime.Now,
            Title = "Test Event",
            Location = "Wonderland"
        };

        [Test]
        public void ShouldAddAnEvent()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(testEvent);
            Assert.AreEqual(1, eventsManager.ListEvents(DateTime.MinValue, 1).Count());
        }

        [Test]
        public void ShouldAddANullEvent()
        {
            IEventsManager eventsManager = new EventsManager();           
            Assert.Throws(typeof(ArgumentNullException), () => { eventsManager.AddEvent(null); });           
        }

        [Test]
        public void ShouldAddDuplicatedEvents()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(testEvent);
            eventsManager.AddEvent(testEvent);
            eventsManager.AddEvent(testEvent);
            eventsManager.AddEvent(testEvent);
            Assert.AreEqual(4, eventsManager.ListEvents(DateTime.MinValue, int.MaxValue).Count());
        }

        [Test]
        public void ShouldDeleteEventByTitle()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(testEvent);
            var eventName = testEvent.Title;
            eventsManager.DeleteEventsByTitle(eventName);
            Assert.AreEqual(0, eventsManager.ListEvents(DateTime.MinValue, int.MaxValue).Count());
        }

        [Test]
        public void ShouldDeleteEventWithAGivenMatchingTitle()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(testEvent);
            var eventName = "Test Event";
            eventsManager.DeleteEventsByTitle(eventName);
            Assert.AreEqual(0, eventsManager.ListEvents(DateTime.MinValue, int.MaxValue).Count());
        }

        [Test]
        public void ShouldDeleteEventWithAGivenNonMatchingTitle()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(testEvent);
            var eventName = "This name will not match";
            eventsManager.DeleteEventsByTitle(eventName);
            Assert.AreEqual(1, eventsManager.ListEvents(DateTime.MinValue, int.MaxValue).Count());
        }

        [Test]
        public void ShouldDeleteEventWithANullTitle()
        {
            IEventsManager eventsManager = new EventsManager();
            Assert.Throws(typeof(ArgumentNullException), () => { eventsManager.DeleteEventsByTitle(null); });
        }

        [Test]
        public void ShouldDeleteEventWithACaseInsensitiveTitle()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(testEvent);
            eventsManager.AddEvent(new Event
            {
                Date = DateTime.Now,
                Title = "TEST Event",
                Location = "Wonderland"
            });
            eventsManager.DeleteEventsByTitle("TEST Event".ToLower());
            Assert.AreEqual(0, eventsManager.ListEvents(DateTime.MinValue, int.MaxValue).Count());
        }

        [Test]
        public void ShouldListEventsByDate()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(
                new Event {
                    Date = new DateTime(2015, 11, 08, 12, 00, 00),
                    Location = "Wonderland",
                    Title = "Pink Unicorn", });
            eventsManager.AddEvent(
                new Event {
                    Date = new DateTime(2017, 05, 10, 10, 30, 00),
                    Location = "Dreamland",
                    Title = "Fluffy Unicorn", });
            Assert.AreEqual(1, eventsManager
                .ListEvents(new DateTime(2016, 11, 08, 12, 00, 00), int.MaxValue).Count());
        }
        [Test]
        public void ShouldListEventsByGivenCountSmallerThanActualEventsCount()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(testEvent);
            eventsManager.AddEvent(
                new Event
                {
                    Date = new DateTime(2015, 11, 08, 12, 00, 00),
                    Location = "Wonderland",
                    Title = "Pink Unicorn",
                });
            eventsManager.AddEvent(
                new Event
                {
                    Date = new DateTime(2017, 05, 10, 10, 30, 00),
                    Location = "Dreamland",
                    Title = "Fluffy Unicorn",
                });
            Assert.AreEqual(2, eventsManager
                .ListEvents(new DateTime(2013, 11, 08, 12, 00, 00), 2).Count());
        }

        [Test]
        public void ShouldNotListEventsByGivenFutureDate()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(testEvent);
            eventsManager.AddEvent(
                new Event
                {
                    Date = new DateTime(2015, 11, 08, 12, 00, 00),
                    Location = "Wonderland",
                    Title = "Pink Unicorn",
                });
            eventsManager.AddEvent(
                new Event
                {
                    Date = new DateTime(2017, 05, 10, 10, 30, 00),
                    Location = "Dreamland",
                    Title = "Fluffy Unicorn",
                });
            Assert.AreEqual(0, eventsManager
                .ListEvents(new DateTime(2018, 11, 08, 12, 00, 00), 2).Count());
        }

        [Test]
        public void ShouldNotListEventsWhenGivenCountIsZero()
        {
            IEventsManager eventsManager = new EventsManager();
            eventsManager.AddEvent(testEvent);
            eventsManager.AddEvent(
                new Event
                {
                    Date = new DateTime(2015, 11, 08, 12, 00, 00),
                    Location = "Wonderland",
                    Title = "Pink Unicorn",
                });
            eventsManager.AddEvent(
                new Event
                {
                    Date = new DateTime(2017, 05, 10, 10, 30, 00),
                    Location = "Dreamland",
                    Title = "Fluffy Unicorn",
                });
            Assert.AreEqual(0, eventsManager
                .ListEvents(new DateTime(2013, 11, 08, 12, 00, 00), 0).Count());
        }
    }
}
