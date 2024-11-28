using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public partial class Metronome : UserControl, INotifyPropertyChanged
    {
        // Button StartStopButton;
        private System.Windows.Forms.Timer timer;

        Pen pen1 = new Pen(Color.Black, 2f);
        Pen pen2 = new Pen(Color.Brown, 4f);

        Font font = new Font("Arial", 8);
        Brush brush1 = new SolidBrush(Color.Red);
        Brush brush2 = new SolidBrush(Color.Black);


        public Metronome()
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(500, 500);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.DoubleBuffered = true;
            this.BPM = 208;
            this.Time = 0;
            this.AngleDeviation = 30;


            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);
            this.Tick += PlayTick;

            SwitchedOn = false;
            pendulumAngle = 90;
            pendulumDisplacement = Convert.ToInt32(this.Size.Height - this.Size.Height * 0.05);
            pendulumPosition = new Point(Convert.ToInt32(this.Size.Width * 0.5), PendulumStart.Y);
            //_bpm = 0;

            //this.Resize += new EventHandler(DrawBody);

           /* int step = Convert.ToInt32(((this.Height - this.Height * 0.05) - (this.Height * 0.05)) / 8);
            pendulumPosition = new Point(Convert.ToInt32(this.Width * 0.5 - step / 2 / 2),
                                         Convert.ToInt32((this.Height - this.Height * 0.05 - step / 2)));*/
        }

        public delegate void Sound();
        public event Sound Tick;

        private void PlayTick()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\ЮЛЯ 28.03.2020 г\Универ\5 семестр\ПВП\lab6\Tick.wav");
            player.Play();
        }
        private double Time
        {
            get; set;
        }
        private const double dt = 0.01;
        
        private void timer_Tick(object sender, EventArgs e)
        {
            //PendulumAngle += 1;
            Time += dt;
            double preAngle = PendulumAngle; 
            PendulumAngle = Math.Clamp(ChangeAngle(), 90 - AngleDeviation, 90 + AngleDeviation);
            //Mes += Math.Round(PendulumAngle, MidpointRounding.ToZero).ToString() + ' ';
            if ((PendulumAngle > 90 && preAngle < 90) || (PendulumAngle < 90 && preAngle > 90)) { Tick(); }
            Invalidate();
        }

        private double ChangeAngle()
        {
            return 90 + AngleDeviation * Math.Cos(2 * Math.PI * BPM / 60 * Time);
        }


        private int _bpm;
        private const int _bpmMin = 40;
        private const int _bpmMax = 208;

        public int BPM
        {
            get { return _bpm; }
            set
            {
                if (value < _bpmMin || value > _bpmMax)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Количество ударов в минуту должно быть от {_bpmMin} до {_bpmMax}");
                }
                _bpm = value;

                Time = 0;
            }
        }

        private bool switchedOn;
        public bool SwitchedOn
        {
            get { return switchedOn; }
            set
            {
                switchedOn = value;
                if (switchedOn)
                {
                    timer.Start();
                    //Mes = "";
                }
                else
                {
                    timer.Stop();
                }
                NotifyPropertyChanged();
            }
        }

        private Point pendulumPosition;
        private Point PendulumPosition
        {
            get { return pendulumPosition; }
            set 
            {

                pendulumPosition.X = value.X + Convert.ToInt32(this.Width * 0.5 - PendulumSize.Width / 2);
                pendulumPosition.Y = pendulumStart.Y - value.Y;
                NotifyPropertyChanged();
            }
        }

        private int pendulumDisplacement;
        private int PendulumDisplacement
        {
            get { return pendulumDisplacement; }
            set
            {
                if (value < pendulumEnd.Y) pendulumDisplacement = pendulumEnd.Y + PendulumSize.Height;
                else if (value > pendulumStart.Y) pendulumDisplacement = pendulumStart.Y;
                else pendulumDisplacement = value;
                NotifyPropertyChanged();
            }
        }

        private Size PendulumSize
        {
            get; set;
        }

        private double pendulumLength;

        private double PendulumLength
        {
            get { return pendulumLength; }
            set 
            { 
                if(value <= 0) throw new ArgumentOutOfRangeException(nameof(value), "Длина маятника должна быть больше 0");
                pendulumLength = value;
                NotifyPropertyChanged();
            }
        }

        private double pendulumAngle;
        private double PendulumAngle
        {
            get { return pendulumAngle; }
            set
            {
                if (Math.Abs(value) > 360) pendulumAngle = Math.Abs(value) - 360;
                else pendulumAngle = Math.Abs(value);
                NotifyPropertyChanged();
            }
        }

        private double AngleDeviation
        {
            get; set;
        }

        private Point pendulumStart;

        private Point PendulumStart
        {
            get { return pendulumStart; }
            set
            {
                pendulumStart = value;               
            }
        }

        private Point pendulumEnd;
        private Point PendulumEnd
        {
            get { return pendulumEnd; }
            set 
            {
                pendulumEnd.X = value.X + pendulumStart.X;
                pendulumEnd.Y = pendulumStart.Y - value.Y;
                NotifyPropertyChanged();
            }
        }
        // public event EventHandler Tick;
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            /* Статично */

            // корпус
            double w = Size.Width, h = Size.Height;
            Point pb1 = new Point(Convert.ToInt32(w * 0.35), Convert.ToInt32(h * 0.05));
            Point pb2 = new Point(Convert.ToInt32(w - w * 0.35), Convert.ToInt32(h * 0.05));
            Point pb3 = new Point(Convert.ToInt32(w - w * 0.25), Convert.ToInt32(h - h * 0.05));
            Point pb4 = new Point(Convert.ToInt32(w * 0.25), Convert.ToInt32(h - h * 0.05));
            Point[] points1 = [pb1, pb2, pb3, pb4]; 
            g.DrawPolygon(pen1, points1);

            // шкала
            Point ps5 = new Point(Convert.ToInt32(w * 0.4), Convert.ToInt32(h * 0.05));
            Point ps6 = new Point(Convert.ToInt32(w - w * 0.4), Convert.ToInt32(h * 0.05));
            Point ps7 = new Point(Convert.ToInt32(w - w * 0.4), Convert.ToInt32(h - h * 0.05));
            Point ps8 = new Point(Convert.ToInt32(w * 0.4), Convert.ToInt32(h - h * 0.05));
            Point[] points2 = [ps5, ps6, ps7, ps8];
            g.DrawPolygon(pen1, points2);

            Point ps9 = new Point(Convert.ToInt32(w * 0.5), Convert.ToInt32(h * 0.05));
            Point ps10 = new Point(Convert.ToInt32(w * 0.5), Convert.ToInt32(h - h * 0.05));
            g.DrawLine(pen1, ps9, ps10);

            int w1 = Convert.ToInt32(w * 0.5 - w * 0.05);
            int w2 = Convert.ToInt32(w * 0.5 + w * 0.05);
            int hFirst = Convert.ToInt32(h * 0.05 + h * 0.1);
            int hLast = Convert.ToInt32(h - h * 0.06);
            int step = Convert.ToInt32((hLast - hFirst) / 8);
            for (int h0 = hLast, value = 208; h0 >= hFirst; h0 -= step, value -= 21)
            {
                Point pCur1 = new Point(w1, h0);
                Point pCur2 = new Point(w2, h0);
                g.DrawLine(pen1, pCur1, pCur2);
               // SizeF size = g.MeasureString(value.ToString(), font);
                //font = new Font("Arial", size.Width);
                g.DrawString(value.ToString(), font, brush2, new Point(w2, Convert.ToInt32(h0 - step / 3)));
            }


            /* Динамично */

            // маятник
            PendulumLength = Convert.ToDouble(h - h * 0.05 - step);
            PendulumStart = new Point(Convert.ToInt32(w * 0.5), Convert.ToInt32(h - h * 0.05));
            PendulumEnd = new Point(Convert.ToInt32(PendulumLength * Math.Cos(PendulumAngle * Math.PI / 180)),
                                  Convert.ToInt32(PendulumLength * Math.Sin(PendulumAngle * Math.PI / 180)));
            //Point p11 = new Point(Convert.ToInt32(w * 0.5), Convert.ToInt32(PendulumLength));
           // Point p11 = new Point(0, 507);
            g.DrawLine(pen2, PendulumStart, PendulumEnd);

            // бегунок
            PendulumSize = new Size(Convert.ToInt32(step / 2), Convert.ToInt32(step / 2));
            PendulumPosition = new Point(Convert.ToInt32(w * 0.5) - PendulumSize.Width / 2, PendulumDisplacement - PendulumSize.Height);
            //PendulumPosition = new Point(Convert.ToInt32(w * 0.5 - PendulumSize.Width / 2), Convert.ToInt32(h - h * 0.05 - PendulumSize.Height));
            PendulumPosition = new Point(Convert.ToInt32((PendulumPosition.Y) * Math.Cos(PendulumAngle * Math.PI / 180)),
                                         Convert.ToInt32((PendulumPosition.Y) * Math.Sin(PendulumAngle * Math.PI / 180)));
            //Mes = PendulumPosition.ToString();
            //PendulumPosition = new Point(Convert.ToInt32(PendulumPosition.X), Convert.ToInt32((PendulumPosition.Y)));

           // Point penPos = new Point(Convert.ToInt32(50 * Math.Cos(PendulumAngle * Math.PI / 180)),
                                  //Convert.ToInt32(50 * Math.Sin(PendulumAngle * Math.PI / 180)));


            Rectangle rectangle = new Rectangle(PendulumPosition, PendulumSize);
            g.FillEllipse(brush1, rectangle);
            //g.FillRectangle(brush1, rectangle);
            //g.DrawEllipse(pen3, rectangle); 
           
          
        } 

        protected override void OnResize(EventArgs e)
        {
            // Invalidate();
            NotifyPropertyChanged();
        }

        private bool isDragging = false;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            SwitchedOn = false;
            PendulumAngle = 90;
            Invalidate();
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isDragging)
            {
                PendulumDisplacement = e.Y;
                //Mes = PendulumDisplacement.ToString();
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            //SwitchedOn = true;
            BPM = GetBPM();
            //Mes = BPM.ToString();
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private int GetBPM()
        {
            return Convert.ToInt32(40 + Convert.ToDouble(_bpmMax - _bpmMin) / Convert.ToDouble(PendulumStart.Y - PendulumEnd.Y) *
                -1 * (pendulumEnd.Y - pendulumPosition.Y));
        }
        public string Mes
        {
            get; set;
        }

    }
}
