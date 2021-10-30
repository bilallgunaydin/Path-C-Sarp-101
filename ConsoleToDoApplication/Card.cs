using System;
using System.Collections.Generic;

namespace ConsoleToDoApplication
{
    public class Card
    {
        static int id;
        public Card()
        {
            id++;
            CardID=id;
            LineType=Line.TODOLine; 
        }
        public int CardID {get; set;}
        public string Title { get; set; }
        public string Content { get; set; }
        public int MemberID{ get; set; }
        public virtual Member Member { get; set; }
        public CardSize cardSize { get; set; }
        public Line LineType { get; set; }

    }
}