using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballScheduleManagement.Model.FactoryPattern
{
    //Factory method pattern
    abstract class CreateUser
    {
        public abstract User UserFactoryMethod();
    }
}
