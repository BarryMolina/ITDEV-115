using System.Windows.Forms;

namespace Windows0
{
	public class Windows0 : Form
    {
	   public Windows0()
	   {
		   Text = "Simple Windows Application";
	   }
        static void Main()
        {
		Windows0 winForm = new Windows0();
            Application.Run(winForm);
        }
    }
}
