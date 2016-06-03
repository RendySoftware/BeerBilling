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
                return ConstUtil.QLHD;
            }
            var allRoles = userDto.AllRoles;
            if (allRoles.Length == 0)
            {
                return ConstUtil.QLHD;
            }
            return allRoles[0].RoleCode;
        }

        public static string GetRoleName(UserDto userDto)
        {
            if (userDto == null)
            {
                return String.Empty;
            }
            var allRoles = userDto.AllRoles;
            if (allRoles.Length == 0)
            {
                return String.Empty;
            }
            return allRoles[0].Description;
        }

        public static bool IsQthtRole(UserDto userDto)
        {
            return string.Compare(GetRoleCode(userDto), ConstUtil.ADMIN, true) == 0;
        }

        public static bool IsQlkhRole(UserDto userDto)
        {
            return string.Compare(GetRoleCode(userDto), ConstUtil.QLKH, true) == 0;
        }

        public static bool IsQlhdRole(UserDto userDto)
        {
            return string.Compare(GetRoleCode(userDto), ConstUtil.QLHD, true) == 0;
        }

        public static List<string> getAllRoleCode(UserDto userDto)
        {
            var allCodes = new List<string>();
            if (userDto == null)
            {
                allCodes.Add(ConstUtil.QLHD);
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