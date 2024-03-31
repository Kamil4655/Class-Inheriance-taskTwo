namespace Class_Inherience.Models
{




    internal class Mobile : Device
    {
        private string[] SimCards;

        public Mobile(int simCardCount, int width, int height, int weight)
        {
            if (simCardCount < 1 || simCardCount > 2)
            {
                Console.WriteLine("SimCardCount 1 ilə 2 arasında olmalıdır.");
                return;
            }

            Width = width;
            Height = height;
            Weight = weight;

            SimCards = new string[simCardCount];
        }
    }
}
