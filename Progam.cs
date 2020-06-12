using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract Class
//namespace AbstractionAbstractClass

//Abstraction Interface
namespace AbstractionInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class
            //KeluargaSodirin Keluarga;

            //Abstraction Interface
            IKeluargaSodirin Keluarga;
            Console.WriteLine("Profil Keluarga Sodirin");
            Console.WriteLine("1. Sodirin");
            Console.WriteLine("2. Partijah");
            Console.WriteLine("3. Ahmad Saifudin");
            Console.WriteLine("4. Miftahul Hoiru\n");
            

            Console.WriteLine("Pilih Prof [1..4]: ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            if (pilihan == 1)
                Keluarga = new Sodirin();
            else if (pilihan == 2)
                Keluarga = new Partijah();
            else if (pilihan == 3)
                Keluarga = new AhmadSaifudin();
            else if (pilihan == 4)
                Keluarga = new MiftahulHoiru();
            else
                Keluarga= new Kosong();

            Keluarga.tampilkan();

            Console.ReadKey();
        }
    }
}