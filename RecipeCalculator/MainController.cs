using System;
using System.Windows.Forms;

namespace RecipeCalculator
{
    class MainController
    {
        private MainView view;

        public MainController(MainView view)
        {
            this.view = view;
        }

        public void AddBreakdown(TreeView tree)
        {
            new BreakdownController(tree);
        }

        public void AddDesigner(TabPage page)
        {

        }

        public void AttemptExit()
        {
            // TODO add check for unsaved files
            view.Close();
        }
    }
}
