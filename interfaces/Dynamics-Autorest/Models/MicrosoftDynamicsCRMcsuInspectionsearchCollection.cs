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
    /// Collection of csu_inspectionsearch
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.csu_inspectionsearchCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMcsuInspectionsearchCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuInspectionsearchCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuInspectionsearchCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuInspectionsearchCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuInspectionsearchCollection(IList<MicrosoftDynamicsCRMcsuInspectionsearch> value = default(IList<MicrosoftDynamicsCRMcsuInspectionsearch>))
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
        public IList<MicrosoftDynamicsCRMcsuInspectionsearch> Value { get; set; }

    }
}