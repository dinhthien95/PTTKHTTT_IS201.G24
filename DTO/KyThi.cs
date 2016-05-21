using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class KyThi
    {
        public  string _makythi{set; get;}
        public DateTime _ngaythi { set; get; }
        public float _giothi { set; get; }
        public string _maphongthi { set; get; }
        public string _madethi { set; get; }
        public KyThi(string makythi, DateTime ngaythi, int giothi, string maphongthi, string madethi)
        {
            this._makythi = makythi;
            this._ngaythi = ngaythi;
            this._giothi = giothi;
            this._maphongthi = maphongthi;
            this._madethi = madethi;
        }

    }
}
