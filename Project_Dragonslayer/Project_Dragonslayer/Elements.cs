using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using WpfApp1;

namespace WpfApp1
{
    public class Elements
    {
        private MainWindow frame;
        
        
        public Elements(MainWindow window)
        {
            this.frame = window;
        }

        public void SetPicture(string imageName)
        {
            ImageBrush Image = new ImageBrush();
            Image.ImageSource = new BitmapImage(new Uri("../Images/" + imageName, UriKind.Relative));
            frame.Background = Image;
        }
    }
}
