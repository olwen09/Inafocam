﻿using System;
using System.Collections.Generic;

namespace Inafocam.core.Modelos
{
    public partial class AddressType
    {
        public AddressType()
        {
            Address = new HashSet<Address>();
        }

        public long AddressTypeId { get; set; }
        public string AddressTypeName { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? UpgradeDate { get; set; }
        public long? StatusId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
