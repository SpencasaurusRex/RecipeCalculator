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
    public partial class MainView : Form
    {
        private MainController controller;

        public MainView()
        {
            controller = new MainController(this);
            InitializeComponent();
        }

        private void ExitMenuItemClicked(object sender, EventArgs e)
        {
            controller.AttemptExit();
        }

        private void NewBreakdownMenuItemClicked(object sender, EventArgs e)
        {
            try
            {
                TabPage page = new TabPage("Breakdown");
                TreeView tree = new TreeView();
                tree.Width = 200;
                tree.Height = 200;
                page.Controls.Add(tree);
                controller.AddBreakdown(tree);
                tabControl.TabPages.Add(page);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex.Message);
            }
        }

        private void NewDesignerMenuItemClicked(object sender, EventArgs e)
        {
            TabPage page = new TabPage("Designer");
            controller.AddDesigner(page);
            tabControl.TabPages.Add(page);
        }
    }
}
