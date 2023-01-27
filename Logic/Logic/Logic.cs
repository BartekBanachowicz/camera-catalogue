using Banachowicz.CameraCatalogue.Interfaces;
using System.Reflection;

namespace Banachowicz.CameraCatalogue.Logic
{
    public class Logic
    {
        private Interfaces.IDAO dao;

        public IEnumerable<Interfaces.ICamera> GetCameras()
        {
            return dao.GetAllCameras();
        }

        public IEnumerable<Interfaces.IBrand> GetBrands() 
        {
            return dao.GetAllBrands();
        }

        public IBrand AddEmptyBrand()
        {
            return dao.AddEmptyBrand();
        }

        public Logic(String daoPath) 
        {
            Assembly a = Assembly.UnsafeLoadFrom(daoPath);

            Type interfaceToFind = typeof(Interfaces.IDAO);
            Type classToCreate = null;

            foreach (Type type in a.GetTypes())
            {
                if (type.GetInterface("Banachowicz.CameraCatalogue.Interfaces.IDAO") != null)
                {
                    classToCreate = type;
                }
            }

            if (classToCreate != null) 
            {
                dao = (Interfaces.IDAO)Activator.CreateInstance(classToCreate, new object[] { });
            }
        }
    }
}