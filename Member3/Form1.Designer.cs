
namespace Member3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numofworkingdays = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MondaycheckBox = new System.Windows.Forms.CheckBox();
            this.TuesdaycheckBox = new System.Windows.Forms.CheckBox();
            this.WednesdaycheckBox = new System.Windows.Forms.CheckBox();
            this.FridaycheckBox = new System.Windows.Forms.CheckBox();
            this.ThursdaycheckBox = new System.Windows.Forms.CheckBox();
            this.SaturdaycheckBox = new System.Windows.Forms.CheckBox();
            this.SundaycheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Minutenumeric = new System.Windows.Forms.NumericUpDown();
            this.Hoursnumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.Updatebutton2 = new System.Windows.Forms.Button();
            this.Deletebutton3 = new System.Windows.Forms.Button();
            this.Clearbutton4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IDtextBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numofworkingdays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutenumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hoursnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding Working days and Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of Working Days";
            // 
            // numofworkingdays
            // 
            this.numofworkingdays.Location = new System.Drawing.Point(207, 81);
            this.numofworkingdays.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numofworkingdays.Name = "numofworkingdays";
            this.numofworkingdays.Size = new System.Drawing.Size(79, 27);
            this.numofworkingdays.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Working days";
            // 
            // MondaycheckBox
            // 
            this.MondaycheckBox.AutoSize = true;
            this.MondaycheckBox.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MondaycheckBox.Location = new System.Drawing.Point(207, 136);
            this.MondaycheckBox.Name = "MondaycheckBox";
            this.MondaycheckBox.Size = new System.Drawing.Size(100, 29);
            this.MondaycheckBox.TabIndex = 4;
            this.MondaycheckBox.Text = "Monday";
            this.MondaycheckBox.UseVisualStyleBackColor = true;
            // 
            // TuesdaycheckBox
            // 
            this.TuesdaycheckBox.AutoSize = true;
            this.TuesdaycheckBox.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TuesdaycheckBox.Location = new System.Drawing.Point(207, 182);
            this.TuesdaycheckBox.Name = "TuesdaycheckBox";
            this.TuesdaycheckBox.Size = new System.Drawing.Size(99, 29);
            this.TuesdaycheckBox.TabIndex = 5;
            this.TuesdaycheckBox.Text = "Tuesday";
            this.TuesdaycheckBox.UseVisualStyleBackColor = true;
            // 
            // WednesdaycheckBox
            // 
            this.WednesdaycheckBox.AutoSize = true;
            this.WednesdaycheckBox.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WednesdaycheckBox.Location = new System.Drawing.Point(207, 231);
            this.WednesdaycheckBox.Name = "WednesdaycheckBox";
            this.WednesdaycheckBox.Size = new System.Drawing.Size(127, 29);
            this.WednesdaycheckBox.TabIndex = 6;
            this.WednesdaycheckBox.Text = "Wednesday";
            this.WednesdaycheckBox.UseVisualStyleBackColor = true;
            // 
            // FridaycheckBox
            // 
            this.FridaycheckBox.AutoSize = true;
            this.FridaycheckBox.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FridaycheckBox.Location = new System.Drawing.Point(207, 328);
            this.FridaycheckBox.Name = "FridaycheckBox";
            this.FridaycheckBox.Size = new System.Drawing.Size(82, 29);
            this.FridaycheckBox.TabIndex = 7;
            this.FridaycheckBox.Text = "Friday";
            this.FridaycheckBox.UseVisualStyleBackColor = true;
            // 
            // ThursdaycheckBox
            // 
            this.ThursdaycheckBox.AutoSize = true;
            this.ThursdaycheckBox.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThursdaycheckBox.Location = new System.Drawing.Point(207, 279);
            this.ThursdaycheckBox.Name = "ThursdaycheckBox";
            this.ThursdaycheckBox.Size = new System.Drawing.Size(106, 29);
            this.ThursdaycheckBox.TabIndex = 8;
            this.ThursdaycheckBox.Text = "Thursday";
            this.ThursdaycheckBox.UseVisualStyleBackColor = true;
            // 
            // SaturdaycheckBox
            // 
            this.SaturdaycheckBox.AutoSize = true;
            this.SaturdaycheckBox.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaturdaycheckBox.Location = new System.Drawing.Point(341, 136);
            this.SaturdaycheckBox.Name = "SaturdaycheckBox";
            this.SaturdaycheckBox.Size = new System.Drawing.Size(104, 29);
            this.SaturdaycheckBox.TabIndex = 9;
            this.SaturdaycheckBox.Text = "Saturday";
            this.SaturdaycheckBox.UseVisualStyleBackColor = true;
            // 
            // SundaycheckBox
            // 
            this.SundaycheckBox.AutoSize = true;
            this.SundaycheckBox.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SundaycheckBox.Location = new System.Drawing.Point(341, 182);
            this.SundaycheckBox.Name = "SundaycheckBox";
            this.SundaycheckBox.Size = new System.Drawing.Size(93, 29);
            this.SundaycheckBox.TabIndex = 10;
            this.SundaycheckBox.Text = "Sunday";
            this.SundaycheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Working Time per day";
            // 
            // Minutenumeric
            // 
            this.Minutenumeric.Location = new System.Drawing.Point(404, 399);
            this.Minutenumeric.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Minutenumeric.Name = "Minutenumeric";
            this.Minutenumeric.Size = new System.Drawing.Size(79, 27);
            this.Minutenumeric.TabIndex = 12;
            // 
            // Hoursnumeric
            // 
            this.Hoursnumeric.Location = new System.Drawing.Point(210, 397);
            this.Hoursnumeric.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Hoursnumeric.Name = "Hoursnumeric";
            this.Hoursnumeric.Size = new System.Drawing.Size(79, 27);
            this.Hoursnumeric.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(515, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(312, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hours";
            // 
            // Addbutton1
            // 
            this.Addbutton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Addbutton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Addbutton1.Location = new System.Drawing.Point(50, 674);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(100, 40);
            this.Addbutton1.TabIndex = 16;
            this.Addbutton1.Text = "Add";
            this.Addbutton1.UseVisualStyleBackColor = false;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // Updatebutton2
            // 
            this.Updatebutton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Updatebutton2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Updatebutton2.Location = new System.Drawing.Point(246, 674);
            this.Updatebutton2.Name = "Updatebutton2";
            this.Updatebutton2.Size = new System.Drawing.Size(100, 40);
            this.Updatebutton2.TabIndex = 17;
            this.Updatebutton2.Text = "Update";
            this.Updatebutton2.UseVisualStyleBackColor = false;
            // 
            // Deletebutton3
            // 
            this.Deletebutton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.Deletebutton3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Deletebutton3.Location = new System.Drawing.Point(451, 674);
            this.Deletebutton3.Name = "Deletebutton3";
            this.Deletebutton3.Size = new System.Drawing.Size(100, 40);
            this.Deletebutton3.TabIndex = 18;
            this.Deletebutton3.Text = "Delete";
            this.Deletebutton3.UseVisualStyleBackColor = false;
            // 
            // Clearbutton4
            // 
            this.Clearbutton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clearbutton4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Clearbutton4.Location = new System.Drawing.Point(641, 674);
            this.Clearbutton4.Name = "Clearbutton4";
            this.Clearbutton4.Size = new System.Drawing.Size(100, 40);
            this.Clearbutton4.TabIndex = 19;
            this.Clearbutton4.Text = "Clear";
            this.Clearbutton4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(628, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(639, 526);
            this.dataGridView1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(628, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(698, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 27);
            this.textBox1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID";
            // 
            // IDtextBox2
            // 
            this.IDtextBox2.Location = new System.Drawing.Point(207, 39);
            this.IDtextBox2.Name = "IDtextBox2";
            this.IDtextBox2.ReadOnly = true;
            this.IDtextBox2.Size = new System.Drawing.Size(63, 27);
            this.IDtextBox2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 752);
            this.Controls.Add(this.IDtextBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clearbutton4);
            this.Controls.Add(this.Deletebutton3);
            this.Controls.Add(this.Updatebutton2);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Hoursnumeric);
            this.Controls.Add(this.Minutenumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SundaycheckBox);
            this.Controls.Add(this.SaturdaycheckBox);
            this.Controls.Add(this.ThursdaycheckBox);
            this.Controls.Add(this.FridaycheckBox);
            this.Controls.Add(this.WednesdaycheckBox);
            this.Controls.Add(this.TuesdaycheckBox);
            this.Controls.Add(this.MondaycheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numofworkingdays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numofworkingdays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minutenumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hoursnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numofworkingdays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox MondaycheckBox;
        private System.Windows.Forms.CheckBox TuesdaycheckBox;
        private System.Windows.Forms.CheckBox WednesdaycheckBox;
        private System.Windows.Forms.CheckBox FridaycheckBox;
        private System.Windows.Forms.CheckBox ThursdaycheckBox;
        private System.Windows.Forms.CheckBox SaturdaycheckBox;
        private System.Windows.Forms.CheckBox SundaycheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Minutenumeric;
        private System.Windows.Forms.NumericUpDown Hoursnumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Button Updatebutton2;
        private System.Windows.Forms.Button Deletebutton3;
        private System.Windows.Forms.Button Clearbutton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IDtextBox2;
    }
}

