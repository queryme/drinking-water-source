using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.SystemUI;
using YiMaGIS.Framework.Core;

namespace testPlugin
{
    public class ShowMessages :  IBarItem
    {
        //#region ICommand
        //private ISIGISApp m_pApp;

        //public int Bitmap
        //{
        //    get { return 0; }
        //}

        //public string Caption
        //{
        //    get { return "testPlugin"; }
        //}

        //public string Category
        //{
        //    get { return "testPlugin Category"; }
        //}

        //public bool Checked
        //{
        //    get { return true; }
        //}

        //public bool Enabled
        //{
        //    get { return true; }
        //}

        //public int HelpContextID
        //{
        //    get { return 0; }
        //}

        //public string HelpFile
        //{
        //    get { return ""; }
        //}

        //public string Message
        //{
        //    get { return "testPlugin Message"; }
        //}

        //public string Name
        //{
        //    get { return "testPlugin Name"; }
        //}

        //public void OnClick()
        //{
        //    MessageBox.Show("这是一个插件测试");
        //}

        //public void OnCreate(object Hook)
        //{
        //    //改接口必须实现，否则无法正确加载该dll，从而导致系统崩溃
        //    if (Hook is ISIGISApp)
        //    {
        //        m_pApp = (ISIGISApp)Hook;
        //    }
        //}

        //public string Tooltip
        //{
        //    get { return "testPlugin Tooltip"; }
        //}
        //#endregion

        #region IBarItem
        public int GroupIndex
        {
            get { return 1; }
        }

        public BarItemKind Kind
        {
            get { return BarItemKind.BarCheckItem; }
        }

        public string ShortCut
        {
            get { return ""; }
        }
        #endregion
    }
}
