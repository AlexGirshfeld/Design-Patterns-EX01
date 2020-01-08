﻿
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
namespace InfluencerToolkit
{
    public class LoginResultAdapter
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
            if (LoggedInUser != null)
            {
                this.LoggedInUser = new UserAdapter(i_LoginResult.LoggedInUser);
                this.AccessToken = i_LoginResult.AccessToken;
            }
            else
            {
                this.LoggedInUser = null;
                this.AccessToken = null;
            }
        }
    }
}
