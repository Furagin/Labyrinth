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
        public List<RobotExp> AgentRobList;
        //количество агентов
        private int agentCount;
        //список задач
        private List<Task> globalTaskList;
        //глобальная карта
        public Map GlobalMap;
        //координаты начала
        private int xStart, yStart;

        public Mras()
        {
            AgentRobList = new List<RobotExp>();
            globalTaskList = new List<Task>();
            GlobalMap = new Map();
            agentCount = 1;
        }
        //
        public void SetAgentCount(int newAgentCount)
        {
            agentCount = newAgentCount;
        }

        public int GetAgentCount()
        {
            return agentCount;
        }
        //
        public void SetStartCoord(int xS, int yS)
        {
            xStart = xS;
            yStart = yS;
        }
        //создание списка агентов системы 
        public void CreateAgentList()
        {
            //формирование пула агентов с указанием начального положения
            for (int i = 0; i == agentCount; i++)
            {
                RobotExp newRobAgent = new RobotExp(xStart, yStart);
                newRobAgent.SetAgentNumber(i);
                AgentRobList.Add(newRobAgent);
            }
        }
    }
}
