using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasArray
{
    public class Mahasiswa
    {
        string[] arrNim = { "1234", "1234", "1234", };
        string[] arrNama = { "erick", "wely", "sony" };
        int[] arrNilai = { 75, 80, 95 };

        public void Show()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}. {1} \t ", i + 1, arrNim[i]);
                Console.Write("\t {0} \t {1} ", arrNama[i], arrNilai[i]);
                Console.WriteLine();
            }
        }
}
}
