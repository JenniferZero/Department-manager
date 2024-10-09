using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _THLTHDT_B3
{
    class Program
    {
        static void Main()
        {
            //GiangVien gv = new GiangVien();
            //gv.nhap();
            //gv.xuat();
            Khoa kh = new Khoa();
            string f = "D:\\Users\\WIN 10\\source\\THLTHDT_B3_DSGV_Khoa\\THLTHDT_B3_DSGV_Khoa\\Khoa.xml";
            kh.DocFileDSGV(f);
            kh.XuatDSGV();
            Console.WriteLine("Danh sach sau khi sap xep nhom tang: ");
            Console.WriteLine("-------------------------------------");
            List<GiangVien> lstSX = kh.SapXep();
            foreach (GiangVien gv in lstSX)
                gv.xuat();
            Console.ReadLine();

        }
    }
}
