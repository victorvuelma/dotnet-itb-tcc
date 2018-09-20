using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vitorrdgs.UiX.Manager;

namespace vitorrdgs.UiX.Component
{
    public partial class UIXMessage : Form
    {

        public enum MessageResult
        {
            YES,
            NO,
            CANCEL
        }

        private MessageResult _result = MessageResult.CANCEL;

        public MessageResult Result { get => _result; set => _result = value; }

        public UIXMessage()
        {
            InitializeComponent();
        }

        public static MessageResult mostrarOk(uixTemplate template, String title, String message)
        {
            UIXMessage msg = create(template, title, message, Properties.Resources.info);

            msg.btnOption1.Hide();
            msg.btnOption2.Text = "Ok";

            msg.ShowDialog();

            return msg.Result;
        }

        public static MessageResult confirmarSim(uixTemplate template, String title, String message)
        {
            UIXMessage msg = create(template, title, message, Properties.Resources.confirmar);

            msg.btnOption1.Text = "Não";
            msg.btnOption2.Text = "Sim";

            uixButton.btnApply(msg.btnOption1, template.Style.ButtonWarningColor);

            msg.ShowDialog();

            return msg.Result;
        }

        private static UIXMessage create(uixTemplate template, String title, String message, Image img)
        {
            UIXMessage msg = new UIXMessage();

            msg.hdrUIX.Title = title;
            msg.lbl.Text = message;
            msg.hdrUIX.Image = img;
            msg.pic.Image = img;

            template.frmApply(msg, msg.hdrUIX);
            

            return msg;
        }

        private void result(MessageResult result)
        {
            Result = result;

            Close();
        }

        private void hdrUIX_Close(object sender, EventArgs e)
        {
            result(MessageResult.CANCEL);
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            result(btnOption1.Text.Equals("Sim", StringComparison.InvariantCultureIgnoreCase) ? MessageResult.YES : MessageResult.NO);
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            result(btnOption2.Text.Equals("Sim", StringComparison.InvariantCultureIgnoreCase) ? MessageResult.YES : MessageResult.NO);
        }
    }
}
