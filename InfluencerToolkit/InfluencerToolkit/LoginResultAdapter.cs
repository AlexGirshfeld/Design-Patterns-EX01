    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
namespace InfluencerToolkit
{
    class LoginResultAdapter
    {
        public UserAdapter LoggedInUser { get; set; }
        public string AccessToken { get; set;}

        public LoginResultAdapter()
        {
            
        }
        public LoginResultAdapter(LoginResult i_LoginResult)
        {
            adaptLoginResult(i_LoginResult);
        }

        public void adaptLoginResult(LoginResult i_LoginResult)
        {
            this.LoggedInUser = new UserAdapter(i_LoginResult.LoggedInUser);
            this.AccessToken = i_LoginResult.AccessToken;
        }
    }
}
