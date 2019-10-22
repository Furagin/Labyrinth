using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Status
    {
        private bool free;
        private bool work;
        public Status()
        {
            free = true;
            work = true;
        }
        //статус "свободен"
        public void Enable()
        {
            free = true;
        }
        //статус "занят"
        public void Busy()
        {
            free = false;
        }
        //статус "не работает"
        //пригодится при добавлении проходимости
        //и лимита топлива
        public void NotWork()
        {
            work = false;
        }
    }
}
