using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    public class AbstractBasic
    {
        public static void main()
        {
            BangunDatar2 persegi = new Persegi2(5);
            persegi.TampilkanInfo();

            BangunDatar2 lingkaran = new Lingkaran3(3);
            lingkaran.TampilkanInfo();
        }
    }

    /*
        Abstraksi adalah salah satu konsep dasar dalam pemrograman berorientasi objek. Dimana kita menyembunyikan detail implementasi dan fungsionalitas yang kompleks dari pengguna.
        Hal ini memungkinkan untuk fokus pada apa yang dilakukan objek daripada bagaimana objek itu bekerja.

        Keuntungan dari abstraksi:
        1. Menyederhanakan penggunaan: Dengan menyembunyikan detail implementasi, pengguna dapat menggunakan objek tanpa harus memahami kompleksitasnya.
        2. Meningkatkan keamanan: Dengan menyembunyikan detail implementasi, kita dapat mencegah pengguna untuk mengakses atau memodifikasi data yang tidak seharusnya diakses.
        3. Memudahkan pemeliharaan: Dengan menyembunyikan detail implementasi, kita dapat mengubah cara kerja objek tanpa mempengaruhi pengguna yang menggunakan objek tersebut.

        Method abstrak adalah method yang dideklarasikan dalam kelas abstrak tetapi tidak memiliki implementasi. Kelas turunan dari kelas abstrak harus mengimplementasikan method abstrak tersebut. 
        Method abstrak digunakan untuk mendefinisikan kontrak atau blueprint yang harus diikuti oleh kelas turunan.
        
     */

    abstract class BangunDatar2
    {

        // method abstract untuk menghitung luas dan keliling, yang harus diimplementasikan oleh kelas turunan
        public abstract double HitungLuas();
        public abstract double HitungKeliling();

        // method konkrit untuk menampilkan informasi luas dan keliling
        public virtual void TampilkanInfo()
        {
            Console.WriteLine($"Luas: {HitungLuas()}");
            Console.WriteLine($"Keliling: {HitungKeliling()}");
        }
    }

    class Persegi2 : BangunDatar2
    {
        private double sisi;

        public double Sisi
        {
            set
            {
                if (sisi < 0)
                {
                    throw new ArgumentException("Sisi tidak boleh negatif");
                }
            }

            get { return sisi; }
        }
        public Persegi2(double sisi)
        {
            this.sisi = sisi;
        }
        public override double HitungLuas()
        {
            return this.sisi * this.sisi;
        }
        public override double HitungKeliling()
        {
            return 4 * this.sisi;
        }

        public override void TampilkanInfo()
        {
            Console.WriteLine("=== Persegi ===");
            base.TampilkanInfo();
        }
    }

    class Lingkaran3 : BangunDatar2
    {

        private double jariJari;

        public double JariJari
        {
            set
            {
                if (jariJari < 0)
                {
                    throw new ArgumentException("Jari-jari tidak boleh negatif");
                }
            }

            get { return jariJari; }
        }
        public Lingkaran3(double jariJari)
        {
            this.jariJari = jariJari;
        }
        public override double HitungLuas()
        {
            return Math.PI * Math.Pow(this.jariJari, 2);
        }
        public override double HitungKeliling()
        {
            return 2 * Math.PI * this.jariJari;
        }

        public override void TampilkanInfo()
        {
            Console.WriteLine("\n=== Lingkaran ===");
            base.TampilkanInfo();
        }
    }
}
