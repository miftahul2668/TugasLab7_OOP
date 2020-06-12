using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    public class AhmadSaifudin : IKeluargaSodirin
    {
        public void tampilkan()
        {
            Console.WriteLine("Biasa di panggil ahmad, dan menjadi anak pertama dari pasangan sodirin dan partijah.");
            Console.WriteLine("cita-cita semasa kecilnya yaitu ingin jadi guru.");
            Console.WriteLine("Menempuh perguruan tinggi di Universitas Ahmad Dahlan Yogyakarta dan mengambil prodi matematika.");
            Console.WriteLine("Lahir di Binakarsa, 15 Agustus 1995.");
        }
    }
}