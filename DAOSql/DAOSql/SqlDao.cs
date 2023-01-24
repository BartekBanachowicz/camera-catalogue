using Banachowicz.CameraCatalogue.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banachowicz.CameraCatalogue.DAOSql
{
    public class SqlDao : Interfaces.IDAO
    {
        public IBrand AddNewBrand(IBrand brand)
        {
            throw new NotImplementedException();
        }

        public ICamera AddNewCamera(ICamera camera)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IBrand> GetAllBrands()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICamera> GetAllCameras()
        {
            throw new NotImplementedException();
        }

        public ICamera GetBrand(string ID)
        {
            throw new NotImplementedException();
        }

        public ICamera GetCamera(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
