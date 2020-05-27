using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace Ping_Pong
{
    public class Circle
    {
        private PictureBox pictureCircle; // объявление графического элемента
        Random rand = new Random();// функция для выбора разных значений координат
        int xCordinate = 3, yCordinate = 3;// начальные значения координат
        int score1 = 0, score2 = 0; // счет 1 и 2 игрока

        public Circle(PictureBox picture)// метод для объявления объекта в других классах
        {
            this.pictureCircle = picture;
        }

        public void MethodCircle(Label label1, Label label3, PictureBox pictureLeft, PictureBox pictureRight)// движение круга + изменение счета игроков
        {

            var bottom1 = 670 - pictureCircle.Height;
            var bottom2 = 1080 - pictureCircle.Width;
            pictureCircle.Location = new Point(pictureCircle.Location.X + xCordinate, Math.Max(0, Math.Min(bottom1, pictureCircle.Location.Y + yCordinate)));

            if (pictureCircle.Location.Y >= bottom1 || pictureCircle.Location.Y <= 0)
                yCordinate *= -1;

            if (pictureCircle.Location.X <= 0 || pictureCircle.Location.X >= bottom2)//если круг вышел за переделы игры(гол)
            {
                if (pictureCircle.Location.X <= 0)
                {
                    score1++;
                    label1.Text = score1.ToString();
                }
                if (pictureCircle.Location.X >= bottom2)
                {
                    score2++;
                    label3.Text = score2.ToString();
                }

                pictureCircle.Location = new Point(1296/2, 670/2); //отображения круга, после гола с пощью случайных координат
                do
                {
                    xCordinate = rand.Next(-4, 4);
                    yCordinate = rand.Next(-4, 4);
                } while (Math.Abs(xCordinate) + Math.Abs(yCordinate) <= 4 || Math.Abs(xCordinate) <= 1);
            }
            if ((pictureLeft.Bounds.IntersectsWith(pictureCircle.Bounds) && xCordinate < 0) || (pictureRight.Bounds.IntersectsWith(pictureCircle.Bounds) && xCordinate > 0))
                xCordinate *= -1; // Препятсвие в виде панели
        }

    }
}

