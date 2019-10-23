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
        private bool Enable { get; set; }

        //свойства задачи
        //номер задачи по обноружению
        private int TaskRumber { get; set; }
        //номер выполневшего/резервировавшего робота
        private int NumberRobot { get; set; }
        //емкость, количство проходов и т.д.
        //смежные задачи
        //метод добавления задачи
        public Task()
        {
            Enable = true;
        }
        //метод удаления задачи
        public void RemoveTask()
        {

        }
        //метод резервирования задачи
        public void ReserveTask(int numberRobot)
        {
            Enable = false;
        }
    }
}
