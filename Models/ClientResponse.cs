﻿namespace FlightsSearchEngineProject.Models
{
    public class ClientResponse
    {
        public string access_token {get;set;}
        public string token_type {get;set;}

        public string expires_in { get; set; }

        public string _bearer {get;set;}

    }
}