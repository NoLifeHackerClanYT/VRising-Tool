namespace VRising_Tool
{
    partial class VRising_Tool
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRising_Tool));
            this.MainFormBorder = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CheckLAM = new System.Windows.Forms.CheckBox();
            this.CheckSkill1 = new System.Windows.Forms.CheckBox();
            this.CheckSkill2 = new System.Windows.Forms.CheckBox();
            this.CheckSkill3 = new System.Windows.Forms.CheckBox();
            this.AutoSkill1 = new System.Windows.Forms.Timer(this.components);
            this.AutoSkill2 = new System.Windows.Forms.Timer(this.components);
            this.AutoSkill3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SkillCD1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SkillCD2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.SkillCD3 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.SkillKey1 = new System.Windows.Forms.Label();
            this.SkillKey2 = new System.Windows.Forms.Label();
            this.SkillKey3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SkillCD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillCD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillCD3)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormBorder
            // 
            this.MainFormBorder.BorderRadius = 6;
            this.MainFormBorder.ContainerControl = this;
            this.MainFormBorder.DockIndicatorTransparencyValue = 0.6D;
            this.MainFormBorder.DragEndTransparencyValue = 0.3D;
            this.MainFormBorder.DragForm = false;
            this.MainFormBorder.ResizeForm = false;
            this.MainFormBorder.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "VRising Tool";
            // 
            // CheckLAM
            // 
            this.CheckLAM.AutoSize = true;
            this.CheckLAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLAM.ForeColor = System.Drawing.Color.Red;
            this.CheckLAM.Location = new System.Drawing.Point(9, 67);
            this.CheckLAM.Name = "CheckLAM";
            this.CheckLAM.Size = new System.Drawing.Size(166, 19);
            this.CheckLAM.TabIndex = 3;
            this.CheckLAM.Text = "[F2] Lock Attack Mode";
            this.CheckLAM.UseVisualStyleBackColor = true;
            // 
            // CheckSkill1
            // 
            this.CheckSkill1.AutoSize = true;
            this.CheckSkill1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSkill1.ForeColor = System.Drawing.Color.Red;
            this.CheckSkill1.Location = new System.Drawing.Point(9, 126);
            this.CheckSkill1.Name = "CheckSkill1";
            this.CheckSkill1.Size = new System.Drawing.Size(126, 19);
            this.CheckSkill1.TabIndex = 4;
            this.CheckSkill1.Text = "[F3] Auto Skill 1";
            this.CheckSkill1.UseVisualStyleBackColor = true;
            // 
            // CheckSkill2
            // 
            this.CheckSkill2.AutoSize = true;
            this.CheckSkill2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSkill2.ForeColor = System.Drawing.Color.Red;
            this.CheckSkill2.Location = new System.Drawing.Point(9, 151);
            this.CheckSkill2.Name = "CheckSkill2";
            this.CheckSkill2.Size = new System.Drawing.Size(126, 19);
            this.CheckSkill2.TabIndex = 5;
            this.CheckSkill2.Text = "[F4] Auto Skill 2";
            this.CheckSkill2.UseVisualStyleBackColor = true;
            // 
            // CheckSkill3
            // 
            this.CheckSkill3.AutoSize = true;
            this.CheckSkill3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckSkill3.ForeColor = System.Drawing.Color.Red;
            this.CheckSkill3.Location = new System.Drawing.Point(9, 176);
            this.CheckSkill3.Name = "CheckSkill3";
            this.CheckSkill3.Size = new System.Drawing.Size(126, 19);
            this.CheckSkill3.TabIndex = 6;
            this.CheckSkill3.Text = "[F5] Auto Skill 3";
            this.CheckSkill3.UseVisualStyleBackColor = true;
            // 
            // AutoSkill1
            // 
            this.AutoSkill1.Interval = 1000;
            this.AutoSkill1.Tick += new System.EventHandler(this.AutoSkill1_Tick);
            // 
            // AutoSkill2
            // 
            this.AutoSkill2.Interval = 1000;
            this.AutoSkill2.Tick += new System.EventHandler(this.AutoSkill2_Tick);
            // 
            // AutoSkill3
            // 
            this.AutoSkill3.Interval = 1000;
            this.AutoSkill3.Tick += new System.EventHandler(this.AutoSkill3_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Macros";
            // 
            // SkillCD1
            // 
            this.SkillCD1.BackColor = System.Drawing.Color.Transparent;
            this.SkillCD1.BorderRadius = 3;
            this.SkillCD1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SkillCD1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SkillCD1.Location = new System.Drawing.Point(210, 126);
            this.SkillCD1.Name = "SkillCD1";
            this.SkillCD1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SkillCD1.Size = new System.Drawing.Size(69, 19);
            this.SkillCD1.TabIndex = 10;
            this.SkillCD1.TextOffset = new System.Drawing.Point(-5, 0);
            this.SkillCD1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SkillCD1.ValueChanged += new System.EventHandler(this.SkillCD1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(207, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cooldown";
            // 
            // SkillCD2
            // 
            this.SkillCD2.BackColor = System.Drawing.Color.Transparent;
            this.SkillCD2.BorderRadius = 3;
            this.SkillCD2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SkillCD2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SkillCD2.Location = new System.Drawing.Point(210, 151);
            this.SkillCD2.Name = "SkillCD2";
            this.SkillCD2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SkillCD2.Size = new System.Drawing.Size(69, 19);
            this.SkillCD2.TabIndex = 12;
            this.SkillCD2.TextOffset = new System.Drawing.Point(-5, 0);
            this.SkillCD2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SkillCD2.ValueChanged += new System.EventHandler(this.SkillCD2_ValueChanged);
            // 
            // SkillCD3
            // 
            this.SkillCD3.BackColor = System.Drawing.Color.Transparent;
            this.SkillCD3.BorderRadius = 3;
            this.SkillCD3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SkillCD3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SkillCD3.Location = new System.Drawing.Point(210, 176);
            this.SkillCD3.Name = "SkillCD3";
            this.SkillCD3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SkillCD3.Size = new System.Drawing.Size(69, 19);
            this.SkillCD3.TabIndex = 13;
            this.SkillCD3.TextOffset = new System.Drawing.Point(-5, 0);
            this.SkillCD3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SkillCD3.ValueChanged += new System.EventHandler(this.SkillCD3_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(144, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Key";
            // 
            // SkillKey1
            // 
            this.SkillKey1.AutoSize = true;
            this.SkillKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillKey1.ForeColor = System.Drawing.Color.White;
            this.SkillKey1.Location = new System.Drawing.Point(144, 129);
            this.SkillKey1.Name = "SkillKey1";
            this.SkillKey1.Size = new System.Drawing.Size(12, 16);
            this.SkillKey1.TabIndex = 15;
            this.SkillKey1.Text = "/";
            // 
            // SkillKey2
            // 
            this.SkillKey2.AutoSize = true;
            this.SkillKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillKey2.ForeColor = System.Drawing.Color.White;
            this.SkillKey2.Location = new System.Drawing.Point(144, 154);
            this.SkillKey2.Name = "SkillKey2";
            this.SkillKey2.Size = new System.Drawing.Size(12, 16);
            this.SkillKey2.TabIndex = 16;
            this.SkillKey2.Text = "/";
            // 
            // SkillKey3
            // 
            this.SkillKey3.AutoSize = true;
            this.SkillKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillKey3.ForeColor = System.Drawing.Color.White;
            this.SkillKey3.Location = new System.Drawing.Point(144, 176);
            this.SkillKey3.Name = "SkillKey3";
            this.SkillKey3.Size = new System.Drawing.Size(12, 16);
            this.SkillKey3.TabIndex = 17;
            this.SkillKey3.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(173, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "[F1] Hide Menu";
            // 
            // VRising_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(291, 207);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SkillKey3);
            this.Controls.Add(this.SkillKey2);
            this.Controls.Add(this.SkillKey1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SkillCD3);
            this.Controls.Add(this.SkillCD2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SkillCD1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckSkill3);
            this.Controls.Add(this.CheckSkill2);
            this.Controls.Add(this.CheckSkill1);
            this.Controls.Add(this.CheckLAM);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "VRising_Tool";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VRising Tool";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SkillCD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillCD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkillCD3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm MainFormBorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckLAM;
        private System.Windows.Forms.CheckBox CheckSkill3;
        private System.Windows.Forms.CheckBox CheckSkill2;
        private System.Windows.Forms.CheckBox CheckSkill1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer AutoSkill1;
        private System.Windows.Forms.Timer AutoSkill2;
        private System.Windows.Forms.Timer AutoSkill3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown SkillCD3;
        private Guna.UI2.WinForms.Guna2NumericUpDown SkillCD2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown SkillCD1;
        private System.Windows.Forms.Label SkillKey3;
        private System.Windows.Forms.Label SkillKey2;
        private System.Windows.Forms.Label SkillKey1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

