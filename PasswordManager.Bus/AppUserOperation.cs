using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordManager.Data;
namespace PasswordManager.Bus
{
public  class AppUserOperation
    {
 
        public bool GetAnyUser(string userName)
        {
            var result = false;
            var query = DbManager._dbInstance.AppUser.Where(s => s.UserName.Equals(userName)).SingleOrDefault();
            if (query == null)
            {
                return result;
            }
            else
            {
                return result = true;
            }
        }

        public void InsertAppUser(string email,string userName,string password)
        {
            string hashPw = PasswordHelper.HashUserPwd(password);
            AppUser adduser = new AppUser()
            {
                Email = email,
                IsActive = true,
                IsDeleted = false,
                Password = hashPw,
                UserName = userName
            };
            DbManager._dbInstance.AppUser.Add(adduser);
            DbManager._dbInstance.SaveChanges();
        }
        public int GetLoginUser(string userName,string password)
        {
            string hashPw = PasswordHelper.HashUserPwd(password);
            int userId = 0;
           var query= DbManager._dbInstance.AppUser.Where(s => s.UserName.Equals(userName) && s.Password.Equals(hashPw) &&s.IsActive.Value&&!s.IsDeleted.Value).SingleOrDefault();
            if (query != null)
            {
              userId = query.UserId;
            }
            return userId;
        }

    }
}
