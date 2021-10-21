using System.Windows.Forms;

namespace BeefCakeGUI
{
    public class NonSelectableChart : System.Windows.Forms.DataVisualization.Charting.Chart
    {
        public NonSelectableChart()
        {
            SetStyle(ControlStyles.Selectable, false);
        }
    }
}
