using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    class cls_msgBox
    {
        public enum buttons { OKOnly=1, YesAndNo, YesAndNoAndCancel };

        /// <summary>
        /// با این متد یک کادر محاوره با یک دکمه تائید نمایش داده می شود
        /// </summary>
        /// <param name="s_prompt"></param>
        /// <returns></returns>
        public static DialogResult show(string s_prompt)
        {
            frm_msgBox _frm_msgBox = new frm_msgBox();
            _frm_msgBox.lbl_prompt.Text = s_prompt;
            _frm_msgBox.btn_no.Visible = false;
            _frm_msgBox.btn_cancel.Visible = false;
            System.Media.SystemSounds.Asterisk.Play();

            return _frm_msgBox.ShowDialog();
        }

        /// <summary>
        /// با این متد می توانید عنوان کادر محاوره ای را نیز تنظیم کنید
        /// </summary>
        /// <param name="s_prompt"></param>
        /// <param name="s_title"></param>
        /// <returns></returns>
        public static DialogResult show(string s_prompt, string s_title)
        {
            frm_msgBox _frm_msgBox = new frm_msgBox();
            _frm_msgBox.lbl_prompt.Text = s_prompt;
            _frm_msgBox.Text = s_title;
            _frm_msgBox.btn_no.Visible = false;
            _frm_msgBox.btn_cancel.Visible = false;

            System.Media.SystemSounds.Asterisk.Play();

            return _frm_msgBox.ShowDialog();
        }

        /// <summary>
        /// با این متد علاوه بر تعیین عنوان کادر محاوره ای می توانید دکمه های آن را نیز تنظیم کنید
        /// </summary>
        /// <param name="s_prompt"></param>
        /// <param name="s_title"></param>
        /// <param name="_btns"></param>
        /// <returns></returns>
        public static DialogResult show(string s_prompt, string s_title, buttons _btns)
        {
            frm_msgBox _frm_msgBox = new frm_msgBox();
            _frm_msgBox.lbl_prompt.Text = s_prompt;
            _frm_msgBox.Text = s_title;
            if (_btns == buttons.OKOnly)
            {
                _frm_msgBox.btn_no.Visible = false;
                _frm_msgBox.btn_cancel.Visible = false;
            }
            else if (_btns == buttons.YesAndNo)
            {
                _frm_msgBox.btn_cancel.Visible = false;
                _frm_msgBox.btn_ok.Text = "بـــله";
                _frm_msgBox.btn_ok.DialogResult = DialogResult.Yes;
            }
            else if (_btns == buttons.YesAndNoAndCancel)
            {
                _frm_msgBox.btn_ok.Text = "بـــله";
                _frm_msgBox.btn_ok.DialogResult = DialogResult.Yes;
            }

            System.Media.SystemSounds.Asterisk.Play();

            return _frm_msgBox.ShowDialog();
        }
    }
}
