using System;
using System.Data.Entity;

namespace InsuranceClaimsLossTypes.Models
{
    public class LossTypeModel
    {
        public string id { get; set; }
        public string lossTypeCode { get; set; }
        public string lossTypeDescription { get; set; }

    }
    public class LossUsersModel
    {
        public string lossUsername { get; set; }
        public string lossPassword { get; set; }
    }
}


