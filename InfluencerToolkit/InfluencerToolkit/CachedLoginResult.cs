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
    public class CachedLoginResult
    {
        private LoginResult m_LoginResult;
       // private LoginResultCacher m_Cacher;

        public CachedLoginResult(LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
         //   m_Cacher.cache(i_LoginResult);
        }
        public String AccessToken {
            get
            {
                string retVal = null;
                if (m_LoginResult == null)
                {
                    //if (LoginResultCacher.getinstance().CachedAccesstoken)
                    //{
                     //   retVal = LoginResultCacher.AccessToken.RetrieveFromCache;
                    //}
                }
                else
                {
                    retVal = m_LoginResult.AccessToken;
                }
                return retVal;
            }
        }
        public String ErrorMessage {
            get
            {
                string retVal = null;
                if(m_LoginResult == null)
                {
                    throw new Exception("Retrieving error message from cache is not implemented\n");
                }
                else
                {
                    retVal = m_LoginResult.ErrorMessage;
                }

                return retVal;
            }
        }
        public User LoggedInUser
        {
            get
            {
                User retVal = null;
                if (m_LoginResult == null)
                {
                    throw new Exception("Retrieving LoggedInUser from cache is not implemented\n");
                }
                else
                {
                    retVal = m_LoginResult.LoggedInUser;
                }

                return retVal;
            }

        }
    }
}
