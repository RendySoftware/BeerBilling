using System;
using System.Collections;
using System.Collections.Generic;
using core_lib.common;
using domain_lib.dto;

namespace BeerBilling.util
{
    public class UserUtil
    {
        public static string GetRoleCode(UserDto userDto)
        {
            if (userDto == null)
            {
                return ConstUtil.USER;
            }
            var allRoles = userDto.AllRoles;
            if (allRoles.Length == 0)
            {
                return ConstUtil.USER;
            }
            return allRoles[0].RoleCode;
        }

        public static bool IsQthtRole(UserDto userDto)
        {
            return string.Compare(GetRoleCode(userDto), ConstUtil.ADMIN, true) == 0;
        }

        public static bool IsQltvRole(UserDto userDto)
        {
            return string.Compare(GetRoleCode(userDto), ConstUtil.USER, true) == 0;
        }

        public static List<string> getAllRoleCode(UserDto userDto)
        {
            var allCodes = new List<string>();
            if (userDto == null)
            {
                allCodes.Add(ConstUtil.USER);
                return allCodes;
            }
            var allRoles = userDto.AllRoles;
            foreach (var roleDto in allRoles)
            {
                allCodes.Add(roleDto.RoleCode);
            }
            return allCodes;
        }
    }
}