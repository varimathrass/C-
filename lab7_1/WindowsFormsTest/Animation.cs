
using System.Drawing;


namespace lab7_1
{
    class Animation
    {
        private Bitmap[] images;
        private int place = 0;

        public Animation(Bitmap[] images)
        {
            this.images = images;
        }

        public Bitmap giveNextImage()
        {
            Bitmap b = null;

            if(place < images.Length)
            {
                b = images[place++];
            }
            else
            {
                place = 0;
                b = images[place++];
            }

            return b;
        }
    }
}
