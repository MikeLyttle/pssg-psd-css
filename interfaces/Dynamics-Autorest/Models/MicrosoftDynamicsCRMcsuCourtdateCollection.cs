// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Pssg.Css.Interfaces.DynamicsAutorest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of csu_courtdate
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.csu_courtdateCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMcsuCourtdateCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuCourtdateCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuCourtdateCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuCourtdateCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuCourtdateCollection(IList<MicrosoftDynamicsCRMcsuCourtdate> value = default(IList<MicrosoftDynamicsCRMcsuCourtdate>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMcsuCourtdate> Value { get; set; }

    }
}
