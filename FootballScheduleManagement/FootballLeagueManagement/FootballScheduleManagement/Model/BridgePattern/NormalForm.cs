using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballScheduleManagement.Model.BridgePattern
{
    //Bridge pattern
    class NormalForm: IForm
    {
        private Form normalForm;

        public NormalForm(Form normalForm)
        {
            this.normalForm = normalForm;
        }

        public void Login()
        {
            this.normalForm.Show();
        }
    }
}
