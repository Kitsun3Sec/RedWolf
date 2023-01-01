// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace RedWolf.API.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GrawlTasking
    {
        /// <summary>
        /// Initializes a new instance of the GrawlTasking class.
        /// </summary>
        public GrawlTasking()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GrawlTasking class.
        /// </summary>
        /// <param name="type">Possible values include: 'Assembly', 'SetDelay',
        /// 'SetJItter', 'SetConneCTAttEmpts', 'SetKillDate', 'Exit',
        /// 'Connect', 'Disconnect', 'Tasks', 'TaskKill'</param>
        /// <param name="status">Possible values include: 'Uninitialized',
        /// 'Tasked', 'Progressed', 'Completed', 'Aborted'</param>
        public GrawlTasking(string name, int grawlId, int grawlTaskId, int? id = default(int?), Grawl grawl = default(Grawl), GrawlTask grawlTask = default(GrawlTask), GrawlTaskingType? type = default(GrawlTaskingType?), IList<string> parameters = default(IList<string>), GrawlTaskingStatus? status = default(GrawlTaskingStatus?), System.DateTime? taskingTime = default(System.DateTime?), System.DateTime? completionTime = default(System.DateTime?), int? grawlCommandId = default(int?))
        {
            Id = id;
            Name = name;
            GrawlId = grawlId;
            Grawl = grawl;
            GrawlTaskId = grawlTaskId;
            GrawlTask = grawlTask;
            Type = type;
            Parameters = parameters;
            Status = status;
            TaskingTime = taskingTime;
            CompletionTime = completionTime;
            GrawlCommandId = grawlCommandId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grawlId")]
        public int GrawlId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grawl")]
        public Grawl Grawl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grawlTaskId")]
        public int GrawlTaskId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grawlTask")]
        public GrawlTask GrawlTask { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Assembly', 'SetDelay',
        /// 'SetJItter', 'SetConneCTAttEmpts', 'SetKillDate', 'Exit',
        /// 'Connect', 'Disconnect', 'Tasks', 'TaskKill'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public GrawlTaskingType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Uninitialized', 'Tasked',
        /// 'Progressed', 'Completed', 'Aborted'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public GrawlTaskingStatus? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "taskingTime")]
        public System.DateTime? TaskingTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completionTime")]
        public System.DateTime? CompletionTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "grawlCommandId")]
        public int? GrawlCommandId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Grawl != null)
            {
                Grawl.Validate();
            }
            if (GrawlTask != null)
            {
                GrawlTask.Validate();
            }
        }
    }
}