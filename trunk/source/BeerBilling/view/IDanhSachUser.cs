using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using domain_lib.dto;

namespace BeerBilling.view
{
    public interface IDanhSachUser : IDanhMuc
    {
        UserDto CheckUser(string userName, string password);
        bool changePassword(string userId, string newPass, string oldPass);
        string GetCurrentTenNsd();
        string GetCurrentUserName();
        List<UserDto> getAllUser();
        List<UserDto> QueryUser(string userName, string fullName);
        bool SaveUser(UserDto userDto);
        bool ExistsUser(long userId, string username);
        bool DeleteUser(long userId);
        UserDto GetUser(long userId);
    }
}
