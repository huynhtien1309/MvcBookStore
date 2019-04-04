using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MvcBookStore.Models
{
    public class Giohang
    {
        dbQLBansachDataContext data = new dbQLBansachDataContext();
        public int IMasach { set; get; }
        public string sTensach { set; get; }
        public string sAnhbia { set; get; }
        public double dDonggia { set; get; }
        public int iSoluong { set; get; }
        public double dThanhtien
        {
            get { return iSoluong * dDonggia; }
        }
        public Giohang(int Masach)
        {
            IMasach = Masach;
            Sach sach = data.Saches.Single(n => n.MaSach == IMasach);
            sTensach = sach.TenSach;
            sAnhbia = sach.AnhBia;
            dDonggia = double.Parse(sach.GiaBan.ToString());
            iSoluong = 1;
        }
    }
}
