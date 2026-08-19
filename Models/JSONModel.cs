using System.Reflection.Metadata;

namespace PiramalSchoolOfLeadership.Models
{
    public class JSONModel
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string PublishedDate { get; set; }
        public string URL { get; set; }
        public string Publisher { get; set; }
    }
    public class JSONResponse
    {
        public List<JSONModel> JSONList { get; set; }
    }
}
