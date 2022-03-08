using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B22_Ex01_Alex_324777424_Lior_208678425
{
    public class FacebookData
    {
        public User LoggedInUser { get; private set; }

        public string AccesToken { get; private set; }

        private LoginResult m_LoginResult;

        public void LoginToFacebook()
        {
            m_LoginResult = FacebookService.Login("743579109959282",
                "public_profile",
                 "email",
                 "user_birthday",
                 "user_age_range",
                 "user_gender",
                 "user_link",
                 "user_tagged_places",
                 "user_videos",
                 "user_friends",
                 "user_events",
                 "user_likes",
                 "user_location",
                 "user_photos",
                 "user_posts",
                 "user_hometown");
            setAccesTokenAndLoggedInUser();    
        }

        private void setAccesTokenAndLoggedInUser()
        {
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                LoggedInUser = m_LoginResult.LoggedInUser;
                AccesToken = m_LoginResult.AccessToken;
                FetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void FetchUserInfo()
        {
            profilePictureBox.LoadAsync(LoggedInUser.PictureLargeURL);
            nameLabel.Text = string.Format("Full Name: {0}", m_LoggedInUser.Name);
            birthDateLabel.Text = string.Format("Birthday: {0}", m_LoggedInUser.Birthday);
            genderLabel.Text = string.Format("Gender: {0}", m_LoggedInUser.Gender);
            locationLabel.Text = string.Format("Location: {0}", m_LoggedInUser.Location.Name);
            buttonLogin.Text = string.Format("Logged in as {0}", m_LoggedInUser.FirstName);
            FetchFeed();
            FetchAlbums();
            FetchEvents();
            FetchGroups();
            FetchLikedPages();
            FetchFriends();
        }

        private void FetchFeed()
        {
            feedListBox.Items.Clear();
            feedListBox.DisplayMember = "Name";
            foreach (Post post in m_LoggedInUser.NewsFeed)
            {
                if (post.Message != null)
                {
                    feedListBox.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    feedListBox.Items.Add(post.Caption);
                }
                else
                {
                    feedListBox.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (feedListBox.Items.Count == 0)
            {
                feedListBox.Items.Add("No Posts to retrieve");
            }
        }

        private void FetchAlbums()
        {
            albumsListBox.Items.Clear();
            albumsListBox.DisplayMember = "Name";
            foreach (Album album in m_LoggedInUser.Albums)
            {
                albumsListBox.Items.Add(album);
                //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (albumsListBox.Items.Count == 0)
            {
                albumsListBox.Items.Add("No Albums to retrieve");
            }
        }

        private void FetchEvents()
        {
            eventsListBox.Items.Clear();
            eventsListBox.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                eventsListBox.Items.Add(fbEvent);
            }

            if (eventsListBox.Items.Count == 0)
            {
                eventsListBox.Items.Add("No Events to retrieve");
            }
        }

        private void FetchLikedPages()
        {
            likedPagesListBox.Items.Clear();
            likedPagesListBox.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    likedPagesListBox.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (likedPagesListBox.Items.Count == 0)
            {
                likedPagesListBox.Items.Add("No liked pages to retrieve");
            }
        }

        private void FetchGroups()
        {
            groupsListBox.Items.Clear();
            groupsListBox.DisplayMember = "Name";

            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    groupsListBox.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (groupsListBox.Items.Count == 0)
            {
                groupsListBox.Items.Add("No groups to retrieve");
            }
        }

        private void FetchFriends()
        {
            friendsListBox.Items.Clear();
            friendsListBox.DisplayMember = "Name";

            foreach (User friend in m_LoggedInUser.Friends)
            {
                friendsListBox.Items.Add(friend);
            }

            if (friendsListBox.Items.Count == 0)
            {
                friendsListBox.Items.Add("No friends to retrieve");
            }
        }
    }
}
