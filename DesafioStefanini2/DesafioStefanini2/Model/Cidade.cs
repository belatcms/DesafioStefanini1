using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioStefanini2.Model
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Cidade
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("zoom")]
        public long Zoom { get; set; }
    }

    public partial class Coord
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public enum Country { Br };
}
