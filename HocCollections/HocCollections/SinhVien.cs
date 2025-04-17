using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocCollections
{
    internal class SinhVien
    {
        private int maSV;
        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        private string? hoTen;
        public string? HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
    }
}