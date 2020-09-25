using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_Station_SCADA_Series
{
    public class Constant
    {
        // tagId	time	value	dataQuality	ownSysId	datasetId	fieldTime

        // MT and TA, Primary ID=9
        public const int FLD__TAGID = 1;
        public const int FLD_TIME = 2;
        public const int FLD_VALUE = 3;
        public const int FLD_DATAQUALITY = 4;

        // OA and NK
        //public const int FLD__TAGID = 0;
        //public const int FLD_TIME = 1;
        //public const int FLD_VALUE = 2;
        //public const int FLD_DATAQUALITY = 3;

        // Suction Ranges
        public const double FLD_SUCTION_MIN = -10;  // -20 PSI
        public const double FLD_SUCTION_MAX = 850;  // 500;  // -20 PSI
        public const int FLD_SUCTION_BIN_RANGE = 25;  // 25 BIN

    }
}
