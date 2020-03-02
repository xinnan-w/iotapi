using System;
using Newtonsoft.Json;

namespace IoT3D.Contracts
{
    [JsonObject, Serializable]
    public class Player
    {
        public int Id {get; set; }
        public String FullName {get; set; }
        public float Score {get; set; }
    }
}
