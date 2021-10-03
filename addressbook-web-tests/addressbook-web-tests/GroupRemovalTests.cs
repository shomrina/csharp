using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            OpenMainPage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            SelectFirstGroup();
            DeleteGroup();
            ReturnToGroupPage();
            Logout();
        }
    }
}
