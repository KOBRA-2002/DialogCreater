using DialogCreaterUI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DialogCreaterUI
{
    public partial class DialogWriter : Form, IDialogWriterView
    {
        public DialogWriter()
        {
            InitializeComponent();
        }

        private void MoveLast_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Движение назад");
        }

        private void MoveToNext_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void InputNPC_PHRASE_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputAnswer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputAnswer4_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputAnswer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputAnswer5_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputAnswer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputAnswer6_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateData()
        {

        }

        public void MoveToLast()
        {
            
        }

        public void MoveNext()
        {

        }
        public void ToSave()
        {

        }
    }
}
