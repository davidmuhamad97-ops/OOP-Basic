using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class AccessModifierBasic
    {
        
    }

    /*
        Access modifier adalah kata kunci yang digunakan untuk mengontrol aksesibilitas anggota kelas (seperti field, method, property) dan kelas itu sendiri. Access modifier menentukan siapa yang dapat mengakses anggota atau kelas tersebut.
        Jenis-jenis access modifier:
        1. Public: Anggota atau kelas yang dideklarasikan sebagai public dapat diakses dari mana saja, baik dari dalam maupun luar assembly.
        2. Private: Anggota atau kelas yang dideklarasikan sebagai private hanya dapat diakses dari dalam kelas itu sendiri.
        3. Protected: Anggota atau kelas yang dideklarasikan sebagai protected dapat diakses dari dalam kelas itu sendiri dan dari kelas turunan (subclass).
        4. Internal: Anggota atau kelas yang dideklarasikan sebagai internal dapat diakses dari dalam assembly yang sama, tetapi tidak dapat diakses dari luar assembly.
     */

    class Persegi
    {
        private double sisi;

        public int Sisi
        {
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Sisi tidak boleh nol");
                }

                sisi = value;
            }

            get
            {
                return (int)sisi;
            }
        }
    }
}
