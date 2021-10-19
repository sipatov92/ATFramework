using System.Threading;
using AutomationTesting.Core;

namespace AutomationTesting.POM
{
    public class MainPage : BasePage
    {
        public Control MenuItemAccount { get; set; }
        public Control ButtonRegister { get; set; }

        public Control MenuItemAccountControl => CreateControl("MenuItemAccount");
        public Control ButtonRegisterControl => CreateControl("ButtonRegister");


        public override void Initialize()
        {
        }

        public MainPage ClickMenuItemAccount()
        {
            MenuItemAccountControl.Click();
            return this;
        }

        public RegisterAccountPage ClickButtonRegister(RegisterAccountPage page)
        {
            Thread.Sleep(3000);
            ButtonRegisterControl.Click();
            return page;
        }
    }
}