using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAbstractClass
{
    public class Sodirin : KeluargaSodirin
    {
        public override void tampilkan()
        {
            Console.WriteLine("Sodirin adalah kepala keluarga dari Keluarga Sodirin.");
            Console.WriteLine("Sodirin lahir di banjarnegara, 05 Agustus 1967.");
            Console.WriteLine("Mempunyai satu istri dan 2 anak laki-laki");
            Console.WriteLine("Pekerjaan sehari-hari sebagai petani.");
            Console.WriteLine("sekarang tinggal di Sumatra Selatan.");
        }
    }
}