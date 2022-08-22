using NUnit.Framework;
using System;
using TestsXF.App.ViewModels;

namespace TestsXF.NUnit
{
    [TestFixture]
    public class LoginViewModelTest
    {
        //private readonly Mock<IAuthenticationService> authenticationServiceMock = new Mock<IAuthenticationService>();

        private LoginViewModel _loginViewModel;

        [SetUp]
        public void Setup()
        {
            _loginViewModel = new LoginViewModel();
        }

        [Test]
        public void ThrowsArgumentNullException_IfUserNameIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _loginViewModel.OnLogin(null, "123"));
        }
        [Test]
        public void ThrowsArgumentNullException_IfPasswordIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _loginViewModel.OnLogin("Esti", null));
        }

    }
}
