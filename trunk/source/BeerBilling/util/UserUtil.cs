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
                return String.Empty;
            }
            var allRoles = userDto.AllRoles;
            if (allRoles.Length == 0)
            {
                return String.Empty;
            }
            if (HasQthtRole(userDto))
            {
                return ConstUtil.ADMIN;
            }
            if (HasQlhdRole(userDto))
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

        public static bool HasRole(UserDto userDto, string roleCode)
        {
            if (userDto == null)
            {
                return false;
            }
            var allRoles = userDto.AllRoles;
            if (allRoles.Length == 0)
            {
                return false;
            }
            foreach(RoleDto dto in allRoles)
            {
                if (string.Compare(dto.RoleCode, roleCode, true) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasQthtRole(UserDto userDto)
        {
            return HasRole(userDto, ConstUtil.ADMIN);
        }

        public static bool HasQlkhRole(UserDto userDto)
        {
            return HasRole(userDto, ConstUtil.QLKH);
        }

        public static bool HasQlhdRole(UserDto userDto)
        {
            return HasRole(userDto, ConstUtil.QLHD);
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