using Newtonsoft.Json;

namespace NasaSpaceApp.Models
{
    public class LoginModel
    {
        [JsonProperty("Username")]
        public string Username { get; set; }
        
        [JsonProperty("Password")]
        public string Password { get; set; }
    }

    public class LoginResponse
    {
        [JsonProperty("isSuccesful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("displayName")]
        public bool DisplayName { get; set; }
    }
}
