using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DeThi
    {
        public string _madethi;
        public string _maloaidethi;
        public DateTime _ngaylap;
        public DeThi() {  }
        public DeThi(string madethi, string maloaidethi, DateTime ngaylap) {
            this._madethi = madethi;
            this._maloaidethi = maloaidethi;
            this._ngaylap = ngaylap;
        }
    }
}
