namespace RSSReader
{
    /// <summary>
    /// Select each component of the RSS feed and give it a structure.
    /// </summary>
    public class NewsItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string pubDate { get; set; }
    }
}
