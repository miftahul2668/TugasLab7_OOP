using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    public class MiftahulHoiru : IKeluargaSodirin
    {
        public void tampilkan()
        {
            Console.WriteLine("Panggilan sehari-hari sebagai Hoiru dan anak ke-dua dari pasangan sodirin dan partijah.");
            Console.WriteLine("Dari semasa lahir dia tidak suka makan nasi tetapi ketika dia masuk ke jenjang SMP dia mulai suka dengan nasi.");
            Console.WriteLine("Cita-cita dari kecil ingin jadi dokter tetapi tidak diijinkan oleh kedua orang tuanya.");
            Console.WriteLine("Sekarang menempuh perguruan tinggi di Universitas Amikom Yogyakarta yang dikenal sebagai kampusnya orang-orang berdasi.");
            Console.WriteLine("Lahir di Binakarsa,Mesuji 01 Maret 2001.");
        }
    }
}