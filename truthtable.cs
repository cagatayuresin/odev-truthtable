namespace Truthtable
{
    public partial class Form1 : Form
    {
		private string bool2text(bool statement)
        {
            if (statement)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        private void reset()
        {
            tbl_p_0.Text = "P";
            tbl_p_1.Text = "1";
            tbl_p_2.Text = "1";
            tbl_p_3.Text = "0";
            tbl_p_4.Text = "0";
            tbl_q_0.Text = "Q";
            tbl_q_1.Text = "1";
            tbl_q_2.Text = "0";
            tbl_q_3.Text = "1";
            tbl_q_4.Text = "0";

        }

        private void btn_clicked(object sender, EventArgs e)
        {
            bool logic_p_1 = true;
            bool logic_p_2 = true;
            bool logic_p_3 = false;
            bool logic_p_4 = false;
            bool logic_q_1 = true;
            bool logic_q_2 = false;
            bool logic_q_3 = true;
            bool logic_q_4 = false;

            reset();

            if (p_not.Checked)
            {
                logic_p_1 = false;
                logic_p_2 = false;
                logic_p_3 = true;
                logic_p_4 = true;

                tbl_p_1.Text = "0";
                tbl_p_2.Text = "0";
                tbl_p_3.Text = "1";
                tbl_p_4.Text = "1";

                tbl_p_0.Text = "P'";
            }
            if (q_not.Checked)
            {
                logic_q_1 = false;
                logic_q_2 = true;
                logic_q_3 = false;
                logic_q_4 = true;

                tbl_q_1.Text = "0";
                tbl_q_2.Text = "1";
                tbl_q_3.Text = "0";
                tbl_q_4.Text = "1";

                tbl_q_0.Text = "Q'";
            }
            if (op_box.Text == "AND")
            {
                tbl_r_1.Text = bool2text((logic_p_1 && logic_q_1));
                tbl_r_2.Text = bool2text((logic_p_2 && logic_q_2));
                tbl_r_3.Text = bool2text((logic_p_3 && logic_q_3));
                tbl_r_4.Text = bool2text((logic_p_4 && logic_q_4));
            }
            else if (op_box.Text == "OR")
            {
                tbl_r_1.Text = bool2text((logic_p_1 || logic_q_1));
                tbl_r_2.Text = bool2text((logic_p_2 || logic_q_2));
                tbl_r_3.Text = bool2text((logic_p_3 || logic_q_3));
                tbl_r_4.Text = bool2text((logic_p_4 || logic_q_4));
            }
            else if (op_box.Text == "IF")
            {
                tbl_r_1.Text = bool2text((!logic_p_1 || logic_q_1));
                tbl_r_2.Text = bool2text((!logic_p_2 || logic_q_2));
                tbl_r_3.Text = bool2text((!logic_p_3 || logic_q_3));
                tbl_r_4.Text = bool2text((!logic_p_4 || logic_q_4));
            }
            else if (op_box.Text == "BI")
            {
                tbl_r_1.Text = bool2text(((!logic_p_1 || logic_q_1) && (!logic_q_1 || logic_p_1)));
                tbl_r_2.Text = bool2text(((!logic_p_2 || logic_q_2) && (!logic_q_2 || logic_p_2)));
                tbl_r_3.Text = bool2text(((!logic_p_3 || logic_q_3) && (!logic_q_3 || logic_p_3)));
                tbl_r_4.Text = bool2text(((!logic_p_4 || logic_q_4) && (!logic_q_4 || logic_p_4)));
            }
            else if (op_box.Text == "XOR")
            {
                tbl_r_1.Text = bool2text(((logic_p_1 && !logic_q_1) || (!logic_p_1 && logic_q_1)));
                tbl_r_2.Text = bool2text(((logic_p_2 && !logic_q_2) || (!logic_p_2 && logic_q_2)));
                tbl_r_3.Text = bool2text(((logic_p_3 && !logic_q_3) || (!logic_p_3 && logic_q_3)));
                tbl_r_4.Text = bool2text(((logic_p_4 && !logic_q_4) || (!logic_p_4 && logic_q_4)));
            }
            else if (op_box.Text == "NOR")
            {
                tbl_r_1.Text = bool2text(!(logic_p_1 || logic_q_1));
                tbl_r_2.Text = bool2text(!(logic_p_2 || logic_q_2));
                tbl_r_3.Text = bool2text(!(logic_p_3 || logic_q_3));
                tbl_r_4.Text = bool2text(!(logic_p_4 || logic_q_4));
            }
            else if (op_box.Text == "XNOR")
            {
                tbl_r_1.Text = bool2text(!((logic_p_1 && !logic_q_1) || (!logic_p_1 && logic_q_1)));
                tbl_r_2.Text = bool2text(!((logic_p_2 && !logic_q_2) || (!logic_p_2 && logic_q_2)));
                tbl_r_3.Text = bool2text(!((logic_p_3 && !logic_q_3) || (!logic_p_3 && logic_q_3)));
                tbl_r_4.Text = bool2text(!((logic_p_4 && !logic_q_4) || (!logic_p_4 && logic_q_4)));
            }
            else
            {
                tbl_r_1.Text = "-";
                tbl_r_2.Text = "-";
                tbl_r_3.Text = "-";
                tbl_r_4.Text = "-";
            }
        }
	}
}