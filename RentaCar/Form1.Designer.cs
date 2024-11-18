namespace RentaCar
{
    partial class Form1
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
            this.dgwcars = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbAractipi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbDurum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPlaka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxmarka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.GroupBox();
            this.tbxUpdateMarka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbUpdateAractipi = new System.Windows.Forms.TextBox();
            this.txbUpdateDurum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbUpdateModel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txbUpdatePlaka = new System.Windows.Forms.TextBox();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.bntdelete = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwcars)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Update.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwcars
            // 
            this.dgwcars.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgwcars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwcars.Location = new System.Drawing.Point(22, 3);
            this.dgwcars.Name = "dgwcars";
            this.dgwcars.RowHeadersWidth = 62;
            this.dgwcars.Size = new System.Drawing.Size(937, 308);
            this.dgwcars.TabIndex = 1;
            this.dgwcars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbAractipi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txbDurum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbPlaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxmarka);
            this.groupBox1.Controls.Add(this.tbxModel);
            this.groupBox1.Location = new System.Drawing.Point(3, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 413);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txbAractipi
            // 
            this.txbAractipi.Location = new System.Drawing.Point(89, 220);
            this.txbAractipi.Name = "txbAractipi";
            this.txbAractipi.Size = new System.Drawing.Size(123, 26);
            this.txbAractipi.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(33, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Plaka\r\n";
            // 
            // txbDurum
            // 
            this.txbDurum.Location = new System.Drawing.Point(89, 182);
            this.txbDurum.Name = "txbDurum";
            this.txbDurum.Size = new System.Drawing.Size(123, 26);
            this.txbDurum.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(15, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "AracTipi\r\n";
            // 
            // txbPlaka
            // 
            this.txbPlaka.Location = new System.Drawing.Point(89, 145);
            this.txbPlaka.Name = "txbPlaka";
            this.txbPlaka.Size = new System.Drawing.Size(123, 26);
            this.txbPlaka.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(19, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Durum";
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(89, 109);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(123, 26);
            this.tbxModel.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(33, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Model";
            // 
            // tbxmarka
            // 
            this.tbxmarka.Location = new System.Drawing.Point(89, 75);
            this.tbxmarka.Name = "tbxmarka";
            this.tbxmarka.Size = new System.Drawing.Size(123, 26);
            this.tbxmarka.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "AracTipi\r\n";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.CausesValidation = false;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(23, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 63);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka\r\n";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Update.Controls.Add(this.tbxUpdateMarka);
            this.Update.Controls.Add(this.label5);
            this.Update.Controls.Add(this.label4);
            this.Update.Controls.Add(this.label13);
            this.Update.Controls.Add(this.txbUpdateAractipi);
            this.Update.Controls.Add(this.txbUpdateDurum);
            this.Update.Controls.Add(this.label15);
            this.Update.Controls.Add(this.txbUpdateModel);
            this.Update.Controls.Add(this.label16);
            this.Update.Controls.Add(this.txbUpdatePlaka);
            this.Update.Controls.Add(this.bntUpdate);
            this.Update.Location = new System.Drawing.Point(273, 341);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(256, 413);
            this.Update.TabIndex = 3;
            this.Update.TabStop = false;
            // 
            // tbxUpdateMarka
            // 
            this.tbxUpdateMarka.Location = new System.Drawing.Point(78, 70);
            this.tbxUpdateMarka.Name = "tbxUpdateMarka";
            this.tbxUpdateMarka.Size = new System.Drawing.Size(123, 26);
            this.tbxUpdateMarka.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Marka\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "AracTipi\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(15, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Plaka\r\n";
            // 
            // txbUpdateAractipi
            // 
            this.txbUpdateAractipi.Location = new System.Drawing.Point(78, 217);
            this.txbUpdateAractipi.Name = "txbUpdateAractipi";
            this.txbUpdateAractipi.Size = new System.Drawing.Size(123, 26);
            this.txbUpdateAractipi.TabIndex = 14;
            // 
            // txbUpdateDurum
            // 
            this.txbUpdateDurum.Location = new System.Drawing.Point(78, 179);
            this.txbUpdateDurum.Name = "txbUpdateDurum";
            this.txbUpdateDurum.Size = new System.Drawing.Size(123, 26);
            this.txbUpdateDurum.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(10, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Durum";
            // 
            // txbUpdateModel
            // 
            this.txbUpdateModel.Location = new System.Drawing.Point(78, 106);
            this.txbUpdateModel.Name = "txbUpdateModel";
            this.txbUpdateModel.Size = new System.Drawing.Size(123, 26);
            this.txbUpdateModel.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(15, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Model";
            // 
            // txbUpdatePlaka
            // 
            this.txbUpdatePlaka.Location = new System.Drawing.Point(78, 144);
            this.txbUpdatePlaka.Name = "txbUpdatePlaka";
            this.txbUpdatePlaka.Size = new System.Drawing.Size(123, 26);
            this.txbUpdatePlaka.TabIndex = 9;
            // 
            // bntUpdate
            // 
            this.bntUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntUpdate.Location = new System.Drawing.Point(19, 338);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(204, 63);
            this.bntUpdate.TabIndex = 0;
            this.bntUpdate.Text = "UPDATE";
            this.bntUpdate.UseVisualStyleBackColor = false;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntdelete
            // 
            this.bntdelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.bntdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntdelete.Location = new System.Drawing.Point(575, 684);
            this.bntdelete.Name = "bntdelete";
            this.bntdelete.Size = new System.Drawing.Size(446, 58);
            this.bntdelete.TabIndex = 4;
            this.bntdelete.Text = "DELETE";
            this.bntdelete.UseVisualStyleBackColor = false;
            this.bntdelete.Click += new System.EventHandler(this.bntdelete_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(692, 420);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(213, 26);
            this.tbxSearch.TabIndex = 5;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "Search:\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1033, 828);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.bntdelete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwcars);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwcars)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Update.ResumeLayout(false);
            this.Update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwcars;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Update;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Button bntdelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbDurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPlaka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxmarka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbAractipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbUpdateAractipi;
        private System.Windows.Forms.TextBox txbUpdateDurum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbUpdateModel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txbUpdatePlaka;
        private System.Windows.Forms.TextBox tbxUpdateMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label6;
    }
}