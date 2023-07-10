using static MagicVillaUtility.SD;

namespace MagicVillaWeb.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; }
        public string Url { get; set; }

        public object Data { get; set; }
    } 
}
