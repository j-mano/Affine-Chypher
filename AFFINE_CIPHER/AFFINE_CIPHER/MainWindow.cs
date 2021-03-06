using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnExitBTNClicked(object sender, EventArgs e)
    {
        System.Environment.Exit(1);
    }

    protected void OnCypherCalcBTNClicked(object sender, EventArgs e)
    {
    }
}
