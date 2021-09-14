using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Novin
{
    class cls_users
    {
        public enum userAccountTypes { uat_programmer = 0, uat_admin, uat_typical, uat_limited }

        private static string s_userName;
        public static string user_name
        {
            get { return s_userName; }
        }

        private static string s_userPassword = "";
        public static string user_password
        {
            get { return s_userPassword; }
        }

        private static string s_userLimitString;
        public static string user_limitString
        {
            get { return s_userLimitString; }
        }

        private static string s_userPicPath = "";
        public static string user_picPath
        {
            get { return s_userPicPath; }
        }

        private static int n_userPicIndex;
        public static int user_picIndex
        {
            get { return n_userPicIndex; }
        }
        
        private static userAccountTypes uat_userAccountType;
        public static userAccountTypes user_accountType
        {
            get { return uat_userAccountType; }
        }

        private static int n_user_id;
        public static int user_id
        {
            get { return n_user_id; }
            set 
            {
                n_user_id = value;
                selectWhere(n_user_id);
            }
        }
        public static int getNextUserID()
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

            _mydal.connect();
            int n_userID = (int)_mydal.doCommandScalar("select max(user_id) from tbl_users");
            _mydal.disconnect();

            return ++n_userID;
        }      

        public static int usersCount()
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();

            _mydal.connect();
            int n_usersCount = (int)_mydal.doCommandScalar("select count(*) from tbl_users");
            _mydal.disconnect();

            return n_usersCount;
        }
        public static string getAUserPassword(int n_user_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "select user_password from tbl_users where user_id = {0}";
            s_sqlCommand = string.Format(s_sqlCommand, n_user_id);

            _mydal.connect();
            string s_userPassword = (string)_mydal.doCommandScalar(s_sqlCommand);
            _mydal.disconnect();

            return s_userPassword;
        }
        public static string getAUserName(int n_user_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "select user_name from tbl_users where user_id = {0}";
            s_sqlCommand = string.Format(s_sqlCommand, n_user_id);

            _mydal.connect();
            string s_userPassword = (string)_mydal.doCommandScalar(s_sqlCommand);
            _mydal.disconnect();

            return s_userPassword;
        }
        public static DataTable selectAllUsers()
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "select * from tbl_users;";

            _mydal.connect();
            DataTable dt_users = _mydal.select(s_sqlCommand, "tbl_users");
            _mydal.disconnect();

            return dt_users;
        }
        public static DataTable selectWhere(int n_user_id)
        {
            cls_myDataAccessLayer _mydal = new cls_myDataAccessLayer();
            string s_sqlCommand = "select * from tbl_users where user_id = {0};";
            s_sqlCommand = string.Format(s_sqlCommand, n_user_id);

            _mydal.connect();
            DataTable dt_users = _mydal.select(s_sqlCommand, "tbl_users");
            _mydal.disconnect();

            try
            {
                s_userName = (string)dt_users.Rows[0]["user_name"];
            }
            catch (Exception ex)
            {
                cls_msgBox.show(ex.Message);
                uat_userAccountType = 0;
            }
            try
            {
                s_userPassword = (string)dt_users.Rows[0]["user_password"];
            }
            catch
            {
            }
            try
            {
                s_userLimitString = (string)dt_users.Rows[0]["user_limitString"];
            }
            catch
            {
            }
            try
            {
                uat_userAccountType = (userAccountTypes)dt_users.Rows[0]["user_accountType"];
            }
            catch
            {
            }
            
            try
            {
                n_userPicIndex = (int)dt_users.Rows[0]["user_picIndex"];
            }
            catch
            {
            }
            try
            {
                s_userPicPath = (string)dt_users.Rows[0]["user_picPath"];
            }
            catch
            {
            }

            return dt_users;
        }
    }
}
