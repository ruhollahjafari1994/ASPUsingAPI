using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonAPI.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Firmness
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Flavor2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Flavor
    {
        public Flavor2 flavor { get; set; }
        public int potency { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class NaturalGiftType
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Rootberry
    {
        public Firmness firmness { get; set; }
        public List<Flavor> flavors { get; set; }
        public int growth_time { get; set; }
        public int id { get; set; }
        public Item item { get; set; }
        public int max_harvest { get; set; }
        public string name { get; set; }
        public int natural_gift_power { get; set; }
        public NaturalGiftType natural_gift_type { get; set; }
        public int size { get; set; }
        public int smoothness { get; set; }
        public int soil_dryness { get; set; }
    }


}