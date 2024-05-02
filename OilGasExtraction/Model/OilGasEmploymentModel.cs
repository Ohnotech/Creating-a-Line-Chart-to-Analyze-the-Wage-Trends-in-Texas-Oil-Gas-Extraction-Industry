using Microsoft.Maui.Controls.Shapes;

namespace OilGasExtraction
{
    public class OilGasEmploymentModel
    {
        public OilGasEmploymentModel(DateTime month, double employmentCount, double employmentGrowth)
        {
            Month = month;
            EmploymentPercent = employmentCount;
            EmploymentCount = employmentGrowth;
        }

        public DateTime Month { get; set; }
        public double EmploymentPercent { get; set; }
        public double EmploymentCount { get; set; }
        public Geometry? Path { get; set; }
        public Brush FillPath { get; set; }
    }

}
