using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts_pemro
{
    class dosen
    {
        private int id { get; set; }
        private string nama { get; set; }
        private int nik { get; set; }
        private string gender { get; set; }
        private string course { get; set; }

        public dosen(int id, String nama, int nik, String gender, String course)
        {
            this.id = id;
            this.nama = nama;
            this.nik = nik;
            this.gender = gender;
            this.course = course;
        }

        public void Hasil()
        {
            Console.WriteLine("Data Dosen");
            Console.WriteLine();
            Console.WriteLine($"ID      : {this.id}");
            Console.WriteLine($"Nama    : {this.nama}");
            Console.WriteLine($"NIK     : {this.nik}");
            Console.WriteLine($"Gender  : {this.gender}");
            Console.WriteLine($"Course  : {this.course}");    
        }

        public void addDosen()
        {
            Console.WriteLine("Inputkan Nama Dosen  : ");
            this.nama = Console.ReadLine();
            Console.Write("Inputkan NIK Dosen       : ");
            this.nik = Convert.ToInt32(Console.ReadLine());
        }

        public string addCourse()
        {
            Console.Write($"Inputkan Course {this.nama} : ");
            this.course = Console.ReadLine();

            return this.nama;
        }

        public void HasilAkhir()
        {
            Console.WriteLine("Biodata Dosen Baru");
            Console.WriteLine();
           // Console.WriteLine($"ID      : {this.id}");
            Console.WriteLine($"Nama    : {this.nama}");
            Console.WriteLine($"NIK     : {this.nik}");
           // Console.WriteLine($"Gender  : {this.gender}");
            Console.WriteLine($"Course  : {this.course}");
        }
    }
}
