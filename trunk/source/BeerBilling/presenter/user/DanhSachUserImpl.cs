using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Text;
using BeerBilling.view;
using core_lib.common;
using domain_lib.controller;
using domain_lib.dto;

namespace BeerBilling.presenter.user
{
    public class DanhSachUserImpl : IDanhSachUser
    {
        private Controller _controller = new Controller();

        public UserDto CheckUser(string userName, string password)
        {
            return _controller.login(userName, password);
        }

        public bool changePassword(string userId, string newPass, string oldPass)
        {
            var rcode = _controller.changePassword(userId, oldPass, newPass);
            return "0".Equals(rcode);
        }

        public bool IsValidInputData()
        {
            return true;
        }

        public string GetCurrentTenNsd()
        {
            return _controller.GetTenNsd(ThamSo.UserId);
        }

        public string GetCurrentUserName()
        {
            return _controller.GetUserName(ThamSo.UserId);
        }

        public List<UserDto> getAllUser()
        {
            return _controller.getAllUser();
        }

        public List<UserDto> QueryUser(string userName, string fullName)
        {
            return _controller.QueryUser(userName, fullName);
        }

        public bool SaveUser(UserDto userDto)
        {
            return _controller.SaveUser(userDto);
        }

        public bool ExistsUser(long userId, string username)
        {
            return _controller.ExistsUser(userId, username);
        }

        public bool DeleteUser(long userId)
        {
            return _controller.DeleteUser(userId);
        }

        public UserDto GetUser(long userId)
        {
            return _controller.GetUser(userId);
        }

        public string ResetPassword(long userId)
        {
            return _controller.ResetPassword(userId);
        }
    }
}
