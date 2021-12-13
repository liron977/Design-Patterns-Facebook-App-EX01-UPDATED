using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAppLogic
{
    public class LoginFacade
    {
        private readonly FacebookAppManager r_AppManager;

        public LoginFacade()
        {
            r_AppManager = FacebookAppManager.Instance;
        }

        public void Login()
        {
            r_AppManager.UserLogin();
        }


    }
}
