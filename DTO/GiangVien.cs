using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien
    {
        public string _magv { get; set; }
        public string _tengv { get; set; }
        public GiangVien()
        {

        }
        public GiangVien(string magv,string tengv)
        {
            this._magv = magv;
            this._tengv = tengv;
        }
    }
}
