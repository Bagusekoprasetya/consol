using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Mahasiswa
            mahasiswa saya = new mahasiswa();
            mahasiswa kamu = new mahasiswa();

            // mengeset nilai propertis objek saya dan kamu
            saya.Nim = "18.11.2309";
            saya.Nama = "Bagus";
            saya.Ipk = 3.95f;

            kamu.Nim = "18.11.2222";
            kamu.Nama = "sopo";
            kamu.Ipk = 3.70f;

            // memanggil metho registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();

        }
    }
}
