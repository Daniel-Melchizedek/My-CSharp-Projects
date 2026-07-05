using System.Runtime.InteropServices;

public class PartMem
{
    
 [DllImport("user32.dll")]
    private static extern int MessageBox(
        IntPtr hWnd,
        string text,
        string caption,
        uint type);
 
  public static void RunMethod()
  {
    MessageBox(IntPtr.Zero, "Hello", "Extern Demo", 0);
  }

}