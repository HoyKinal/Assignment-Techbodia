using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Notification
    {
        public int Id { get; set; } 
        public string Title { get; set; }   
        public List<string> Channels {  get; set; }
        public Notification(string Title) 
        {
            this.Title = Title;

            Channels = new List<string>();  
        }   
    }
}
