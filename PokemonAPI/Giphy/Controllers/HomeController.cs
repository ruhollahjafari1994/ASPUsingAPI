using PokemonAPI;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Web.Mvc;
using Giphy.Models;
using System.Diagnostics;

namespace PokemonAPI.Controllers
{
    public class GiphyController : Controller
    {
        // GET: Giphy
        public ActionResult Index()
        {
            //create request to the api
            string apikey = System.Web.Configuration.WebConfigurationManager.AppSettings["giphyAPIKeys"];
            //string query = "ASS";
            //string offset = "0";
            WebRequest request = WebRequest.Create("https://api.giphy.com/v1/gifs/search?q=funny+cat&api_key="+apikey);

            //send the request off
            WebResponse response = request.GetResponse();
            //get back the response stream
            System.IO.Stream stream = response.GetResponseStream();
            //Make It Accessible
            StreamReader reader = new StreamReader(stream);
            //put into string which is json formatted
            string responseFromServer = reader.ReadToEnd();
            JObject parsedString = JObject.Parse(responseFromServer);
            Root rootGiph = parsedString.ToObject<Root>();

            return View(rootGiph);

        }
    }
}