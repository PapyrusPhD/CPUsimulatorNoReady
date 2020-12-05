using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class Homepage : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Homepage()
        {
            InitializeComponent();
        }

        private void Ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int rows = Base.Rows.Count;
            if (Process.TextLength == 0 || BT.TextLength == 0)
            {
                MessageBox.Show("Fill up the textbox!", "Error");
            }
            else
            {
                if (Sing.Checked)
                {
                    if (rows == 1)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label20.Text = Process.Text;
                        this.label19.Text = AT.Text;
                        this.label18.Text = BT.Text;

                    }
                    else if (rows == 2)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label17.Text = Process.Text;
                        this.label6.Text = label19.Text;
                        this.label7.Text = BT.Text;
                    }
                    else if (rows == 3)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label8.Text = Process.Text;
                        this.label9.Text = label19.Text;
                        this.label10.Text = BT.Text;
                    }
                    else if (rows == 4)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label11.Text = Process.Text;
                        this.label12.Text = label19.Text;
                        this.label13.Text = BT.Text;
                    }
                    else if (rows == 5)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label14.Text = Process.Text;
                        this.label15.Text = label19.Text;
                        this.label16.Text = BT.Text;
                    }
                    else
                    {
                        MessageBox.Show("Only minimum of 3 rows and maximum of 5 rows are accepted!", "Error");
                    }
                }
                else if (Multi.Checked)
                {
                    if (rows == 1)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label20.Text = Process.Text;
                        this.label19.Text = AT.Text;
                        this.label18.Text = BT.Text;

                    }
                    else if (rows == 2)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label17.Text = Process.Text;
                        this.label6.Text = AT.Text;
                        this.label7.Text = BT.Text;
                    }
                    else if (rows == 3)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label8.Text = Process.Text;
                        this.label9.Text = AT.Text;
                        this.label10.Text = BT.Text;
                    }
                    else if (rows == 4)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label11.Text = Process.Text;
                        this.label12.Text = AT.Text;
                        this.label13.Text = BT.Text;
                    }
                    else if (rows == 5)
                    {
                        this.Base.Rows.Add(Process.Text, AT.Text, BT.Text);
                        this.label14.Text = Process.Text;
                        this.label15.Text = AT.Text;
                        this.label16.Text = BT.Text;
                    }
                    else
                    {
                        MessageBox.Show("Only minimum of 3 rows and maximum of 5 rows are accepted!", "Error");
                    }
                }


            }
            Process.Clear();
            AT.Clear();
            BT.Clear();
        }

        private void Process_TextChanged(object sender, EventArgs e)
        {

        }

        private void Process_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void AT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Base.Rows.Clear();
            Base.Refresh();
            AT.ReadOnly = false;
            Process.Clear();
            AT.Clear();
            BT.Clear();
            WT.Clear();
            TT.Clear();
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            label21.ForeColor = Color.WhiteSmoke;
            s1.ForeColor = Color.WhiteSmoke;
            s2.ForeColor = Color.WhiteSmoke;
            s3.ForeColor = Color.WhiteSmoke;
            s4.ForeColor = Color.WhiteSmoke;
            s5.ForeColor = Color.WhiteSmoke;
            s6.ForeColor = Color.WhiteSmoke;
            bs1.ForeColor = Color.WhiteSmoke;
            bs2.ForeColor = Color.WhiteSmoke;
            bs3.ForeColor = Color.WhiteSmoke;
            bs4.ForeColor = Color.WhiteSmoke;
            bs5.ForeColor = Color.WhiteSmoke;
            p1.ForeColor = Color.WhiteSmoke;
            p2.ForeColor = Color.WhiteSmoke;
            p3.ForeColor = Color.WhiteSmoke;
            p4.ForeColor = Color.WhiteSmoke;
            p5.ForeColor = Color.WhiteSmoke;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            progressBar5.Visible = false;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            this.AcceptButton = Add;
            Add.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Base_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            int rows = Base.Rows.Count;
            if (Sing.Checked)
            {
                if (rows == 4) //row 3
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    string c1 = label20.Text;
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    string c2 = label17.Text;
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    string c3 = label8.Text;
                    float add1 = a1 + b1;
                    float add2 = add1 + b2;
                    float sum = a1 + add1 + add2;
                    float div = sum / 3;
                    float ans = div - a1;
                    // Turn Around Time
                    float add3 = add2 + b3;
                    float Tadd = add1 + add2 + add3;
                    float div2 = Tadd / 3;
                    float ans2 = div2 - a1;
                    // Starting Time display
                    s1.Text = a1.ToString();
                    s2.Text = add1.ToString();
                    s3.Text = add2.ToString();
                    s4.Text = add3.ToString();
                    // Burst time display
                    bs1.Text = b1.ToString();
                    bs2.Text = b2.ToString();
                    bs3.Text = b3.ToString();
                    // Process display
                    p1.Text = c1;
                    p2.Text = c2;
                    p3.Text = c3;
                    // results
                    WT.Text = ans.ToString() + " ms";
                    TT.Text = ans2.ToString() + " ms";
                    // Progress bars
                    progressBar1.Visible = true;
                    timer1.Start();
                    panel2.BackColor = Color.Black;
                    label21.ForeColor = Color.Black;
                    // colors
                }
                else if (rows == 5)
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    string c1 = label20.Text;
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    string c2 = label17.Text;
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    string c3 = label8.Text;
                    // Row4
                    int a4 = Convert.ToInt32(label12.Text);
                    int b4 = Convert.ToInt32(label13.Text);
                    string c4 = label11.Text;
                    float add1 = a1 + b1;
                    float add2 = add1 + b2;
                    float add3 = add2 + b3;
                    float sum = a1 + add1 + add2 + add3;
                    float div = sum / 4;
                    float ans = div - a1;
                    // Turn Around Time
                    float add4 = add3 + b4;
                    float Tadd = add1 + add2 + add3 + add4;
                    float div2 = Tadd / 4;
                    float ans2 = div2 - a1;
                    // Starting Time display
                    s1.Text = a1.ToString();
                    s2.Text = add1.ToString();
                    s3.Text = add2.ToString();
                    s4.Text = add3.ToString();
                    s5.Text = add4.ToString();
                    // Burst time display
                    bs1.Text = b1.ToString();
                    bs2.Text = b2.ToString();
                    bs3.Text = b3.ToString();
                    bs4.Text = b4.ToString();
                    // Process display
                    p1.Text = c1;
                    p2.Text = c2;
                    p3.Text = c3;
                    p4.Text = c4;
                    // results
                    WT.Text = ans.ToString() + " ms";
                    TT.Text = ans2.ToString() + " ms";
                    // color
                    progressBar1.Visible = true;
                    timer1.Start();
                    panel2.BackColor = Color.Black;
                    label21.ForeColor = Color.Black;
                }
                else if (rows == 6)
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    string c1 = label20.Text;
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    string c2 = label17.Text;
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    string c3 = label8.Text;
                    // Row4
                    int a4 = Convert.ToInt32(label12.Text);
                    int b4 = Convert.ToInt32(label13.Text);
                    string c4 = label11.Text;
                    // Row5
                    int a5 = Convert.ToInt32(label15.Text);
                    int b5 = Convert.ToInt32(label16.Text);
                    string c5 = label14.Text;

                    float add1 = a1 + b1;
                    float add2 = add1 + b2;
                    float add3 = add2 + b3;
                    float add4 = add3 + b4;
                    float sum = a1 + add1 + add2 + add3 + add4;
                    float div = sum / 5;
                    float ans = div - a1;
                    // Turn Around Time
                    float add5 = add4 + b5;
                    float Tadd = add1 + add2 + add3 + add4 + add5;
                    float div2 = Tadd / 5;
                    float ans2 = div2 - a1;
                    // Starting Time display
                    s1.Text = a1.ToString();
                    s2.Text = add1.ToString();
                    s3.Text = add2.ToString();
                    s4.Text = add3.ToString();
                    s5.Text = add4.ToString();
                    s6.Text = add5.ToString();
                    // Burst time display
                    bs1.Text = b1.ToString();
                    bs2.Text = b2.ToString();
                    bs3.Text = b3.ToString();
                    bs4.Text = b4.ToString();
                    bs5.Text = b5.ToString();
                    // Process display
                    p1.Text = c1;
                    p2.Text = c2;
                    p3.Text = c3;
                    p4.Text = c4;
                    p5.Text = c5;
                    // results
                    WT.Text = ans.ToString() + " ms";
                    TT.Text = ans2.ToString() + " ms";
                    // color
                    progressBar1.Visible = true;
                    timer1.Start();
                    panel2.BackColor = Color.Black;
                    label21.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("You can only input 3-5 process!", "Error");
                }
            }
            else if (Multi.Checked)
            {
                if (rows == 4) //row 3
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);

                    var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 } };
                    for (int i = 0; i < input.GetLength(0) - 1; i++)
                    {
                        for (int j = i; j < input.GetLength(0); j++)
                        {
                            if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                            {
                                for (int k = 0; k < input.GetLength(1); k++)
                                {
                                    var temp = input[i, k];
                                    input[i, k] = input[j, k];
                                    input[j, k] = temp;
                                }
                            }
                        }
                    }
                    // finish time
                    double add1 = input[0, 0] + input[0, 1];
                    double add2 = add1 + input[1, 1];
                    double add3 = add2 + input[2, 1];
                    // waiting time
                    double wt1 = 0;
                    double wt2 = add1 - input[1, 0];
                    double wt3 = add2 - input[2, 0];
                    // average waiting time
                    double sum = wt1 + wt2 + wt3;
                    double div = sum / 3;
                    // average turn around time
                    double ta1 = add1 - input[0, 0];
                    double ta2 = add2 - input[1, 0];
                    double ta3 = add3 - input[2, 0];
                    // average turn around time
                    double sum1 = ta1 + ta2 + ta3;
                    double div1 = sum1 / 3;
                    WT.Text = div.ToString() + " ms";
                    TT.Text = div1.ToString() + " ms";
                    // starting time
                    s1.Text = input[0, 0].ToString();
                    s2.Text = add1.ToString();
                    s3.Text = add2.ToString();
                    s4.Text = add3.ToString();
                    // burst time
                    bs1.Text = input[0, 1].ToString();
                    bs2.Text = input[1, 1].ToString();
                    bs3.Text = input[2, 1].ToString();
                    // process
                    p1.Text = "P 1";
                    p2.Text = "P 2";
                    p3.Text = "P 3";
                    // color
                    progressBar1.Visible = true;
                    timer1.Start();
                    panel2.BackColor = Color.Black;
                    label21.ForeColor = Color.Black;

                }
                else if (rows == 5) //row 4
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text); ;
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    // Row4
                    int a4 = Convert.ToInt32(label12.Text);
                    int b4 = Convert.ToInt32(label13.Text);

                    var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 }, { a4, b4 } };
                    for (int i = 0; i < input.GetLength(0) - 1; i++)
                    {
                        for (int j = i; j < input.GetLength(0); j++)
                        {
                            if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                            {
                                for (int k = 0; k < input.GetLength(1); k++)
                                {
                                    var temp = input[i, k];
                                    input[i, k] = input[j, k];
                                    input[j, k] = temp;
                                }
                            }
                        }
                    }
                    // finish time
                    double add1 = input[0, 0] + input[0, 1];
                    double add2 = add1 + input[1, 1];
                    double add3 = add2 + input[2, 1];
                    double add4 = add3 + input[3, 1];
                    // waiting time
                    double wt1 = 0;
                    double wt2 = add1 - input[1, 0];
                    double wt3 = add2 - input[2, 0];
                    double wt4 = add3 - input[3, 0];
                    // average waiting time
                    double sum = wt1 + wt2 + wt3 + wt4;
                    double div = sum / 4;
                    // average turn around time
                    double ta1 = add1 - input[0, 0];
                    double ta2 = add2 - input[1, 0];
                    double ta3 = add3 - input[2, 0];
                    double ta4 = add4 - input[3, 0];
                    // average turn around time
                    double sum1 = ta1 + ta2 + ta3 + ta4;
                    double div1 = sum1 / 4;
                    // starting time
                    s1.Text = input[0, 0].ToString();
                    s2.Text = add1.ToString();
                    s3.Text = add2.ToString();
                    s4.Text = add3.ToString();
                    s5.Text = add4.ToString();
                    // burst time
                    bs1.Text = input[0, 1].ToString();
                    bs2.Text = input[1, 1].ToString();
                    bs3.Text = input[2, 1].ToString();
                    bs4.Text = input[3, 1].ToString();
                    // process
                    p1.Text = "P 1";
                    p2.Text = "P 2";
                    p3.Text = "P 3";
                    p4.Text = "P 4";
                    // result
                    WT.Text = div.ToString() + " ms";
                    TT.Text = div1.ToString() + " ms";
                    // color
                    progressBar1.Visible = true;
                    timer1.Start();
                    panel2.BackColor = Color.Black;
                    label21.ForeColor = Color.Black;
                }
                else if (rows == 6) //row5
                {
                    // Row1
                    int a1 = Convert.ToInt32(label19.Text);
                    int b1 = Convert.ToInt32(label18.Text);
                    // Row2
                    int a2 = Convert.ToInt32(label6.Text);
                    int b2 = Convert.ToInt32(label7.Text);
                    // Row3
                    int a3 = Convert.ToInt32(label9.Text);
                    int b3 = Convert.ToInt32(label10.Text);
                    // Row4
                    int a4 = Convert.ToInt32(label12.Text);
                    int b4 = Convert.ToInt32(label13.Text);
                    // Row5
                    int a5 = Convert.ToInt32(label15.Text);
                    int b5 = Convert.ToInt32(label16.Text);

                    var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 }, { a4, b4 }, { a5, b5 } };
                    for (int i = 0; i < input.GetLength(0) - 1; i++)
                    {
                        for (int j = i; j < input.GetLength(0); j++)
                        {
                            if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                            {
                                for (int k = 0; k < input.GetLength(1); k++)
                                {
                                    var temp = input[i, k];
                                    input[i, k] = input[j, k];
                                    input[j, k] = temp;
                                }
                            }
                        }
                    }
                    // finish time
                    double add1 = input[0, 0] + input[0, 1];
                    double add2 = add1 + input[1, 1];
                    double add3 = add2 + input[2, 1];
                    double add4 = add3 + input[3, 1];
                    double add5 = add4 + input[4, 1];
                    // waiting time
                    double wt1 = 0; // D
                    double wt2 = add1 - input[1, 0];
                    double wt3 = add2 - input[2, 0];
                    double wt4 = add3 - input[3, 0];
                    double wt5 = add4 - input[4, 0];
                    // average waiting time
                    double sum = wt1 + wt2 + wt3 + wt4 + wt5;
                    double div = sum / 5;
                    // average turn around time
                    double ta1 = add1 - input[0, 0];
                    double ta2 = add2 - input[1, 0];
                    double ta3 = add3 - input[2, 0];
                    double ta4 = add4 - input[3, 0];
                    double ta5 = add5 - input[4, 0];
                    // average turn around time
                    double sum1 = ta1 + ta2 + ta3 + ta4 + ta5;
                    double div1 = sum1 / 5;
                    WT.Text = div.ToString() + " ms";
                    TT.Text = div1.ToString() + " ms";
                    // starting time
                    s1.Text = input[0, 0].ToString();
                    s2.Text = add1.ToString();
                    s3.Text = add2.ToString();
                    s4.Text = add3.ToString();
                    s5.Text = add4.ToString();
                    s6.Text = add5.ToString();
                    // burst time
                    bs1.Text = input[0, 1].ToString();
                    bs2.Text = input[1, 1].ToString();
                    bs3.Text = input[2, 1].ToString();
                    bs4.Text = input[3, 1].ToString();
                    bs5.Text = input[4, 1].ToString();
                    // process
                    p1.Text = "P 1";
                    p2.Text = "P 2";
                    p3.Text = "P 3";
                    p4.Text = "P 4";
                    p5.Text = "P 5";
                    // result
                    WT.Text = div.ToString() + " ms";
                    TT.Text = div1.ToString() + " ms";
                    // color
                    progressBar1.Visible = true;
                    timer1.Start();
                    panel2.BackColor = Color.Black;
                    label21.ForeColor = Color.Black;
                }
            }
        }

        private void Sing_CheckedChanged(object sender, EventArgs e)
        {
            Base.Rows.Clear();
            Base.Refresh();
            AT.ReadOnly = false;
            Process.Clear();
            AT.Clear();
            BT.Clear();
            WT.Clear();
            TT.Clear();
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            label21.ForeColor = Color.WhiteSmoke;
            s1.ForeColor = Color.WhiteSmoke;
            s2.ForeColor = Color.WhiteSmoke;
            s3.ForeColor = Color.WhiteSmoke;
            s4.ForeColor = Color.WhiteSmoke;
            s5.ForeColor = Color.WhiteSmoke;
            s6.ForeColor = Color.WhiteSmoke;
            bs1.ForeColor = Color.WhiteSmoke;
            bs2.ForeColor = Color.WhiteSmoke;
            bs3.ForeColor = Color.WhiteSmoke;
            bs4.ForeColor = Color.WhiteSmoke;
            bs5.ForeColor = Color.WhiteSmoke;
            p1.ForeColor = Color.WhiteSmoke;
            p2.ForeColor = Color.WhiteSmoke;
            p3.ForeColor = Color.WhiteSmoke;
            p4.ForeColor = Color.WhiteSmoke;
            p5.ForeColor = Color.WhiteSmoke;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            progressBar5.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AT_TextChanged(object sender, EventArgs e)
        {
            int rows = Base.Rows.Count;
            if (Sing.Checked && rows >= 2)
            {
                AT.ReadOnly = true;
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }



        private void bs1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            if (Sing.Checked)
            {
                int b1 = Convert.ToInt32(label18.Text);
                progressBar1.Maximum = b1;
                progressBar1.Increment(1);
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    progressBar1.Visible = false;
                    timer1.Stop();
                    panel3.BackColor = Color.DimGray;
                    s1.ForeColor = Color.Black;
                    bs1.ForeColor = Color.Black;
                    p1.ForeColor = Color.Black;
                    timer2.Start();
                    progressBar2.Visible = true;
                }
            }
            else if (Multi.Checked)
            {
                int a1 = Convert.ToInt32(label19.Text);
                int b1 = Convert.ToInt32(label18.Text);
                // Row2
                int a2 = Convert.ToInt32(label6.Text);
                int b2 = Convert.ToInt32(label7.Text);
                // Row3
                int a3 = Convert.ToInt32(label9.Text);
                int b3 = Convert.ToInt32(label10.Text);
                var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 } };
                for (int i = 0; i < input.GetLength(0) - 1; i++)
                {
                    for (int j = i; j < input.GetLength(0); j++)
                    {
                        if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                        {
                            for (int k = 0; k < input.GetLength(1); k++)
                            {
                                var temp = input[i, k];
                                input[i, k] = input[j, k];
                                input[j, k] = temp;
                            }
                        }
                    }
                }
                progressBar1.Maximum = Convert.ToInt32(input[0, 1]);
                progressBar1.Increment(1);
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    progressBar1.Visible = false;
                    timer1.Stop();
                    panel3.BackColor = Color.DimGray;
                    s1.ForeColor = Color.Black;
                    bs1.ForeColor = Color.Black;
                    p1.ForeColor = Color.Black;
                    timer2.Start();
                    progressBar2.Visible = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Sing.Checked)
            {
                int b2 = Convert.ToInt32(label7.Text);
                progressBar2.Maximum = b2;
                progressBar2.Increment(1);
                if (progressBar2.Value == progressBar2.Maximum)
                {
                    progressBar2.Visible = false;
                    timer2.Stop();
                    panel4.BackColor = Color.Silver;
                    s2.ForeColor = Color.Black;
                    bs2.ForeColor = Color.Black;
                    p2.ForeColor = Color.Black;
                    timer3.Start();
                    progressBar3.Visible = true;
                }
            }
            else if (Multi.Checked)
            {
                int a1 = Convert.ToInt32(label19.Text);
                int b1 = Convert.ToInt32(label18.Text);
                // Row2
                int a2 = Convert.ToInt32(label6.Text);
                int b2 = Convert.ToInt32(label7.Text);
                // Row3
                int a3 = Convert.ToInt32(label9.Text);
                int b3 = Convert.ToInt32(label10.Text);


                var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 } };
                for (int i = 0; i < input.GetLength(0) - 1; i++)
                {
                    for (int j = i; j < input.GetLength(0); j++)
                    {
                        if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                        {
                            for (int k = 0; k < input.GetLength(1); k++)
                            {
                                var temp = input[i, k];
                                input[i, k] = input[j, k];
                                input[j, k] = temp;
                            }
                        }
                    }
                }
                progressBar2.Maximum = Convert.ToInt32(input[1, 1]);
                progressBar2.Increment(1);
                if (progressBar2.Value == progressBar2.Maximum)
                {
                    progressBar2.Visible = false;
                    timer2.Stop();
                    panel4.BackColor = Color.Silver;
                    s2.ForeColor = Color.Black;
                    bs2.ForeColor = Color.Black;
                    p2.ForeColor = Color.Black;
                    timer3.Start();
                    progressBar3.Visible = true;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int rows = Base.Rows.Count;
            if (Sing.Checked)
            {
                int b3 = Convert.ToInt32(label10.Text);
                progressBar3.Maximum = b3;
                progressBar3.Increment(1);
                if (progressBar3.Value == progressBar3.Maximum)
                {
                    progressBar3.Visible = false;
                    timer3.Stop();
                    panel5.BackColor = Color.DimGray;
                    s3.ForeColor = Color.Black;
                    bs3.ForeColor = Color.Black;
                    p3.ForeColor = Color.Black;
                    if (rows == 5 || rows == 6)
                    {
                        progressBar4.Visible = true;
                        timer4.Start();
                    }
                }
            }
            else if (Multi.Checked)
            {
                int a1 = Convert.ToInt32(label19.Text);
                int b1 = Convert.ToInt32(label18.Text);
                // Row2
                int a2 = Convert.ToInt32(label6.Text);
                int b2 = Convert.ToInt32(label7.Text);
                // Row3
                int a3 = Convert.ToInt32(label9.Text);
                int b3 = Convert.ToInt32(label10.Text);
                var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 } };
                for (int i = 0; i < input.GetLength(0) - 1; i++)
                {
                    for (int j = i; j < input.GetLength(0); j++)
                    {
                        if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                        {
                            for (int k = 0; k < input.GetLength(1); k++)
                            {
                                var temp = input[i, k];
                                input[i, k] = input[j, k];
                                input[j, k] = temp;
                            }
                        }
                    }
                }
                progressBar3.Maximum = Convert.ToInt32(input[2, 1]);
                progressBar3.Increment(1);
                if (progressBar3.Value == progressBar3.Maximum)
                {
                    progressBar3.Visible = false;
                    timer3.Stop();
                    panel5.BackColor = Color.Silver;
                    s3.ForeColor = Color.Black;
                    bs3.ForeColor = Color.Black;
                    p3.ForeColor = Color.Black;
                    timer3.Start();
                    if (rows == 5 || rows == 6)
                    {
                        timer4.Start();
                        
                    }
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int rows = Base.Rows.Count;
            if (Sing.Checked)
            {
                int b4 = Convert.ToInt32(label13.Text);
                progressBar4.Maximum = b4;
                progressBar4.Increment(1);
                if (progressBar4.Value == progressBar4.Maximum)
                {
                    progressBar4.Visible = false;
                    timer4.Stop();
                    panel6.BackColor = Color.Silver;
                    s4.ForeColor = Color.Black;
                    bs4.ForeColor = Color.Black;
                    p4.ForeColor = Color.Black;
                    if (rows == 6)
                    {
                        progressBar5.Visible = true;
                        timer5.Start();
                    }
                }
            }
            else if (Multi.Checked)
            {
                progressBar4.Visible = true;
                int a1 = Convert.ToInt32(label19.Text);
                int b1 = Convert.ToInt32(label18.Text);
                // Row2
                int a2 = Convert.ToInt32(label6.Text);
                int b2 = Convert.ToInt32(label7.Text);
                // Row3
                int a3 = Convert.ToInt32(label9.Text);
                int b3 = Convert.ToInt32(label10.Text);
                // Row4
                int a4 = Convert.ToInt32(label12.Text);
                int b4 = Convert.ToInt32(label13.Text);
                var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 }, { a4, b4 } };
                for (int i = 0; i < input.GetLength(0) - 1; i++)
                {
                    for (int j = i; j < input.GetLength(0); j++)
                    {
                        if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                        {
                            for (int k = 0; k < input.GetLength(1); k++)
                            {
                                var temp = input[i, k];
                                input[i, k] = input[j, k];
                                input[j, k] = temp;
                            }
                        }
                    }
                }
                progressBar4.Maximum = Convert.ToInt32(input[3, 1]);
                progressBar4.Increment(1);
                if (progressBar4.Value == progressBar4.Maximum)
                {
                    progressBar4.Visible = false;
                    timer4.Stop();
                    panel6.BackColor = Color.Silver;
                    s4.ForeColor = Color.Black;
                    bs4.ForeColor = Color.Black;
                    p4.ForeColor = Color.Black;
                    if (rows == 6)
                    {
                        
                        timer5.Start();
                    }
                }
            }
        }
          

        private void timer5_Tick(object sender, EventArgs e)
        {
            int rows = Base.Rows.Count;
            if (Sing.Checked)
            {
                int b5 = Convert.ToInt32(label16.Text);
                progressBar5.Maximum = b5;
                progressBar5.Increment(1);
                if (progressBar5.Value == progressBar5.Maximum)
                {
                    progressBar5.Visible = false;
                    timer5.Stop();
                    panel7.BackColor = Color.Silver;
                    s5.ForeColor = Color.Black;
                    s6.ForeColor = Color.Black;
                    bs5.ForeColor = Color.Black;
                    p5.ForeColor = Color.Black;   
                }
            }
            else if (Multi.Checked)
            {
                progressBar5.Visible = true;
                int a1 = Convert.ToInt32(label19.Text);
                int b1 = Convert.ToInt32(label18.Text);
                // Row2
                int a2 = Convert.ToInt32(label6.Text);
                int b2 = Convert.ToInt32(label7.Text);
                // Row3
                int a3 = Convert.ToInt32(label9.Text);
                int b3 = Convert.ToInt32(label10.Text);
                // Row4
                int a4 = Convert.ToInt32(label12.Text);
                int b4 = Convert.ToInt32(label13.Text);
                // Row5
                int a5 = Convert.ToInt32(label15.Text);
                int b5 = Convert.ToInt32(label16.Text);
                var input = new double[,] { { a1, b1 }, { a2, b2 }, { a3, b3 }, { a4, b4 }, { a5, b5 } };
                for (int i = 0; i < input.GetLength(0) - 1; i++)
                {
                    for (int j = i; j < input.GetLength(0); j++)
                    {
                        if (input[i, 0] > input[j, 0]) // sort by ascending by first index of each row
                        {
                            for (int k = 0; k < input.GetLength(1); k++)
                            {
                                var temp = input[i, k];
                                input[i, k] = input[j, k];
                                input[j, k] = temp;
                            }
                        }
                    }
                }
                progressBar5.Maximum = Convert.ToInt32(input[4, 1]);
                progressBar5.Increment(1);
                if (progressBar5.Value == progressBar5.Maximum)
                {
                    progressBar5.Visible = false;
                    timer5.Stop();
                    panel7.BackColor = Color.Silver;
                    s5.ForeColor = Color.Black;
                    s6.ForeColor = Color.Black;
                    bs5.ForeColor = Color.Black;
                    p5.ForeColor = Color.Black;
                }
            }
        }

        private void Multi_CheckedChanged(object sender, EventArgs e)
        {
            Base.Rows.Clear();
            Base.Refresh();
            AT.ReadOnly = false;
            Process.Clear();
            AT.Clear();
            BT.Clear();
            WT.Clear();
            TT.Clear();
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel6.BackColor = Color.Transparent;
            panel7.BackColor = Color.Transparent;
            label21.ForeColor = Color.WhiteSmoke;
            s1.ForeColor = Color.WhiteSmoke;
            s2.ForeColor = Color.WhiteSmoke;
            s3.ForeColor = Color.WhiteSmoke;
            s4.ForeColor = Color.WhiteSmoke;
            s5.ForeColor = Color.WhiteSmoke;
            s6.ForeColor = Color.WhiteSmoke;
            bs1.ForeColor = Color.WhiteSmoke;
            bs2.ForeColor = Color.WhiteSmoke;
            bs3.ForeColor = Color.WhiteSmoke;
            bs4.ForeColor = Color.WhiteSmoke;
            bs5.ForeColor = Color.WhiteSmoke;
            p1.ForeColor = Color.WhiteSmoke;
            p2.ForeColor = Color.WhiteSmoke;
            p3.ForeColor = Color.WhiteSmoke;
            p4.ForeColor = Color.WhiteSmoke;
            p5.ForeColor = Color.WhiteSmoke;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            progressBar3.Visible = false;
            progressBar4.Visible = false;
            progressBar5.Visible = false;
        }
    }
}