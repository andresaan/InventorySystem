using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Parts;

namespace Data.Parts
{
    public class PartsTableDTO
    {
        public int AutoIncrement { get; set; }
        public List<InHousePart> InHouseParts = new List<InHousePart>();
        public List<OutsourcedPart> OutSourcedParts = new List<OutsourcedPart>();
    }
}
