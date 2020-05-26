using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class pingPong : Form
    {
        bool? flag = true; // Добавочная переменная для определения условия
        int rightForm = 670;// Предел высоты формы

        public pingPong()// Инициализация объектов
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(pingPongMouse);// инициализация события Mouse
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pingPongLoad);// инициализация события Paint
        }

        private void timerTick(object sender, EventArgs e)// Отображает изменение формы каждую секудну
        {
            computer(pictureLeft);
        }

        private void pingPongMouse(object sender, MouseEventArgs e)// Перемещение панели игрока за курсором мышки
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            if (X >= 1310 / 2 && X < 1296)
            {
                pictureRight.Left = X - 160;
                pictureRight.Top = Y - 160;
            }
        }
        private void pingPongLoad(object sender, PaintEventArgs e)//Вырисовка линии по середине формы(разделение панелей)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.Black);
            g.DrawLine(pen1, 475, 60, 475, rightForm);

        }

        private void computer(PictureBox picture)//Панель, которой управляет компьютер
        {

            if (picture.Location.Y < rightForm - picture.Height && picture.Location.Y > 0 && flag == false)
            {
                picture.Location = new Point(picture.Location.X,
                                        Math.Max(0, Math.Min(rightForm - picture.Height, picture.Location.Y - 4)));
            }

            else if (picture.Location.Y >= rightForm - picture.Height)
            {
                picture.Location = new Point(picture.Location.X,
                Math.Max(0, Math.Min(rightForm - picture.Height, picture.Location.Y - 4)));
                flag = false;

            }
            else if (picture.Location.Y <= 0)
            {
                picture.Location = new Point(picture.Location.X,
                                        Math.Max(0, Math.Min(rightForm - picture.Height, picture.Location.Y + 4)));
                flag = true;
            }

            else if (picture.Location.Y < rightForm - picture.Height && flag == true)
                picture.Location = new Point(picture.Location.X,
                                        Math.Max(0, Math.Min(rightForm - picture.Height, picture.Location.Y + 4)));


        }
    }
}
