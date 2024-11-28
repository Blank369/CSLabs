using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab5.NumberPanel;


namespace lab5
{
    public class NumberPanel : Panel, INotifyPropertyChanged
    {
        //private bool check = false;

        //public bool Check
        //{
        //    get { return check; }
        //    set { check = value; Refresh(); }

        //}

        private int maxValue = 9;
        private int minValue = 0;

        private int sizeM = 1;
        private bool isHorizontal = true;

        public NumberPanel()
        {
            maxValue = 9;
            minValue = 0;
            sizeM = 1;
            isHorizontal = true;

            this.Location = new Point(0, 0);
            this.Size = new Size(500, 500);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
        }
        public bool IsHorisontal
        {
            get { return isHorizontal; }
            set
            {
                isHorizontal = value;

                OnPropertyChanged(nameof(IsHorisontal));
                Refresh();
                Invalidate();
            }
        }
        public int MinValue
        {
            get { return minValue; }
            set
            {
                if (value >= maxValue) minValue = maxValue;
                //else if (value < 0) minValue = 0;
                //else if (value > 9) minValue = 9;
                else minValue = value;

                OnPropertyChanged(nameof(MinValue));
                OnPropertyChanged(nameof(CountNumber));
                Refresh();
                Invalidate();
            }
        }

        public int MaxValue
        {
            get { return maxValue; }
            set
            {
                if (value <= minValue) maxValue = minValue;
                //else if (value < 0) maxValue = 0;
                // else if (value > 9) maxValue = 9;
                else maxValue = value;

                OnPropertyChanged(nameof(MaxValue));
                OnPropertyChanged(nameof(CountNumber));
                Refresh();
                Invalidate();
            }
        }

        public int CountNumber => MaxValue - MinValue + 1;

        public int SizeM
        {
            get { return sizeM; }
            set
            {
                if (value < 1) sizeM = 1;
                else if (value > CountNumber) sizeM = CountNumber;
                else sizeM = value;

                OnPropertyChanged(nameof(SizeM));
                Refresh();
                Invalidate();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

                Invalidate();
            }
        }

        public const int distX = 50, distY = 50;

        public const int sizeX = 50, sizeY = 50;



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < CountNumber; ++i)
            {
                int row = 0, column = 0;
                if (isHorizontal)
                {
                    column = (int)(i / sizeM);
                    row = i % sizeM;
                }
                else
                {
                    row = (int)(i / sizeM);
                    column = i % sizeM;
                }
                //gSizeX = distX * row + distX;
                //gSizeY = distY * column + distY;

                Rectangle rect = new Rectangle(distX * row, distY * column, sizeX, sizeY);

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), rect);
                e.Graphics.DrawString((i + minValue).ToString(), new Font("Arial", 14), Brushes.LimeGreen, rect, stringFormat);

            }
            //this.Size = new Size(gSizeX, gSizeY);
        }


        public class NumberPanelEventArgs : EventArgs
        {
            private int number;
            public int Num
            {
                get { return number; }
            }
            public NumberPanelEventArgs(int num)
            {
                number = num;
            }

        }

        public delegate void NumberClickEventHandler(object sender, NumberPanelEventArgs number);
        public event NumberClickEventHandler NumberClicked;
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            int num = FindNumber(e.X, e.Y);
            if (num != -1 && num <= maxValue && num >= minValue)
            {
                NumberClicked?.Invoke(this, new NumberPanelEventArgs(num));
            }
        }
                //NumberClicked?.Invoke(num);

                   
               // NumberClickEventHandler? numClick;   
        public int FindNumber(int x, int y)
        {
            int rows = 0, columns = 0;
            double width = 0, height = 0;

            if (isHorizontal)
            {
                columns = sizeM;
                if(CountNumber % columns != 0) rows = CountNumber / columns + 1;
                else rows = CountNumber / columns;
            }
            else
            {
                rows = sizeM;
                if (CountNumber % rows != 0) columns = CountNumber / rows + 1; 
                else columns = CountNumber / rows;
            }

            width = (double)sizeX * columns;
            height = (double)sizeY * rows;

            if (x <= width && y <= height)
            {
                int index = 0;

                int col = x / sizeX;
                int row = y / sizeY;

                if (isHorizontal)
                {
                   // MessageBox.Show($"{row}, {col} = {minValue + row * columns + col}");
                    index = row * columns + col;
                }
                else
                {
                   // MessageBox.Show($"{row}, {col} = {minValue + col * rows + row}");
                    index = col * rows + row;
                }
                return minValue + index;
            }

            return -1;
        }
    }
}
