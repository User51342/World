using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows;
using Microsoft.Practices.Prism.Mvvm;

namespace World
{
    public class MainViewModel : BindableBase
    {
        #region Fields
        private Window myView;
        private Dot[,] myMatrix;
        private bool myIsRunning;
        private Timer myTimer;
        #endregion

        #region Construction / Initialization / Deconstruction

        public MainViewModel(Window view)
        {
            myView = view;
            myView.SizeChanged += Initialized;
            RectItems = new ObservableCollection<Dot>();
        }
        #endregion

        #region Properties
        public ObservableCollection<Dot> RectItems { get; set; }

        public bool IsRunning
        {
            get { return myIsRunning; }
        }
        #endregion

        #region Public implementations
        public void Stop()
        {
            myIsRunning = false;
        }
        #endregion

        #region Private implementations
        private void Initialized(object sender, EventArgs e)
        {
            BuildMatrix(((Window)sender).ActualWidth, ((Window)sender).ActualHeight);
            Start(100, 100);
        }

        private void Start(int x, int y)
        {
            myIsRunning = true;
            myTimer = new Timer(Work, null, new TimeSpan(0), new TimeSpan(0, 0, 0, 0, 100));
        }

        private void Work(object state)
        {
            if (!myIsRunning)
            {
                myTimer.Dispose();
            }
        }

        private void BuildMatrix(double width, double height)
        {
            for (int i = 0; i < (int)height; i++)
            {
                myMatrix = new Dot[(int)width, (int)height];
            }
        }

        private void Initialize()
        {
        }
        #endregion
    }
}
