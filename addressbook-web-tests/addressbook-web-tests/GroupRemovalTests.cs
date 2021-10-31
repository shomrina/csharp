using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            navigator.OpenMainPage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroupsPage();
            groupHelper.SelectFirstGroup();
            groupHelper.DeleteGroup();
            groupHelper.ReturnToGroupPage();
            loginHelper.Logout();
        }
    }
}
