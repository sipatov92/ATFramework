using System;
using System.Threading;
using AutomationTesting.Core;
using AutomationTesting.POM;
using NUnit.Framework;

namespace AutomationTesting.TC
{
    public class Test_WI_1 : BaseTestCase
    {
        [Test]
        public void Test()
        {
            Driver.Navigate().GoToUrl(BaseUrl);

            #region MyRegion

            Random rnd = new Random();
            var firstName = "Abba" + rnd.Next(1, 50);
            var lastName = "Tarantino" + rnd.Next(1, 50);
            var email = "new" + rnd.Next(1, 50) + "@gmail.com";
            var telephone = rnd.Next(1, 5000).ToString();
            var password = "Qwerty1!";

            #endregion

            CreatePage<MainPage>().ClickMenuItemAccount()
                .ClickButtonRegister(CreatePage<RegisterAccountPage>())
                .SetFirstName(firstName)
                .SetLastName(lastName)
                .SetEmail(email)
                .SetTelephone(telephone)
                .SetPassword(password)
                .SetConfirmPassword(password)
                .ClickRadioButtonNo()
                .ClickButtonAgree()
                .ClickButtonContinue();
        }
    }
}