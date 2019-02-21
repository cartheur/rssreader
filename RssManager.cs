// Designed and constructed by Christopher A Tucker, February 2007.

namespace RSSReader
{
    /// <summary>
    /// Each iteration through the RSS XML will create a new instance of NewsItem that will be added to the returnArrayList, which will ultimately return to the method that consumes/calls ProcessNewsFeed.
    /// </summary>
    /// <remarks>Keep the RSSManager generic without losing desired functionality. Switch and optimize the delegation roles and persistence chores.</remarks>
    public class RssManager
    {
        public static System.Collections.ArrayList ProcessNewsFeed(string rssURL)
        {
            // Begin the WebRequest to the desired RSS Feed.
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(rssURL);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            // Convert the RSS Feed into an XML document.
            System.IO.Stream rssStream = myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            rssDoc.Load(rssStream);

            // This uses an XPath expression to get all nodes that fall under this path.
            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            // Loop through the Item nodes from the RSS Feed and retrieve the Title, Link, Description, and Date. Then add it to the database (if not already present).
            System.Collections.ArrayList returnArrayList = new System.Collections.ArrayList();

            // Look through each individual item and add them to an array list.
            for (int i = 0; i < rssItems.Count; i++)
            {
                System.Xml.XmlNode rssDetail;

                NewsItem tempNewsItem = new NewsItem();

                rssDetail = rssItems.Item(i).SelectSingleNode("title");
                if (rssDetail != null)
                {
                    tempNewsItem.Title = rssDetail.InnerText;  
                }
                else
                {
                    tempNewsItem.Title = "";
                }
                rssDetail = rssItems.Item(i).SelectSingleNode("link");
                if (rssDetail != null)
                {
                    tempNewsItem.Link = rssDetail.InnerText;
                }
                else
                {
                    tempNewsItem.Link = "";
                }
                rssDetail = rssItems.Item(i).SelectSingleNode("description");
                if (rssDetail != null)
                {
                    tempNewsItem.Description = rssDetail.InnerText;
                }
                else
                {
                    tempNewsItem.Description = "";
                }
                rssDetail = rssItems.Item(i).SelectSingleNode("pubDate");
                if (rssDetail != null)
                {
                    tempNewsItem.pubDate = rssDetail.InnerText;
                }
                else
                {
                    tempNewsItem.pubDate = "";
                }
                returnArrayList.Add(tempNewsItem);
            }
            return returnArrayList;
        }
    }
}
