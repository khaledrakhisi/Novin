using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Novin
{
    class cls_inputBox
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s_prompt"></param>
        /// <returns></returns>
        public static string show(string s_prompt)
        {
            string s_returnValue = "";
            frm_inputBox _frm_inputBox = new frm_inputBox();
            _frm_inputBox.lbl_prompt.Text = s_prompt;
            if (_frm_inputBox.ShowDialog() == DialogResult.OK)
            {
                s_returnValue = _frm_inputBox.textBox1.Text;
            }

            return s_returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s_prompt"></param>
        /// <param name="s_defaultValue"></param>
        /// <returns></returns>
        public static string show(string s_prompt, string s_defaultValue)
        {
            string s_returnValue = "";
            frm_inputBox _frm_inputBox = new frm_inputBox();
            _frm_inputBox.lbl_prompt.Text = s_prompt;
            _frm_inputBox.textBox1.Text = s_defaultValue;
            if (_frm_inputBox.ShowDialog() == DialogResult.OK)
            {
                s_returnValue = _frm_inputBox.textBox1.Text;
            }

            return s_returnValue;
        }
    }
}
