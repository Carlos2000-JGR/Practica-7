using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSpecific.Models
{
    public class Anime
    {
        public string Name { get; }
        public string Language { get; }


        public Anime(string name, string language)
        {
            Name = name;
            Language = language;
        }

       
    }
}