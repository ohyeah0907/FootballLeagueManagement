using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballScheduleManagement.Model.BridgePattern
{
    //Bridge pattern
    class ManagerForm: IForm
    {
		private Form managerForm;

		public ManagerForm(Form managerForm)
		{
			this.managerForm = managerForm;
		}

		public void Login()
		{
			this.managerForm.Show();
		}
	}
}
