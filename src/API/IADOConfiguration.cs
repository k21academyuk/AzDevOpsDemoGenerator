﻿
namespace RestAPI
{
    public interface IADOConfiguration
    {
        string PersonalAccessToken { get; set; }
        string AccountName { get; set; }
        string Project { get; set; }
        string ProjectId { get; set; }
        string UriString { get; set; }
        string VersionNumber { get; set; }
        string Id { get; set; }
        string Team { get; set; }
        public string _adoAuthScheme { get; set; }


        string _gitbaseAddress { get; set; }
        string _mediaType { get; set; }
        string _scheme { get; set; }
        string _gitcredential { get; set; }
        string userName { get; set; }
    }
}