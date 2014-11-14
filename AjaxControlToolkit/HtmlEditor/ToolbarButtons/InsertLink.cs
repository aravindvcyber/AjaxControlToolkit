using AjaxControlToolkit.HtmlEditor.Popups;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Web.UI;

namespace AjaxControlToolkit.HtmlEditor.ToolbarButtons {

    [ToolboxItem(false)]
    [ParseChildren(true)]
    [PersistChildren(false)]
    [RequiredScript(typeof(CommonToolkitScripts))]
    [ClientScriptResource("Sys.Extended.UI.HtmlEditor.ToolbarButtons.InsertLink", Constants.HtmlEditorInsertLinkButtonName)]
    public class InsertLink : OkCancelPopupButton {
        protected override void OnInit(EventArgs e) {
            base.OnInit(e);
            RelatedPopup = new LinkProperties();
            AutoClose = false;
        }

        protected override void OnPreRender(EventArgs e) {
            RegisterButtonImages("EdLink");
            base.OnPreRender(e);
        }
    }

}