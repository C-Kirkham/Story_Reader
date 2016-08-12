using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Story_Reader
{
    public class Chapter
    {
        string Chap_Title = "";
        string Chap_Body = "";
        public Chapter(string title,string body)
        {
            Chap_Title = title;
            Chap_Body = body;
        }
    }
    class Story
    {
        string Author = "";
        string Title = "";
        int Chapters = 0;
        bool Complete = false;
        List<Chapter> StoryBody;

        public Story(string author,string title_Story, string title_Chap, string body_Chap, bool finished)
        {
            StoryBody = new List<Chapter>();
            Author = author;
            Title = title_Story;
            AddChapter(title_Chap, body_Chap, finished);
            
        }

        public void AddChapter(string title, string body, bool status)
        {
            StoryBody.Add(new Chapter(title, body));
            Complete = status;
            Chapters++;
        }
    }
}