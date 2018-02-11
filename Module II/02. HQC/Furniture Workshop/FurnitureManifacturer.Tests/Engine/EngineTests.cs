using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Engine.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace FurnitureManifacturer.Tests.Engine
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        public void FactoryShouldBeCalledOnceWithProperCommandName()
        {
            string commandLine = "Comand comand comand";
            string commandName = commandLine.Split()[0];

            Mock<ICommandsFactory> factoryMock = new Mock<ICommandsFactory>();
            Mock<IRenderer> rendererStub = new Mock<IRenderer>();
            rendererStub.Setup(x => x.Input()).Returns(new List<string>() { commandLine });

            var engine = new FurnitureEngine(rendererStub.Object, factoryMock.Object);
            engine.Start();

            factoryMock.Verify(x => x.GetCommand(commandName), Times.Once);
        }
    }
}
