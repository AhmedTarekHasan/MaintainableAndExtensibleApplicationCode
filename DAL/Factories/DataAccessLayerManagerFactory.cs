using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonEntities.BaseClasses;
using CommonEntities.Enums;

namespace DAL.Factories
{
    public static class DataAccessLayerManagerFactory
    {
        public static DALManagerBase GetDALManager(DALManagerType dALManagerType)
        {
            DALManagerBase result = null;

            switch (dALManagerType)
            {
                case DALManagerType.SQL:
                    result = new SQLDataAccessLayerManager();
                    break;
                case DALManagerType.Oracle:
                    result = new OracleDataAccessLayerManager();
                    break;
            }

            return result;
        }
    }
}
