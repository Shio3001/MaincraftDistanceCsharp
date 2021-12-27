using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaincraftDistanceCsharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Crun_Click(object sender, EventArgs e)
        {
            string text_x1_str =text_x1.Text;
            string text_z1_str = text_z1.Text;
            string text_x2_str = text_x2.Text;
            string text_z2_str = text_z2.Text;

            int text_x1_int;
            int text_z1_int;
            int text_x2_int;
            int text_z2_int;

            bool text_x1_bool = int.TryParse(text_x1_str, out text_x1_int);
            bool text_z1_bool = int.TryParse(text_z1_str, out text_z1_int);
            bool text_x2_bool = int.TryParse(text_x2_str, out text_x2_int);
            bool text_z2_bool = int.TryParse(text_z2_str, out text_z2_int);

            bool convert_bool = text_x1_bool && text_z1_bool && text_x2_bool && text_z2_bool;

            if (!convert_bool){
                return;
            }

            text_x1_int = Convert.ToInt32(text_x1_str);
            text_z1_int = Convert.ToInt32(text_z1_str);
            text_x2_int = Convert.ToInt32(text_x2_str);
            text_z2_int = Convert.ToInt32(text_z2_str);

            int x_distance = Math.Abs(text_x2_int - text_x1_int);
            int y_distance = Math.Abs(text_z2_int - text_z1_int);

            int movement_distance_calculation = x_distance + y_distance;

            double pythagorean_proposition_double = Math.Sqrt(Math.Pow(x_distance,2) + Math.Pow(y_distance, 2));

            int pythagorean_proposition_int = Convert.ToInt32(pythagorean_proposition_double);

            movement_distance.Text = movement_distance_calculation.ToString();
            straight_distance.Text = pythagorean_proposition_int.ToString();

        }

        private void movement_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(movement_distance.Text);

        }

        private void straight_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(straight_distance.Text);

        }
    }
}
