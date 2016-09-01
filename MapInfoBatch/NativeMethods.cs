using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Application = Intergraph.GeoMedia.GeoMedia.Application;
using GMViewListeners = Intergraph.GeoMedia.PCmdMgr.GMViewListeners;
using MapWindow = Intergraph.GeoMedia.GeoMedia.MapWindow;

[System.Runtime.InteropServices.ProgId("GeomediaCommand.MapInfoBatch")]
public class MapInfoBatch
{
    public struct RectType
    {
        public int iLeft;
        public int iTop;
        public int iright;
        public int ibottom;
    };

    [DllImport("User32.dll")]
    public static extern int GetWindowRect(int hwnd, ref RectType lpRect);

    [DllImport("User32.dll")]
    public static extern int WinHelp(int hwnd, String lpHelpFile, int wCommand, int dwData);

    private const short HELP_CONTEXT = 1;
    private Application _app = null;
    private GMViewListeners _viewListeners = null;
    MainForm _form = new MainForm();
    bool _done = false;

    public bool IsDone { get { return _done; } }

    public void Initialize(Application objApplication, GMViewListeners objViewListeners)
    {
        _app = objApplication;
        _viewListeners = objViewListeners;
    }

    public void Activate()
    {
        _form.GeoMediaApp = _app;
        System.Windows.Forms.Form form = _form;
        form.StartPosition = FormStartPosition.CenterParent;
        _form.ShowDialog();
    }

    public bool CanDeactivate(MapWindow objViewWindow)
    {
        Marshal.ReleaseComObject(objViewWindow);
        return true;
    }

    public bool CanEnable() { return true; }
    public bool CanActivate() { return true; }

    public void Deactivate()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    public void AddView(MapWindow objViewWindow) { }
    public void RemoveView(MapWindow objViewWindow) { }
    public void IgnoreEvents(MapWindow objViewWindow) { }
    public void RestoreEvents(MapWindow objViewWindow) { }

    public void Terminate()
    {
        if (_viewListeners != null) Marshal.ReleaseComObject(_viewListeners);
        if (_app != null) Marshal.ReleaseComObject(_app);
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    public bool Help() { return false; }
    public void NotifyEndModal() { }
    public void NotifyStartModal() { }

}





































