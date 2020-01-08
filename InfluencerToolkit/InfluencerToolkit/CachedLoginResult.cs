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
            LogingResultCacher.s_Instance.SaveToFile(m_LoginResult.LoggedInUser);
        }

        public String AccessToken {
            get
            {
                string retVal = null;
                if (m_LoginResult == null)
                {
                    //m_LoginResult = LogingResultCacher.s_Instance.LoadCachedLoginResultFromDisc();
                    retVal = m_LoginResult.AccessToken;
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
                    //m_LoginResult = LogingResultCacher.s_Instance.LoadCachedLoginResultFromDisc();
                    retVal = m_LoginResult.ErrorMessage;
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
                    retVal = LogingResultCacher.s_Instance.LoadCachedLoginResultFromDisc();
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
