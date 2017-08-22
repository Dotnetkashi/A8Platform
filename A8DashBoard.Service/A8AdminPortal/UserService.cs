using System;
using System.Linq;
using System.Web;
using A8DashBoard.Data.CustomUserIdentity;
using A8Dashboard.Models.Enums;
using A8Dashboard.Models.CustomUserIdentity;
using A8DashBoard.Data.Repository.A8AdminPortal;
using A8DashBoard.Data.CustomIdentity;
using A8DashBoard.Models.A8Product.ViewModels;

namespace A8DashBoard.Service.A8AdminPortal
{
    class UserService
    {

        private UserRepository UserRepo;
        public UserService()
        {
            UserRepo = new UserRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objser"></param>
        public async void CreateWifiUser(User objUser)
        {
          await UserRepo.CreateWifiUser(objUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public async void UpdateWifiUser(User objUser)
        {
          await UserRepo.UpdateUser(objUser);  
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUser"></param>
        public async void CreateAuthenticatedUser(User objUser)
        {
           await UserRepo.CreateApplicationUser(objUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objUser"></param>
        public void CreateUserRole(User objUser)
        {
            UserRepo.AddToRoleAsync(objUser.Id, "WiFiUser");
        }

      
        public int GetUserId(string UserName)
        {
            return UserRepo.GetUserIdFromUserName(UserName);
        }

        public User MapToApplicationUser(MemberViewModel model)
        {
            User objUser = new User();
            objUser= UserRepo.GetMemberAsPerUserUniqueId(model.UserId, model.SiteId);
            objUser.UserName = model.UserName;
            objUser.Email = model.Email;
            objUser.PasswordHash = model.Password;
            objUser.SiteId = model.SiteId;
            objUser.FirstName = model.FirstName;
            objUser.LastName = model.LastName;
            objUser.UniqueUserId = model.UserId;
            objUser.AutoLogin = model.AutoLogin;
            objUser.MobileNumer = model.MobileNumber;
            objUser.GenderId = model.GenderId;
            objUser.AgeId = model.AgeId;
            objUser.BirthDate = model.BirthDate;
            return objUser;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public User GetUniqueUserAsPerUserName(string UserName, int SiteId)
        {
            return UserRepo.GetUserAsPerUserNameDb(UserName, SiteId);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="MacAddress"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public User GetDeviceAsPerMacAddress(string MacAddress, int SiteId)
        {
            return UserRepo.GetUserAsPerMacAddress(MacAddress, SiteId);
        }

       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public bool IsNewUserAsPerUserName(string UserName, int SiteId)
        {
            return UserRepo.IsNewUserAsPerUserName(UserName, SiteId);
        }
    }
}
