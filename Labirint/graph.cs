using System;
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
        int number_roobot;
        int task_number;
        int current_task_number;
        //список - сам граф
        List<Task> roster = new List<Task>();
        //добавление задачи
        public void add_task(int task_number, int number_roobot)
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
