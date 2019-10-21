using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Status
    {
        bool _free;
        bool _work;
        public Status()
        {
            bool free = true;
            bool work = true;
        }
        //статус "свободен"
        public void Enable()
        {
            bool free = true;
        }
        //статус "занят"
        public void Busy()
        {
            bool free = false;
        }
        //статус "не работает"
        //пригодится при добавлении проходимости
        public void NotWork()
        {
            bool work = false;
        }
    }
}
