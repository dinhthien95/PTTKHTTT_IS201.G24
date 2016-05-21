using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaHoc
    {
        public string _makhoahoc{get;set;}
        public string _tenkhoahoc { get; set; }
        public DateTime _ngaykhaigiang { get; set; }
        public KhoaHoc() { }
        public KhoaHoc(string makhoahoc, string tenkhoahoc, DateTime ngaykhaigiang)
        {
            this._makhoahoc = makhoahoc;
            this._tenkhoahoc = tenkhoahoc;
            this._ngaykhaigiang = ngaykhaigiang;
        }
    }
}
