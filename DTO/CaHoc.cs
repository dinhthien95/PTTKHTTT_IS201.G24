using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaHoc
    {
        public string _maca { get; set; }
        public string _buoi { get; set; }
        public float _giobatdau { get; set; }
        public float _gioketthuc { get; set; }
        public CaHoc()
        {
        }
        public CaHoc(string maca,string buoi,float giobatdau,float gioketthuc)
        {
            this._maca = maca;
            this._buoi = buoi;
            this._giobatdau = giobatdau;
            this._gioketthuc = _gioketthuc;
        }
    }
}
