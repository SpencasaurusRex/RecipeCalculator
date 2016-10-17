
namespace RecipeCalculator
{
    class DesignerController
    {
        private DesignerView view;

        public DesignerController(DesignerView view)
        {
            this.view = view;
        }

        public void AttemptExit()
        {
            // TODO add check for unsaved files
            view.Close();
        }
    }
}
