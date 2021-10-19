using BeefCakeData.DAL.DAOInterface;
using BeefCakeData.Model;
using System;

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
        public static decimal CalculateBmi(User activeUser, Measurement measurement)
        {
            if (activeUser == null)
            {
                throw new ArgumentNullException(nameof(activeUser));
            }
            if (measurement == null)
            {
                throw new ArgumentNullException(nameof(measurement));
            }
            decimal heightInMeters = activeUser.Height * 0.01M;
            decimal bmi = measurement.Weight / (heightInMeters * heightInMeters);
            return bmi;
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
