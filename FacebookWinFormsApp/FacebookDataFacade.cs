using FacebookWrapper.ObjectModel;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    public sealed class FacebookDataFacade
    {
        private static FacebookDataFacade s_FacebookDataFacade = null;
        private FacebookData m_FacebookData = new FacebookData();

        private FacebookDataFacade()
        {

        }

        public static FacebookDataFacade GetInstance
        {
            get
            {
                if (s_FacebookDataFacade == null)
                {
                    s_FacebookDataFacade = new FacebookDataFacade();
                }

                return s_FacebookDataFacade;
            }
        }

        public string Name
        {
            get { return string.Format("Name: {0}", m_FacebookData.UserName()); }
        }

        public string Birthday
        {
            get { return string.Format("Birthday: {0}", m_FacebookData.GetBirthday()); }
        }

        public string Gender
        {
            get { return string.Format("Gendr: {0}", m_FacebookData.GetGender()); }
        }

        public string Location
        {
            get { return string.Format("Location: {0}", m_FacebookData.GetLocation()); }
        }


    }
}
