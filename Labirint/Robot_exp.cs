using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    public class RobotExp
    {
        //номер робота
        private int _number;
        //координаты робота
        private int _x, _y;
        //текущая задача
        Task _currentTask;
        //статус
        Status _currentStatus;
        //граф задач робота
        Graph _localGraph;
        //конструктор класса
        public RobotExp(int x, int y)
        {
            _x = x;
            _y = y;
            //номер робота
            _number = 0;
            //координаты робота
            //int x, y;
            //текущая задача
            _currentTask = new Task();
            //статус
            _currentStatus = new Status();
            //граф задач робота
            _localGraph = new Graph();
        }        
        //цвет
        
        //функция движения
        public void Move()
        {

        }
        //функция обследования
        public void Explore()
        {

        }
        //функция орисовки
        public void DrawWay()
        {

        }
        

    }
}
