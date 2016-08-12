using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

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
        List<string> keywords;
        List<Chapter> StoryBody;

        public Story(string author,string title_Story, string title_Chap, string body_Chap, bool finished, string keyword)
        {
            StoryBody = new List<Chapter>();
            keywords = new List<string>();;
            Author = author;
            Title = title_Story;
            string filename = string.Format("{0}-{1}.xml",Author,Title);
            File.OpenWrite(filename); 
            File.AppendText("<story>");
            File.AppendText("<string Author='Auth'>");
            File.AppendText(Author);
            File.AppendText("</string>");
            File.AppendText("<string Title='Title'>");
            File.AppendText(Title);
            File.AppendText("</string>");
            File.AppendText("<bool Complete='Finished'>");
            File.AppendText(finished.ToString());
            File.AppendText("</bool>");
            
            
            AddKeywords(filename,keyword);
            
            AddChapter(filename,title_Chap, body_Chap, finished);
            
            File.OpenWrite(filename);
            File.AppendText("</Story>");
            
        }

        public void AddChapter(string file, string title, string body, bool status)
        {
            StoryBody.Add(new Chapter(title, body));
            Complete = status;
            Chapters++;
            File.OpenWrite(file);
            File.AppendText("<Chapter>");
            File.AppendText("<string Chap_Title='C_T'>");
            File.AppendText(title);
            File.AppendText("</string>");
            File.AppendText("<string Chap_Body='C_B'>");
            File.AppendText(body);
            File.AppendText("</string>");
            File.AppendText("</Chapter>");

        }
        public void AddKeywords(string file, string keyword)
        {
            string[] words = keyword.Split(' ');
            File.OpenWrite(file);
            File.AppendText("<Keywords>");
            for (int i = 0; i < words.Length; i++)
            {
                keywords.Add(words[i]);
                File.AppendText("<string keyword='K'>");
                File.AppendText(words[i]);
                File.AppendText("</string>");
            }
            File.AppendText("</Keywords>");
        }
    }
}