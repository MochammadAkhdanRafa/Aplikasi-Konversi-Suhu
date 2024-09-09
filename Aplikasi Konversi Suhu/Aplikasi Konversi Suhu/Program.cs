﻿using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("===== Aplikasi Konversi Suhu =====");
            Console.WriteLine("Pilih Salah Satu Opsi Untuk Di Konversi:");
            Console.WriteLine("1. Celcius --> Fahrenheit");
            Console.WriteLine("2. Celcius --> Kelvin");
            Console.WriteLine("3. Celcius --> Reamur");
            Console.WriteLine("4. Back To Reality");
            Console.WriteLine("==================================");
            Console.Write("Masukkan pilihan Anda: ");

            string pilihan = Console.ReadLine();

            double celcius, hasil;

            switch (pilihan)
            {
                case "1":
                    Console.Write("Masukkan suhu dalam satuan Celcius yaa :3: ");
                    celcius = Convert.ToDouble(Console.ReadLine());
                    hasil = (celcius * 9 / 5) + 32; // Rumus Celcius ke Fahrenheit
                    Console.WriteLine("Hasil Konversi: {0} Celcius = {1} Fahrenheit", celcius, hasil);
                    break;

                case "2":
                    Console.Write("Masukkan suhu dalam satuan Celcius yaa :3: ");
                    celcius = Convert.ToDouble(Console.ReadLine());
                    hasil = celcius + 273; // Rumus Celcius ke Kelvin
                    Console.WriteLine("Hasil Konversi: {0} Celcius = {1} Kelvin", celcius, hasil);
                    break;

                case "3":
                    Console.Write("Masukkan suhu dalam satuan Celcius yaa :3: ");
                    celcius = Convert.ToDouble(Console.ReadLine());
                    hasil = celcius * 4 / 5; // Rumus Celcius ke Reamur
                    Console.WriteLine("Hasil Konversi: {0} Celcius = {1} Reamur", celcius, hasil);
                    break;

                case "4":
                    isRunning = false; // Keluar dari program
                    Console.WriteLine("Terima kasih telah percaya dengan saya secara sepenuh hati :D.");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak ada. Silakan coba lagi mungkin ada yang salah sama si doi.");
                    break;
            }

            if (isRunning)
            {
                Console.WriteLine("========= HASIL KONVERSI =========");
                Console.WriteLine("Nah sudah udah tau kan? ayo balik ke halaman utama, tekan tombol apa aja asal jangan tekan tombol hati si doi nanti nyesel :>");
                Console.ReadKey();
                    }
        }
    }
}