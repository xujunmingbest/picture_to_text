using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptt
{
    class Program
    {
        static void Main(string[] args)
        {
            MODI.Document doc = new MODI.Document();

            doc.Create("1.png");

            MODI.Image image;

            MODI.Layout layout;

            doc.OCR(MODI.MiLANGUAGES.miLANG_CHINESE_SIMPLIFIED, true, true);  // 识别简体中文
            string sb;
            for (int i = 0; i < doc.Images.Count; i++)

            {

                image = (MODI.Image)doc.Images[i];

                layout = image.Layout;

                Console.WriteLine(layout.Text);

            }
            Console.ReadLine();

        }
    }
}
