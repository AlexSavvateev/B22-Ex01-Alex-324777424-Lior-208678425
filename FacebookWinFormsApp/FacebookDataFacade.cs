using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace B22_Ex02_Alex_324777424_Lior_208678425
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

        public void GetUserDataCollections(ListBox i_FeedListBox, ListBox i_AlbumsListBox, ListBox i_EventsListBox, ListBox i_GroupsListBox, ListBox i_LikedPagesListBox, ListBox i_FriendsListBox, User i_LoggedInUser, ListBox i_searchListBox)
        {
            new Thread(() => m_FacebookData.FetchFeed(i_FeedListBox, i_LoggedInUser, i_searchListBox)).Start();
            new Thread(() => m_FacebookData.FetchAlbums(i_AlbumsListBox, i_LoggedInUser, i_searchListBox)).Start();
            new Thread(() => m_FacebookData.FetchEvents(i_EventsListBox, i_LoggedInUser, i_searchListBox)).Start();
            new Thread(() => m_FacebookData.FetchGroups(i_GroupsListBox, i_LoggedInUser, i_searchListBox)).Start();
            new Thread(() => m_FacebookData.FetchLikedPages(i_LikedPagesListBox, i_LoggedInUser, i_searchListBox)).Start();
            new Thread(() => m_FacebookData.FetchFriends(i_FriendsListBox, i_LoggedInUser, i_searchListBox)).Start();
        }
    }
}
