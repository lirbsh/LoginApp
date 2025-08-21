using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.ModelsLogic
{
    class User : UserModel
    {
        public override bool Login()
        {
            return true;
        }
    }
}
