using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


using System.Windows.Forms;

namespace MaincraftDistanceCsharp
{
    public partial class MainForm : Form

    {
        int select = 0;

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            PositionDataViewList.View = View.Details;
            PositionDataViewList.Columns.Add("座標管理番号");
            PositionDataViewList.Columns.Add("X座標");
            PositionDataViewList.Columns.Add("Z座標");
            PositionDataViewList.MultiSelect = false;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Crun_Click(object sender, EventArgs e)
        {


            int pos_index_count = PositionDataViewList.Items.Count;

            Debug.Print("開始");
            Debug.Print(pos_index_count.ToString());

            int accumulation_movement_distance_calculation = 0;
            int accumulation_pythagorean_proposition_int = 0;

            for (int i = 0; i < pos_index_count - 1; i++)
            {
                string pos_x_strB = PositionDataViewList.Items[i].SubItems[1].Text;
                string pos_z_strB = PositionDataViewList.Items[i].SubItems[2].Text;

                string pos_x_strN = PositionDataViewList.Items[i + 1].SubItems[1].Text;
                string pos_z_strN = PositionDataViewList.Items[i + 1].SubItems[2].Text;

                Debug.Print("   確認");
                Debug.Print(pos_x_strB.ToString());
                Debug.Print(pos_z_strB.ToString());
                Debug.Print(pos_x_strN.ToString());
                Debug.Print(pos_z_strN.ToString());

                int pos_x_intB = Convert.ToInt32(pos_x_strB);
                int pos_z_intB = Convert.ToInt32(pos_z_strB);
                int pos_x_intN = Convert.ToInt32(pos_x_strN);
                int pos_z_intN = Convert.ToInt32(pos_z_strN);


                int x_distance = Math.Abs(pos_x_intN - pos_x_intB);
                int y_distance = Math.Abs(pos_z_intN - pos_z_intB);

                int movement_distance_calculation = x_distance + y_distance;

                double pythagorean_proposition_double = Math.Sqrt(Math.Pow(x_distance, 2) + Math.Pow(y_distance, 2));
                int pythagorean_proposition_int = Convert.ToInt32(pythagorean_proposition_double);


                Debug.Print("   出力");
                Debug.Print(movement_distance_calculation.ToString());
                Debug.Print(pythagorean_proposition_int.ToString());
                accumulation_movement_distance_calculation += movement_distance_calculation;
                accumulation_pythagorean_proposition_int += pythagorean_proposition_int;

                Debug.Print(i.ToString());
            }


            movement_distance.Text = accumulation_movement_distance_calculation.ToString();
            straight_distance.Text = accumulation_pythagorean_proposition_int.ToString();

            //    string text_x1_str =text_x1.Text;
            //    string text_z1_str = text_z1.Text;
            //    string text_x2_str = text_x.Text;
            //    string text_z2_str = text_z.Text;

            //    int text_x1_int;
            //    int text_z1_int;
            //    int text_x2_int;
            //    int text_z2_int;

            //    bool text_x1_bool = int.TryParse(text_x1_str, out text_x1_int);
            //    bool text_z1_bool = int.TryParse(text_z1_str, out text_z1_int);
            //    bool text_x2_bool = int.TryParse(text_x2_str, out text_x2_int);
            //    bool text_z2_bool = int.TryParse(text_z2_str, out text_z2_int);

            //    bool convert_bool = text_x1_bool && text_z1_bool && text_x2_bool && text_z2_bool;

            //    if (!convert_bool){
            //        return;
            //    }

            //    text_x1_int = Convert.ToInt32(text_x1_str);
            //    text_z1_int = Convert.ToInt32(text_z1_str);
            //    text_x2_int = Convert.ToInt32(text_x2_str);
            //    text_z2_int = Convert.ToInt32(text_z2_str);

            //    int x_distance = Math.Abs(text_x2_int - text_x1_int);
            //    int y_distance = Math.Abs(text_z2_int - text_z1_int);

            //    int movement_distance_calculation = x_distance + y_distance;

            //    double pythagorean_proposition_double = Math.Sqrt(Math.Pow(x_distance,2) + Math.Pow(y_distance, 2));

            //    int pythagorean_proposition_int = Convert.ToInt32(pythagorean_proposition_double);

            //    movement_distance.Text = movement_distance_calculation.ToString();
            //    straight_distance.Text = pythagorean_proposition_int.ToString();

        }

        private void movement_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(movement_distance.Text);

        }

        private void straight_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(straight_distance.Text);

        }

        int count = 0;

        private List<string> get_position()
        {

            string text_x_str = text_x.Text;
            string text_z_str = text_z.Text;

            int text_x_int;
            int text_z_int;

            bool text_x_bool = int.TryParse(text_x_str, out text_x_int);
            bool text_z_bool = int.TryParse(text_z_str, out text_z_int);

            bool convert_bool = text_x_bool && text_z_bool;

            if (!convert_bool)
            {
                MessageBox.Show("正しい値を入力してね(´・ω・`)",
                "(∩´﹏`∩)",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                text_x_str = "0";
                text_z_str = "0";

            }


            text_x_int = Convert.ToInt32(text_x_str);
            text_z_int = Convert.ToInt32(text_z_str);

            List<string> number = new List<string>();

            number.Add(text_x_str);
            number.Add(text_z_str);

            return number;

        }

        private void position_new_Click(object sender, EventArgs e)
        {
            ListViewItem lvi;

            List<string> pos = get_position();

            lvi = PositionDataViewList.Items.Add(count.ToString());
            lvi.SubItems.Add(pos[0]);
            lvi.SubItems.Add(pos[1]);

            count++;

        }

        private bool click_judge_position_listview()
        {
            int click_count = PositionDataViewList.SelectedItems.Count;

            if (click_count != 1)
            {
                MessageBox.Show("必ずひとつだけ選択してね(´・ω・`)",
                "(∩´﹏`∩)",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                return false;
            }


            return true;
        }

        

        private void position_delete_Click(object sender, EventArgs e)
        {
            PositionDataViewList.Items.Remove(PositionDataViewList.SelectedItems[0]);
        }

        private void position_change_Click(object sender, EventArgs e)
        {
            if (click_judge_position_listview())
            {
                PositionDataViewList.SelectedItems[0].SubItems[1].Text = text_x.Text;
                PositionDataViewList.SelectedItems[0].SubItems[2].Text = text_z.Text;
            }
        }

        private void PositionDataViewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                id = PositionDataViewList.SelectedItems[0].Index;
            }
            catch
            {

            }

            if (id < 0) return;

            select = id;

            string select_str = PositionDataViewList.SelectedItems[0].SubItems[0].Text;
            string pos_x_str = PositionDataViewList.SelectedItems[0].SubItems[1].Text;
            string pos_z_str = PositionDataViewList.SelectedItems[0].SubItems[2].Text;

            int pos_x = Convert.ToInt32(pos_x_str);
            int pos_z = Convert.ToInt32(pos_z_str);

            text_x.Text = pos_x_str;
            text_z.Text = pos_z_str;
        }
    }
}
