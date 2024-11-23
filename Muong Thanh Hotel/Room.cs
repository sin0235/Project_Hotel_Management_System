using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muong_Thanh_Hotel
{
    public class Room
    {
        private int _soPhong;
        private string _loaiPhong;
        private int _floor;
        private float _gia;
        private string _trangThaiPhong;
        private string _loaiGiuong;
        private bool _isAvailable;


        public int soPhong { get { return _soPhong; } set { _soPhong = value; } }
        public string loaiPhong { get { return _loaiPhong; } set { _loaiPhong = value; } }
        public int floor { get { return _floor; } set { _floor = value; } }
        public float gia { get { return _gia; } set { _gia = value; } }
        public bool isAvailable { get { return _isAvailable; } set { _isAvailable = value; } }
        public string loaiGiuong { get { return _loaiGiuong; } set { _loaiGiuong = value; } }
        public string trangThaiPhong { get {return _trangThaiPhong; } set {_trangThaiPhong = value; }}
    }
}