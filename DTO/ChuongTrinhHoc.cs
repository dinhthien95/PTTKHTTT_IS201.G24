using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuongTrinhHoc
    {
        public string _machuongtrinhhoc { get; set; }
        public string _matrinhdo { get; set; }
        public string _tenlop { get; set; }
        public double _hocphi { get; set; }
        public ChuongTrinhHoc()
        {
        }
        public ChuongTrinhHoc(string machuongtrinhhoc, string matrinhdo, string tenlop, double hocphi)
        {
            this._machuongtrinhhoc = machuongtrinhhoc;
            this._matrinhdo = matrinhdo;
            this._tenlop = tenlop;
            this._hocphi = hocphi;
        }
    }
}
