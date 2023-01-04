// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace RedWolf.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RedWolfUserLoginResult
    {
        /// <summary>
        /// Initializes a new instance of the RedWolfUserLoginResult class.
        /// </summary>
        public RedWolfUserLoginResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedWolfUserLoginResult class.
        /// </summary>
        public RedWolfUserLoginResult(bool? success = default(bool?), string redwolfToken = default(string))
        {
            Success = success;
            RedWolfToken = redwolfToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "redwolfToken")]
        public string RedWolfToken { get; set; }

    }
}
