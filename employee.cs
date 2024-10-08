using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndSignUp
{
    public class employer
    {
        private string MaSP;

        public string masp { get => MaSP; set => MaSP = value; }

        private string TenSP;

        public string tensp { get => TenSP; set => TenSP = value; }

        private string Don_gia;

        public string dongia { get => Don_gia; set => Don_gia = value; }

        private string Hinh_anh;

        public string hinhanh { get => Hinh_anh; set => Hinh_anh = value; }

        private string Mo_ta_ngan;

        public string mota { get => Mo_ta_ngan; set => Mo_ta_ngan = value; }

        private string Mo_ta_dai;

        public string mota1 { get => Mo_ta_dai; set => Mo_ta_dai = value; }

        private string Loai_SP;

        public string loaisp { get => Loai_SP; set => Loai_SP = value; }

        public employer(string maSP, string tenSP, string don_gia,  string hinh_anh,  string mo_ta_ngan,  string mo_ta_dai,  string loai_SP )
        {
            MaSP = maSP;
            TenSP = tenSP;

            Don_gia = don_gia;

            Hinh_anh = hinh_anh;

            Mo_ta_ngan = mo_ta_ngan;

            Mo_ta_dai = mo_ta_dai;

            Loai_SP = loai_SP;

        }
    }
}
