
using on_tap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap
{
    class Program
    {
        static void Main(string[] arg)
        {
            //ToaDo td = new ToaDo();
            //td.NhapToaDo();
            //td.XuatToaDo();
            SinhVien sv=new SinhVien();
            sv.NhapSinhVien();
            sv.XuatSinhVien();
            Console.ReadLine();
        }

    }
   
}
