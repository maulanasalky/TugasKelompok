using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasKelompok
{
    public class Dosen
    {
        private int Id, NIK;
        private string Nama, Gender, Course;

        public Dosen()
        {
            this.Id = 1;
            this.Nama = "Dosen Pengampu";
            this.NIK = 123456789;
            this.Gender = "male";
            this.Course = "Pemrograman Berprestasi Objek";
        }

        public void attDosen(string nama, int NIK)
        {
            this.Nama = Nama;
            this.NIK = NIK;
        }
        
        public void addCourse(string course)
        {
            this.Course += ", " + course;
        }

        public void Tampil()
        {
            Console.WriteLine($"ID :" +  Id);
            Console.WriteLine($"Nama :" + Nama);
            Console.WriteLine($"NIK :" + NIK);
        }

       
           
    }
}
