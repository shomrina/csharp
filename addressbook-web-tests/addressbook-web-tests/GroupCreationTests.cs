﻿using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        

        [Test]
        public void GroupCreationTest()
        {
            OpenMainPage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            Logout();
        }

       
    }
}
