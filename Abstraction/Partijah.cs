using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAbstractClass
{
    public class Partijah : KeluargaSodirin
    {
        public override void tampilkan()
        {
            Console.WriteLine("Partijah adalah sebagai istri Sodirin dan menjadi ratu di keluarga sodirin.");
            Console.WriteLine("Banyak prestasi yang diraih oleh partijah salah satunya yaitu dia mendapatkan beasiswa untuk kuliah.");
            Console.WriteLine("Pekerjaan sebagai PNS di desa pematang sari, kecamatan Mesuji Makmur, Kabupaten Ogan komering Ilir, Provinsi Sumtra Selatan.");
            Console.WriteLine("Dari semasa kecilnya dia gigih dan tak malas untuk membantu orang tuanya, sehingga sekarang menjadi sukses dan terwujud yang dicita-citakan. ");
            Console.WriteLine("Lahir di Sleman, 23 April 1970.");
        }
    }
}