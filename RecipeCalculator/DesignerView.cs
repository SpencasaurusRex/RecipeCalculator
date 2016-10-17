using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeCalculator
{
    public partial class DesignerView : Form
    {
        private DesignerController controller;

        public DesignerView()
        {
            controller = new DesignerController(this);
            InitializeComponent();
        }

        private void ExitMenuItemClicked(object sender, EventArgs e)
        {
            controller.AttemptExit();
        }
    }
}
