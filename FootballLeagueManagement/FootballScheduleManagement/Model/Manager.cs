using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballScheduleManagement.Model.BridgePattern;

namespace FootballScheduleManagement.Model
{
    class Manager : User
    {
        public Manager(IForm form, string account, string password) : base(form, account, password)
        {

        }

    }
}
