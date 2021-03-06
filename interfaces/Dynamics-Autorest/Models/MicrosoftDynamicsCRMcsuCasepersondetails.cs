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
    /// Microsoft.Dynamics.CRM.csu_casepersondetails
    /// </summary>
    public partial class MicrosoftDynamicsCRMcsuCasepersondetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuCasepersondetails class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuCasepersondetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcsuCasepersondetails class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuCasepersondetails(string csuAddressdescriptioncopied = default(string), int? importsequencenumber = default(int?), string csuCitycopied = default(string), int? statuscode = default(int?), string csuStateprovincecopied = default(string), int? timezoneruleversionnumber = default(int?), int? statecode = default(int?), string _csuPersondetailsValue = default(string), string versionnumber = default(string), string _owningteamValue = default(string), string _owningbusinessunitValue = default(string), string csuAddressdescription = default(string), string csuPostalcode = default(string), string _csuCaseCasepersondetailsidValue = default(string), string csuAddress = default(string), string csuCountryregion = default(string), string csuRelationshiptocase = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? csuInvolvementtype = default(int?), int? csuIssec105applicant = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string csuPrimaryphone = default(string), string csuCountry = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string csuName = default(string), int? utcconversiontimezonecode = default(int?), string csuCasepersondetailsid = default(string), string csuFirstnameandlastname = default(string), string csuFax = default(string), string csuZippostalcode = default(string), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string csuRecordid = default(string), string csuStateprovince = default(string), string csuCity = default(string), string csuAptsuiteunit = default(string), string csuStreetaddress = default(string), string _owneridValue = default(string), string csuAptsuiteunitcopied = default(string), string _createdonbehalfbyValue = default(string), string csuOtherphone = default(string), string csuOtherinvolvementtype = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> csuCasepersondetailsSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> csuCasepersondetailsDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> csuCasepersondetailsDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> csuCasepersondetailsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> csuCasepersondetailsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> csuCasepersondetailsProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> csuCasepersondetailsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> csuCasepersondetailsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMcontact csuPersonDetails = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMincident csuCaseCasePersonDetailsId = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMcsuViolation> csuCsuCasepersondetailsCsuViolationCasePersonDetail = default(IList<MicrosoftDynamicsCRMcsuViolation>), IList<MicrosoftDynamicsCRMcsuViolation> csuCsuCasepersondetailsCsuViolationPerson = default(IList<MicrosoftDynamicsCRMcsuViolation>), IList<MicrosoftDynamicsCRMcsuDemandandorder> csuCsuCasepersondetailsCsuDemandandorderIssuedForPerson = default(IList<MicrosoftDynamicsCRMcsuDemandandorder>), IList<MicrosoftDynamicsCRMcsuAmp> csuCsuCasepersondetailsCsuAmpAMPNoticeIssuedtoPersonId = default(IList<MicrosoftDynamicsCRMcsuAmp>), IList<MicrosoftDynamicsCRMcsuInjuctiondetail> csuCsuCasepersondetailsCsuInjuctiondetailPerson = default(IList<MicrosoftDynamicsCRMcsuInjuctiondetail>), IList<MicrosoftDynamicsCRMcsuInjuctiondetail> csuCsuCasepersondetailsCsuInjuctiondetailServedToPerson = default(IList<MicrosoftDynamicsCRMcsuInjuctiondetail>), IList<MicrosoftDynamicsCRMcsuApplicationforreturnofseizedcannabis> csuCsuCasepersondetailsCsuApplicationforreturnofseizedcannabisApplicantNamePerson = default(IList<MicrosoftDynamicsCRMcsuApplicationforreturnofseizedcannabis>), IList<MicrosoftDynamicsCRMcsuJudicialreview> csuCsuCasepersondetailsCsuJudicialreviewApplicantNamePerson = default(IList<MicrosoftDynamicsCRMcsuJudicialreview>))
        {
            CsuAddressdescriptioncopied = csuAddressdescriptioncopied;
            Importsequencenumber = importsequencenumber;
            CsuCitycopied = csuCitycopied;
            Statuscode = statuscode;
            CsuStateprovincecopied = csuStateprovincecopied;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statecode = statecode;
            this._csuPersondetailsValue = _csuPersondetailsValue;
            Versionnumber = versionnumber;
            this._owningteamValue = _owningteamValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            CsuAddressdescription = csuAddressdescription;
            CsuPostalcode = csuPostalcode;
            this._csuCaseCasepersondetailsidValue = _csuCaseCasepersondetailsidValue;
            CsuAddress = csuAddress;
            CsuCountryregion = csuCountryregion;
            CsuRelationshiptocase = csuRelationshiptocase;
            Createdon = createdon;
            CsuInvolvementtype = csuInvolvementtype;
            CsuIssec105applicant = csuIssec105applicant;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedbyValue = _modifiedbyValue;
            CsuPrimaryphone = csuPrimaryphone;
            CsuCountry = csuCountry;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            CsuName = csuName;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            CsuCasepersondetailsid = csuCasepersondetailsid;
            CsuFirstnameandlastname = csuFirstnameandlastname;
            CsuFax = csuFax;
            CsuZippostalcode = csuZippostalcode;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            CsuRecordid = csuRecordid;
            CsuStateprovince = csuStateprovince;
            CsuCity = csuCity;
            CsuAptsuiteunit = csuAptsuiteunit;
            CsuStreetaddress = csuStreetaddress;
            this._owneridValue = _owneridValue;
            CsuAptsuiteunitcopied = csuAptsuiteunitcopied;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            CsuOtherphone = csuOtherphone;
            CsuOtherinvolvementtype = csuOtherinvolvementtype;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CsuCasepersondetailsSyncErrors = csuCasepersondetailsSyncErrors;
            CsuCasepersondetailsDuplicateMatchingRecord = csuCasepersondetailsDuplicateMatchingRecord;
            CsuCasepersondetailsDuplicateBaseRecord = csuCasepersondetailsDuplicateBaseRecord;
            CsuCasepersondetailsAsyncOperations = csuCasepersondetailsAsyncOperations;
            CsuCasepersondetailsMailboxTrackingFolders = csuCasepersondetailsMailboxTrackingFolders;
            CsuCasepersondetailsProcessSession = csuCasepersondetailsProcessSession;
            CsuCasepersondetailsBulkDeleteFailures = csuCasepersondetailsBulkDeleteFailures;
            CsuCasepersondetailsPrincipalObjectAttributeAccesses = csuCasepersondetailsPrincipalObjectAttributeAccesses;
            CsuPersonDetails = csuPersonDetails;
            CsuCaseCasePersonDetailsId = csuCaseCasePersonDetailsId;
            CsuCsuCasepersondetailsCsuViolationCasePersonDetail = csuCsuCasepersondetailsCsuViolationCasePersonDetail;
            CsuCsuCasepersondetailsCsuViolationPerson = csuCsuCasepersondetailsCsuViolationPerson;
            CsuCsuCasepersondetailsCsuDemandandorderIssuedForPerson = csuCsuCasepersondetailsCsuDemandandorderIssuedForPerson;
            CsuCsuCasepersondetailsCsuAmpAMPNoticeIssuedtoPersonId = csuCsuCasepersondetailsCsuAmpAMPNoticeIssuedtoPersonId;
            CsuCsuCasepersondetailsCsuInjuctiondetailPerson = csuCsuCasepersondetailsCsuInjuctiondetailPerson;
            CsuCsuCasepersondetailsCsuInjuctiondetailServedToPerson = csuCsuCasepersondetailsCsuInjuctiondetailServedToPerson;
            CsuCsuCasepersondetailsCsuApplicationforreturnofseizedcannabisApplicantNamePerson = csuCsuCasepersondetailsCsuApplicationforreturnofseizedcannabisApplicantNamePerson;
            CsuCsuCasepersondetailsCsuJudicialreviewApplicantNamePerson = csuCsuCasepersondetailsCsuJudicialreviewApplicantNamePerson;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addressdescriptioncopied")]
        public string CsuAddressdescriptioncopied { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_citycopied")]
        public string CsuCitycopied { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_stateprovincecopied")]
        public string CsuStateprovincecopied { get; set; }

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
        [JsonProperty(PropertyName = "_csu_persondetails_value")]
        public string _csuPersondetailsValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_addressdescription")]
        public string CsuAddressdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_postalcode")]
        public string CsuPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_case_casepersondetailsid_value")]
        public string _csuCaseCasepersondetailsidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_address")]
        public string CsuAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_countryregion")]
        public string CsuCountryregion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_relationshiptocase")]
        public string CsuRelationshiptocase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_involvementtype")]
        public int? CsuInvolvementtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_issec105applicant")]
        public int? CsuIssec105applicant { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_primaryphone")]
        public string CsuPrimaryphone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_country")]
        public string CsuCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_name")]
        public string CsuName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_casepersondetailsid")]
        public string CsuCasepersondetailsid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_firstnameandlastname")]
        public string CsuFirstnameandlastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_fax")]
        public string CsuFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_zippostalcode")]
        public string CsuZippostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_recordid")]
        public string CsuRecordid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_stateprovince")]
        public string CsuStateprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_city")]
        public string CsuCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_aptsuiteunit")]
        public string CsuAptsuiteunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_streetaddress")]
        public string CsuStreetaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_aptsuiteunitcopied")]
        public string CsuAptsuiteunitcopied { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_otherphone")]
        public string CsuOtherphone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_otherinvolvementtype")]
        public string CsuOtherinvolvementtype { get; set; }

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
        [JsonProperty(PropertyName = "csu_casepersondetails_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CsuCasepersondetailsSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_casepersondetails_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuCasepersondetailsDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_casepersondetails_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuCasepersondetailsDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_casepersondetails_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CsuCasepersondetailsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_casepersondetails_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CsuCasepersondetailsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_casepersondetails_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CsuCasepersondetailsProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_casepersondetails_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CsuCasepersondetailsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_casepersondetails_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CsuCasepersondetailsPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_PersonDetails")]
        public MicrosoftDynamicsCRMcontact CsuPersonDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_Case_CasePersonDetailsId")]
        public MicrosoftDynamicsCRMincident CsuCaseCasePersonDetailsId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_casepersondetails_csu_violation_CasePersonDetail")]
        public IList<MicrosoftDynamicsCRMcsuViolation> CsuCsuCasepersondetailsCsuViolationCasePersonDetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_casepersondetails_csu_violation_Person")]
        public IList<MicrosoftDynamicsCRMcsuViolation> CsuCsuCasepersondetailsCsuViolationPerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_casepersondetails_csu_demandandorder_IssuedForPerson")]
        public IList<MicrosoftDynamicsCRMcsuDemandandorder> CsuCsuCasepersondetailsCsuDemandandorderIssuedForPerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_casepersondetails_csu_amp_AMPNoticeIssuedtoPersonId")]
        public IList<MicrosoftDynamicsCRMcsuAmp> CsuCsuCasepersondetailsCsuAmpAMPNoticeIssuedtoPersonId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_casepersondetails_csu_injuctiondetail_Person")]
        public IList<MicrosoftDynamicsCRMcsuInjuctiondetail> CsuCsuCasepersondetailsCsuInjuctiondetailPerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_casepersondetails_csu_injuctiondetail_ServedToPerson")]
        public IList<MicrosoftDynamicsCRMcsuInjuctiondetail> CsuCsuCasepersondetailsCsuInjuctiondetailServedToPerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_casepersondetails_csu_applicationforreturnofseizedcannabis_ApplicantNamePerson")]
        public IList<MicrosoftDynamicsCRMcsuApplicationforreturnofseizedcannabis> CsuCsuCasepersondetailsCsuApplicationforreturnofseizedcannabisApplicantNamePerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_csu_casepersondetails_csu_judicialreview_ApplicantNamePerson")]
        public IList<MicrosoftDynamicsCRMcsuJudicialreview> CsuCsuCasepersondetailsCsuJudicialreviewApplicantNamePerson { get; set; }

    }
}
