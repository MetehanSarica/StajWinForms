using System.Windows.Forms;

class Program
{
    [STAThread]
    static int Main()
    {
        AppDomain.CurrentDomain.UnhandledException += (s, e) =>
        {
            Console.WriteLine("UNHANDLED: " + e.ExceptionObject);
            Environment.Exit(2);
        };
        try
        {
            var ctrl = new StajWinForms.MusteriKaydiControl(1, 5, 1, 3);
            ctrl.CreateControl();
            Console.WriteLine("MusteriKaydiControl OK");

            var form = new StajWinForms.CokluMusteriKaydi(new List<int> { 5, 6 }, 1, 1, 3);
            form.CreateControl();
            Console.WriteLine("CokluMusteriKaydi OK");
        }
        catch (Exception ex)
        {
            Console.WriteLine("EXCEPTION: " + ex);
            return 1;
        }
        return 0;
    }
}
