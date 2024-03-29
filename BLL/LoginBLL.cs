﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        public SqlDataReader getLogin(tblLogin login)
        {
            LoginDAL dal = new LoginDAL();
            return dal.getLogin(login);
        }
        public List<tblLogin> GetUserDAL()
        {
            LoginDAL dal = new LoginDAL();
            return dal.GetUserDAL();
        }
        public List<tblLogin> SearchUserDAL(string name)
        {
            LoginDAL dal = new LoginDAL();
            return dal.SearchUserDAL(name);
        }
        public bool AddUserDAL(tblLogin user)
        {
            LoginDAL dal = new LoginDAL();
            return dal.AddUserDAL(user);
        }
        public bool DelUserDAL(string id)
        {
            LoginDAL dal = new LoginDAL();
            return dal.DelUserDAL(id);
        }
        public bool UpUserDAL(tblLogin user)
        {
            LoginDAL dal = new LoginDAL();
            return dal.UpUserDAL(user);
        }
    }
}
