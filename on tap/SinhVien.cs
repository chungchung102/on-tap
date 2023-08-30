using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_tap
{
    internal class SinhVien
    {
        private int MaSinhVien;
        private string HoTen;
        private float DiemLT;
        private float DiemTH;

        public int MaSinhVien1 { get => MaSinhVien;
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Du lieu ko hop le");
                    MaSinhVien=0;
                }
                else
                    MaSinhVien=value;
            }
        }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public float DiemLT1 { get => DiemLT;
            set
            {
                if (value < 0||value>10)
                {
                    Console.WriteLine("Du lieu ko hop le");
                    DiemLT = 0;
                }
                else
                    DiemLT = value;
            }
        }
        public float DiemTH1 { get => DiemTH;
            set
            {
                if (value < 0||value>10)
                {
                    Console.WriteLine("Du lieu ko hop le");
                    DiemTH = 0;
                }
                else
                    DiemTH = value;
            }
        }
        public SinhVien()
        {
            MaSinhVien = 0;
            HoTen = string.Empty;
            DiemLT1 = 0;
            DiemTH1 = 0;

        }
        public SinhVien(int MaSinhVien,string HoTen,float DiemLT,float DiemTH)
        {
            this.MaSinhVien1 = MaSinhVien;
            this.HoTen1 = HoTen;
            this.DiemLT1 = DiemLT;
            this.DiemTH1 = DiemTH1;
        }
        public float TinhDiemTB()
        {
            return (float)(DiemLT1 + DiemTH1) / 2;
        }
        public void NhapSinhVien()
        {
            Console.Write("Nhap ma sinh vien 3: ");
            MaSinhVien = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten sinh vien 3: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem lt sv3: ");
            DiemLT = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem th sv3: ");
            DiemTH = int.Parse(Console.ReadLine());
        }
        public virtual void XuatSinhVien()
        {


            Console.WriteLine("mssv \t ho ten \t diemLT \t diemTH \t diemTb:\n " + MaSinhVien +HoTen +DiemLT +DiemTH +TinhDiemTB());
           
        }
    } 
}
