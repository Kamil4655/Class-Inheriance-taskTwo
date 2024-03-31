using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Inherience.Models
{
    internal class Device
    {
        public bool isOpened = false;

        public int Width;
        public int Height;
        public int Weight;



        public void  OpenDevice()
        {
            if (!isOpened)
            {
                Console.WriteLine("Device opening…");
                isOpened = true;
            }
            else
            {
                Console.WriteLine("Device already opened");
            }
        }

        public void CloseDevice()
        {
            Console.WriteLine("Device closing...");
            isOpened = false;
        }

    }
}
