using FacebookWrapper.ObjectModel;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    public sealed class LoggedInUser
    {
        private static User s_LoggedInUser = null;

        public LoggedInUser()
        {

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
