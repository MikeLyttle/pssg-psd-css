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
    /// Collection of csu_vehicledetail
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.csu_vehicledetailCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMcsuVehicledetailCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuVehicledetailCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuVehicledetailCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuVehicledetailCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuVehicledetailCollection(IList<MicrosoftDynamicsCRMcsuVehicledetail> value = default(IList<MicrosoftDynamicsCRMcsuVehicledetail>))
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
        public IList<MicrosoftDynamicsCRMcsuVehicledetail> Value { get; set; }

    }
}
