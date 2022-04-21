using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    public class FacebookData
    {
        private LoggedInUser m_LoggedInUserControl = new LoggedInUser();

        public string UserName()
        {
            return (m_LoggedInUserControl.GetUserInstance() == null || m_LoggedInUserControl.GetUserInstance().Name == null ? null : m_LoggedInUserControl.GetUserInstance().Name);
        }

        public string GetBirthday()
        {
            return (m_LoggedInUserControl.GetUserInstance() == null || m_LoggedInUserControl.GetUserInstance().Birthday == null ?
                null : m_LoggedInUserControl.GetUserInstance().Birthday.Substring(3, 3) +
                m_LoggedInUserControl.GetUserInstance().Birthday.Substring(0, 3) +
                m_LoggedInUserControl.GetUserInstance().Birthday.Substring(6, 4));
        }

        public string GetGender()
        {
            return (m_LoggedInUserControl.GetUserInstance() == null || m_LoggedInUserControl.GetUserInstance().Gender == null ? null : m_LoggedInUserControl.GetUserInstance().Gender.ToString());
        }

        public string GetLocation()
        {
            return (m_LoggedInUserControl.GetUserInstance() == null || m_LoggedInUserControl.GetUserInstance().Location == null ? null : m_LoggedInUserControl.GetUserInstance().Location.Name);
        }

        public void FetchFeed(ListBox i_feedListBox, User i_LoggedInUser, ListBox i_searchListBox)
        {
            //i_feedListBox.Items.Clear();
            i_feedListBox.DisplayMember = "Name";
            foreach (Post post in i_LoggedInUser.NewsFeed)
            {
                if (post.Message != null)
                {
                    i_feedListBox.Invoke(new Action(() => i_feedListBox.Items.Add(post.Message)));
                    //i_searchListBox.Invoke(new Action(() => i_searchListBox.Items.Add(post.Message)));
                    i_searchListBox.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    i_feedListBox.Invoke(new Action(() => i_feedListBox.Items.Add(post.Caption)));
                }
                else
                {
                    i_feedListBox.Invoke(new Action(() => i_feedListBox.Items.Add(string.Format("[{0}]", post.Type))));
                }
            }

            if (i_feedListBox.Items.Count == 0)
            {
                i_feedListBox.Invoke(new Action(() => i_feedListBox.Text = "No Posts to retrieve"));
                //i_feedListBox.Text = "No Posts to retrieve";
            }
        }

        public void FetchAlbums(ListBox i_albumsListBox, User i_LoggedInUser, ListBox i_searchListBox)
        {
            //i_albumsListBox.Items.Clear();
            i_albumsListBox.DisplayMember = "Name";
            foreach (Album album in i_LoggedInUser.Albums)
            {
                i_albumsListBox.Invoke(new Action(() => i_albumsListBox.Items.Add(album)));
                //i_searchListBox.Invoke(new Action(() => i_searchListBox.Items.Add(album)));
                i_searchListBox.Items.Add(album);
            }

            if (i_albumsListBox.Items.Count == 0)
            {
                i_albumsListBox.Invoke(new Action(() => i_albumsListBox.Text = "No Albums to retrieve"));
                //i_albumsListBox.Text = "No Albums to retrieve";
            }
        }

        public void FetchEvents(ListBox i_EventsListBox, User i_LoggedInUser, ListBox i_searchListBox)
        {
            //i_EventsListBox.Items.Clear();
            i_EventsListBox.DisplayMember = "Name";
            foreach (Event fbEvent in i_LoggedInUser.Events)
            {
                i_EventsListBox.Invoke(new Action(() => i_EventsListBox.Items.Add(fbEvent)));
                //i_searchListBox.Invoke(new Action(() => i_searchListBox.Items.Add(fbEvent)));
                i_searchListBox.Items.Add(fbEvent);
            }

            if (i_EventsListBox.Items.Count == 0)
            {
                i_EventsListBox.Invoke(new Action(() => i_EventsListBox.Text = "No Events to retrieve"));
                //i_EventsListBox.Text = "No Events to retrieve";
            }
        }

        public void FetchLikedPages(ListBox i_likedPagesListBox, User i_LoggedInUser, ListBox i_searchListBox)
        {
            //i_likedPagesListBox.Items.Clear();
            i_likedPagesListBox.DisplayMember = "Name";

            try
            {
                foreach (Page page in i_LoggedInUser.LikedPages)
                {
                    i_likedPagesListBox.Invoke(new Action(() => i_likedPagesListBox.Items.Add(page)));
                    //i_searchListBox.Invoke(new Action(() => i_searchListBox.Items.Add(page)));
                    i_searchListBox.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (i_likedPagesListBox.Items.Count == 0)
            {
                i_likedPagesListBox.Invoke(new Action(() => i_likedPagesListBox.Text = "No liked pages to retrieve"));
                //i_likedPagesListBox.Text = "No liked pages to retrieve";
            }
        }

        public void FetchGroups(ListBox i_groupsListBox, User i_LoggedInUser, ListBox i_searchListBox)
        {
            //i_groupsListBox.Items.Clear();
            i_groupsListBox.DisplayMember = "Name";

            try
            {
                foreach (Group group in i_LoggedInUser.Groups)
                {
                    i_groupsListBox.Invoke(new Action(() => i_groupsListBox.Items.Add(group)));
                    //i_searchListBox.Invoke(new Action(() => i_searchListBox.Items.Add(group)));
                    i_searchListBox.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (i_groupsListBox.Items.Count == 0)
            {
                i_groupsListBox.Invoke(new Action(() => i_groupsListBox.Text = "No Groups to retrieve"));
                //i_groupsListBox.Text = "No Groups to retrieve";
            }
        }

        public void FetchFriends(ListBox i_friendsListBox, User i_LoggedInUser, ListBox i_searchListBox)
        {
            //i_friendsListBox.Items.Clear();
            i_friendsListBox.DisplayMember = "Name";

            foreach (User friend in i_LoggedInUser.Friends)
            {
                i_friendsListBox.Invoke(new Action(() => i_friendsListBox.Items.Add(friend)));
                //i_searchListBox.Invoke(new Action(() => i_searchListBox.Items.Add(friend)));
                i_searchListBox.Items.Add(friend);
            }

            if (i_friendsListBox.Items.Count == 0)
            {
                i_friendsListBox.Invoke(new Action(() => i_friendsListBox.Text = "No friends to retrieve"));
                //i_friendsListBox.Text = "No friends to retrieve";
            }
        }
    }
}
