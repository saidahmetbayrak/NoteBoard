using System;
using System.Collections.Generic;
using NoteBoard.DAL.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBoard.BLL
{
    class NoteController
    {
        NoteDAL _noteDAL;
        public NoteController()
        {
            _noteDAL = new NoteDAL();
        }

        public void a()
        {
            int a = 4;  
        }
    }
}
