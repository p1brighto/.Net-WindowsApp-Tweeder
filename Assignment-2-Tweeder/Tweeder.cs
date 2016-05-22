/*
Assigment-: Tweeder
Author: Brighto Paul
Purpose:To become comfortable with building C# applications in Visual Studio, 
building an application  connects the Twitter account and show all the tweets.
Date of Submission:7th March,2016
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace Assignment_2
{
    public partial class twitterForm : Form
    {

        TwitterService sTwitterService; // interact with Twitter

        // to hold the 4 keys to access to Twitter
        const string consumerKeyString = "SocgYwxWPJzya0wWDqLgJOftp";
        const string consumerSecretString = "QpIFvBZw8JvdSrAqEmnIuf1rxHOTekol9vtxLvjwenilDdNCZw";
        const string tokenyAcessString = "385509003-Z5eM0VtLhmvHtQcmSjz92WWwsYNgGIQrtIy0YPsz";
        const string tokenSecretString = "jXidp0nbJVDdyiJ6JZBPCSJvPD9ZpumKGAEg9DtS6Crbj";
        public twitterForm()
        {
            InitializeComponent();
        }
        //application load
        private void TwitterForm_Load(object sender, EventArgs e)
        {
            //instantiate a new twitter service
            sTwitterService = new TwitterService(consumerKeyString, consumerSecretString);
            //authenticate
            sTwitterService.AuthenticateWith(tokenyAcessString, tokenSecretString);
        }
        //close the app when the user click on exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//close command
        }
        // displays a MessageBox with the title of the application, name and a brief description 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author:Brighto Paul \nThis is an application  connects the Twitter account \nand show all the tweets."
            , "Tweeder", MessageBoxButtons.OK, MessageBoxIcon.Information); ; // Display a message box showing  details 
        }
        // Search and Display the tweet by user from the twitter account
        private void searchUserButton_Click(object sender, EventArgs e)
        {
            //enabled to try to skip the errors
            try {
                TweetsRichTextBox.Text = String.Empty;//clear rich text box
                ListTweetsOnUserTimelineOptions lt = new ListTweetsOnUserTimelineOptions();
                lt.ScreenName = TweetHandleTextBox.Text; // The Twitter Account/Handle name 
                lt.Count = Int32.Parse(TweetsCountTextBox.Text); // How many tweets to grab 
                lt.ExcludeReplies = true; // Show only tweets, no replies
                var tweets = sTwitterService.ListTweetsOnUserTimeline(lt);
                if (lt.Count > 0 && lt.ScreenName != String.Empty)//verify if Tweets must be > 0 & Twitter Handle or HashTag field must not be blank
                {
                    if (tweets.Any()) // verify if any tweets exist 
                        foreach (var tweet in tweets)//loop to get all the tweets as per count
                        {
                            TweetsRichTextBox.Text += tweet.CreatedDate + ": " + tweet.Text + "\n";//tweetes will be added to the rich box

                        }
                    else
                    {
                        TweetsRichTextBox.Text = "No tweets found";//if no tweet found
                    }
                }
                else
                {
                    MessageBox.Show("Please Input a valid value for Twitter Handle or HashTag field and Tweets Field","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
               
            }
        }
        // Search and Display the tweet by Hash tag from the twitter account
        private void searchHashButton_Click(object sender, EventArgs e)
        {
            //enabled to try to skip the errors
            try
            {
                TweetsRichTextBox.Text = String.Empty;//clear the rich text box
                SearchOptions so = new SearchOptions();
                so.Q =TweetHandleTextBox.Text; // the Hashtag to look for
                so.Count =Int32.Parse(TweetsCountTextBox.Text); // the number of tweets to obtain
                var results = sTwitterService.Search(so);
                if (so.Count > 0 && so.Q != String.Empty)//verify if Tweets must be > 0 & Twitter Handle or HashTag field must not be blank
                {
                    if (results.Statuses.Any()) // verify if any tweets exist
                        foreach (var result in results.Statuses)
                        {
                            TweetsRichTextBox.Text += result.CreatedDate + ": " + result.Text + "\n";//tweetes will be added to the rich box
                        }
                    else
                    {
                        TweetsRichTextBox.Text = "No tweets found";//if no tweet found
                    }
                }
                else
                {
                    MessageBox.Show("Please Input a valid value for Twitter Handle or HashTag field and Tweets Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                
            }
        }
    }
}
