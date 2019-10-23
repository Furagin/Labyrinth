using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    class Status
    {
        private bool _free;
        private bool _work;
        public Status()
        {
            _free = true;
            _work = true;
        }
        //статус "свободен"
        public void Enable()
        {
            _free = true;
        }
        //статус "занят"
        public void Busy()
        {
            _free = false;
        }
        //статус "не работает"
        //пригодится при добавлении проходимости
        //и лимита топлива
        public void NotWork()
        {
            _work = false;
        }
    }
}
