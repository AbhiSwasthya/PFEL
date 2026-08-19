using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PiramalSchoolOfLeadership.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Text;
using Newtonsoft.Json;
using PiramalSchoolOfLeadership.Helper;
using PiramalSchoolOfLeadership.ActionFilter;

namespace PiramalSchoolOfLeadership.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISession _session;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _webHostEnvironment;
        
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor, IConfiguration configuration, IWebHostEnvironment webHostEnvironment) 
        {
            _logger = logger;
            _session = httpContextAccessor.HttpContext.Session;
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;           
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("about-us")]
        public IActionResult About()
        {
            return View();
        }
        [Route("contact-us")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("articles")]
        public IActionResult Articles()
        {
            JSONResponse articleData = JsonReaderFromFile.ReadJsonFileToList("articles.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            return View(articleData.JSONList);
        }
        [Route("blogs")]
        public IActionResult Blogs()
        {
            JSONResponse blogData = JsonReaderFromFile.ReadJsonFileToList("blogs.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            return View(blogData.JSONList);
        }
        [Route("career")]
        public IActionResult Career()
        {
            return View();
        }        
        [Route("news-stories")]
        public IActionResult NewsStories()
        {
            JSONResponse blogData = JsonReaderFromFile.ReadJsonFileToList("news-stories.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            return View(blogData.JSONList);
        }
        [Route("press-releases")]
        public IActionResult PressReleases()
        {
            JSONResponse blogData = JsonReaderFromFile.ReadJsonFileToList("press-releases.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            return View(blogData.JSONList);
        }
        [Route("reports")]
        public IActionResult Reports()
        {
            JSONResponse articleData = JsonReaderFromFile.ReadJsonFileToList("reports.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            return View(articleData.JSONList);
        }
        [Route("research-papers")]
        public IActionResult ResearchPapers()
        {

            JSONResponse articleData = JsonReaderFromFile.ReadJsonFileToList("research-papers.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            return View(articleData.JSONList);
        }
        public IActionResult LoadBlogs(int count)
        {            
            JSONResponse blogData = JsonReaderFromFile.ReadJsonFileToList("blogs.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            List<JSONModel> blogListFiltered = blogData.JSONList.Take(count).ToList();
            return PartialView("_PartialBlogs", blogListFiltered);
        }
        public IActionResult LoadArticles(int count)
        {
            JSONResponse articleData = JsonReaderFromFile.ReadJsonFileToList("articles.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            List<JSONModel> articleListFiltered = articleData.JSONList.Take(count).ToList();
            return PartialView("_PartialBlogs", articleListFiltered);
        }
        public IActionResult LoadStories(int count)
        {
            JSONResponse storyData = JsonReaderFromFile.ReadJsonFileToList("news-stories.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            List<JSONModel> storyListFiltered = storyData.JSONList.Take(count).ToList();
            return PartialView("_PartialBlogs", storyListFiltered);
        }
        public IActionResult LoadResearchPapers(int count)
        {
            JSONResponse researchPaperData = JsonReaderFromFile.ReadJsonFileToList("research-papers.json", _webHostEnvironment.WebRootPath); // Example: 5 items per page
            List<JSONModel> researchPaperListFiltered = researchPaperData.JSONList.Take(count).ToList();
            return PartialView("_PartialBlogs", researchPaperListFiltered);
        }                
        [Route("beneath-the-shadow-of-mountains-and-memories-muskaans-awakening")]
        public IActionResult BeneathTheShadowOfMountainsAndMemoriesMuskaansAwakening()
        {
            return View();
        }       
        [Route("building-bharat-by-strengthening-maternal-health-through-capacity-building-of-nurses")]
        public IActionResult BuildingBharatByStrengtheningMaternalHealthThroughCapacityBuildingOfNurses()
        {
            return View();
        }
        [Route("building-bharat-on-the-shoulders-of-education-how-maulana-azads-educational-dream-lives-on-through-nep-2020")]
        public IActionResult BuildingBharatOnTheShouldersOfEducationHowMaulanaAzadsEducationalDreamLivesOnThroughNep2020()
        {
            return View();
        }        
        [Route("centre-for-nurturing-future-leaders")]
        public IActionResult CentreForNurturingFutureLeaders()
        {
            return View();
        }
        [Route("compassionate-eco-system-to-foster-well-being-educating-the-heart-and-mind")]
        public IActionResult CompassionateEcoSystemToFosterWellBeingEducatingTheHeartAndMind()
        {
            return View();
        }       
        [Route("different-not-less-building-an-inclusive-bharat-for-children-with-autism")]
        public IActionResult DifferentNotLessBuildingAnInclusiveBharatForChildrenWithAutism()
        {
            return View();
        }
        [Route("emotional-literacy-will-ensure-a-happy-next-generation")]
        public IActionResult EmotionalLiteracyWillEnsureAHappyNextGeneration()
        {
            return View();
        }
        [Route("empowering-diversity-autism-stereotypes-and-social-responsibility")]
        public IActionResult EmpoweringDiversityAutismStereotypesAndSocialResponsibility()
        {
            return View();
        }
        [Route("foundation-stone-laying-at-psl")]
        public IActionResult FoundationStoneLayingAtPsl()
        {
            return View();
        }
        [Route("holistic-education-for-girls-dignity-ability-and-opportunity")]
        public IActionResult HolisticEducationForGirlsDignityAbilityAndOpportunity()
        {
            return View();
        }
        [Route("hp-government-join-hands-with-piramal-foundation-to-launch-social-emotional-ethical-learning-in-the-state")]
        public IActionResult HpGovernmentJoinHandsWithPiramalFoundationToLaunchSocialEmotionalEthicalLearningInTheState()
        {
            return View();
        }
        [Route("inclusive-education-a-path-to-combat-discrimination")]
        public IActionResult InclusiveEducationAPathToCombatDiscrimination()
        {
            return View();
        }       
        [Route("indias-march-to-100-weve-to-ensure-an-inclusive-future-for-all-writes-business-tycoon-ajay-piramal")]
        public IActionResult IndiasMarchTo100WeveToEnsureAnInclusiveFutureForAllWritesBusinessTycoonAjayPiramal()
        {
            return View();
        }
        [Route("integrating-project-based-learning-in-middle-school-years-program-action-research-and-design-experiment-from-india")]
        public IActionResult IntegratingProjectBasedLearningInMiddleSchoolYearsProgramActionResearchAndDesignExperimentFromIndia()
        {
            return View();
        }
        [Route("international-day-of-women-and-girls-in-science")]
        public IActionResult InternationalDayOfWomenAndGirlsInScience()
        {
            return View();
        }
        [Route("international-education-day-how-to-build-a-compassionate-and-capable-india")]
        public IActionResult InternationalEducationDayHowToBuildACompassionateAndCapableIndia()
        {
            return View();
        }
        [Route("journey-aimed-at-transforming-saharsa-district-hospital-into-a-future-ready-technologically-enabled-centre-of-excellence")]
        public IActionResult JourneyAimedAtTransformingSaharsaDistrictHospitalIntoAFutureReadyTechnologicallyEnabledCentreOfExcellence()
        {
            return View();
        }
        [Route("kashmir-news-chasing-dreams-through-art-based-learning-in-conflict-torn-valley-schools")]
        public IActionResult KashmirNewsChasingDreamsThroughArtBasedLearningInConflictTornValleySchools()
        {
            return View();
        }
        [Route("new-paths-of-learning-soescs-centers-transforming-education")]
        public IActionResult NewPathsOfLearningSoescsCentersTransformingEducation()
        {
            return View();
        }       
        [Route("on-world-health-day-the-need-for-respectful-healthcare")]
        public IActionResult OnWorldHealthDayTheNeedForRespectfulHealthcare()
        {
            return View();
        }
        [Route("piramal-foundation-google-join-hands-to-help-6-lakh-children-learn-to-read-in-30-aspirational-districts")]
        public IActionResult PiramalFoundationGoogleJoinHandsToHelp6LakhChildrenLearnToReadIn30AspirationalDistricts()
        {
            return View();
        }
        [Route("piramal-foundation-hosts-event-to-advance-compassion-based-education-in-india")]
        public IActionResult PiramalFoundationHostsEventToAdvanceCompassionBasedEducationInIndia()
        {
            return View();
        }
        [Route("piramal-foundation-partners-with-emory-university-to-advance-social-emotional-and-ethical-learning")]
        public IActionResult PiramalFoundationPartnersWithEmoryUniversityToAdvanceSocialEmotionalAndEthicalLearning()
        {
            return View();
        }
        [Route("piramal-foundation-showcases-compassion-driven-transformations-in-india-at-5th-annual-juliet-e-shield-symposium-in-us")]
        public IActionResult PiramalFoundationShowcasesCompassionDrivenTransformationsInIndiaAt5thAnnualJulietEShieldSymposiumInUs()
        {
            return View();
        }
        [Route("power-of-compassion-revolutionising-healthcare-in-india")]
        public IActionResult PowerOfCompassionRevolutionisingHealthcareInIndia()
        {
            return View();
        }       
        [Route("rajasthan-mission-buniyaad-to-cover-all-districts-initiative-launched")]
        public IActionResult RajasthanMissionBuniyaadToCoverAllDistrictsInitiativeLaunched()
        {
            return View();
        }
        [Route("re-imagine-literacy-to-develop-compassionate-nation-builders")]
        public IActionResult ReImagineLiteracyToDevelopCompassionateNationBuilders()
        {
            return View();
        }       
        [Route("school-of-climate-and-sustainability")]
        public IActionResult SchoolOfClimateAndSustainability()
        {
            return View();
        }
        [Route("school-of-education-and-systems-change")]
        public IActionResult SchoolOfEducationAndSystemsChange()
        {
            return View();
        }
        [Route("school-of-gender-and-inclusion")]
        public IActionResult SchoolOfGenderAndInclusion()
        {
            return View();
        }
        [Route("school-of-health")]
        public IActionResult SchoolOfHealth()
        {
            return View();
        }
        [Route("shifting-the-needle-from-rule-based-to-role-based-systems")]
        public IActionResult ShiftingTheNeedleFromRuleBasedToRoleBasedSystems()
        {
            return View();
        }
        [Route("socs-greywater-management")]
        public IActionResult SocsGreywaterManagement()
        {
            return View();
        }
        [Route("socs-middle-manager-leadership-development")]
        public IActionResult SocsMiddleManagerLeadershipDevelopment()
        {
            return View();
        }
        [Route("socs-water-conservation")]
        public IActionResult SocsWaterConservation()
        {
            return View();
        }
        [Route("socs-water-efficient-agriculture")]
        public IActionResult SocsWaterEfficientAgriculture()
        {
            return View();
        }
        [Route("soesc-aesthetic-literacy")]
        public IActionResult SoescAestheticLiteracy()
        {
            return View();
        }
        [Route("soesc-assessment-reform")]
        public IActionResult SoescAssessmentReform()
        {
            return View();
        }
        [Route("soesc-compassionate-gender-transformative-education-system")]
        public IActionResult SoescCompassionateGenderTransformativeEducationSystem()
        {
            return View();
        }
        [Route("soesc-karmayogi-saarthi-program")]
        public IActionResult SoescKarmayogiSaarthiProgram()
        {
            return View();
        }
        [Route("soesc-leadership-development")]
        public IActionResult SoescLeadershipDevelopment()
        {
            return View();
        }
        [Route("soesc-mission-buniyaad")]
        public IActionResult SoescMissionBuniyaad()
        {
            return View();
        }
        [Route("soesc-mitra-fellowship")]
        public IActionResult SoescMitraFellowship()
        {
            return View();
        }
        [Route("soesc-physical-literacy")]
        public IActionResult SoescPhysicalLiteracy()
        {
            return View();
        }
        [Route("soesc-project-based-learning")]
        public IActionResult SoescProjectBasedLearning()
        {
            return View();
        }
        [Route("soesc-project-sampoorna")]
        public IActionResult SoescProjectSampoorna()
        {
            return View();
        }
        [Route("soesc-project-samriddhi")]
        public IActionResult SoescProjectSamriddhi()
        {
            return View();
        }
        [Route("soesc-school-to-work")]
        public IActionResult SoescSchoolToWork()
        {
            return View();
        }
        [Route("soesc-social-emotional-and-ethical-learning")]
        public IActionResult SoescSocialEmotionalAndEthicalLearning()
        {
            return View();
        }
        [Route("soh-centre-for-leadership-development")]
        public IActionResult SohCentreForLeadershipDevelopment()
        {
            return View();
        }
        [Route("soh-centre-for-medical-services")]
        public IActionResult SohCentreForMedicalServices()
        {
            return View();
        }
        [Route("soh-centre-for-organizational-development")]
        public IActionResult SohCentreForOrganizationalDevelopment()
        {
            return View();
        }
        [Route("soh-centre-for-public-health-services")]
        public IActionResult SohCentreForPublicHealthServices()
        {
            return View();
        }
        [Route("soh-centre-for-quality-improvement")]
        public IActionResult SohCentreForQualityImprovement()
        {
            return View();
        }
        [Route("soh-gender-and-diversity")]
        public IActionResult SohGenderAndDiversity()
        {
            return View();
        }
        [Route("the-syllabus-for-a-compassionate-future")]
        public IActionResult TheSyllabusForACompassionateFuture()
        {
            return View();
        }
        [Route("transforming-rural-health-systems-articles")]
        public IActionResult TransformingRuralHealthSystemsArticles()
        {
            return View();
        }
        [Route("transforming-rural-health-systems-press-release")]
        public IActionResult TransformingRuralHealthSystemsPressRelease()
        {
            return View();
        }
        [Route("transforming-rural-health-systems")]
        public IActionResult TransformingRuralHealthSystems()
        {
            return View();
        }
        [Route("waste-to-worth-rural-indias-plastic-challenge")]
        public IActionResult WasteToWorthRuralIndiasPlasticChallenge()
        {
            return View();
        }
        [Route("when-the-wetlands-call-out-for-protection")]
        public IActionResult WhenTheWetlandsCallOutForProtection()
        {
            return View();
        }
        [Route("world-environment-day-2023-need-to-think-beyond-carbon-footprint-to-plastic-and-water-footprint")]
        public IActionResult WorldEnvironmentDay2023NeedToThinkBeyondCarbonFootprintToPlasticAndWaterFootprint()
        {
            return View();
        }
        [Route("zero-plastic-waste-communities-a-movement-led-by-70000-eco-warriors-from-jhunjhunu-district-in-rajasthan")]
        public IActionResult ZeroPlasticWasteCommunitiesAMovementLedBy70000EcoWarriorsFromJhunjhunuDistrictInRajasthan()
        {
            return View();
        }
        [Route("workshop-on-rejuvenation-of-water-bodies-and-water-held-at-kupwara")]
        public IActionResult WorkshopOnRejuvenationOfWaterBodiesAndWaterHeldAtKupwara()
        {
            return View();
        }
        [Route("privacy-policy")]
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        [Route("terms-of-use")]
        public IActionResult TermsOfUse()
        {
            return View();
        }
        [Route("disclaimer")]
        public IActionResult Disclaimer()
        {
            return View();
        }


        [Route("videos")]
        public IActionResult Videos()
        {
            List<PlaylistItem> videoList = GetVideos(50);
            return View(videoList);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("submit-data")]
        [HttpPost]
        public IActionResult SubmitContactUsLead(ContactUsModel model)
        {
            if(string.IsNullOrEmpty(model.Captcha))
            {
                return Json(new { status = false, message = "Invalid Captcha" });
            }
            else
            {
                string captcha = HttpContext.Session.GetString("SessionCaptcha").ToString();
                if (model.Captcha.Trim() != captcha)
                {
                    return Json(new { status = false, message = "Captcha doesn't match." });
                }
            }
            if (string.IsNullOrWhiteSpace(model.Name) || model.Name.Contains("<") || model.Name.Contains(">"))
            {
                return Json(new { status = false, message = "Invalid Name" });
            }
            if (model.Name.Length > 100)
            {
                return Json(new { status = false, message = "Name is more than 100 characters." });
            }
            if (string.IsNullOrWhiteSpace(model.CompanyName) || model.CompanyName.Contains("<") || model.CompanyName.Contains(">"))
            {
                return Json(new { status = false, message = "Invalid Company Name" });
            }
            if (model.CompanyName.Length > 100)
            {
                return Json(new { status = false, message = "Company Name is more than 100 characters." });
            }
            if (string.IsNullOrWhiteSpace(model.ContactNo) || !Regex.IsMatch(model.ContactNo, @"^\d{10}$"))
            {
                return Json(new { status = false, message = "Invalid Contact Number" });
            }
           

            if (string.IsNullOrWhiteSpace(model.EmailId)  || model.EmailId.Contains("<") || model.EmailId.Contains(">") ||
                !Regex.IsMatch(model.EmailId, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return Json(new { status = false, message = "Invalid Email Address" });
            }
            if (model.EmailId.Length > 100)
            {
                return Json(new { status = false, message = "EmailId is more than 100 characters." });
            }
            if (string.IsNullOrWhiteSpace(model.Message) || model.Message.Contains("<") || model.Message.Contains(">"))
            {
                return Json(new { status = false, message = "Invalid Text message" });
            }
            if (model.Message.Length > 200)
            {
                return Json(new { status = false, message = "Message is more than 200 characters." });
            }
            StringBuilder emailString = new StringBuilder();
            emailString.AppendLine("Name:- " + model.Name);
            emailString.AppendLine("Company Name:- " + model.CompanyName);
            emailString.AppendLine("Contact no:- " + model.ContactNo);
            emailString.AppendLine("EmailId:- " + model.EmailId);
            emailString.AppendLine("Message:- " + model.Message);
            string username = _configuration["SMTP:UserName"];
            string password = _configuration["SMTP:Password"];
            string displayname = _configuration["SMTP:DisplayName"];
            var rsult = MailSendHelper.SendEmailAsync("New Lead", emailString.ToString(), username, password, displayname, false);
            return Json(new { status = true });
        }
        [Route("captcha-psl")]
        public IActionResult CaptchaPSL(string prefix, bool noisy = true)
        {
            var rand = new Random((int)DateTime.Now.Ticks);

            //var captchaWord = Utility.GenerateNumericPassword(5);
            var captchaWord = GenerateNumericPassword(5);


            HttpContext.Session.SetString("SessionCaptcha", captchaWord);

            //image stream 
            FileContentResult img = null;

            using (var mem = new MemoryStream())
            using (var bmp = new Bitmap(130, 30))
            using (var gfx = Graphics.FromImage((System.Drawing.Image)bmp))
            {
                gfx.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));

                //add noise 
                if (noisy)
                {
                    int i, r, x, y;
                    var pen = new Pen(Color.Yellow);
                    for (i = 1; i < 10; i++)
                    {
                        pen.Color = Color.FromArgb(
                        (rand.Next(0, 255)),
                        (rand.Next(0, 255)),
                        (rand.Next(0, 255)));

                        r = rand.Next(0, (130 / 3));
                        x = rand.Next(0, 130);
                        y = rand.Next(0, 30);

                        gfx.DrawEllipse(pen, x - r, y - r, r, r);
                    }
                }

                //add question 
                //gfx.DrawString(captcha, new Font("Tahoma", 15), Brushes.Gray, 2, 3);
                gfx.DrawString(captchaWord, new System.Drawing.Font("Tahoma", 15), Brushes.Gray, 2, 3);

                //render as Jpeg 
                bmp.Save(mem,System.Drawing.Imaging.ImageFormat.Jpeg);
                img = this.File(mem.GetBuffer(), "image/Jpeg");
            }

            return img;
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
        private string GenerateNumericPassword(int length)
        {
            const string valid = "0123456789";
            System.Text.StringBuilder res = new System.Text.StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
