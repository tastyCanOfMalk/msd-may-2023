﻿

namespace MessageContracts.HrAcl;

public record HiringRequestCreated
{
    public static readonly string MessageId = "HrAcl.HiringRequestCreated";
   
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string JobId { get; set; } = string.Empty;
    public string OfferingId { get; set; } = string.Empty;

}