using System;

namespace domain_lib.dto
{
    public class DanhMucDto : CommonDto
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Id { get; set; }
        public string GhiChu { get; set; }

        public string PhanLoai { get; set; }
        public string TenNganGon { get; set; }
    }
}
