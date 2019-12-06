using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatBoxApi.Models
{
  public class MessagesModel
  {
    public string clientUniqueId { get; set; }
    public string messages { get; set; }
    public string type { get; set; }
    public DateTime date { get; set; }
  }
}
