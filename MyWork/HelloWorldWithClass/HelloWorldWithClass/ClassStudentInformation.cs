using System;
using System.Text;

namespace HelloWorldWithClass
{
    public class ClassStudentInformation  
    {
        string Author;
        string Title;
        string Publisher;

        public ClassStudentInformation(string a,string t, string p)
        {
            this.Author = a;
            this.Title = t;
            this.Publisher = p;

        }

        public string getAuthorName()
        {
            return Author;
        }

        public string getTitle()
        {
            return Title;
        }

        public string getPublisher()
        {
            return Publisher;
        }

        public string Output()
        {

            return ("Title: " + this.getTitle() + " Author: " + this.getAuthorName()+ " Publisher: " + this.getPublisher()); 
            
           
        }
   
    }
}
