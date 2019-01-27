using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordManager.Data;
namespace PasswordManager.Bus
{
public  class PasswordManagerOperation
    {
        public void InsertData(string siteName,string userName,string passWord,int userId)
        {
           
            Data.PasswordManager addPwManager = new Data.PasswordManager()
            {
                IsActive = true,
                IsDeleted = false,
                Password = passWord,
                SiteName = siteName,
                UserId = userId,
                UserName = userName,
            };
            DbManager._dbInstance.PasswordManager.Add(addPwManager);
            DbManager._dbInstance.SaveChanges(); 
        }

        public List<Data.PasswordManager> GetAllPasswordList(int userId )
        {
            return DbManager._dbInstance.PasswordManager.Where(s => s.UserId == userId && s.IsActive.Value && !s.IsDeleted.Value).ToList();
        }
        public void DeletePassword(int pwId)
        {
          var query= DbManager._dbInstance.PasswordManager.Where(s => s.PasswordManagerId == pwId).SingleOrDefault();
            if (query != null)
            {
                query.IsActive = false;
                query.IsDeleted = true;
                DbManager._dbInstance.SaveChanges();
            }
        }

        public void UpdateData(string siteName, string userName, string passWord, int userId,int dataId)
        {
        var query = DbManager._dbInstance.PasswordManager.Where(s => s.UserId == userId && s.PasswordManagerId == dataId && s.IsActive.Value && !s.IsDeleted.Value).SingleOrDefault();
            if (query != null)
            {
                query.SiteName = siteName;
                query.UserName = userName;
                query.Password = passWord;
                DbManager._dbInstance.SaveChanges();
            }

        }
        public Data.PasswordManager GetPasswordManagerSelectedById(int dataId,int userId)
        {
            var query = DbManager._dbInstance.PasswordManager.Where(s => s.PasswordManagerId == dataId && s.UserId == userId && s.IsActive.Value && !s.IsDeleted.Value).SingleOrDefault();
           return query;
        }
    }
}
