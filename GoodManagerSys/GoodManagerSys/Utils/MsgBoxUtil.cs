using System.Windows.Forms;

namespace GoodManagerSys.Utils {
    public class MsgBoxUtil
    {
        public static DialogResult QuestionMsgBox(string message)
        {
            return MessageBox.Show(message, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static DialogResult YesNoCancelMsgBox(string message)
        {
            return MessageBox.Show(message, "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static void ErrMsgBox(string message)
        {
            MessageBox.Show(message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
