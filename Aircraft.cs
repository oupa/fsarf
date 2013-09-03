using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSAircraftRepositoryFactory
{
    public class Aircraft
    {
        public string title = "";
        public string icao = "";
        public string atc_airline = "";
        public string ui_variation = "";
        public string ui_type = "";
        public string ui_manufacturer = "";
        public string texture = "";
        public string atc_parking_codes = "";
        public string atc_type = "";
        public string atc_model = "";
        public string wake;
        public string engine_type;
        public int engine_count;
        public string match_reason = "";
        public string sim = "";

        public int match_count = 0;

        public override string ToString()
        {
            return title + "," + atc_model + "," + atc_type + "," + atc_airline + "," + atc_parking_codes + "," + texture + "," + ui_type + "," + ui_variation;
        }

        public void Fill()
        {
            wake = ICAO.GetWake(icao);
            engine_type = ICAO.GetEngineType(icao);
            engine_count = ICAO.GetEngineCount(icao);
        }
    }
}
