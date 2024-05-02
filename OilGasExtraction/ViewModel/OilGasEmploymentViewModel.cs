using Microsoft.Maui.Controls.Shapes;
using System.Collections.ObjectModel;
using System.Reflection;

namespace OilGasExtraction
{
    public class OilGasEmploymentViewModel
    {
        public ObservableCollection<OilGasEmploymentModel> EmploymentDetails { get; set; }
        public ObservableCollection<Brush> CustomBrushes { get; set; }
        public double CrossesAt { get; set; }
        public Geometry? Green { get; set; } = (Geometry?)(new PathGeometryConverter().ConvertFromInvariantString("M16.000016,0L24.000008,10.7 32,21.399999 16.000016,21.399999 0,21.399999 7.9999928,10.7z"));
        public Geometry? Red { get; set; } = (Geometry?)(new PathGeometryConverter().ConvertFromInvariantString("M0.87499046,0L31.12499,0C31.92399,0,32.22299,0.49899435,31.82399,0.9979887L16.648991,21.064764C16.24999,21.563759,15.65099,21.563759,15.250991,21.064764L0.1759901,0.9979887C-0.22300911,0.49899435,0.075990677,0,0.87499046,0z"));

        public OilGasEmploymentViewModel()
        {
           
            EmploymentDetails = new ObservableCollection<OilGasEmploymentModel>(ReadCSV());

            CustomBrushes = new ObservableCollection<Brush>();

            CrossesAt = new DateTime(2015, 06, 15).ToOADate();

            foreach (var item in EmploymentDetails)
            {
                if (item.EmploymentPercent >= 0)
                {
                    item.Path = Green;
                    item.FillPath = new SolidColorBrush(Color.FromHex("#619624"));
                    CustomBrushes.Add(new SolidColorBrush(Color.FromHex("#619624")));
                }
                else if (item.EmploymentPercent < 0)
                {
                    item.Path = Red;
                    item.FillPath = new SolidColorBrush(Color.FromHex("#eb6569"));
                    CustomBrushes.Add(new SolidColorBrush(Color.FromHex("#eb6569")));
                }
            }
        }

        private IEnumerable<OilGasEmploymentModel> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("OilGasExtraction.Resources.Raw.data.csv");

            string? line;
            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            lines[0].Remove(0);
            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                DateTime day = DateTime.Parse(data[0]);
                
             return new OilGasEmploymentModel(day, Convert.ToDouble(data[1]), Convert.ToDouble(data[2]));
               
            });
        }
    }
}
