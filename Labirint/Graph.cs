﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Graph
    {
        //создание графа

        //в эелементе графа содержится:
        //прошлая задача, номер робота, номер текущей задачи
        int numberRoobot;
        int taskNumber;
        int currentTaskNumber;
        //список - сам граф
        List<Task> roster = new List<Task>();
        //добавление задачи
        public void add_task(int taskNumber, int numberRoobot)
        {
            //номер задачи
            //"вес ребра"
            //номер робота, который занялся
            
        }
        //текущая задача
        public void draw_graph(List<Task> roster)
        {

        }

    }
}
