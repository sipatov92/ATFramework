using AutomationTesting.Core;
using OpenQA.Selenium;

namespace AutomationTesting.POM.RegisterAccountPage
{
    public class RegisterAccountPage : BasePage
    {
        public CustomControl EditFirstName { get; set; }
        public CustomControl EditLastName { get; set; }
        public CustomControl EditEmail { get; set; }
        public CustomControl EditTelephone { get; set; }
        public CustomControl EditPassword { get; set; }
        public CustomControl EditConfirmPassword { get; set; }
        public CustomControl RadioButtonNo { get; set; }
        public CustomControl ButtonAgree { get; set; }
        public CustomControl ButtonContinue { get; set; }
        
        public IWebElement EditFirstNameControl => CreateControl(EditFirstName).NativeControl;
        public IWebElement EditLastNameControl => CreateControl(EditLastName).NativeControl;
        public IWebElement EditEmailControl => CreateControl(EditEmail).NativeControl;
        public IWebElement EditTelephoneControl => CreateControl(EditTelephone).NativeControl;
        public IWebElement EditPasswordControl => CreateControl(EditPassword).NativeControl;
        public IWebElement EditConfirmPasswordControl => CreateControl(EditConfirmPassword).NativeControl;
        
        public IWebElement RadioButtonNoControl => CreateControl(RadioButtonNo).NativeControl;
        public IWebElement ButtonAgreeControl => CreateControl(ButtonAgree).NativeControl;
        public IWebElement ButtonContinueControl => CreateControl(ButtonContinue).NativeControl;
        
    }
}