using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer

        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";


            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                        
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("\n1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampil Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan customer ke dalam collection
            Customer customer = new Customer();
            Console.WriteLine("Tambah Data Customer");
            Console.Write("\nKode Customer  : ");
            customer.Kode = Console.ReadLine();
            Console.Write("Nama Customer    : ");
            customer.Nama = Console.ReadLine();
            Console.Write("Total Piutang    : ");
            customer.Piutang = Convert.ToDouble(Console.ReadLine());
            daftarCustomer.Add(customer);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus customer dari dalam collection
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Customer");
            Console.Write("Kode Customer    : ");
            string kode = Console.ReadLine();
            foreach (Customer customer in daftarCustomer)
            {
                no++;
                if (customer.Kode == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarCustomer.RemoveAt(hapus);
                Console.WriteLine("\nData customer berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode customer tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar customer yang ada di dalam collection
            Console.WriteLine("Tampil Data Customer\n");
            int noUrut = 0;

            foreach (Customer customer in daftarCustomer)
            {
                noUrut++;
                Console.WriteLine("{0}. Kode: {1}, Nama: {2}, Total Piutang: {3:N0}", noUrut, customer.Kode, customer.Nama, customer.Piutang);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
