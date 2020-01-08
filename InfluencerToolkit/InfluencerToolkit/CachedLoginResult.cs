using System;

using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class CachedLoginResultAdapter
    {
        private LoginResultAdapter m_LoginResult;
        
        public CachedLoginResultAdapter(LoginResultAdapter i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            m_LoginResult = i_LoginResult;
            //LogingResultCacher.s_Instance.SaveToFile();
        }

        public string AccessToken {
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

        public UserAdapter LoggedInUser
        {
            get
            {
                UserAdapter retVal = m_LoginResult.LoggedInUser;
               /* if (m_LoginResult == null)
                {
                    //retVal = LogingResultCacher.s_Instance.LoadCachedLoginResultFromDisc();
                }
                else
                {
                    retVal = m_LoginResult.LoggedInUser;
                }*/
                return retVal;
            }

        }
    }
}
