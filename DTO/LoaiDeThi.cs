using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDeThi
    {
        string _maloaidethi { get; set; }
        string _tenloidethi { get; set; }
        float _thoiluongdethi { get; set; }

        public LoaiDeThi() { }
        public LoaiDeThi(string maloaidethi, string tenloaidethi, float thoiluongthi)
        {
            this._maloaidethi = maloaidethi;
            this._tenloidethi = tenloaidethi;
            this._thoiluongdethi = thoiluongthi;
        }

    }
}
