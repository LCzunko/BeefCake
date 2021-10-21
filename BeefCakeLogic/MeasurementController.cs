using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;
using System;
using System.Linq;

namespace BeefCakeLogic
{
    public class MeasurementController
    {
        readonly IMeasurementDao _measurementDao;

        public MeasurementController(IMeasurementDao measurementDao)
        {
            _measurementDao = measurementDao;
        }

        /// <summary>
        /// Calculates given user's Body Mass Index
        /// </summary>
        /// <param name="activeUser">User to calculate BMI for</param>
        /// <param name="measurement">Measurement to use</param>
        /// <returns></returns>
        public static decimal CalculateBmi(decimal height, decimal weight)
        {
            decimal heightInMeters = height * 0.01M;
            decimal bmi = weight / (heightInMeters * heightInMeters);
            return bmi;
        }

        public Measurement GetUserMeasurementForDate(User current, DateTime dateTime)
        {
            return _measurementDao.ReadAll().FirstOrDefault(x => x.Date == dateTime && x.UserId == current.Id);
        }

        public void EditMeasurement(Measurement measurement)
        {
            _measurementDao.Update(measurement);
        }

        public void AddMeasurement(Measurement measurement)
        {
            _measurementDao.Add(measurement);
        }
    }
}
