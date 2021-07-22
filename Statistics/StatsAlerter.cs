using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class StatsAlerter
    {
        float maxthreshold;
        IAlerter[] alerters;

        public StatsAlerter(float maxthreshold, IAlerter[] alerters)
        {
            this.maxthreshold = maxthreshold;
            this.alerters = alerters;
        }

        public void checkAndAlert(List<float> thresholds)
        {
            for(int i = 0; i < thresholds.Count; ++i)
            {
                if(thresholds[i] > maxThreshold)
                {
                    for(int j = 0; j < alerter.Length; ++j)
                    {
                        alerter[j].Alert();
                    }
                    break;
                }
            }
        }
    }
}
