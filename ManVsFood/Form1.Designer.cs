﻿namespace ManVsFood
{
    partial class Form_MVF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MVF));
            this.lb_Items = new System.Windows.Forms.ListBox();
            this.lb_Description = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ChallengeTime = new System.Windows.Forms.Label();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_MVF = new System.Windows.Forms.Label();
            this.lbl_ChallengeStatic = new System.Windows.Forms.Label();
            this.lbl_DescribeStatic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Items
            // 
            this.lb_Items.DisplayMember = "challengename";
            this.lb_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Items.FormattingEnabled = true;
            this.lb_Items.ItemHeight = 17;
            this.lb_Items.Location = new System.Drawing.Point(12, 146);
            this.lb_Items.Name = "lb_Items";
            this.lb_Items.Size = new System.Drawing.Size(283, 616);
            this.lb_Items.TabIndex = 0;
            this.lb_Items.SelectedIndexChanged += new System.EventHandler(this.lb_Items_SelectedIndexChanged);
            // 
            // lb_Description
            // 
            this.lb_Description.FormattingEnabled = true;
            this.lb_Description.ItemHeight = 24;
            this.lb_Description.Location = new System.Drawing.Point(481, 146);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(283, 628);
            this.lb_Description.TabIndex = 1;
            this.lb_Description.SelectedIndexChanged += new System.EventHandler(this.lb_AddedItems_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(334, 371);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 44);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(334, 439);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(110, 44);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(334, 510);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(110, 44);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(1360, 802);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(110, 44);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1360, 852);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(110, 44);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(830, 146);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(640, 640);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 812);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Challenge Duration:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(883, 861);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cost of Failure:";
            // 
            // lbl_ChallengeTime
            // 
            this.lbl_ChallengeTime.AutoSize = true;
            this.lbl_ChallengeTime.Location = new System.Drawing.Point(1103, 812);
            this.lbl_ChallengeTime.Name = "lbl_ChallengeTime";
            this.lbl_ChallengeTime.Size = new System.Drawing.Size(0, 25);
            this.lbl_ChallengeTime.TabIndex = 10;
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.Location = new System.Drawing.Point(1103, 861);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(0, 25);
            this.lbl_Cost.TabIndex = 11;
            // 
            // lbl_MVF
            // 
            this.lbl_MVF.AutoSize = true;
            this.lbl_MVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MVF.Location = new System.Drawing.Point(970, 33);
            this.lbl_MVF.Name = "lbl_MVF";
            this.lbl_MVF.Size = new System.Drawing.Size(416, 74);
            this.lbl_MVF.TabIndex = 12;
            this.lbl_MVF.Text = "Man Vs Food";
            // 
            // lbl_ChallengeStatic
            // 
            this.lbl_ChallengeStatic.AutoSize = true;
            this.lbl_ChallengeStatic.Location = new System.Drawing.Point(12, 108);
            this.lbl_ChallengeStatic.Name = "lbl_ChallengeStatic";
            this.lbl_ChallengeStatic.Size = new System.Drawing.Size(177, 25);
            this.lbl_ChallengeStatic.TabIndex = 13;
            this.lbl_ChallengeStatic.Text = "Select a Challenge";
            // 
            // lbl_DescribeStatic
            // 
            this.lbl_DescribeStatic.AutoSize = true;
            this.lbl_DescribeStatic.Location = new System.Drawing.Point(476, 108);
            this.lbl_DescribeStatic.Name = "lbl_DescribeStatic";
            this.lbl_DescribeStatic.Size = new System.Drawing.Size(109, 25);
            this.lbl_DescribeStatic.TabIndex = 14;
            this.lbl_DescribeStatic.Text = "Description";
            // 
            // Form_MVF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1576, 1016);
            this.Controls.Add(this.lbl_DescribeStatic);
            this.Controls.Add(this.lbl_ChallengeStatic);
            this.Controls.Add(this.lbl_MVF);
            this.Controls.Add(this.lbl_Cost);
            this.Controls.Add(this.lbl_ChallengeTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.lb_Items);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_MVF";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Man Vs Food";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Items;
        private System.Windows.Forms.ListBox lb_Description;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ChallengeTime;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lbl_MVF;
        private System.Windows.Forms.Label lbl_ChallengeStatic;
        private System.Windows.Forms.Label lbl_DescribeStatic;
    }
}

