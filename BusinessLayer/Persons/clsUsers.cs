using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class clsUsers 
    {
         private enum enMode { enUpdate = 0, enAdd = 1 };
         private enMode Mode = new enMode();

        
        public enum enPermission
        {
            enAll = -1,enAdd = 1, enUpdate = 2, enDelete = 4, enFind = 8, 
            enTransaction = 16, enManageUsers = 32, enLoginRegister = 64
        };
        

        public int UserID {  get; set; }
        public string UserName { get; set; }
         public string FirstName { get; set; }
         public string LastName { get; set; }
         public string Email { get; set; }
         public int Phone { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }

        public clsUsers()
        {
            this.UserID = -1;
            this.UserName = "";
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = 0;
            this.Password = "";
            this.Permission = 0;
            Mode = enMode.enAdd;
        }

        private clsUsers(int UserID, string UserName, string FirstName, string LastName, string Email
            , int Phone, string Password, int Persmission)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Password = Password;
            this.Permission = Persmission;
            Mode = enMode.enUpdate;
        }

        private bool _AddUser()
        {
            return clsDataUsers.AddNewUser( this.UserName, this.FirstName, this.LastName,
                this.Email, this.Phone, this.Password, this.Permission);
        }
        
        private bool _UpdateUser()
        {

            return clsDataUsers.UpdateUser(this.UserID, this.UserName, this.FirstName, this.LastName,
                this.Email,this.Phone, this.Password, this.Permission);
        }

        public bool Save()
        {
           switch(Mode)
            {
                case enMode.enAdd:
                    if (_AddUser())
                    {
                        Mode = enMode.enUpdate;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.enUpdate:
                    return _UpdateUser();

            }
            return true;
        }

        static public bool CheckedUser(string UserName, string Password)
        {
            return clsDataUsers.CheckedDataUser(UserName, clsSetting.Encryption(Password));
        }
        static public bool AddLoginRegister(string UserName)
        {
            return clsDataUsers.AddLoginRegister(UserName);
        }
        static public DataTable GetAllLoginRegister()
        {
            return clsDataUsers.GetAllLoginRegister();
        }

        static public clsUsers FindUserByUserID(int UserID)
        {
            string US = "",FirstName = "", LastName = "", Email = "", Password = "";
            int  Permission = 0, Phone = 0;
            if (clsDataUsers.FindUserByID(UserID, ref US, ref FirstName, ref LastName, ref Email, ref Phone,
                ref Password, ref Permission))
            {
                return new clsUsers(UserID, US, FirstName, LastName, Email, Phone,
                    clsSetting.Decryption(Password), Permission);
            }
            return new clsUsers(0 , US, FirstName, LastName, Email, Phone,
                    clsSetting.Decryption(Password), Permission);
            
        }

        static public clsUsers FindUserByUserName(string UserName)
        {
            int UserID = 0, Phone = 0,Permission  = 0;
            string FirstName = "", LastName = "", Email = "", Password = "";
            if (clsDataUsers.FindUserByUserName(ref UserID, UserName,ref FirstName,ref LastName, 
                ref Email,ref Phone,ref Password,ref Permission))
            {
                return new clsUsers(UserID, UserName, FirstName, LastName, Email, Phone,
                    clsSetting.Decryption(Password), Permission);
            }
            return new clsUsers(UserID, "", FirstName, LastName, Email, Phone,
                    clsSetting.Decryption(Password), Permission);
        }

        static public bool DeleteUserByUserID(int UserID)
        {
            return clsDataUsers.DeleteUser(UserID);
        }

        static public bool CheckedUser(int UserID)
        {
            return clsDataUsers.CheckedUser(UserID);
        }

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            dt = clsDataUsers.GetAllUsers();
            if (dt.Columns.Count == 0)
            {
                return dt;
            }
            DataRow[] Resulted = dt.Select("UserID>0");

            foreach (var ResultedRow in Resulted)
            {
                ResultedRow["Password"] = clsSetting.Decryption(ResultedRow["Password"].ToString());
            }
            return dt;
        }

        static public bool NotUniqueUserName(string UN, int ID)
        {
            return clsDataUsers.NotUniqueUser(UN, ID);
        }

    }
}
