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
    /// Collection of csu_offence
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.csu_offenceCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMcsuOffenceCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuOffenceCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuOffenceCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuOffenceCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuOffenceCollection(IList<MicrosoftDynamicsCRMcsuOffence> value = default(IList<MicrosoftDynamicsCRMcsuOffence>))
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
        public IList<MicrosoftDynamicsCRMcsuOffence> Value { get; set; }

    }
}