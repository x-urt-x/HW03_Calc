using IInOutPutNS;
using Moq;
using System;
using System.IO;
using UINS;

namespace UITestNS
{
    [TestClass]
    public class UITests
    {
        static UserInterface ui;
        static Mock<IInOutPut> mock;
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {

            mock = new Mock<IInOutPut>();
            ui = new UserInterface(mock.Object);
        }
        [TestMethod]
        [DataRow("1+1", "2", "чиcло простое")]
        [DataRow("1-1", "0", "число непростое")]
        [DataRow("1+4", "5", "чиcло простое")]
        public void CorrectInput(string input, string expRes1, string expRes2)
        {
            mock.Reset();
            mock
                .SetupSequence(x => x.ReadLine())
                .Returns(input)
                .Returns("exit");
            ui.RunProgramm();

            mock.Verify(x => x.WriteLine(It.Is<string>(s=>s.Contains(expRes1)||s.Contains(expRes2))), Times.Exactly(2));

        }


        [TestMethod]
        public void IncorrectInput()
        {
            mock
                .SetupSequence(x => x.ReadLine())
                .Returns("1/0")
                .Returns("exit");

            ui.RunProgramm();

            mock.Verify(x => x.WriteLine(It.Is<string>(s => s.Contains("ошибка при вводе данных:"))), Times.Once);
        }
    }
}
