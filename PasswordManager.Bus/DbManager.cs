using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordManager.Data;
namespace PasswordManager.Bus
{
public static class DbManager
    {
        private static PasswordManagerEntities dbInstance;

        public static PasswordManagerEntities _dbInstance
        {
            get
            {
                if (dbInstance == null)
                    dbInstance = new PasswordManagerEntities();

                return dbInstance;
            }
        }
    }
}
