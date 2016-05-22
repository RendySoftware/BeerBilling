using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain_lib.dto
{
    public class UserDto
    {
        #region Declarations

        // Property variables
        private long _userId = -1;

        // Member variables
        private string _accountNumber = string.Empty;

        private string _userName = String.Empty;

        private string _fullName = String.Empty;

        private DateTime? _ngaySinh;

        private String _soCmnd = String.Empty;

        private DateTime? _ngayCap;

        private String _soDienThoai = String.Empty;

        private String _diaChi = String.Empty;

        private String _gioiTinh = String.Empty;

        private String _soTaiKhoan = String.Empty;

        private String _chiNhanhNh = String.Empty;

        private String _imageUrl = String.Empty;

        private DateTime _createdDate = DateTime.Now;

        private String _createdBy = String.Empty;

        private RoleDto[] _roles = new RoleDto[0];

        private string _message = string.Empty;

        private string _parentId = string.Empty;

        private string _parentDirectId = string.Empty;

        #endregion

    	#region Constructor

        public UserDto()
        {
        }

    	#endregion

        #region Properties

        /// <summary>
        /// User ID
        /// </summary>
        public virtual long UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }

        /// <summary>
        /// Account Number
        /// </summary>
        public virtual string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        /// <summary>
        /// Parent ID
        /// </summary>
        public virtual string ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }

        /// <summary>
        /// Parent Direct ID
        /// </summary>
        public virtual string ParentDirectId
        {
            get { return _parentDirectId; }
            set { _parentDirectId = value; }
        }

        /// <summary>
        /// User name.
        /// </summary>
        public virtual string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        /// <summary>
        /// Full name.
        /// </summary>
        public virtual string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        /// <summary>
        /// Ngay Sinh
        /// </summary>
        public virtual DateTime? NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        /// <summary>
        /// So Cmnd
        /// </summary>
        public virtual String SoCmnd
        {
            get { return _soCmnd; }
            set { _soCmnd = value; }
        }

        /// <summary>
        /// Ngay Cap
        /// </summary>
        public virtual DateTime? NgayCap
        {
            get { return _ngayCap; }
            set { _ngayCap = value; }
        }

        /// <summary>
        /// So Dien Thoai
        /// </summary>
        public virtual String SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }

        /// <summary>
        /// Dia Chi
        /// </summary>
        public virtual String DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        /// <summary>
        /// Gioi Tinh
        /// </summary>
        public virtual String GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        /// <summary>
        /// So Tai Khoan
        /// </summary>
        public virtual String SoTaiKhoan
        {
            get { return _soTaiKhoan; }
            set { _soTaiKhoan = value; }
        }

        /// <summary>
        /// Chi Nhanh NH
        /// </summary>
        public virtual String ChiNhanhNH
        {
            get { return _chiNhanhNh; }
            set { _chiNhanhNh = value; }
        }

        /// <summary>
        /// Member Code
        /// </summary>
        public virtual String ImageUrl
        {
            get { return _imageUrl; }
            set { _imageUrl = value; }
        }

        /// <summary>
        /// Created Date
        /// </summary>
        public virtual DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        /// <summary>
        /// So Cmnd
        /// </summary>
        public virtual String CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        /// <summary>
        /// Message
        /// </summary>
        public virtual String Message
        {
            get { return _message; }
            set { _message = value; }
        }

        /// <summary>
        /// Array of Roles
        /// </summary>
        public virtual RoleDto[] AllRoles
        {
            get { return _roles; }
            set { _roles = value; }
        }

        #endregion

        #region Method Overrides

        public override string ToString()
        {
            return _userName;
        }

        #endregion
    }
}
