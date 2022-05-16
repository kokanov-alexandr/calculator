using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_form
{
    internal class Create : Button
    {
        public Button CreateMyBuutton(Form frm, string str, int coord_x, int coord_y, int w, int h, Color text_color, Color back_color)
        {
            Button btn = new Button();
            btn.Text = str;
            btn.Size = new Size(w, h);
            btn.BackColor = back_color;
            btn.ForeColor = text_color;
            btn.Location = new Point(coord_x, coord_y);
            frm.Controls.Add(btn);
            return btn;
        }

        public Label CreareMyLable(Form frm, string str, int coord_x, int coord_y, int w, int h)
        {
            Label lbl = new Label();
            lbl.Text = str;
            lbl.Size = new Size(w, h);
            lbl.Location = new Point(coord_x, coord_y);
            frm.Controls.Add(lbl);
            return lbl;
        }

        public TextBox CreareMyTextBox(Form frm, int coord_x, int coord_y, int w, int h)
        {
            TextBox tx1 = new TextBox();
            tx1.Size = new Size(w, h);
            tx1.Location = new Point(coord_x, coord_y);
            frm.Controls.Add(tx1);
            return tx1;
        }

        public ComboBox CreareMyComboBox(Form frm, int coord_x, int coord_y, int w, int h, params string[] info)
        {
            ComboBox cmb = new ComboBox();
            cmb.Size = new Size(w, h);
            cmb.Location = new Point(coord_x, coord_y);
            cmb.Items.AddRange(info);
            frm.Controls.Add(cmb);
            return cmb;
        }


    }
}
