using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Newtonsoft.Json;

namespace ZipShare.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        public string UnitNumber { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }

        [Required]
        public string City {get; set;}

        [Required]
        public string State { get; set; }

        [Required]
        public string ZipCode { get; set; }
        public bool Residential { get; set; }
        public string PONumber { get; set; }

        public static List<State> LoadStatesFromJSON()
        {
            var states = new List<State>();
            using (StreamReader r = File.OpenText("states.json"))
            {
                string json = r.ReadToEnd();
                states = JsonConvert.DeserializeObject<List<State>>(json);
            }

            return states;
        }

    }
}