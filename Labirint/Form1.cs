using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Labirint
{
    public partial class Form1 : Form
    {
        //размеры карты
        public int XRange,YRange;
        public Form1()
        {
            InitializeComponent();
            textBox9.Multiline = true;
            textBox8.Multiline = true;
        }        
        //создание карты
        private void button1_Click(object sender, EventArgs e)
        {
            //вывод на передний план окна ввода карты
            textBox8.BringToFront();
            textBox8.Text = "";
            //
        }
        //Загрузка карты
        private void button2_Click(object sender, EventArgs e)
        {
            //вывод на передний план окна символьного отображения карты
            textBox8.BringToFront();
            //получение имени файла
            string fileName = textBox2.Text;
            fileName += ".txt";
            //получение адреса
            string adress = get_adress(fileName);
            //чтение файла
            System.IO.StreamReader file = new System.IO.StreamReader(@adress);
            string line;
            textBox8.Text = "";
            for(int i = 0; (line = file.ReadLine()) != null ;i++)
            {
                //чтение размеров карты
                if(i == 0) { textBox3.Text = line; }
                else if(i == 1) { textBox4.Text = line; }
                //заполнение карты
                else
                {
                    textBox8.Text += line + Environment.NewLine;
                }
            }
        }
        //Сохранение карты
        private void button3_Click(object sender, EventArgs e)
        {

            textBox8.BringToFront();
            //получение имени файла
            string fileName = textBox2.Text;
            fileName += ".txt";
            //получение адреса
            string adress = get_adress(fileName);
            //создание файла            
            //проверка наличия файла
            if (File.Exists(adress))
            {
                textBox5.Text = "Файл уже существует";
            }
            else
            {
                //создание файла
                using (FileStream newFile = File.Create(adress))
                {
                    //запись в файл параметров X и Y 
                    Byte[] mapInfoX = new UTF8Encoding(true).GetBytes(textBox3.Text+"\r\n");
                    newFile.Write(mapInfoX, 0, mapInfoX.Length);
                    Byte[] mapInfoY = new UTF8Encoding(true).GetBytes(textBox4.Text+"\r\n");
                    newFile.Write(mapInfoY, 0, mapInfoY.Length);
                    //запись в файл карты
                    Byte[] mapInfo = new UTF8Encoding(true).GetBytes(textBox8.Text);
                    newFile.Write(mapInfo, 0, mapInfo.Length);
                }
            }            

        }
        //Карта лабиринта
        Map _generalMap = new Map();
        //Инициализация обхода лабиринта
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            XRange = int.Parse(textBox3.Text);
            YRange = int.Parse(textBox4.Text);
            _generalMap.create_map(XRange, YRange, textBox8.Text, textBox9);
            //отрисовка карты в пикчербокс1
            _generalMap.draw_map(pictureBox1, _generalMap.MapCoord);
            //вызов дополнительного окна (робот, локальная карта, граф)
            //инициализация обхода
            //граф обхода лабиринта
            Graph generalGraph = new Graph();
            //количество роботов
            int robotCount;
            //просмотр изменения количества роботов
            try
            {
               robotCount = int.Parse(textBox1.Text);
            }
            catch
            {
                //ничего не происходит
                //число роботов все еще 1
                robotCount = 1;
            }
            //массив роботов
            RobotExp[] robotArray = new RobotExp[robotCount];
            
        }
        
        private void label8_Click(object sender, EventArgs e)
        {
            //Тык по названию "х"
            //Ничего не происходит
        }
        //Вывоз справки
        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.BringToFront();
            textBox8.Text = "1. Создание карты - вызов окна ввода для задания карты лабиринта" + Environment.NewLine;
            textBox8.Text += "При создании карты следует помнить, что построенная карта исчезнет при запуске, поэтому рекомендуется сохранить файл с ее параемтрами" + Environment.NewLine;
            textBox8.Text += "Символьные обозначения: 1 - стена, 2 - проход со стандартной проходимотью." + Environment.NewLine;
            textBox8.Text += "Крайние строки и столбцы не могут быть проходами." + Environment.NewLine;
            textBox8.Text += "2. Загрузка карты - загрузка текстового файла, содержащего карту лабиринта." + Environment.NewLine;
            textBox8.Text += "При загрузке карты необходимо иметь заполненной строку 'Имя файла'." + Environment.NewLine;
            textBox8.Text += "Загрузка карты происхоит из той же директории, где находится исполняемый файл программы." + Environment.NewLine;
            textBox8.Text += "3. Сохранение карты - сохранение текстового файла, содержащего карту лабиринта." + Environment.NewLine;
            textBox8.Text += "При сохранении карты необходимо иметь заполненной строки 'Имя файла', 'Размерность поля' и содержание карты." + Environment.NewLine;
            textBox8.Text += "Сохранение карты происхоит из ту же директории, где находится исполняемый файл программы." + Environment.NewLine;
            textBox8.Text += "4. Пройти лабиринт - вызов процедуры обхода лабиринта." + Environment.NewLine;
            textBox8.Text += "При вызове обхода лабиринта необходимо убедиться, что:" + Environment.NewLine;
            textBox8.Text += "а) Карта загружена или сохранена, если была инициализоровано создание" + Environment.NewLine;
            textBox8.Text += "б) Убедиться, что введены координаты начала. Данные параметры указывают начальное положение роботов." + Environment.NewLine;
            textBox8.Text += "в) Убедиться, что указано число роботов, если необходимо более одного робота. По умолчанию используется один робот." + Environment.NewLine;
            textBox8.Text += "5. В 'Строке состояния' показывается статус приложения, включая ошибки и прогресс обхода лабиринта." + Environment.NewLine;
        }
        //Функция отрисовки карты 
        //Может не понадобиться, в классе есть метод
        public void draw_map()
        {
            //отрисовка карты
        }
        //Функция получения адреса
        private string get_adress(string fileName)
        {
            string adress = Path.GetFullPath(fileName);
            return adress;
        }
        
    }
}
