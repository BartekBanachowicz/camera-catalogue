using Banachowicz.CameraCatalogue.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banachowicz.CameraCatalogue.DAOSql
{
    public class SqlDao : IDAO
    {
        private DatabaseContext db = new DatabaseContext();

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
            return db.Brands;
        }

        public IEnumerable<ICamera> GetAllCameras()
        {
            throw new NotImplementedException();
        }

        public IBrand GetBrand(int ID)
        {
            throw new NotImplementedException();
        }

        public ICamera GetCamera(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
