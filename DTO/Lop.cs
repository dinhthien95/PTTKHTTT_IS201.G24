using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        string _malop { get; set; }
        string _makhoahoc { get; set; }
        string _machuongtrinhhoc { get; set; }
        DateTime _ngaybatdau { get; set; }
        DateTime _ngayketthuc { get; set; }
        string _maca { get; set; }
        string _mangay { get; set; }
        string _magiangvien { get; set; }
        string _maphonghoc { get; set; }
        public Lop() { }
        public Lop(string malop, string makhoahoc, string machuongtrinhhoc, DateTime ngaybatdau, DateTime ngayketthuc, string maca, string mangay, string magiangvien, string maphonghoc)
        {
            this._malop = malop;
            this._makhoahoc = makhoahoc;
            this._machuongtrinhhoc = machuongtrinhhoc;
            this._ngaybatdau = ngaybatdau;
            this._ngayketthuc = ngayketthuc;
            this._maca = maca;
            this._mangay = mangay;
            this._magiangvien = magiangvien;
            this._maphonghoc = maphonghoc;
        }
    }
}
