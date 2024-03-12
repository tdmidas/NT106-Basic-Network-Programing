using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    public partial class EducationForm : UserControl
    {
        public EducationForm()
        {
            InitializeComponent();
            AddHorizontalLine();
        }
        private void AddHorizontalLine()
        {
            // Create a new Panel control
            Panel linePanel = new Panel();

            // Set properties to make it look like a line
            linePanel.BackColor = Color.Black; // Set line color
            linePanel.Height = 2; // Set line thickness
            linePanel.Dock = DockStyle.Top; // Dock it to the top
            linePanel.BorderStyle = BorderStyle.FixedSingle; // Make it look like a line

            // Add the Panel control to the form
            Controls.Add(linePanel);
        }

        
    }
}
