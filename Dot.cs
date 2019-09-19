using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Microsoft.Practices.Prism.Mvvm;

namespace World
{
    public class Dot : BindableBase
    {
        private SolidColorBrush myBrush;
        private double myX;
        private double myY;
        private double myHeight = 1;
        private double myWidth = 1;

        public Dot()
        {
                Brush = new SolidColorBrush(Colors.Red);
        }
        public SolidColorBrush Brush
        {
            get
            {
                return myBrush;
            }
            set
            {
                myBrush = value;
                OnPropertyChanged(() => Brush);
            }
        }


        public double X
        {
            get { return myX; }
            set
            {
                myX = value;
                OnPropertyChanged(() => X);
            }
        }

        public double Y
        {
            get { return myY; }
            set { myY = value; OnPropertyChanged(() => Y); }
        }


        public double Height
        {
            get { return myHeight; }
            set { myHeight = value; OnPropertyChanged(() => Height); }
        }



        public double Width
        {
            get { return myWidth; }
            set { myWidth = value; OnPropertyChanged(() => Width); }
        }


    }
}
