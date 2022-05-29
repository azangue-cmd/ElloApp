using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElloApp.Models
{
    public class StatusDataModel
    {
        public string ContactName { get; set; }
        public Uri ContactPhoto { get; set; }
        public Uri StatusImage { get; set; }
        
        //if we want to add our status
        public bool IsMeAddStatus { get; set; }
        /// <summary>
        /// we will be covering in one of our upcomiung video 
        /// To-DO: Status message
        /// </summary>
        //public string StatusMessage { get; set; }
    }
}
