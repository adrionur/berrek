using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ServiceRequest
/// </summary>
/// 

[DataContract]
public class ServiceRequest
{
    [DataMember(IsRequired = true)]
    public int Number1 { get; set; }
    [DataMember(IsRequired = true)]
    public int Number2 { get; set; }
}