namespace PiramalSchoolOfLeadership.Models
{
    public class YouTubePlaylistResponse
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextpagetoken { get; set; }
        public List<PlaylistItem> items { get; set; }
        public PageInfo pageinfo { get; set; }
    }

    public class PlaylistItem
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public Snippet snippet { get; set; }
    }

    public class Snippet
    {
        public DateTime publishedat { get; set; }
        public string channelid { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Thumbnails thumbnails { get; set; }
        public string channeltitle { get; set; }
        public string playlistid { get; set; }
        public int position { get; set; }
        public ResourceId resourceid { get; set; }
        public string videoownerchanneltitle { get; set; }
        public string videoownerchannelid { get; set; }
    }

    public class Thumbnails
    {
        public Thumbnail @default { get; set; }
        public Thumbnail medium { get; set; }
        public Thumbnail high { get; set; }
        public Thumbnail standard { get; set; }
        public Thumbnail maxres { get; set; }
    }

    public class Thumbnail
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class ResourceId
    {
        public string kind { get; set; }
        public string videoid { get; set; }
    }

    public class PageInfo
    {
        public int totalresults { get; set; }
        public int resultsperpage { get; set; }
    }
}
