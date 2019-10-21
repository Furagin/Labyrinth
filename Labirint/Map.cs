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
        int _xRange = 0;
        int _yRange = 0;
        //размер клеток в пикселях
        float _penXSize = 15, _penYSize = 15;
        //метод установки масштаба карты
        //матрица карты
        public int[,] MapCoord;// = new int[x_range, y_range];
        private void set_range(int x, int y)
        {
            _xRange = x;
            _yRange = y;
            MapCoord = new int[_xRange, _yRange];
        }        
        //метод установки карты
        private void set_map(string textMap)
        {
            //конец 
            bool endMap = false;
            //эксперимент
            char[] mapChar;// = new char[x_range * y_range];
            mapChar = textMap.ToCharArray(0,textMap.Length);            
            //разбиение карты на строки
            //разбиение строк на элементы и перенос 
            for(int i = 0; i<_xRange; i++)
            {
                //переменная для прохода символьного массива
                int k = 0;
                for (int j=0; j<_yRange; j++)
                {
                    if ((mapChar[i * _yRange + k] == '\n') || (mapChar[i * _yRange + k] == '\r')) { k+=2; }
                    if ((mapChar[i * _yRange + k]!='\n')&&(mapChar[i * _yRange + k] != '\r'))
                    {
                        MapCoord[i, j] = (int)Char.GetNumericValue(mapChar[i * _yRange + k]);                        
                    }
                    //if ((map_char[i * y_range + k] == '\n') || (map_char[i * y_range + k] == '\r')) { k--; }
                    k++;
                }
                //while()
            }
           
                       
        }
        //метод изменения карты
        public void change_map(string textMap)
        {

        }
        //метод проверки карты
        public void output_map(int[,] mapCoord, TextBox texBoxN)
        {
            for(int i = 0; i < _xRange; i++)
            {
                for(int j = 0; j < _yRange; j++)
                {
                    texBoxN.Text += mapCoord[i, j];
                }
                texBoxN.Text += Environment.NewLine;
            }
        }
        //метод отрисовки карты
        public void draw_map(PictureBox pictureBoxN, int[,] mapCoord)
        {
            //настройка рисования
            Pen blackPen = new Pen(Color.Black);
            Pen whitePen = new Pen(Color.White);
            //Настройка отрисовки квадратов-клеток
            PointF sqPoint = new PointF { X = 0, Y = 0 };
            PointF[] polygonSetting = new PointF[4];
            //заливка полигонов
            Brush blBrush = new HatchBrush(HatchStyle.DarkHorizontal, Color.Black);
            Brush whBrush = new HatchBrush(HatchStyle.DarkHorizontal, Color.WhiteSmoke);
            //отрисовка матрицы карты
            for (int i = 0; i < _xRange; i++)
            {
                for(int j = 0; j < _yRange; j++)
                {
                    //переопределение координат
                    sqPoint.X = _penXSize * i;
                    sqPoint.Y = _penYSize * j;
                    polygonSetting[0] = sqPoint;
                    sqPoint.Y += _penYSize;
                    polygonSetting[1] = sqPoint;
                    sqPoint.X += _penXSize;
                    polygonSetting[2] = sqPoint;
                    sqPoint.Y -= _penYSize;
                    polygonSetting[3] = sqPoint;
                    //коридоры
                    if (mapCoord[i, j] == 1)
                    {
                        pictureBoxN.CreateGraphics().DrawPolygon(whitePen, polygonSetting);
                        pictureBoxN.CreateGraphics().FillPolygon(whBrush, polygonSetting);
                    }
                    //стены               
                    if (mapCoord[i, j] == 2)
                    {
                        pictureBoxN.CreateGraphics().DrawPolygon(blackPen, polygonSetting);
                        pictureBoxN.CreateGraphics().FillPolygon(blBrush,polygonSetting);
                    }
                    
                }
            }
        }
        //метод переокраски карты
        public void change_draw_map(string textMap)
        {

        }
        //создание карты по параметрам
        public void create_map(int x, int y, string textMap, TextBox textBoxN)
        {
            set_range(x, y);
            set_map(textMap);
            output_map(MapCoord, textBoxN);
        }
        
    }
}
