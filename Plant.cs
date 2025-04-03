using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public class Plant
    {
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public DateTime LastWatered { get; set; }
        public DateTime LastFertilized { get; set; }
        public int WateringFrequency { get; set; }
        public int FertilizationFrequency { get; set; }
        public System.Drawing.Image PlantImage { get; set; }

        public int Health { get; set; } = 100;
        public int WaterTolerance { get; set; } = 2; // Number of days before decay starts
        public int FertilizerTolerance { get; set; } = 7;
        public List<string> HealthLog { get; set; } = new List<string>();

        private DateTime LastHealthUpdate { get; set; } = DateTime.MinValue;

        public void UpdateHealth()
        {
            DateTime currentDate = DateTime.Now.Date;
            if (LastHealthUpdate == currentDate)
            {
                return; // Prevent multiple updates on the same day
            }

            LastHealthUpdate = currentDate;
            bool healthChanged = false;

            DateTime nextWaterDate = LastWatered.AddDays(WateringFrequency);
            DateTime nextFertilizeDate = LastFertilized.AddDays(FertilizationFrequency);

            int missedWaterDays = (currentDate - nextWaterDate).Days;
            if (missedWaterDays > WaterTolerance)
            {
                int excessDays = missedWaterDays - WaterTolerance;
                int decay = CalculateDecay(excessDays, 2);
                Health -= decay;
                HealthLog.Add($"Health decreased by {decay} due to missed watering on {nextWaterDate.ToShortDateString()}.");
                healthChanged = true;
            }

            int missedFertilizeDays = (currentDate - nextFertilizeDate).Days;
            if (missedFertilizeDays > FertilizerTolerance)
            {
                int excessDays = missedFertilizeDays - FertilizerTolerance;
                int decay = CalculateDecay(excessDays, 1);
                Health -= decay;
                HealthLog.Add($"Health decreased by {decay} due to missed fertilization on {nextFertilizeDate.ToShortDateString()}.");
                healthChanged = true;
            }

            if (Health < 0) Health = 0;

            if (healthChanged)
            {
                RegenerateHealth();
            }
        }

        /// <summary>
        /// Regenerates plant health if it's within care tolerance.
        /// </summary>
        private void RegenerateHealth()
        {
            if (Health < 100 && DateTime.Now.Subtract(LastWatered).Days <= WaterTolerance &&
                DateTime.Now.Subtract(LastFertilized).Days <= FertilizerTolerance)
            {
                Health += 5;
                if (Health > 100) Health = 100;
                HealthLog.Add($"Health increased by 5 due to regular care on {DateTime.Now.ToShortDateString()}.");
            }
        }

        /// <summary>
        /// Calculates health decay over time.
        /// </summary>
        private int CalculateDecay(int days, int severity)
        {
            int decay = 0;
            for (int i = 1; i <= days; i++)
            {
                decay += severity * i;
            }
            return decay;
        }
    }
}
