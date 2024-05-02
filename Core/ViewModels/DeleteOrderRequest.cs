using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class DeleteOrderRequest
    {
        [JsonIgnore]
        public int Id { get; set; }
    }
}
