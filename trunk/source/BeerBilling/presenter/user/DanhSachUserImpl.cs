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

    }
}
