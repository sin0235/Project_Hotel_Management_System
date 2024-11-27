using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muong_Thanh_Hotel
{
    public class Room : IMappingToDSPhong
    {
        private int _soPhong;
        private string _loaiPhong;
        private int _soTang;
        private float _gia;
        private string _trangThaiPhong;
        private string _loaiGiuong;
        private string _isAvailable;


        public int soPhong { get { return _soPhong; } set { _soPhong = value; } }
        public string loaiPhong { get { return _loaiPhong; } set { _loaiPhong = value; } }
        public int soTang { get { return _soTang; } set { _soTang = value; } }
        public float gia { get { return _gia; } set { _gia = value; } }
        public string isAvailable { get { return _isAvailable; } set { _isAvailable = value; } }
        public string loaiGiuong { get { return _loaiGiuong; } set { _loaiGiuong = value; } }
        public string trangThaiPhong { get { return _trangThaiPhong; } set { _trangThaiPhong = value; } }

        public danhSachPhong mapping()
        {
            danhSachPhong dsPhong = new danhSachPhong();
            dsPhong.soPhong = soPhong;
            dsPhong.soTang = soTang;
            dsPhong.loaiPhong = loaiPhong;
            dsPhong.trangThaiPhong = trangThaiPhong;
            dsPhong.gia = gia;
            dsPhong.isAvailable = isAvailable;
            dsPhong.loaiGiuong = loaiGiuong;
            return dsPhong;
        }
    }

}