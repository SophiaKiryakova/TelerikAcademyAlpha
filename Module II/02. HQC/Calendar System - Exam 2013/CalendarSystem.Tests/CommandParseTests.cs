using NUnit.Framework;
using System;

namespace CalendarSystem.Tests
{
    [TestFixture]
    public class CommandParseTests
    {
        [Test]
        public void CommandToAddEventWithThreeParameters()
        {
            var commandText = "AddEvent 2012-01-21T20:00:00 | party Viki | home";
            var command = Command.Parse(commandText);
            Assert.AreEqual(command.CommandName, "AddEvent");
            Assert.AreEqual(3, command.Parameters.Length);
            Assert.AreEqual("2012-01-21T20:00:00", command.Parameters[0]);
            Assert.AreEqual("party Viki", command.Parameters[1]);
            Assert.AreEqual("home", command.Parameters[2]);
        }
        [Test]
        public void CommandToAddEventWithTwoParameters()
        {
            var commandText = "AddEvent 2012-03-26T09:00:00 | C# exam";
            var command = Command.Parse(commandText);
            Assert.AreEqual(command.CommandName, "AddEvent");
            Assert.AreEqual(2, command.Parameters.Length);
            Assert.AreEqual("2012-03-26T09:00:00", command.Parameters[0]);
            Assert.AreEqual("C# exam", command.Parameters[1]);
        }
        public void CommandToDeleteEventWithOneParameter()
        {
            var commandText = "DeleteEvents c# exam";
            var command = Command.Parse(commandText);
            Assert.AreEqual(command.CommandName, "DeleteEvents");
            Assert.AreEqual(1, command.Parameters.Length);
            Assert.AreEqual("c# exam", command.Parameters[0]);
        }
        [Test]
        public void CommandNullString()
        {
            string commandText = null;
            Assert.Throws(typeof(ArgumentNullException), () => { Command.Parse(commandText); } );
        }
        [Test]
        public void CommandExitString()
        {
            string commandText = "Exit";
            Assert.Throws(typeof(ArgumentException), () => { Command.Parse(commandText); });
        }
    }
}
