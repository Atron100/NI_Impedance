namespace NI_imp
{
    partial class impedance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_measure = new System.Windows.Forms.Button();
            this.cmd_quit = new System.Windows.Forms.Button();
            this.cmd_browse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Dealy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_graph = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_measure
            // 
            this.cmd_measure.Enabled = false;
            this.cmd_measure.Location = new System.Drawing.Point(115, 515);
            this.cmd_measure.Name = "cmd_measure";
            this.cmd_measure.Size = new System.Drawing.Size(82, 38);
            this.cmd_measure.TabIndex = 0;
            this.cmd_measure.Text = "Measure";
            this.cmd_measure.UseVisualStyleBackColor = true;
            this.cmd_measure.Click += new System.EventHandler(this.cmd_measure_Click);
            // 
            // cmd_quit
            // 
            this.cmd_quit.Location = new System.Drawing.Point(433, 515);
            this.cmd_quit.Name = "cmd_quit";
            this.cmd_quit.Size = new System.Drawing.Size(82, 38);
            this.cmd_quit.TabIndex = 1;
            this.cmd_quit.Text = "Quit";
            this.cmd_quit.UseVisualStyleBackColor = true;
            this.cmd_quit.Click += new System.EventHandler(this.cmd_quit_Click);
            // 
            // cmd_browse
            // 
            this.cmd_browse.Location = new System.Drawing.Point(16, 515);
            this.cmd_browse.Name = "cmd_browse";
            this.cmd_browse.Size = new System.Drawing.Size(82, 38);
            this.cmd_browse.TabIndex = 2;
            this.cmd_browse.Text = "Browse";
            this.cmd_browse.UseVisualStyleBackColor = true;
            this.cmd_browse.Click += new System.EventHandler(this.cmd_browse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test Mouse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "...................";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Duration,
            this.Frequency,
            this.Time_Dealy});
            this.dataGridView1.Location = new System.Drawing.Point(16, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 148);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Num
            // 
            this.Num.HeaderText = "Number";
            this.Num.Name = "Num";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration (milisec)";
            this.Duration.Name = "Duration";
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            // 
            // Time_Dealy
            // 
            this.Time_Dealy.HeaderText = "Time Delay(milisec)";
            this.Time_Dealy.Name = "Time_Dealy";
            // 
            // cmd_graph
            // 
            this.cmd_graph.Location = new System.Drawing.Point(215, 515);
            this.cmd_graph.Name = "cmd_graph";
            this.cmd_graph.Size = new System.Drawing.Size(82, 38);
            this.cmd_graph.TabIndex = 8;
            this.cmd_graph.Text = "Graph";
            this.cmd_graph.UseVisualStyleBackColor = true;
            this.cmd_graph.Click += new System.EventHandler(this.cmd_graph_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Configuration File:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Description});
            this.dataGridView2.Location = new System.Drawing.Point(12, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(503, 240);
            this.dataGridView2.TabIndex = 10;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // impedance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 568);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmd_graph);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmd_browse);
            this.Controls.Add(this.cmd_quit);
            this.Controls.Add(this.cmd_measure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "impedance";
            this.Text = "Impedance measurement v1.0";
            this.Load += new System.EventHandler(this.impedance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_measure;
        private System.Windows.Forms.Button cmd_quit;
        private System.Windows.Forms.Button cmd_browse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmd_graph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Dealy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

