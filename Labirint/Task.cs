using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Task
    {
        //статус задачи
        bool enable;
        //свойства задачи
        //номер задачи по обноружению
        int taskRumber;
        //номер выполневшего/резервировавшего робота
        int numberRobot;
        //емкость, количство проходов и т.д.
        //смежные задачи
        //метод добавления задачи
        public void CreateTask()
        {

        }
        //метод удаления задачи
        public void RemoveTask()
        {

        }
        //метод резервирования задачи
        public void ReserveTask(int number_robot)
        {
            enable = false;
        }
    }
}
