using GameOfLife;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameOfLifeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class DrawingVisualElement : FrameworkElement
    {
        private VisualCollection _children;

        public DrawingVisual drawingVisual;

        public DrawingVisualElement()
        {
            _children = new VisualCollection(this);

            drawingVisual = new DrawingVisual();
            _children.Add(drawingVisual);
        }

        protected override int VisualChildrenCount
        {
            get { return _children.Count; }
        }

        protected override Visual GetVisualChild(int index)
        {
            if (index < 0 || index >= _children.Count)
                throw new ArgumentOutOfRangeException();

            return _children[index];
        }
    }


    public partial class MainWindow : Window
    {
        private static System.Timers.Timer aTimer;
        private static System.Timers.Timer bTimer;
        private const int Interval = 200;
        private const int Delay = 3000;
        private const int BoardWidth = 50;
        private const int BoardHeight = 100;
        private const int CellSize = 9;
        private readonly Board Board;
        private DrawingVisualElement drawingVisualElement;


        public MainWindow()
        {
            InitializeComponent();

            Width = CellSize * (BoardHeight + 2);
            Height = CellSize * (BoardWidth + 5);

            var stackPanel = new StackPanel();

            Content = stackPanel;

            drawingVisualElement = new DrawingVisualElement();

            stackPanel.Children.Add(drawingVisualElement);

            var drawingContext = drawingVisualElement.drawingVisual.RenderOpen();

            Board = new Board(BoardHeight, BoardWidth, InitialPatterns.HelloWorld());

            bTimer = aTimer = new System.Timers.Timer();
            bTimer.Interval = Delay;

            // Hook up the Elapsed event for the timer. 
            bTimer.Elapsed += (sender, e) => bTimerCall();

            // Have the timer fire repeated events (true is the default)
            bTimer.AutoReset = true;

            // Start the timer
            bTimer.Enabled = true;

            loadGrid();
        }

        void loadGrid()
        {
            Dispatcher.BeginInvoke(
                new ThreadStart(() => {
                    var drawingContext = drawingVisualElement.drawingVisual.RenderOpen();
                    for (int i = 0; i < 2; i++)
                    {
                        for (int x = 0; x < Board.Width; x++)
                            for (int y = 0; y < Board.Height; y++)
                                drawingContext.DrawRectangle(
                                    Board.Grid[x, y].IsAlive ? Brushes.OrangeRed : Brushes.WhiteSmoke,
                                    (Pen)null,
                                    new Rect(x * CellSize, y * CellSize, CellSize, CellSize));
                    }
                    drawingContext.Close();
                    Board.UpdateBoard();
                }));
        }

        void bTimerCall()
        {
            
            // Create a timer and set a two second interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = Interval;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += (sender, e) => loadGrid();

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

            bTimer.Stop();
        }
    }
}
