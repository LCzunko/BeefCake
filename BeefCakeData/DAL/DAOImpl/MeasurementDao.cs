using System.Linq;
using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;

namespace BeefCakeData.DAL.DAOImpl
{
    public class MeasurementDao : IMeasurementDao
    {
        public void Add(Measurement measurement)
        {
            using (var context = new AppContext())
            {
                context.Measurements.Add(measurement);
                context.SaveChanges();
            }
        }

        public void Delete(Measurement measurement)
        {
            using (var context = new AppContext())
            {
                context.Measurements.Remove(measurement);
                context.SaveChanges();
            }
        }

        public void ReadAll()
        {
            using (var context = new AppContext())
            {
                context.Measurements.ToList();
            }
        }

        public void Update(Measurement measurement)
        {
            using (var context = new AppContext())
            {
                context.Measurements.Update(measurement);
                context.SaveChanges();
            }
        }
    }
}
