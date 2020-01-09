using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace InfluencerToolkit
{
    public class CachedLoginResultAdapter
    {
        private LoginResultAdapter m_LoginResult;
        public CachedLoginResultAdapter()
        {
            m_LoginResult = LogingResultAdapterCacher.s_Instance.LoadCachedLoginResultFromDisc();
        }
        public CachedLoginResultAdapter(LoginResultAdapter i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            LogingResultAdapterCacher.s_Instance.CurretnLoginResult = m_LoginResult;
            LogingResultAdapterCacher.s_Instance.SaveToFile();
<<<<<<< HEAD
            var CacheThread = new Thread(LogingResultAdapterCacher.s_Instance.SaveToFile);
            CacheThread.SetApartmentState(ApartmentState.STA);
            CacheThread.Start();
=======
>>>>>>> 0f511204a43c6e772ada152662516e116f7e68f0
        }

        public string AccessToken {
            get
            {
                string retVal = null;
                if (m_LoginResult == null)
                {
                    m_LoginResult = LogingResultAdapterCacher.s_Instance.LoadCachedLoginResultFromDisc();
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
                if (m_LoginResult == null)
                {
                    m_LoginResult = LogingResultAdapterCacher.s_Instance.LoadCachedLoginResultFromDisc();
                    retVal = m_LoginResult.LoggedInUser;
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
