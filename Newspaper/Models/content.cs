//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Newspaper.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class content
    {
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string logo { get; set; }
        public short categoryid { get; set; }
        public short languageid { get; set; }
        public string countrycode { get; set; }
        public Nullable<short> continentid { get; set; }
        public System.DateTime addeddate { get; set; }
        public string description { get; set; }
        public string metadescription { get; set; }
        public string metakeywords { get; set; }
        public bool status { get; set; }
    }
}
