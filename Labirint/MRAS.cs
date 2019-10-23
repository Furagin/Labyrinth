using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Mras
    {
        //класс общей системы агентов
        //список агентов(роботов)
        private List<RobotExp> _agentRobList = new List<RobotExp>();
        //список задач
        private List<Task> _globalTaskList = new List<Task>();
        //глобальная карта
        private Map _globalMap = new Map();

    }
}
