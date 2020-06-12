using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAbstractClass
{
    public class Kosong : KeluargaSodirin
    {
        public override void tampilkan()
        {
            Console.WriteLine("Profil Tidak Ditemukan");
        }
    }
}