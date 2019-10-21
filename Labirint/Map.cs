using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Labirint
{
    class Map
    {
        //размер карты (число строк и стобцов)
        int x_range = 0;
        int y_range = 0;
        //размер клеток в пикселях
        float pen_x_size = 15, pen_y_size = 15;
        //метод установки масштаба карты
        //матрица карты
        public int[,] map_coord;// = new int[x_range, y_range];
        private void set_range(int x, int y)
        {
            x_range = x;
            y_range = y;
            map_coord = new int[x_range, y_range];
        }        
        //метод установки карты
        private void set_map(string text_map)
        {
            //конец 
            bool end_map = false;
            //эксперимент
            char[] map_char;// = new char[x_range * y_range];
            map_char = text_map.ToCharArray(0,text_map.Length);            
            //разбиение карты на строки
            //разбиение строк на элементы и перенос 
            for(int i = 0; i<x_range; i++)
            {
                //переменная для прохода символьного массива
                int k = 0;
                for (int j=0; j<y_range; j++)
                {
                    if ((map_char[i * y_range + k] == '\n') || (map_char[i * y_range + k] == '\r')) { k+=2; }
                    if ((map_char[i * y_range + k]!='\n')&&(map_char[i * y_range + k] != '\r'))
                    {
                        map_coord[i, j] = (int)Char.GetNumericValue(map_char[i * y_range + k]);                        
                    }
                    //if ((map_char[i * y_range + k] == '\n') || (map_char[i * y_range + k] == '\r')) { k--; }
                    k++;
                }
                //while()
            }
           
                       
        }
        //метод изменения карты
        public void change_map(string text_map)
        {

        }
        //метод проверки карты
        public void output_map(int[,] map_coord, TextBox texBoxN)
        {
            for(int i = 0; i < x_range; i++)
            {
                for(int j = 0; j < y_range; j++)
                {
                    texBoxN.Text += map_coord[i, j];
                }
                texBoxN.Text += Environment.NewLine;
            }
        }
        //метод отрисовки карты
        public void draw_map(PictureBox pictureBoxN, int[,] map_coord)
        {
            //настройка рисования
            Pen Black_pen = new Pen(Color.Black);
            Pen White_pen = new Pen(Color.White);
            //Настройка отрисовки квадратов-клеток
            PointF Sq_point = new PointF { X = 0, Y = 0 };
            PointF[] Polygon_setting = new PointF[4];
            //заливка полигонов
            Brush Bl_brush = new HatchBrush(HatchStyle.DarkHorizontal, Color.Black);
            Brush Wh_brush = new HatchBrush(HatchStyle.DarkHorizontal, Color.WhiteSmoke);
            //отрисовка матрицы карты
            for (int i = 0; i < x_range; i++)
            {
                for(int j = 0; j < y_range; j++)
                {
                    //переопределение координат
                    Sq_point.X = pen_x_size * i;
                    Sq_point.Y = pen_y_size * j;
                    Polygon_setting[0] = Sq_point;
                    Sq_point.Y += pen_y_size;
                    Polygon_setting[1] = Sq_point;
                    Sq_point.X += pen_x_size;
                    Polygon_setting[2] = Sq_point;
                    Sq_point.Y -= pen_y_size;
                    Polygon_setting[3] = Sq_point;
                    //коридоры
                    if (map_coord[i, j] == 1)
                    {
                        pictureBoxN.CreateGraphics().DrawPolygon(White_pen, Polygon_setting);
                        pictureBoxN.CreateGraphics().FillPolygon(Wh_brush, Polygon_setting);
                    }
                    //стены               
                    if (map_coord[i, j] == 2)
                    {
                        pictureBoxN.CreateGraphics().DrawPolygon(Black_pen, Polygon_setting);
                        pictureBoxN.CreateGraphics().FillPolygon(Bl_brush,Polygon_setting);
                    }
                    
                }
            }
        }
        //метод переокраски карты
        public void change_draw_map(string text_map)
        {

        }
        //создание карты по параметрам
        public void create_map(int x, int y, string text_map, TextBox textBoxN)
        {
            set_range(x, y);
            set_map(text_map);
            output_map(map_coord, textBoxN);
        }
        
    }
}
