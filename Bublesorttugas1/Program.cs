using System;

namespace Bublesorttugas1
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        // Deklarasi variabel int untuk menyimpan banyaknya data pada array 
        private int n;

        // Fungsi / Method untuk menerima masukan 
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
                Console.WriteLine("");
                Console.WriteLine("------------------------");
                Console.WriteLine(" Masukkan elemen array ");
                Console.WriteLine("------------------------");

                // Pengguna memasukkan elemen pada array
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("<" + (i + 1) + "> ");
                    string s1 = Console.ReadLine();
                    a[i] = Int32.Parse(s1);
                }

            }
        }

        private void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun");
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]++);
            }
            Console.WriteLine("");
        }
        public void BubleSortArray()
        {
            for (int i = 1; i < n; i++) // for n-1 passes
            {
                // Pada pass i , bandingkan n - i elemen pertama dengan elemen selanjutnya 
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Creating the object of the Bubblesort class 
            Program myList = new Program();
            // Pemanggilan fungsi untuk menerima elemen array 
            myList.read();
            // Pemanggilan fungsi untuk menampilkan array 
            myList.BubleSortArray();
            //manggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
            Console.Read();

        }
    }
}