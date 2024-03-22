using System;
using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Dynamics.Framework.Tools.MetaModel.Automation;
using Microsoft.Dynamics.Framework.Tools.MetaModel.Automation.Tables;
using Microsoft.Dynamics.Framework.Tools.MetaModel.Core;
using System.Windows.Forms;
using Microsoft.Dynamics.Framework.Tools.Extensibility;
using Microsoft.Dynamics.Framework.Tools.MetaModel.Automation.BaseTypes;
using Microsoft.Dynamics.Framework.Tools.MetaModel.Automation.Reports;

namespace CopilotBuilder.CopilotActionBuilder
{
    [Export(typeof(IMainMenu))]
    class CopilotBuilderMenu : MainMenuBase
    {
        #region Properties
        /// <summary>
        ///     Caption for the menu item. This is what users would see in the menu.
        /// </summary>
        public override string Caption => "CopilotBuilder - Copilot Action";

        private const string AddinName = "CopilotBuilder.AcopilotAction";
        /// <summary>
        ///     Unique name of the add-in
        /// </summary>
        public override string Name => AddinName;
        #endregion

        #region Callbacks

        /// <summary>
        ///     Called when user clicks on the add-in menu
        /// </summary>
        /// <param name="e">The context of the VS tools and metadata</param>
        [SuppressMessage("ReSharper", "MergeCastWithTypeCheck")]
        public override void OnClick(AddinEventArgs e)
        {
            try
            {
                CopilotBuilderDialog dialog = new CopilotBuilderDialog();
                dialog.Show();
            }
            catch (Exception ex)
            {
                CoreUtility.HandleExceptionWithErrorMessage(ex);
            }
        }

        #endregion

    }
}
