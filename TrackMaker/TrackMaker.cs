using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHW.Tools.TrackMaker
{
    public partial class TrackMaker
    {
        public int currentStormId;
        public List<Storm> stormList;

        public TrackMaker()
        {
            currentStormId = 0; //yeah...
            stormList = new List<Storm>();
        }
        
        public void AddStorm(Storm storm) // adds a storm to the list.
        {
            currentStormId = currentStormId + 1;
            stormList.Add(storm);
            return;
        }

    }
}
