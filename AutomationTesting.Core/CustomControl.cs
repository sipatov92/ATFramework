using System.Threading.Tasks.Dataflow;

namespace AutomationTesting.Core
{
    public class CustomControl : Control
    {
        public CustomControl(Control control)
        {
            //control.NativeControl = control;
        }
    }
}