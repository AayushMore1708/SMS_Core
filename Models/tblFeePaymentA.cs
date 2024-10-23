using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Core.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    public partial class tblFeePaymentA
    {


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        [JsonIgnore]
        public virtual ICollection<tblFeePaymentDT> TblFeePaymentDTs { get; set; }
    }
}