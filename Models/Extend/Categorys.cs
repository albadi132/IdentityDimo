using IdentityDimo.Models.Extra;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace IdentityDimo.Models
{
    public partial class Categorys
    {
        public MultiLanguage Tname
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.Name))
                {
                    return new MultiLanguage { ar = "", en = "" };
                }

                return JsonConvert.DeserializeObject<MultiLanguage>(this.Name);
            }
        }
    }
}
