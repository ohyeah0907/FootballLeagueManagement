using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballScheduleManagement.Model.BridgePattern;

namespace FootballScheduleManagement.Model.FactoryPattern
{
    //factory method pattern
    class NormalUserCreator: CreateUser
	{
		private IForm form;
		private string account;
		private string password;

		public NormalUserCreator(IForm form, string account, string password)
		{
			this.form = form;
			this.account = account;
			this.password = password;

		}

		public override User UserFactoryMethod()
		{
			return new NormalUser(this.form, this.account, this.password);
		}
	}
}
