using Jectory.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JectoryLibrary
{
    public class Customer : Record<Customer>
    {
        [PrimaryKey]
        [MaxLength(20)]
        public string Code { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public bool Blocked { get; set; }

        protected override void OnInsert()
        {
            Validate(e => e.Name, "Customer " + Code);
        }

        [ValidateEvent("Code")]
        private void OnValidateCode()
        {
            if (Code.Length > 1)
                Validate(e => e.Blocked, true);
        }
    }
}
