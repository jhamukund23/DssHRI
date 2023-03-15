using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DssHRI.Domain.Models.MRM
{
    public class AddDocument
    {
        //public AddDocument() => CorrelationId = Guid.NewGuid();

        public Guid CorrelationId  { get; set; }       
        public string FileName { get; set; }
        public string FileSize { get; set; }

    }

}
