using A8Dashboard.Models.CustomUserIdentity;
using A8DashBoard.Data.Repository.A8AdminPortal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A8DashBoard.Data.A8Product;

namespace A8DashBoard.Service.A8AdminPortal
{
    class MemberService
    {
        private UserRepository UserRepo;
        private A8ProdcutEntities db;
        public MemberService( )
        {
            UserRepo = new UserRepository();
            db = new A8ProdcutEntities();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MemberUniqueId"></param>
        /// <param name="SiteId"></param>
        public async void RemoveMemberAsUserUniqueId(string MemberUniqueId, int SiteId)
        {
            var User = GetMemberAsPerUserUniqueIdSiteId(MemberUniqueId, SiteId);
            await UserRepo.DeleteUser(User);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MemberUniqueId"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public User GetMemberAsPerUserUniqueIdSiteId(string MemberUniqueId, int SiteId)
        {
           return  UserRepo.GetMemberAsPerUserUniqueId(MemberUniqueId, SiteId);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="MemberUniqueId"></param>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public bool IsMemberExistInSite(string MemberUniqueId,int SiteId)
        {
            return UserRepo.IsMemberExist(MemberUniqueId, SiteId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool UserIsMemeber(string UserName)
        {
            return UserRepo.IsUserAMember(UserName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool IsAuthenticatedUserExist(string UserName, string Password,int SiteId)
        {
            return UserRepo.IsAuthenticatedMemberWithCredential(UserName, Password, SiteId);
        }
    }
}
