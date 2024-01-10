using Data.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IPartRepository
    {
        PartsTableDTO GetAll();
        void AddPart(Part part);
        void UpdatePart(Part part);
        void DeletePart(long id);
    }
}
