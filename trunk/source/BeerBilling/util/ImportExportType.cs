using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeerBilling.util
{
    class ImportExportType
    {
        public static ImportExportType IMPORT = new ImportExportType("IMP", "Nhập kho");
        public static ImportExportType EXPORT = new ImportExportType("EXP", "Xuất kho");

        private string _code;

        private string _name;

        private ImportExportType( String code, String name)
        {
            this.code = code;
            this.name = name;
        }

        public virtual string code
        {
            get { return _code; }
            set { _code = value; }
        }

        public virtual string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
