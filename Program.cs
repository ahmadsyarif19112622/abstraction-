using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MatKul matkul;
            matkul = new Wirausaha();
            matkul.Jadwal();

            Console.WriteLine();
            matkul = new Informasi();
            matkul.Jadwal();*/

            IMataKuliah matkul;
            matkul = new Wirausaha();
            matkul.Jadwal();

            Console.WriteLine();
            matkul = new Informasi();
            matkul.Jadwal();
            Console.ReadKey();
        }
    }
}
