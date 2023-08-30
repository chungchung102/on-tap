using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap
{
    internal class ToaDo
    {
        private float HoanhDo;
        private float TungDo;
        private string TenToaDo;
      
        public float HoanhDo1 { get => HoanhDo; set => HoanhDo = value; }
        public float TungDo1 { get => TungDo; set => TungDo = value; }
        public ToaDo()
        {
            HoanhDo = 0f;
            TungDo = 0f;
        }
        public void NhapToaDo()
        {
            Console.Write("nhap hoanh do: ");
            HoanhDo1 = float.Parse(Console.ReadLine());
            Console.Write("nhap tung do:");
            TungDo1 = float.Parse(Console.ReadLine());
            Console.Write("nhap ten toa do: ");
            TenToaDo = Console.ReadLine();
        }
        public void XuatToaDo()
        {
            Console.Write(TenToaDo +"({0},{1})",HoanhDo,TungDo );
        }
    }
}
