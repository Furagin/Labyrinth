using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Labirint
{
    class Map
    {
        //размер карты (число строк и стобцов)
        int xRange = 0;
        int yRange = 0;
        //размер клеток в пикселях
        float penXSize = 15, penYSize = 15;
        //метод установки масштаба карты
        //матрица карты
        public int[,] MapCoord;// = new int[x_range, y_range];
        private void SetRange(int x, int y)
        {
            xRange = x;
            yRange = y;
            MapCoord = new int[xRange, yRange];
        }        
        //метод установки карты
        private void SetMap(string textMap)
        {
            //конец 
            bool endMap = false;
            //эксперимент
            char[] mapChar;// = new char[x_range * y_range];
            mapChar = textMap.ToCharArray(0,textMap.Length);            
            //разбиение карты на строки
            //разбиение строк на элементы и перенос 
            for(int i = 0; i<xRange; i++)
            {
                //переменная для прохода символьного массива
                int k = 0;
                for (int j=0; j<yRange; j++)
                {
                    if ((mapChar[i * yRange + k] == '\n') || (mapChar[i * yRange + k] == '\r')) { k+=2; }
                    if ((mapChar[i * yRange + k]!='\n')&&(mapChar[i * yRange + k] != '\r'))
                    {
                        MapCoord[i, j] = (int)Char.GetNumericValue(mapChar[i * yRange + k]);                        
                    }
                    //if ((map_char[i * y_range + k] == '\n') || (map_char[i * y_range + k] == '\r')) { k--; }
                    k++;
                }
                //while()
            }
           
                       
        }
        //метод изменения карты
        public void ChangeMap(string textMap)
        {

        }
        //метод проверки карты
        public void OutputMap(int[,] mapCoord, TextBox texBoxN)
        {
            for(int i = 0; i < xRange; i++)
            {
                for(int j = 0; j < yRange; j++)
                {
                    texBoxN.Text += mapCoord[i, j];
                }
                texBoxN.Text += Environment.NewLine;
            }
        }
        //метод отрисовки карты
        public void DrawMap(PictureBox pictureBoxN, int[,] mapCoord)
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
            for (int i = 0; i < xRange; i++)
            {
                for(int j = 0; j < yRange; j++)
                {
                    //переопределение координат
                    sqPoint.X = penXSize * i;
                    sqPoint.Y = penYSize * j;
                    polygonSetting[0] = sqPoint;
                    sqPoint.Y += penYSize;
                    polygonSetting[1] = sqPoint;
                    sqPoint.X += penXSize;
                    polygonSetting[2] = sqPoint;
                    sqPoint.Y -= penYSize;
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
        public void ChangeDrawMap(string textMap)
        {

        }
        //создание карты по параметрам
        public void CreateMap(int x, int y, string textMap, TextBox textBoxN)
        {
            SetRange(x, y);
            SetMap(textMap);
            OutputMap(MapCoord, textBoxN);
        }
        
    }
}
