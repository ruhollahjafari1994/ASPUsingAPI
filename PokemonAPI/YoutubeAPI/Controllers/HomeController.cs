using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Web.Mvc;
using System.Diagnostics;
using YoutubeAPI.Models;

namespace YoutubeAPI
{
    public class YoutubeController : Controller
    {
        // GET: Giphy
        public ActionResult Index()
        {
            //create request to the api
            string apikey = "AIzaSyBqSlrPVyq43u8Vo0vi4GJG8k9dvPzS-Gg";
            WebRequest request = WebRequest.Create("https://www.googleapis.com/youtube/v3/search?part=snippet&q=pokemon&key="+apikey);

            //send the request off
            WebResponse response = request.GetResponse();
            //get back the response stream
            System.IO.Stream stream = response.GetResponseStream();
            //Make It Accessible
            StreamReader reader = new StreamReader(stream);
            //put into string which is json formatted
            string responseFromServer = reader.ReadToEnd();
            JObject parsedString = JObject.Parse(responseFromServer);
            YouTubeSearch search = parsedString.ToObject<YouTubeSearch>();
            return View();

        }
    }
}