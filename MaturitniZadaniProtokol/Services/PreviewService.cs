using MaturitniZadaniProtokol.Forms;
using MaturitniZadaniProtokol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitniZadaniProtokol.Services
{
    public class PreviewService
    {
        private IModelService[] _services;

        public PreviewService(IModelService[] services)
        {
            _services = services;
        }

        public void Preview()
        {
            ProtocolModel model = new ProtocolModel();

            foreach (IModelService service in _services)
            {
                service.Save(model);
            }

            PreviewForm form = new PreviewForm(model);            
            form.Show();
        }
    }
}