using NUnit.Framework;
using Senka_QAkurs.Helpers;
using Senka_QAkurs.Pages;
using System;
using TechTalk.SpecFlow;

namespace Senka_QAkurs.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.SignIn);

        }

        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username,TestConstants.Username);
            ut.EnterTextInElement(ap.password,TestConstants.Password);
        }

        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signInBtn);

        }

        [When(@"user opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage map = new MyAccountPage(Driver);
            ut.ClickOnElement(map.wishlist);
        }

        [Then(@"can add new wishlist")]
        public void ThenCanAddNewWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyWishlistPage mwp = new MyWishlistPage(Driver);
            Assert.True(ut.ElementDisplayed(mwp.newWishlist));
        }


        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage map = new MyAccountPage(Driver);
            Assert.True(ut.ElementDisplayed(map.logOutBtn), "Log out failed");
        }
    }
}
