using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            navigator.OpenMainPage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToHomePage();
            contactHelper.InitContactCreation();
            ContactData contact = new ContactData("Marina", "Klippert");
            contactHelper.FillContactForm(contact);
            contactHelper.SubmitContactCreation();
            contactHelper.ReturnToHomePage();
            loginHelper.Logout();
        }
    }
}
