using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballScheduleManagement.Model.BridgePattern;

namespace FootballScheduleManagement.Model.FactoryPattern
{
    //Factory method pattern
    class ManagerUserCreator: CreateUser
    {
		private IForm form;
		private string account;
		private string password;

		public ManagerUserCreator(IForm form, string account, string password)
		{
			this.form = form;
			this.account = account;
			this.password = password;

		}

		public override User UserFactoryMethod()
		{
			return new Manager(this.form, this.account, this.password);
		}
	}
}
