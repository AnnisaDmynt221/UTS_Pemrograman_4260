using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts_pemro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dosen inidosen = new dosen(1, "Kamarudin", 21114260, "Laki-laki", "Pemrograman");
            inidosen.Hasil();
            Console.WriteLine();
            inidosen.addDosen();
            inidosen.addCourse();
            Console.WriteLine();
            inidosen.HasilAkhir();

            Console.ReadKey();
        }
    }
}
