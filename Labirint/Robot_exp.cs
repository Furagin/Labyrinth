using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    public class Robot_exp
    {
        //номер робота
        int number;
        //координаты робота
        int x, y;
        //текущая задача
        Task currentTask;
        //статус
        Status currentStatus;
        //граф задач робота
        Graph localGraph;
        //конструктор класса
        public Robot_exp()
        {
            //номер робота
            int number;
            //координаты робота
            int x, y;
            //текущая задача
            Task currentTask = new Task();
            //статус
            Status currentStatus = new Status();
            //граф задач робота
            Graph localGraph = new Graph();
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
