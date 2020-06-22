using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassAnak;
using TugasLab8.ClassInduk;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            // Membuat objek untuk semua karyawan

            permanentemployees permanentemployees = new permanentemployees();
            permanentemployees.NIK = "123-234-345";
            permanentemployees.Nama = "Michael Suyama";
            permanentemployees.GajiBulanan = 4000000;

            Dailyemployee Dailyemployee = new Dailyemployee();
            Dailyemployee.NIK = "123-321-346";
            Dailyemployee.Nama = "Laura Callahan";
            Dailyemployee.UpahPerJam = 13000;
            Dailyemployee.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "123-333-346";
            sales.Nama = "Andrew Fuller";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            // Objek class collection
            List<Theemployee> listTheemployee = new List<Theemployee>();

            listTheemployee.Add(permanentemployees);
            listTheemployee.Add(Dailyemployee);
            listTheemployee.Add(sales);

            int noUrut = 1;

            foreach (Theemployee Theemployee in listTheemployee)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}", noUrut, Theemployee.NIK, Theemployee.Nama, Theemployee.Gaji());

                noUrut++;
            }

            Console.ReadLine();
        }
    }
}
