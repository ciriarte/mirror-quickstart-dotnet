using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.Apis.Mirror.v1.Data;
using Newtonsoft.Json;

namespace MirrorQuickstart.Models
{
    public class MyContact : Contact
    {
        [JsonProperty("acceptCommands")]
        public virtual IList<Command> AcceptCommands { get; set; }
    }

    public class Command
    {
        [JsonProperty("type")]
        public String Type { get; set; }
    }
}