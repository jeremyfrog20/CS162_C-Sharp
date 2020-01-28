using System;
using System.Collections;
using System.Collections.Generic;


namespace Assignment3
{
    class Program
    {
        static public void initLinks(ref Page page1, ref Page page2, ref Page page3, ref Page page4)
        {
            page1.addLink(ref page2);
            page1.addLink(ref page3);

            page2.addLink(ref page3);

            page3.addLink(ref page1);

            page4.addLink(ref page1);
            page4.addLink(ref page3);
        }

        static ref Page findNewPage(ref Page currentPage, ref Page page1, ref Page page2, ref Page page3, ref Page page4)
        {
            int randNum = rand.Next(1, 100);

            if ((currentPage.getNumLinks() == 0) || (randNum <= 15))
            {
                int pageNum = rand.Next(0,4);

                switch(pageNum)
                {
                    case 0: return ref page1;
                    case 1: return ref page2;
                    case 2: return ref page3;
                    case 3: return ref page4;
                    default: throw new IndexOutOfRangeException();
                }
            }

            return ref currentPage.getRandomLink();
        }
        const int LIMIT = 10000;
        static public void simulate(ref Page page1, ref Page page2, ref Page page3, ref Page page4)
        {
            //does this copy?
            Page currentPage = page1;

            for (int i = 0; i < LIMIT; i++)
            {
                currentPage = findNewPage(ref currentPage, ref page1, ref page2, ref page3, ref page4);
                currentPage.visit();
            }
        }

        static void printResult(ref Page page1, ref Page page2, ref Page page3, ref Page page4)
        {
            Console.WriteLine($"{page1.getURL()} got {((double)page1.getNumVisits() / LIMIT) * 100}% of the visits\n");
            Console.WriteLine($"{page2.getURL()} got {((double)page2.getNumVisits() / LIMIT) * 100}% of the visits\n");
            Console.WriteLine($"{page3.getURL()} got {((double)page3.getNumVisits() / LIMIT) * 100}% of the visits\n");
            Console.WriteLine($"{page4.getURL()} got {((double)page4.getNumVisits() / LIMIT) * 100}% of the visits\n");


        }

        static Random rand = new Random(DateTime.Now.Second);
        static void Main(string[] args)
        {
            Page page1 = new Page("http://page1");
            Page page2 = new Page("http://page2");
            Page page3 = new Page("http://page3");
            Page page4 = new Page("http://page4");

            initLinks(ref page1, ref page2, ref page3, ref page4);

            simulate(ref page1, ref page2, ref page3, ref page4);

            printResult(ref page1, ref page2, ref page3, ref page4);

        }
    }
}
