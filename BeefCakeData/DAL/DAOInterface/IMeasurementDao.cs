using System.Collections.Generic;
using BeefCakeData.Model;

namespace BeefCakeData.DAL.DAOInterface
{
    public interface IMeasurementDao
    {
        void Add(Measurement measurement);
        void Update(Measurement measurement);
        void Delete(Measurement measurement);
        IList<Measurement> ReadAll();
    }
}
