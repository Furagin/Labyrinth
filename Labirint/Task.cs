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
        bool _enable;
        //свойства задачи
        //номер задачи по обноружению
        int _taskRumber;
        //номер выполневшего/резервировавшего робота
        int _numberRobot;
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
        public void ReserveTask(int numberRobot)
        {
            _enable = false;
        }
    }
}
