using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }

        [Test]
        public void TestingAddtion()
        {
            // Arrange
            app.EnterText("EntryA", "5");
            app.EnterText("EntryB", "8");
            // Act
            app.Tap("AddButton");
            // Assert
            var appResult = app.Query("ResultLabel").First(result => result.Text == "13");
            Assert.IsTrue(appResult != null, "Failed Test");
        }
    }
}
