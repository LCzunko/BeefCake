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

        public static decimal CalculateBmi(decimal height, decimal weight)
        {
            decimal heightInMeters = height * 0.01M;
            decimal bmi = weight / (heightInMeters * heightInMeters);
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
