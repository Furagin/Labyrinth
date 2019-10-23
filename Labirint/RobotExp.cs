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
        private int number;
        //координаты робота
        private int x, y;
        //текущая задача
        Task currentTask;
        //статус
        Status currentStatus;
        //граф задач робота
        Graph localGraph;
        //цвет для отрисовки

        //конструктор класса
        public RobotExp(int x, int y)
        {
            this.x = x;
            this.y = y;
            number = 0;
            currentTask = new Task();
            currentStatus = new Status();
            localGraph = new Graph();
        }       
        //Установка и получение номера
        public void SetAgentNumber(int newNumber)
        {
            number = newNumber;
        }
        //
        public int GetAgentNumber()
        {
            return number;
        }
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
