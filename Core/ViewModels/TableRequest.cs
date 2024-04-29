using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class TableRequest
    {
        [JsonIgnore]
        int Id { get; set; }
        public int TableId { get; set; }
        public string TableNumber { get; set; }
    }
}
