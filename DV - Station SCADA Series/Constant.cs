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
        public const double FLD_SUCTION_MAX = 1500;  // 500;  // -20 PSI
        public const int FLD_SUCTION_BIN_RANGE = 50;  // 25 BIN

        public const double FLD_CYCLE_MIN = -1500;  // MIN CYCLE PRESSURE
        public const double FLD_CYCLE_MAX = 1500;   // MAX CYCLE PRESSURE
        public const double FLD_CYCLE_BIN_INTERVAL = 50;   // MAX CYCLE PRESSURE

        public const string FLD_CYCLE_DPRESSURE = "dPRESSURE";
        public const string FLD_CYCLE_DTIME = "dTime (s)";
        public const string FLD_CYCLE_DRECORD_COUNT = "dRECORD_COUNT";

        public const double NEXT_BIN_DELAY_SECONDS = 345;  // 345 seconds delay to next BIN.  Note each BIN is > 12 hour
        public const double MAX_BIN_DELAY_SECONDS = 12*60*60;  // 12 hours.  Note each BIN is > 12 hour

    }
}
