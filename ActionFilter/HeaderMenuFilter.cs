using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using PiramalSchoolOfLeadership.Helper;
using PiramalSchoolOfLeadership.Models;

namespace PiramalSchoolOfLeadership.ActionFilter
{
    public class HeaderMenuFilter: IActionFilter
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        public HeaderMenuFilter(IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                var controller = context.Controller as Controller;
                if (controller == null) return;
                JSONResponse articleData = JsonReaderFromFile.ReadJsonFileToList("articles.json", _webHostEnvironment.WebRootPath);
                if (articleData != null && articleData.JSONList != null && articleData.JSONList.Count > 0)
                {
                    controller.ViewBag.ArticleList = articleData.JSONList.Take(2).ToList();
                }
                JSONResponse blogData = JsonReaderFromFile.ReadJsonFileToList("blogs.json", _webHostEnvironment.WebRootPath);
                if (blogData != null && blogData.JSONList != null && blogData.JSONList.Count > 0)
                {
                    controller.ViewBag.BlogData = blogData.JSONList.Take(2).ToList();
                }
                JSONResponse stories = JsonReaderFromFile.ReadJsonFileToList("news-stories.json", _webHostEnvironment.WebRootPath);
                if (stories != null && stories.JSONList != null && stories.JSONList.Count > 0)
                {
                    controller.ViewBag.Stories = stories.JSONList.Take(2).ToList();
                }
                JSONResponse pressReleases = JsonReaderFromFile.ReadJsonFileToList("press-releases.json", _webHostEnvironment.WebRootPath);
                if (pressReleases != null && pressReleases.JSONList != null && pressReleases.JSONList.Count > 0)
                {
                    controller.ViewBag.PressReleases = pressReleases.JSONList.Take(2).ToList();
                }
                JSONResponse reports = JsonReaderFromFile.ReadJsonFileToList("reports.json", _webHostEnvironment.WebRootPath);
                if (reports != null && reports.JSONList != null && reports.JSONList.Count > 0)
                {
                    controller.ViewBag.Reports = reports.JSONList.Take(2).ToList();
                }
                JSONResponse researchPapers = JsonReaderFromFile.ReadJsonFileToList("research-papers.json", _webHostEnvironment.WebRootPath);
                if (researchPapers != null && researchPapers.JSONList != null && researchPapers.JSONList.Count > 0)
                {
                    controller.ViewBag.ResearchPapers = researchPapers.JSONList.Take(2).ToList();
                }
                controller.ViewBag.Videos = GetVideos(2);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private List<PlaylistItem> GetVideos(int count)
        {
            List<PlaylistItem> dataList = null;
            try
            {
                var client = new HttpClient();
                string youtubeURL = _configuration["Videos:YoutubeAPIURL"];
                string apiKey = _configuration["Videos:YoutubeAPIKey"];
                string apiPlayList = _configuration["Videos:YoutubeAPIPlayList"];
                string url = youtubeURL + "&maxResults=" + count + "&playlistId=" + apiPlayList + "&key=" + apiKey;
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                var response = client.SendAsync(request).Result;
                response.EnsureSuccessStatusCode();
                string responseString = response.Content.ReadAsStringAsync().Result;
                YouTubePlaylistResponse data = JsonConvert.DeserializeObject<YouTubePlaylistResponse>(responseString);
                dataList = data.items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataList;
        }

        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
           
        }

    }
}
