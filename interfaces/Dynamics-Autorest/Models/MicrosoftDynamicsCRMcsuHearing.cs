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
    /// Microsoft.Dynamics.CRM.csu_hearing
    /// </summary>
    public partial class MicrosoftDynamicsCRMcsuHearing
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcsuHearing
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuHearing()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcsuHearing
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuHearing(string _owneridValue = default(string), string _createdonbehalfbyValue = default(string), int? csuAmpappforreconhearingreceived = default(int?), string _owningbusinessunitValue = default(string), string csuName = default(string), System.DateTimeOffset? csuPublishingampaspersection32cannabiscontro = default(System.DateTimeOffset?), string _csuRelatedhearingsidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _csuCaseValue = default(string), int? csuPublishinghearingdecisionstothewebsite = default(int?), string _owningteamValue = default(string), int? timezoneruleversionnumber = default(int?), int? statecode = default(int?), int? csuJudicialreviewtype = default(int?), int? statuscode = default(int?), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? csuHearingdecisiondate = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? csuDisclosuredeadline = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), System.DateTimeOffset? csuPostingsignsrelatingtoampaspersection33cc = default(System.DateTimeOffset?), int? csuHearingmethod = default(int?), int? utcconversiontimezonecode = default(int?), string _owninguserValue = default(string), int? csuApplicationforhearingreceived = default(int?), string _csuCasetaskdisclosuredeadlinedateidValue = default(string), string csuHearingid = default(string), System.DateTimeOffset? csuHearingdate = default(System.DateTimeOffset?), System.DateTimeOffset? csuDisclosuredate = default(System.DateTimeOffset?), int? csuReasonfororalhearing = default(int?), int? csuHearingresult = default(int?), string versionnumber = default(string), string csuOther = default(string), string _createdbyValue = default(string), int? importsequencenumber = default(int?), int? csuHearingtype = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> csuHearingSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> csuHearingDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> csuHearingDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> csuHearingAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> csuHearingMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> csuHearingProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> csuHearingBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> csuHearingPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMcsuAmp csuRelatedHearingsId = default(MicrosoftDynamicsCRMcsuAmp), IList<MicrosoftDynamicsCRMcsuJudicialreview> csuCsuHearingCsuJudicialreviewHearingUnderDispute = default(IList<MicrosoftDynamicsCRMcsuJudicialreview>), MicrosoftDynamicsCRMincident csuCase = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMcsuCasetask csuCaseTaskDisclosureDeadlineDateId = default(MicrosoftDynamicsCRMcsuCasetask), IList<MicrosoftDynamicsCRMcsuCasetask> csuCsuHearingCsuCasetaskHearing = default(IList<MicrosoftDynamicsCRMcsuCasetask>))
        {
            this._owneridValue = _owneridValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            CsuAmpappforreconhearingreceived = csuAmpappforreconhearingreceived;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            CsuName = csuName;
            CsuPublishingampaspersection32cannabiscontro = csuPublishingampaspersection32cannabiscontro;
            this._csuRelatedhearingsidValue = _csuRelatedhearingsidValue;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            this._csuCaseValue = _csuCaseValue;
            CsuPublishinghearingdecisionstothewebsite = csuPublishinghearingdecisionstothewebsite;
            this._owningteamValue = _owningteamValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statecode = statecode;
            CsuJudicialreviewtype = csuJudicialreviewtype;
            Statuscode = statuscode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            CsuHearingdecisiondate = csuHearingdecisiondate;
            Modifiedon = modifiedon;
            CsuDisclosuredeadline = csuDisclosuredeadline;
            this._modifiedbyValue = _modifiedbyValue;
            CsuPostingsignsrelatingtoampaspersection33cc = csuPostingsignsrelatingtoampaspersection33cc;
            CsuHearingmethod = csuHearingmethod;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owninguserValue = _owninguserValue;
            CsuApplicationforhearingreceived = csuApplicationforhearingreceived;
            this._csuCasetaskdisclosuredeadlinedateidValue = _csuCasetaskdisclosuredeadlinedateidValue;
            CsuHearingid = csuHearingid;
            CsuHearingdate = csuHearingdate;
            CsuDisclosuredate = csuDisclosuredate;
            CsuReasonfororalhearing = csuReasonfororalhearing;
            CsuHearingresult = csuHearingresult;
            Versionnumber = versionnumber;
            CsuOther = csuOther;
            this._createdbyValue = _createdbyValue;
            Importsequencenumber = importsequencenumber;
            CsuHearingtype = csuHearingtype;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CsuHearingSyncErrors = csuHearingSyncErrors;
            CsuHearingDuplicateMatchingRecord = csuHearingDuplicateMatchingRecord;
            CsuHearingDuplicateBaseRecord = csuHearingDuplicateBaseRecord;
            CsuHearingAsyncOperations = csuHearingAsyncOperations;
            CsuHearingMailboxTrackingFolders = csuHearingMailboxTrackingFolders;
            CsuHearingProcessSession = csuHearingProcessSession;
            CsuHearingBulkDeleteFailures = csuHearingBulkDeleteFailures;
            CsuHearingPrincipalObjectAttributeAccesses = csuHearingPrincipalObjectAttributeAccesses;
            CsuRelatedHearingsId = csuRelatedHearingsId;
            CsuCsuHearingCsuJudicialreviewHearingUnderDispute = csuCsuHearingCsuJudicialreviewHearingUnderDispute;
            CsuCase = csuCase;
            CsuCaseTaskDisclosureDeadlineDateId = csuCaseTaskDisclosureDeadlineDateId;
            CsuCsuHearingCsuCasetaskHearing = csuCsuHearingCsuCasetaskHearing;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_ampappforreconhearingreceived")]
        public int? CsuAmpappforreconhearingreceived { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_name")]
        public string CsuName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_publishingampaspersection32cannabiscontro")]
        public System.DateTimeOffset? CsuPublishingampaspersection32cannabiscontro { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_relatedhearingsid_value")]
        public string _csuRelatedhearingsidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_case_value")]
        public string _csuCaseValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_publishinghearingdecisionstothewebsite")]
        public int? CsuPublishinghearingdecisionstothewebsite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_judicialreviewtype")]
        public int? CsuJudicialreviewtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearingdecisiondate")]
        public System.DateTimeOffset? CsuHearingdecisiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_disclosuredeadline")]
        public System.DateTimeOffset? CsuDisclosuredeadline { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_postingsignsrelatingtoampaspersection33cc")]
        public System.DateTimeOffset? CsuPostingsignsrelatingtoampaspersection33cc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearingmethod")]
        public int? CsuHearingmethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_applicationforhearingreceived")]
        public int? CsuApplicationforhearingreceived { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_casetaskdisclosuredeadlinedateid_value")]
        public string _csuCasetaskdisclosuredeadlinedateidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearingid")]
        public string CsuHearingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearingdate")]
        public System.DateTimeOffset? CsuHearingdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_disclosuredate")]
        public System.DateTimeOffset? CsuDisclosuredate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_reasonfororalhearing")]
        public int? CsuReasonfororalhearing { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearingresult")]
        public int? CsuHearingresult { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_other")]
        public string CsuOther { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearingtype")]
        public int? CsuHearingtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearing_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CsuHearingSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearing_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuHearingDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearing_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuHearingDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearing_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CsuHearingAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearing_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CsuHearingMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearing_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CsuHearingProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearing_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CsuHearingBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_hearing_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CsuHearingPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_RelatedHearingsId")]
        public MicrosoftDynamicsCRMcsuAmp CsuRelatedHearingsId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_hearing_csu_judicialreview_HearingUnderDispute")]
        public IList<MicrosoftDynamicsCRMcsuJudicialreview> CsuCsuHearingCsuJudicialreviewHearingUnderDispute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_case")]
        public MicrosoftDynamicsCRMincident CsuCase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_CaseTaskDisclosureDeadlineDateId")]
        public MicrosoftDynamicsCRMcsuCasetask CsuCaseTaskDisclosureDeadlineDateId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_hearing_csu_casetask_Hearing")]
        public IList<MicrosoftDynamicsCRMcsuCasetask> CsuCsuHearingCsuCasetaskHearing { get; set; }

    }
}
