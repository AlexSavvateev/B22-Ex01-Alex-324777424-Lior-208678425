using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B22_Ex03_Alex_324777424_Lior_208678425
{
    public sealed class LoggedInUser
    {
        private static User s_LoggedInUser = null;
        private LoginResult m_LoginResult;

        public string AccesToken { get; private set; }

        public LoggedInUser()
        {
        }

        public LoggedInUser(bool i_Connect, string i_LastAccesToken = null)
        {
            if (i_Connect)
            {
                connect(i_LastAccesToken);
            }
            else
            {
                loginToFacebook();
            }
        }

        private void loginToFacebook()
        {
            m_LoginResult = FacebookService.Login(
                "743579109959282",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");
            setAccesTokenAndLoggedInUser();
        }

        private void connect(string i_LastAccesToken)
        {
            m_LoginResult = FacebookService.Connect(i_LastAccesToken);
            setAccesTokenAndLoggedInUser();
        }

        private void setAccesTokenAndLoggedInUser()
        {
            s_LoggedInUser = m_LoginResult.LoggedInUser;
            AccesToken = m_LoginResult.AccessToken;
        }

        public void SetUser(User i_LoggedInUser)
        {
            s_LoggedInUser = i_LoggedInUser;
        }

        public User GetUserInstance()
        {
            return s_LoggedInUser;
        }
    }
}
