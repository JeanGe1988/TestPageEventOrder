﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestPageEventOrder
{
    public partial class ParentMasterChildControl3 : System.Web.UI.UserControl
    {
        private string currentControl = "Parent Master Child Control 3";

        protected override void OnInit(EventArgs e)
        {
            Logger.LogToStaticFile("OnInit " + currentControl);
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            Logger.LogToStaticFile("OnLoad " + currentControl);
            base.OnLoad(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            Logger.LogToStaticFile("OnPreRender " + currentControl);
            base.OnLoad(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            Logger.LogToStaticFile("OnUnload " + currentControl);
            base.OnUnload(e);
        }
    }
}