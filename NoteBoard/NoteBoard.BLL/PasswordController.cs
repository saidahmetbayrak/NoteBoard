using System;
using System.Collections.Generic;
using NoteBoard.DAL.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBoard.BLL
{
    class PasswordController
    {
        PasswordDAL _passwordDAL;
        public PasswordController()
        {
            _passwordDAL = new PasswordDAL();
        }
    }
}
