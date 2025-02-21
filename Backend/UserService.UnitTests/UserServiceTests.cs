using UserService.Core.Services;

namespace UserService.UnitTests
{
    [TestClass]
    public class UserServiceTests
    {
        private IUserService _userService;

        [TestInitialize]

        public void Init()
        {
            _userService = new Core.Services.UserService();
        }

        [TestMethod]
        public void RegisterUser_WithNewUser_ShouldReturnTrueWhenUserIsNew()
        {
            bool result = _userService.RegisterUser("seynabou", "seyna@gmail.com", "123", "client");
            Assert.IsTrue(result);
        }

    }
}
