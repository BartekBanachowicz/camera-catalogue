using Banachowicz.CameraCatalogue.Interfaces;
using System.Reflection;

namespace Banachowicz.CameraCatalogue.Logic
{
    public class Logic
    {
        private IDAO dao;

        public IEnumerable<ICamera> GetCameras()
        {
            return dao.GetAllCameras();
        }

        public IEnumerable<IBrand> GetBrands() 
        {
            return dao.GetAllBrands();
        }

        public IBrand NewBrand()
        {
            return dao.NewBrand();
        }

        public void SaveBrand(IBrand brand)
        {
            dao.SaveBrand(brand);
        }

        public void DeleteBrand(IBrand brand)
        {
            dao.DeleteBrand(brand);
        }

        public ICamera NewCamera()
        {
            return dao.NewCamera();
        }

        public void SaveCamera(ICamera camera)
        {
            dao.SaveCamera(camera);
        }

        public void DeleteCamera(ICamera camera)
        {
           dao.DeleteCamera(camera);
        }

        public Logic(String daoPath) 
        {
            Assembly a = Assembly.UnsafeLoadFrom(daoPath);
            Type? classToCreate = null;

            foreach (Type type in a.GetTypes())
            {
                if (type.GetInterface("Banachowicz.CameraCatalogue.Interfaces.IDAO") != null)
                {
                    classToCreate = type;
                }
            }

            if (classToCreate != null) 
            {
                dao = (IDAO)Activator.CreateInstance(classToCreate, new object[] { });
            }
        }
    }
}