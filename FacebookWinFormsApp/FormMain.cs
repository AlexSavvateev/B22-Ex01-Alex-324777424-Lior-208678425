using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        User m_LoggedInUser;
        LoginResult m_LoginResult;

        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login("743579109959282", 
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
                    "user_videos",
                    "pages_read_user_content",
                    "pages_read_engagement");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void fetchUserInfo()
        {
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureLargeURL);
            nameLabel.Text = string.Format("Full Name: {0}", m_LoggedInUser.Name);
            birthDateLabel.Text = string.Format("Birthday: {0}", m_LoggedInUser.Birthday);
            genderLabel.Text = string.Format("Gender: {0}", m_LoggedInUser.Gender);
            locationLabel.Text = string.Format("Location: {0}", m_LoggedInUser.Location.Name);
            buttonLogin.Text = string.Format("Logged in as {0}", m_LoggedInUser.FirstName);
            fetchFeed();
            fetchAlbums();
            fetchEvents();
            fetchGroups();
            fetchLikedPages();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("alex.savvateev@gmail.com"); 

            loginAndInit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }

        private void fetchFeed()
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

        private void fetchAlbums()
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

        private void fetchEvents()
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

        private void fetchLikedPages()
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

        private void fetchGroups()
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

            foreach (FriendList friend in m_LoggedInUser.FriendLists)
            {
                friendsListBox.Items.Add(friend);
            }

            if (friendsListBox.Items.Count == 0)
            {
                friendsListBox.Items.Add("No friends to retrieve");
            }
        }

        private void feedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPostFromFeed();
            Post selectedPost = m_LoggedInUser.Posts[feedListBox.SelectedIndex];
            commentsListBox.DisplayMember = "Message";
            commentsListBox.DataSource = selectedPost.Comments;
        }

        private void displaySelectedPostFromFeed()
        {
            if (feedListBox.SelectedItems.Count == 1)
            {
                Post selectedPost = m_LoggedInUser.Posts[feedListBox.SelectedIndex];
                if (selectedPost.PictureURL != null)
                {
                    feedPictureBox.Visible = true;
                    feedPictureBox.LoadAsync(selectedPost.PictureURL);
                    feedPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                else
                {
                    feedPictureBox.Visible = false;
                }
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(postTextBox.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
