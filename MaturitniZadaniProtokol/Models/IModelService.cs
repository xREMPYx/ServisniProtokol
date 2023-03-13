using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Models
{
    public interface IModelService
    {
        void Update(ProtocolModel model);
        void Save(ProtocolModel model); 
    }
}
