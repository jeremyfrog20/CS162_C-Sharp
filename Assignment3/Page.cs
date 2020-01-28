using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Page
    {
        public Page()
        {
            rand = new Random(DateTime.Now.Second);
            url = "";
            visits = 0;
            usedLinks = 0;
            links = new Page[3];
        }

        public Page(in string url)
        {
            rand = new Random(DateTime.Now.Second);
            this.url = url;
            visits = 0;
            usedLinks = 0;
            links = new Page[3];
        }

        public string getURL()
        {
            return url;
        }

        public int getNumLinks()
        {
            return usedLinks;
        }

        public ref Page getRandomLink()
        {
            return ref links[rand.Next(0, usedLinks)];
        }

        public void addLink(ref Page other)
        {
            links[usedLinks] = other;
            usedLinks++;
        }

        public void visit()
        {
            visits++;
        }

        public int getNumVisits()
        {
            return visits;
        }

        private Random rand;
        private string url;
        private int visits, usedLinks;
        //This isn't a pointer, but c# does this different.
        private Page[] links;
    }
}
