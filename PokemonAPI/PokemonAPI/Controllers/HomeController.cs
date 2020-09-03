using PokemonAPI;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Web.Mvc;
using PokemonAPI.Models;
using System.Diagnostics;

namespace PokemonAPI.Controllers  
{
    public class  HomeController : Controller
    {
        public ActionResult Index()
        {
            //create request to the api
            WebRequest request = WebRequest.Create("http://pokeapi.co/api/v2/pokemon/534/");
           //send the request off
            WebResponse response = request.GetResponse();

            //get back the response stream
           Stream stream= response.GetResponseStream();

            //Make It Accessible
            StreamReader reader = new StreamReader(stream);
            //put into string which is json formatted
            string responseFromServer = reader.ReadToEnd();


            JObject parsedString = JObject.Parse(responseFromServer);

            Root myPokeman = parsedString.ToObject<Root>();
           //Debug.WriteLine( myPokeman.moves[0].move.name);
            return View(myPokeman);


        }
        
        public ActionResult Index2()
        {

            //create request to the api
            WebRequest request = WebRequest.Create("https://pokeapi.co/api/v2/berry/12");
            //send the request off
            WebResponse response = request.GetResponse();
            //get back the response stream
            Stream stream = response.GetResponseStream();
            //Make It Accessible
            StreamReader reader = new StreamReader(stream);
            //put into string which is json formatted
            string responseFromServer = reader.ReadToEnd();
            JObject parsedString = JObject.Parse(responseFromServer);

            Rootberry myPokeman = parsedString.ToObject<Rootberry>();
            //Debug.WriteLine( myPokeman.moves[0].move.name);
            return View(myPokeman);
        }



    }
}