﻿namespace Wski_kvaser
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
            this.components = new System.ComponentModel.Container();
            this.cb_0 = new System.Windows.Forms.CheckBox();
            this.tb_canout_B = new System.Windows.Forms.TableLayoutPanel();
            this.uC_FFD0_B = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFA1_B = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFD1_B = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FF40_B = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFD2_B = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FF31_B = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFD3_B = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFCC_B = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFCA_B = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFCB_B = new Wski_kvaser.UC_CANMessageOut();
            this.tb_canout_A = new System.Windows.Forms.TableLayoutPanel();
            this.uC_FFD0_A = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFD1_A = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFD2_A = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFD3_A = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFCA_A = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFCB_A = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFCC_A = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FF31_A = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FF40_A = new Wski_kvaser.UC_CANMessageOut();
            this.uC_FFA1_A = new Wski_kvaser.UC_CANMessageOut();
            this.timer1_CanSEND = new System.Windows.Forms.Timer(this.components);
            this.btnToggleTimer = new System.Windows.Forms.Button();
            this.timer2_sysinfo = new System.Windows.Forms.Timer(this.components);
            this.rb_CU_A_intCtrl = new System.Windows.Forms.RadioButton();
            this.rb_CU_b_intCtrl = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_CuinCtrl = new System.Windows.Forms.GroupBox();
            this.gb_Aconfig = new System.Windows.Forms.GroupBox();
            this.rb_A_confPORT = new System.Windows.Forms.RadioButton();
            this.rb_A_confSTBD = new System.Windows.Forms.RadioButton();
            this.gb_Bconfig = new System.Windows.Forms.GroupBox();
            this.rb_B_confPORT = new System.Windows.Forms.RadioButton();
            this.rb_B_confSTBD = new System.Windows.Forms.RadioButton();
            this.cb_A_allowClutch = new System.Windows.Forms.CheckBox();
            this.cb_B_allowClutch = new System.Windows.Forms.CheckBox();
            this.gb_A_clutch_FBK = new System.Windows.Forms.GroupBox();
            this.rb_A_clutchFBK_DIS = new System.Windows.Forms.RadioButton();
            this.rb_A_clutchFBK_AHD = new System.Windows.Forms.RadioButton();
            this.rb_A_clutchFBK_AST = new System.Windows.Forms.RadioButton();
            this.gb_A_clutch_COM = new System.Windows.Forms.GroupBox();
            this.rb_A_clutchCOM_DIS = new System.Windows.Forms.RadioButton();
            this.rb_A_clutchCOM_AHD = new System.Windows.Forms.RadioButton();
            this.rb_A_clutchCOM_AST = new System.Windows.Forms.RadioButton();
            this.gb_B_clutch_COM = new System.Windows.Forms.GroupBox();
            this.rb_B_clutchCOM_DIS = new System.Windows.Forms.RadioButton();
            this.rb_B_clutchCOM_AHD = new System.Windows.Forms.RadioButton();
            this.rb_B_clutchCOM_AST = new System.Windows.Forms.RadioButton();
            this.gb_B_clutch_FBK = new System.Windows.Forms.GroupBox();
            this.rb_B_clutchFBK_DIS = new System.Windows.Forms.RadioButton();
            this.rb_B_clutchFBK_AHD = new System.Windows.Forms.RadioButton();
            this.rb_B_clutchFBK_AST = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_B_clutchCOM_DIS2 = new System.Windows.Forms.RadioButton();
            this.rb_B_clutchCOM_AHD2 = new System.Windows.Forms.RadioButton();
            this.rb_B_clutchCOM_AST2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_A_clutchCOM_DIS2 = new System.Windows.Forms.RadioButton();
            this.rb_A_clutchCOM_AHD2 = new System.Windows.Forms.RadioButton();
            this.rb_A_clutchCOM_AST2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_B_clutchFBK_DIS2 = new System.Windows.Forms.RadioButton();
            this.rb_B_clutchFBK_AHD2 = new System.Windows.Forms.RadioButton();
            this.rb_B_clutchFBK_AST2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_A_clutchFBK_DIS2 = new System.Windows.Forms.RadioButton();
            this.rb_A_clutchFBK_AHD2 = new System.Windows.Forms.RadioButton();
            this.rb_A_clutchFBK_AST2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_useInternal_A = new System.Windows.Forms.CheckBox();
            this.uC_AzimthSliders2 = new Wski_kvaser.UC_AzimthSliders();
            this.uC_SteerEnginSliders2 = new Wski_kvaser.UC_SteerEnginSliders();
            this.uC_AzimthSliders1 = new Wski_kvaser.UC_AzimthSliders();
            this.uC_SteerEnginSliders1 = new Wski_kvaser.UC_SteerEnginSliders();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_canout_B.SuspendLayout();
            this.tb_canout_A.SuspendLayout();
            this.gb_CuinCtrl.SuspendLayout();
            this.gb_Aconfig.SuspendLayout();
            this.gb_Bconfig.SuspendLayout();
            this.gb_A_clutch_FBK.SuspendLayout();
            this.gb_A_clutch_COM.SuspendLayout();
            this.gb_B_clutch_COM.SuspendLayout();
            this.gb_B_clutch_FBK.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_0
            // 
            this.cb_0.AutoSize = true;
            this.cb_0.Location = new System.Drawing.Point(34, 12);
            this.cb_0.Name = "cb_0";
            this.cb_0.Size = new System.Drawing.Size(162, 33);
            this.cb_0.TabIndex = 0;
            this.cb_0.Text = "checkBox1";
            this.cb_0.UseVisualStyleBackColor = true;
            // 
            // tb_canout_B
            // 
            this.tb_canout_B.ColumnCount = 1;
            this.tb_canout_B.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_canout_B.Controls.Add(this.uC_FFD0_B, 0, 0);
            this.tb_canout_B.Controls.Add(this.uC_FFA1_B, 0, 9);
            this.tb_canout_B.Controls.Add(this.uC_FFD1_B, 0, 1);
            this.tb_canout_B.Controls.Add(this.uC_FF40_B, 0, 8);
            this.tb_canout_B.Controls.Add(this.uC_FFD2_B, 0, 2);
            this.tb_canout_B.Controls.Add(this.uC_FF31_B, 0, 7);
            this.tb_canout_B.Controls.Add(this.uC_FFD3_B, 0, 3);
            this.tb_canout_B.Controls.Add(this.uC_FFCC_B, 0, 6);
            this.tb_canout_B.Controls.Add(this.uC_FFCA_B, 0, 4);
            this.tb_canout_B.Controls.Add(this.uC_FFCB_B, 0, 5);
            this.tb_canout_B.Location = new System.Drawing.Point(990, 95);
            this.tb_canout_B.Name = "tb_canout_B";
            this.tb_canout_B.RowCount = 14;
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_B.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tb_canout_B.Size = new System.Drawing.Size(800, 613);
            this.tb_canout_B.TabIndex = 2;
            // 
            // uC_FFD0_B
            // 
            this.uC_FFD0_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFD0_B.Location = new System.Drawing.Point(3, 3);
            this.uC_FFD0_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFD0_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFD0_B.Name = "uC_FFD0_B";
            this.uC_FFD0_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FFD0_B.TabIndex = 12;
            // 
            // uC_FFA1_B
            // 
            this.uC_FFA1_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFA1_B.Location = new System.Drawing.Point(3, 408);
            this.uC_FFA1_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFA1_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFA1_B.Name = "uC_FFA1_B";
            this.uC_FFA1_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FFA1_B.TabIndex = 21;
            // 
            // uC_FFD1_B
            // 
            this.uC_FFD1_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFD1_B.Location = new System.Drawing.Point(3, 48);
            this.uC_FFD1_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFD1_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFD1_B.Name = "uC_FFD1_B";
            this.uC_FFD1_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FFD1_B.TabIndex = 13;
            // 
            // uC_FF40_B
            // 
            this.uC_FF40_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FF40_B.Location = new System.Drawing.Point(3, 363);
            this.uC_FF40_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FF40_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FF40_B.Name = "uC_FF40_B";
            this.uC_FF40_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FF40_B.TabIndex = 20;
            // 
            // uC_FFD2_B
            // 
            this.uC_FFD2_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFD2_B.Location = new System.Drawing.Point(3, 93);
            this.uC_FFD2_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFD2_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFD2_B.Name = "uC_FFD2_B";
            this.uC_FFD2_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FFD2_B.TabIndex = 14;
            // 
            // uC_FF31_B
            // 
            this.uC_FF31_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FF31_B.Location = new System.Drawing.Point(3, 318);
            this.uC_FF31_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FF31_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FF31_B.Name = "uC_FF31_B";
            this.uC_FF31_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FF31_B.TabIndex = 19;
            // 
            // uC_FFD3_B
            // 
            this.uC_FFD3_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFD3_B.Location = new System.Drawing.Point(3, 138);
            this.uC_FFD3_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFD3_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFD3_B.Name = "uC_FFD3_B";
            this.uC_FFD3_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FFD3_B.TabIndex = 15;
            // 
            // uC_FFCC_B
            // 
            this.uC_FFCC_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFCC_B.Location = new System.Drawing.Point(3, 273);
            this.uC_FFCC_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFCC_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFCC_B.Name = "uC_FFCC_B";
            this.uC_FFCC_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FFCC_B.TabIndex = 18;
            // 
            // uC_FFCA_B
            // 
            this.uC_FFCA_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFCA_B.Location = new System.Drawing.Point(3, 183);
            this.uC_FFCA_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFCA_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFCA_B.Name = "uC_FFCA_B";
            this.uC_FFCA_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FFCA_B.TabIndex = 16;
            // 
            // uC_FFCB_B
            // 
            this.uC_FFCB_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFCB_B.Location = new System.Drawing.Point(3, 228);
            this.uC_FFCB_B.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFCB_B.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFCB_B.Name = "uC_FFCB_B";
            this.uC_FFCB_B.Size = new System.Drawing.Size(800, 40);
            this.uC_FFCB_B.TabIndex = 17;
            // 
            // tb_canout_A
            // 
            this.tb_canout_A.ColumnCount = 1;
            this.tb_canout_A.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_canout_A.Controls.Add(this.uC_FFD0_A, 0, 0);
            this.tb_canout_A.Controls.Add(this.uC_FFD1_A, 0, 1);
            this.tb_canout_A.Controls.Add(this.uC_FFD2_A, 0, 2);
            this.tb_canout_A.Controls.Add(this.uC_FFD3_A, 0, 3);
            this.tb_canout_A.Controls.Add(this.uC_FFCA_A, 0, 4);
            this.tb_canout_A.Controls.Add(this.uC_FFCB_A, 0, 5);
            this.tb_canout_A.Controls.Add(this.uC_FFCC_A, 0, 6);
            this.tb_canout_A.Controls.Add(this.uC_FF31_A, 0, 7);
            this.tb_canout_A.Controls.Add(this.uC_FF40_A, 0, 8);
            this.tb_canout_A.Controls.Add(this.uC_FFA1_A, 0, 9);
            this.tb_canout_A.Location = new System.Drawing.Point(34, 95);
            this.tb_canout_A.Name = "tb_canout_A";
            this.tb_canout_A.RowCount = 14;
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tb_canout_A.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tb_canout_A.Size = new System.Drawing.Size(800, 605);
            this.tb_canout_A.TabIndex = 22;
            // 
            // uC_FFD0_A
            // 
            this.uC_FFD0_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFD0_A.Location = new System.Drawing.Point(3, 3);
            this.uC_FFD0_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFD0_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFD0_A.Name = "uC_FFD0_A";
            this.uC_FFD0_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FFD0_A.TabIndex = 1;
            // 
            // uC_FFD1_A
            // 
            this.uC_FFD1_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFD1_A.Location = new System.Drawing.Point(3, 48);
            this.uC_FFD1_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFD1_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFD1_A.Name = "uC_FFD1_A";
            this.uC_FFD1_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FFD1_A.TabIndex = 3;
            // 
            // uC_FFD2_A
            // 
            this.uC_FFD2_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFD2_A.Location = new System.Drawing.Point(3, 93);
            this.uC_FFD2_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFD2_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFD2_A.Name = "uC_FFD2_A";
            this.uC_FFD2_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FFD2_A.TabIndex = 4;
            // 
            // uC_FFD3_A
            // 
            this.uC_FFD3_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFD3_A.Location = new System.Drawing.Point(3, 138);
            this.uC_FFD3_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFD3_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFD3_A.Name = "uC_FFD3_A";
            this.uC_FFD3_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FFD3_A.TabIndex = 5;
            // 
            // uC_FFCA_A
            // 
            this.uC_FFCA_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFCA_A.Location = new System.Drawing.Point(3, 183);
            this.uC_FFCA_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFCA_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFCA_A.Name = "uC_FFCA_A";
            this.uC_FFCA_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FFCA_A.TabIndex = 6;
            // 
            // uC_FFCB_A
            // 
            this.uC_FFCB_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFCB_A.Location = new System.Drawing.Point(3, 228);
            this.uC_FFCB_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFCB_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFCB_A.Name = "uC_FFCB_A";
            this.uC_FFCB_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FFCB_A.TabIndex = 7;
            // 
            // uC_FFCC_A
            // 
            this.uC_FFCC_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFCC_A.Location = new System.Drawing.Point(3, 273);
            this.uC_FFCC_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFCC_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFCC_A.Name = "uC_FFCC_A";
            this.uC_FFCC_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FFCC_A.TabIndex = 8;
            // 
            // uC_FF31_A
            // 
            this.uC_FF31_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FF31_A.Location = new System.Drawing.Point(3, 318);
            this.uC_FF31_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FF31_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FF31_A.Name = "uC_FF31_A";
            this.uC_FF31_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FF31_A.TabIndex = 9;
            // 
            // uC_FF40_A
            // 
            this.uC_FF40_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FF40_A.Location = new System.Drawing.Point(3, 363);
            this.uC_FF40_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FF40_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FF40_A.Name = "uC_FF40_A";
            this.uC_FF40_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FF40_A.TabIndex = 10;
            // 
            // uC_FFA1_A
            // 
            this.uC_FFA1_A.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.uC_FFA1_A.Location = new System.Drawing.Point(3, 408);
            this.uC_FFA1_A.MaximumSize = new System.Drawing.Size(800, 50);
            this.uC_FFA1_A.MinimumSize = new System.Drawing.Size(800, 40);
            this.uC_FFA1_A.Name = "uC_FFA1_A";
            this.uC_FFA1_A.Size = new System.Drawing.Size(800, 40);
            this.uC_FFA1_A.TabIndex = 11;
            // 
            // btnToggleTimer
            // 
            this.btnToggleTimer.Location = new System.Drawing.Point(1879, 115);
            this.btnToggleTimer.Name = "btnToggleTimer";
            this.btnToggleTimer.Size = new System.Drawing.Size(140, 68);
            this.btnToggleTimer.TabIndex = 27;
            this.btnToggleTimer.Text = "button1";
            this.btnToggleTimer.UseVisualStyleBackColor = true;
            // 
            // timer2_sysinfo
            // 
            this.timer2_sysinfo.Interval = 3000;
            // 
            // rb_CU_A_intCtrl
            // 
            this.rb_CU_A_intCtrl.AutoSize = true;
            this.rb_CU_A_intCtrl.Location = new System.Drawing.Point(33, 45);
            this.rb_CU_A_intCtrl.Name = "rb_CU_A_intCtrl";
            this.rb_CU_A_intCtrl.Size = new System.Drawing.Size(162, 33);
            this.rb_CU_A_intCtrl.TabIndex = 28;
            this.rb_CU_A_intCtrl.TabStop = true;
            this.rb_CU_A_intCtrl.Text = "CU A in ctrl";
            this.rb_CU_A_intCtrl.UseVisualStyleBackColor = true;
            // 
            // rb_CU_b_intCtrl
            // 
            this.rb_CU_b_intCtrl.AutoSize = true;
            this.rb_CU_b_intCtrl.Location = new System.Drawing.Point(33, 107);
            this.rb_CU_b_intCtrl.Name = "rb_CU_b_intCtrl";
            this.rb_CU_b_intCtrl.Size = new System.Drawing.Size(163, 33);
            this.rb_CU_b_intCtrl.TabIndex = 29;
            this.rb_CU_b_intCtrl.TabStop = true;
            this.rb_CU_b_intCtrl.Text = "CU B in ctrl";
            this.rb_CU_b_intCtrl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2039, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "unit in ctrl";
            // 
            // gb_CuinCtrl
            // 
            this.gb_CuinCtrl.Controls.Add(this.rb_CU_A_intCtrl);
            this.gb_CuinCtrl.Controls.Add(this.rb_CU_b_intCtrl);
            this.gb_CuinCtrl.Location = new System.Drawing.Point(1879, 205);
            this.gb_CuinCtrl.Name = "gb_CuinCtrl";
            this.gb_CuinCtrl.Size = new System.Drawing.Size(318, 182);
            this.gb_CuinCtrl.TabIndex = 31;
            this.gb_CuinCtrl.TabStop = false;
            this.gb_CuinCtrl.Text = "CU in Ctrl";
            // 
            // gb_Aconfig
            // 
            this.gb_Aconfig.Controls.Add(this.rb_A_confPORT);
            this.gb_Aconfig.Controls.Add(this.rb_A_confSTBD);
            this.gb_Aconfig.Location = new System.Drawing.Point(1879, 393);
            this.gb_Aconfig.Name = "gb_Aconfig";
            this.gb_Aconfig.Size = new System.Drawing.Size(236, 182);
            this.gb_Aconfig.TabIndex = 32;
            this.gb_Aconfig.TabStop = false;
            this.gb_Aconfig.Text = "A Config";
            // 
            // rb_A_confPORT
            // 
            this.rb_A_confPORT.AutoSize = true;
            this.rb_A_confPORT.Location = new System.Drawing.Point(33, 45);
            this.rb_A_confPORT.Name = "rb_A_confPORT";
            this.rb_A_confPORT.Size = new System.Drawing.Size(157, 33);
            this.rb_A_confPORT.TabIndex = 28;
            this.rb_A_confPORT.TabStop = true;
            this.rb_A_confPORT.Text = "A is PORT";
            this.rb_A_confPORT.UseVisualStyleBackColor = true;
            // 
            // rb_A_confSTBD
            // 
            this.rb_A_confSTBD.AutoSize = true;
            this.rb_A_confSTBD.Location = new System.Drawing.Point(33, 107);
            this.rb_A_confSTBD.Name = "rb_A_confSTBD";
            this.rb_A_confSTBD.Size = new System.Drawing.Size(154, 33);
            this.rb_A_confSTBD.TabIndex = 29;
            this.rb_A_confSTBD.TabStop = true;
            this.rb_A_confSTBD.Text = "A is STBD";
            this.rb_A_confSTBD.UseVisualStyleBackColor = true;
            // 
            // gb_Bconfig
            // 
            this.gb_Bconfig.Controls.Add(this.rb_B_confPORT);
            this.gb_Bconfig.Controls.Add(this.rb_B_confSTBD);
            this.gb_Bconfig.Location = new System.Drawing.Point(2121, 393);
            this.gb_Bconfig.Name = "gb_Bconfig";
            this.gb_Bconfig.Size = new System.Drawing.Size(219, 182);
            this.gb_Bconfig.TabIndex = 33;
            this.gb_Bconfig.TabStop = false;
            this.gb_Bconfig.Text = "B Config";
            // 
            // rb_B_confPORT
            // 
            this.rb_B_confPORT.AutoSize = true;
            this.rb_B_confPORT.Location = new System.Drawing.Point(33, 45);
            this.rb_B_confPORT.Name = "rb_B_confPORT";
            this.rb_B_confPORT.Size = new System.Drawing.Size(158, 33);
            this.rb_B_confPORT.TabIndex = 28;
            this.rb_B_confPORT.TabStop = true;
            this.rb_B_confPORT.Text = "B is PROT";
            this.rb_B_confPORT.UseVisualStyleBackColor = true;
            // 
            // rb_B_confSTBD
            // 
            this.rb_B_confSTBD.AutoSize = true;
            this.rb_B_confSTBD.Location = new System.Drawing.Point(33, 107);
            this.rb_B_confSTBD.Name = "rb_B_confSTBD";
            this.rb_B_confSTBD.Size = new System.Drawing.Size(155, 33);
            this.rb_B_confSTBD.TabIndex = 29;
            this.rb_B_confSTBD.TabStop = true;
            this.rb_B_confSTBD.Text = "B is STBD";
            this.rb_B_confSTBD.UseVisualStyleBackColor = true;
            // 
            // cb_A_allowClutch
            // 
            this.cb_A_allowClutch.AutoSize = true;
            this.cb_A_allowClutch.Location = new System.Drawing.Point(1875, 581);
            this.cb_A_allowClutch.Name = "cb_A_allowClutch";
            this.cb_A_allowClutch.Size = new System.Drawing.Size(225, 33);
            this.cb_A_allowClutch.TabIndex = 34;
            this.cb_A_allowClutch.Text = "A allow cltch eng";
            this.cb_A_allowClutch.UseVisualStyleBackColor = true;
            // 
            // cb_B_allowClutch
            // 
            this.cb_B_allowClutch.AutoSize = true;
            this.cb_B_allowClutch.Location = new System.Drawing.Point(2121, 581);
            this.cb_B_allowClutch.Name = "cb_B_allowClutch";
            this.cb_B_allowClutch.Size = new System.Drawing.Size(241, 33);
            this.cb_B_allowClutch.TabIndex = 35;
            this.cb_B_allowClutch.Text = "B allow clutch Eng";
            this.cb_B_allowClutch.UseVisualStyleBackColor = true;
            // 
            // gb_A_clutch_FBK
            // 
            this.gb_A_clutch_FBK.Controls.Add(this.rb_A_clutchFBK_DIS);
            this.gb_A_clutch_FBK.Controls.Add(this.rb_A_clutchFBK_AHD);
            this.gb_A_clutch_FBK.Controls.Add(this.rb_A_clutchFBK_AST);
            this.gb_A_clutch_FBK.Location = new System.Drawing.Point(1879, 902);
            this.gb_A_clutch_FBK.Name = "gb_A_clutch_FBK";
            this.gb_A_clutch_FBK.Size = new System.Drawing.Size(178, 232);
            this.gb_A_clutch_FBK.TabIndex = 36;
            this.gb_A_clutch_FBK.TabStop = false;
            this.gb_A_clutch_FBK.Text = "A clutch FBK";
            // 
            // rb_A_clutchFBK_DIS
            // 
            this.rb_A_clutchFBK_DIS.AutoSize = true;
            this.rb_A_clutchFBK_DIS.Location = new System.Drawing.Point(35, 162);
            this.rb_A_clutchFBK_DIS.Name = "rb_A_clutchFBK_DIS";
            this.rb_A_clutchFBK_DIS.Size = new System.Drawing.Size(83, 33);
            this.rb_A_clutchFBK_DIS.TabIndex = 30;
            this.rb_A_clutchFBK_DIS.TabStop = true;
            this.rb_A_clutchFBK_DIS.Text = "DIS";
            this.rb_A_clutchFBK_DIS.UseVisualStyleBackColor = true;
            // 
            // rb_A_clutchFBK_AHD
            // 
            this.rb_A_clutchFBK_AHD.AutoSize = true;
            this.rb_A_clutchFBK_AHD.Location = new System.Drawing.Point(33, 45);
            this.rb_A_clutchFBK_AHD.Name = "rb_A_clutchFBK_AHD";
            this.rb_A_clutchFBK_AHD.Size = new System.Drawing.Size(93, 33);
            this.rb_A_clutchFBK_AHD.TabIndex = 28;
            this.rb_A_clutchFBK_AHD.TabStop = true;
            this.rb_A_clutchFBK_AHD.Text = "AHD";
            this.rb_A_clutchFBK_AHD.UseVisualStyleBackColor = true;
            // 
            // rb_A_clutchFBK_AST
            // 
            this.rb_A_clutchFBK_AST.AutoSize = true;
            this.rb_A_clutchFBK_AST.Location = new System.Drawing.Point(33, 107);
            this.rb_A_clutchFBK_AST.Name = "rb_A_clutchFBK_AST";
            this.rb_A_clutchFBK_AST.Size = new System.Drawing.Size(91, 33);
            this.rb_A_clutchFBK_AST.TabIndex = 29;
            this.rb_A_clutchFBK_AST.TabStop = true;
            this.rb_A_clutchFBK_AST.Text = "AST";
            this.rb_A_clutchFBK_AST.UseVisualStyleBackColor = true;
            // 
            // gb_A_clutch_COM
            // 
            this.gb_A_clutch_COM.Controls.Add(this.rb_A_clutchCOM_DIS);
            this.gb_A_clutch_COM.Controls.Add(this.rb_A_clutchCOM_AHD);
            this.gb_A_clutch_COM.Controls.Add(this.rb_A_clutchCOM_AST);
            this.gb_A_clutch_COM.Location = new System.Drawing.Point(1875, 648);
            this.gb_A_clutch_COM.Name = "gb_A_clutch_COM";
            this.gb_A_clutch_COM.Size = new System.Drawing.Size(178, 232);
            this.gb_A_clutch_COM.TabIndex = 36;
            this.gb_A_clutch_COM.TabStop = false;
            this.gb_A_clutch_COM.Text = "A clutch COM";
            // 
            // rb_A_clutchCOM_DIS
            // 
            this.rb_A_clutchCOM_DIS.AutoSize = true;
            this.rb_A_clutchCOM_DIS.Location = new System.Drawing.Point(35, 162);
            this.rb_A_clutchCOM_DIS.Name = "rb_A_clutchCOM_DIS";
            this.rb_A_clutchCOM_DIS.Size = new System.Drawing.Size(83, 33);
            this.rb_A_clutchCOM_DIS.TabIndex = 30;
            this.rb_A_clutchCOM_DIS.TabStop = true;
            this.rb_A_clutchCOM_DIS.Text = "DIS";
            this.rb_A_clutchCOM_DIS.UseVisualStyleBackColor = true;
            // 
            // rb_A_clutchCOM_AHD
            // 
            this.rb_A_clutchCOM_AHD.AutoSize = true;
            this.rb_A_clutchCOM_AHD.Location = new System.Drawing.Point(33, 45);
            this.rb_A_clutchCOM_AHD.Name = "rb_A_clutchCOM_AHD";
            this.rb_A_clutchCOM_AHD.Size = new System.Drawing.Size(93, 33);
            this.rb_A_clutchCOM_AHD.TabIndex = 28;
            this.rb_A_clutchCOM_AHD.TabStop = true;
            this.rb_A_clutchCOM_AHD.Text = "AHD";
            this.rb_A_clutchCOM_AHD.UseVisualStyleBackColor = true;
            // 
            // rb_A_clutchCOM_AST
            // 
            this.rb_A_clutchCOM_AST.AutoSize = true;
            this.rb_A_clutchCOM_AST.Location = new System.Drawing.Point(33, 107);
            this.rb_A_clutchCOM_AST.Name = "rb_A_clutchCOM_AST";
            this.rb_A_clutchCOM_AST.Size = new System.Drawing.Size(91, 33);
            this.rb_A_clutchCOM_AST.TabIndex = 29;
            this.rb_A_clutchCOM_AST.TabStop = true;
            this.rb_A_clutchCOM_AST.Text = "AST";
            this.rb_A_clutchCOM_AST.UseVisualStyleBackColor = true;
            // 
            // gb_B_clutch_COM
            // 
            this.gb_B_clutch_COM.Controls.Add(this.rb_B_clutchCOM_DIS);
            this.gb_B_clutch_COM.Controls.Add(this.rb_B_clutchCOM_AHD);
            this.gb_B_clutch_COM.Controls.Add(this.rb_B_clutchCOM_AST);
            this.gb_B_clutch_COM.Location = new System.Drawing.Point(2131, 648);
            this.gb_B_clutch_COM.Name = "gb_B_clutch_COM";
            this.gb_B_clutch_COM.Size = new System.Drawing.Size(178, 232);
            this.gb_B_clutch_COM.TabIndex = 37;
            this.gb_B_clutch_COM.TabStop = false;
            this.gb_B_clutch_COM.Text = "B clutch COM";
            // 
            // rb_B_clutchCOM_DIS
            // 
            this.rb_B_clutchCOM_DIS.AutoSize = true;
            this.rb_B_clutchCOM_DIS.Location = new System.Drawing.Point(35, 162);
            this.rb_B_clutchCOM_DIS.Name = "rb_B_clutchCOM_DIS";
            this.rb_B_clutchCOM_DIS.Size = new System.Drawing.Size(83, 33);
            this.rb_B_clutchCOM_DIS.TabIndex = 30;
            this.rb_B_clutchCOM_DIS.TabStop = true;
            this.rb_B_clutchCOM_DIS.Text = "DIS";
            this.rb_B_clutchCOM_DIS.UseVisualStyleBackColor = true;
            // 
            // rb_B_clutchCOM_AHD
            // 
            this.rb_B_clutchCOM_AHD.AutoSize = true;
            this.rb_B_clutchCOM_AHD.Location = new System.Drawing.Point(33, 45);
            this.rb_B_clutchCOM_AHD.Name = "rb_B_clutchCOM_AHD";
            this.rb_B_clutchCOM_AHD.Size = new System.Drawing.Size(93, 33);
            this.rb_B_clutchCOM_AHD.TabIndex = 28;
            this.rb_B_clutchCOM_AHD.TabStop = true;
            this.rb_B_clutchCOM_AHD.Text = "AHD";
            this.rb_B_clutchCOM_AHD.UseVisualStyleBackColor = true;
            // 
            // rb_B_clutchCOM_AST
            // 
            this.rb_B_clutchCOM_AST.AutoSize = true;
            this.rb_B_clutchCOM_AST.Location = new System.Drawing.Point(33, 107);
            this.rb_B_clutchCOM_AST.Name = "rb_B_clutchCOM_AST";
            this.rb_B_clutchCOM_AST.Size = new System.Drawing.Size(91, 33);
            this.rb_B_clutchCOM_AST.TabIndex = 29;
            this.rb_B_clutchCOM_AST.TabStop = true;
            this.rb_B_clutchCOM_AST.Text = "AST";
            this.rb_B_clutchCOM_AST.UseVisualStyleBackColor = true;
            // 
            // gb_B_clutch_FBK
            // 
            this.gb_B_clutch_FBK.Controls.Add(this.rb_B_clutchFBK_DIS);
            this.gb_B_clutch_FBK.Controls.Add(this.rb_B_clutchFBK_AHD);
            this.gb_B_clutch_FBK.Controls.Add(this.rb_B_clutchFBK_AST);
            this.gb_B_clutch_FBK.Location = new System.Drawing.Point(2134, 902);
            this.gb_B_clutch_FBK.Name = "gb_B_clutch_FBK";
            this.gb_B_clutch_FBK.Size = new System.Drawing.Size(178, 232);
            this.gb_B_clutch_FBK.TabIndex = 38;
            this.gb_B_clutch_FBK.TabStop = false;
            this.gb_B_clutch_FBK.Text = "B clutch FBK";
            // 
            // rb_B_clutchFBK_DIS
            // 
            this.rb_B_clutchFBK_DIS.AutoSize = true;
            this.rb_B_clutchFBK_DIS.Location = new System.Drawing.Point(35, 162);
            this.rb_B_clutchFBK_DIS.Name = "rb_B_clutchFBK_DIS";
            this.rb_B_clutchFBK_DIS.Size = new System.Drawing.Size(83, 33);
            this.rb_B_clutchFBK_DIS.TabIndex = 30;
            this.rb_B_clutchFBK_DIS.TabStop = true;
            this.rb_B_clutchFBK_DIS.Text = "DIS";
            this.rb_B_clutchFBK_DIS.UseVisualStyleBackColor = true;
            // 
            // rb_B_clutchFBK_AHD
            // 
            this.rb_B_clutchFBK_AHD.AutoSize = true;
            this.rb_B_clutchFBK_AHD.Location = new System.Drawing.Point(33, 45);
            this.rb_B_clutchFBK_AHD.Name = "rb_B_clutchFBK_AHD";
            this.rb_B_clutchFBK_AHD.Size = new System.Drawing.Size(93, 33);
            this.rb_B_clutchFBK_AHD.TabIndex = 28;
            this.rb_B_clutchFBK_AHD.TabStop = true;
            this.rb_B_clutchFBK_AHD.Text = "AHD";
            this.rb_B_clutchFBK_AHD.UseVisualStyleBackColor = true;
            // 
            // rb_B_clutchFBK_AST
            // 
            this.rb_B_clutchFBK_AST.AutoSize = true;
            this.rb_B_clutchFBK_AST.Location = new System.Drawing.Point(33, 107);
            this.rb_B_clutchFBK_AST.Name = "rb_B_clutchFBK_AST";
            this.rb_B_clutchFBK_AST.Size = new System.Drawing.Size(91, 33);
            this.rb_B_clutchFBK_AST.TabIndex = 29;
            this.rb_B_clutchFBK_AST.TabStop = true;
            this.rb_B_clutchFBK_AST.Text = "AST";
            this.rb_B_clutchFBK_AST.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2059, 851);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "FFD1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_B_clutchCOM_DIS2);
            this.groupBox1.Controls.Add(this.rb_B_clutchCOM_AHD2);
            this.groupBox1.Controls.Add(this.rb_B_clutchCOM_AST2);
            this.groupBox1.Location = new System.Drawing.Point(2131, 1157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 156);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "B clutch COM";
            // 
            // rb_B_clutchCOM_DIS2
            // 
            this.rb_B_clutchCOM_DIS2.AutoSize = true;
            this.rb_B_clutchCOM_DIS2.Location = new System.Drawing.Point(33, 114);
            this.rb_B_clutchCOM_DIS2.Name = "rb_B_clutchCOM_DIS2";
            this.rb_B_clutchCOM_DIS2.Size = new System.Drawing.Size(83, 33);
            this.rb_B_clutchCOM_DIS2.TabIndex = 30;
            this.rb_B_clutchCOM_DIS2.TabStop = true;
            this.rb_B_clutchCOM_DIS2.Text = "DIS";
            this.rb_B_clutchCOM_DIS2.UseVisualStyleBackColor = true;
            // 
            // rb_B_clutchCOM_AHD2
            // 
            this.rb_B_clutchCOM_AHD2.AutoSize = true;
            this.rb_B_clutchCOM_AHD2.Location = new System.Drawing.Point(28, 34);
            this.rb_B_clutchCOM_AHD2.Name = "rb_B_clutchCOM_AHD2";
            this.rb_B_clutchCOM_AHD2.Size = new System.Drawing.Size(93, 33);
            this.rb_B_clutchCOM_AHD2.TabIndex = 28;
            this.rb_B_clutchCOM_AHD2.TabStop = true;
            this.rb_B_clutchCOM_AHD2.Text = "AHD";
            this.rb_B_clutchCOM_AHD2.UseVisualStyleBackColor = true;
            // 
            // rb_B_clutchCOM_AST2
            // 
            this.rb_B_clutchCOM_AST2.AutoSize = true;
            this.rb_B_clutchCOM_AST2.Location = new System.Drawing.Point(30, 73);
            this.rb_B_clutchCOM_AST2.Name = "rb_B_clutchCOM_AST2";
            this.rb_B_clutchCOM_AST2.Size = new System.Drawing.Size(91, 33);
            this.rb_B_clutchCOM_AST2.TabIndex = 29;
            this.rb_B_clutchCOM_AST2.TabStop = true;
            this.rb_B_clutchCOM_AST2.Text = "AST";
            this.rb_B_clutchCOM_AST2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_A_clutchCOM_DIS2);
            this.groupBox2.Controls.Add(this.rb_A_clutchCOM_AHD2);
            this.groupBox2.Controls.Add(this.rb_A_clutchCOM_AST2);
            this.groupBox2.Location = new System.Drawing.Point(1875, 1157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 156);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A clutch COM";
            // 
            // rb_A_clutchCOM_DIS2
            // 
            this.rb_A_clutchCOM_DIS2.AutoSize = true;
            this.rb_A_clutchCOM_DIS2.Location = new System.Drawing.Point(27, 114);
            this.rb_A_clutchCOM_DIS2.Name = "rb_A_clutchCOM_DIS2";
            this.rb_A_clutchCOM_DIS2.Size = new System.Drawing.Size(83, 33);
            this.rb_A_clutchCOM_DIS2.TabIndex = 30;
            this.rb_A_clutchCOM_DIS2.TabStop = true;
            this.rb_A_clutchCOM_DIS2.Text = "DIS";
            this.rb_A_clutchCOM_DIS2.UseVisualStyleBackColor = true;
            // 
            // rb_A_clutchCOM_AHD2
            // 
            this.rb_A_clutchCOM_AHD2.AutoSize = true;
            this.rb_A_clutchCOM_AHD2.Location = new System.Drawing.Point(25, 34);
            this.rb_A_clutchCOM_AHD2.Name = "rb_A_clutchCOM_AHD2";
            this.rb_A_clutchCOM_AHD2.Size = new System.Drawing.Size(93, 33);
            this.rb_A_clutchCOM_AHD2.TabIndex = 28;
            this.rb_A_clutchCOM_AHD2.TabStop = true;
            this.rb_A_clutchCOM_AHD2.Text = "AHD";
            this.rb_A_clutchCOM_AHD2.UseVisualStyleBackColor = true;
            // 
            // rb_A_clutchCOM_AST2
            // 
            this.rb_A_clutchCOM_AST2.AutoSize = true;
            this.rb_A_clutchCOM_AST2.Location = new System.Drawing.Point(27, 73);
            this.rb_A_clutchCOM_AST2.Name = "rb_A_clutchCOM_AST2";
            this.rb_A_clutchCOM_AST2.Size = new System.Drawing.Size(91, 33);
            this.rb_A_clutchCOM_AST2.TabIndex = 29;
            this.rb_A_clutchCOM_AST2.TabStop = true;
            this.rb_A_clutchCOM_AST2.Text = "AST";
            this.rb_A_clutchCOM_AST2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_B_clutchFBK_DIS2);
            this.groupBox3.Controls.Add(this.rb_B_clutchFBK_AHD2);
            this.groupBox3.Controls.Add(this.rb_B_clutchFBK_AST2);
            this.groupBox3.Location = new System.Drawing.Point(2131, 1319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 156);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "B clutch fbk";
            // 
            // rb_B_clutchFBK_DIS2
            // 
            this.rb_B_clutchFBK_DIS2.AutoSize = true;
            this.rb_B_clutchFBK_DIS2.Location = new System.Drawing.Point(33, 114);
            this.rb_B_clutchFBK_DIS2.Name = "rb_B_clutchFBK_DIS2";
            this.rb_B_clutchFBK_DIS2.Size = new System.Drawing.Size(83, 33);
            this.rb_B_clutchFBK_DIS2.TabIndex = 30;
            this.rb_B_clutchFBK_DIS2.TabStop = true;
            this.rb_B_clutchFBK_DIS2.Text = "DIS";
            this.rb_B_clutchFBK_DIS2.UseVisualStyleBackColor = true;
            // 
            // rb_B_clutchFBK_AHD2
            // 
            this.rb_B_clutchFBK_AHD2.AutoSize = true;
            this.rb_B_clutchFBK_AHD2.Location = new System.Drawing.Point(28, 34);
            this.rb_B_clutchFBK_AHD2.Name = "rb_B_clutchFBK_AHD2";
            this.rb_B_clutchFBK_AHD2.Size = new System.Drawing.Size(93, 33);
            this.rb_B_clutchFBK_AHD2.TabIndex = 28;
            this.rb_B_clutchFBK_AHD2.TabStop = true;
            this.rb_B_clutchFBK_AHD2.Text = "AHD";
            this.rb_B_clutchFBK_AHD2.UseVisualStyleBackColor = true;
            // 
            // rb_B_clutchFBK_AST2
            // 
            this.rb_B_clutchFBK_AST2.AutoSize = true;
            this.rb_B_clutchFBK_AST2.Location = new System.Drawing.Point(30, 73);
            this.rb_B_clutchFBK_AST2.Name = "rb_B_clutchFBK_AST2";
            this.rb_B_clutchFBK_AST2.Size = new System.Drawing.Size(91, 33);
            this.rb_B_clutchFBK_AST2.TabIndex = 29;
            this.rb_B_clutchFBK_AST2.TabStop = true;
            this.rb_B_clutchFBK_AST2.Text = "AST";
            this.rb_B_clutchFBK_AST2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_A_clutchFBK_DIS2);
            this.groupBox4.Controls.Add(this.rb_A_clutchFBK_AHD2);
            this.groupBox4.Controls.Add(this.rb_A_clutchFBK_AST2);
            this.groupBox4.Location = new System.Drawing.Point(1875, 1319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 156);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "A clutch fbk";
            // 
            // rb_A_clutchFBK_DIS2
            // 
            this.rb_A_clutchFBK_DIS2.AutoSize = true;
            this.rb_A_clutchFBK_DIS2.Location = new System.Drawing.Point(27, 114);
            this.rb_A_clutchFBK_DIS2.Name = "rb_A_clutchFBK_DIS2";
            this.rb_A_clutchFBK_DIS2.Size = new System.Drawing.Size(83, 33);
            this.rb_A_clutchFBK_DIS2.TabIndex = 30;
            this.rb_A_clutchFBK_DIS2.TabStop = true;
            this.rb_A_clutchFBK_DIS2.Text = "DIS";
            this.rb_A_clutchFBK_DIS2.UseVisualStyleBackColor = true;
            // 
            // rb_A_clutchFBK_AHD2
            // 
            this.rb_A_clutchFBK_AHD2.AutoSize = true;
            this.rb_A_clutchFBK_AHD2.Location = new System.Drawing.Point(25, 34);
            this.rb_A_clutchFBK_AHD2.Name = "rb_A_clutchFBK_AHD2";
            this.rb_A_clutchFBK_AHD2.Size = new System.Drawing.Size(93, 33);
            this.rb_A_clutchFBK_AHD2.TabIndex = 28;
            this.rb_A_clutchFBK_AHD2.TabStop = true;
            this.rb_A_clutchFBK_AHD2.Text = "AHD";
            this.rb_A_clutchFBK_AHD2.UseVisualStyleBackColor = true;
            // 
            // rb_A_clutchFBK_AST2
            // 
            this.rb_A_clutchFBK_AST2.AutoSize = true;
            this.rb_A_clutchFBK_AST2.Location = new System.Drawing.Point(27, 73);
            this.rb_A_clutchFBK_AST2.Name = "rb_A_clutchFBK_AST2";
            this.rb_A_clutchFBK_AST2.Size = new System.Drawing.Size(91, 33);
            this.rb_A_clutchFBK_AST2.TabIndex = 29;
            this.rb_A_clutchFBK_AST2.TabStop = true;
            this.rb_A_clutchFBK_AST2.Text = "AST";
            this.rb_A_clutchFBK_AST2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2059, 1301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "FF31";
            // 
            // cb_useInternal_A
            // 
            this.cb_useInternal_A.AutoSize = true;
            this.cb_useInternal_A.Location = new System.Drawing.Point(742, 1182);
            this.cb_useInternal_A.Name = "cb_useInternal_A";
            this.cb_useInternal_A.Size = new System.Drawing.Size(177, 33);
            this.cb_useInternal_A.TabIndex = 43;
            this.cb_useInternal_A.Text = "use arduino ";
            this.cb_useInternal_A.UseVisualStyleBackColor = true;
            // 
            // uC_AzimthSliders2
            // 
            this.uC_AzimthSliders2.Location = new System.Drawing.Point(952, 1260);
            this.uC_AzimthSliders2.Name = "uC_AzimthSliders2";
            this.uC_AzimthSliders2.SetTitle = null;
            this.uC_AzimthSliders2.Size = new System.Drawing.Size(800, 278);
            this.uC_AzimthSliders2.TabIndex = 26;
            // 
            // uC_SteerEnginSliders2
            // 
            this.uC_SteerEnginSliders2.Location = new System.Drawing.Point(972, 714);
            this.uC_SteerEnginSliders2.Name = "uC_SteerEnginSliders2";
            this.uC_SteerEnginSliders2.SetTitle = null;
            this.uC_SteerEnginSliders2.Size = new System.Drawing.Size(630, 480);
            this.uC_SteerEnginSliders2.TabIndex = 25;
            // 
            // uC_AzimthSliders1
            // 
            this.uC_AzimthSliders1.Location = new System.Drawing.Point(12, 1271);
            this.uC_AzimthSliders1.Name = "uC_AzimthSliders1";
            this.uC_AzimthSliders1.SetTitle = null;
            this.uC_AzimthSliders1.Size = new System.Drawing.Size(800, 278);
            this.uC_AzimthSliders1.TabIndex = 24;
            // 
            // uC_SteerEnginSliders1
            // 
            this.uC_SteerEnginSliders1.Location = new System.Drawing.Point(34, 706);
            this.uC_SteerEnginSliders1.Name = "uC_SteerEnginSliders1";
            this.uC_SteerEnginSliders1.SetTitle = null;
            this.uC_SteerEnginSliders1.Size = new System.Drawing.Size(630, 480);
            this.uC_SteerEnginSliders1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 810);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2480, 1595);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_useInternal_A);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_B_clutch_COM);
            this.Controls.Add(this.gb_A_clutch_COM);
            this.Controls.Add(this.gb_B_clutch_FBK);
            this.Controls.Add(this.gb_A_clutch_FBK);
            this.Controls.Add(this.cb_B_allowClutch);
            this.Controls.Add(this.cb_A_allowClutch);
            this.Controls.Add(this.gb_Bconfig);
            this.Controls.Add(this.gb_Aconfig);
            this.Controls.Add(this.gb_CuinCtrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToggleTimer);
            this.Controls.Add(this.uC_AzimthSliders2);
            this.Controls.Add(this.uC_SteerEnginSliders2);
            this.Controls.Add(this.uC_AzimthSliders1);
            this.Controls.Add(this.uC_SteerEnginSliders1);
            this.Controls.Add(this.tb_canout_A);
            this.Controls.Add(this.tb_canout_B);
            this.Controls.Add(this.cb_0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tb_canout_B.ResumeLayout(false);
            this.tb_canout_A.ResumeLayout(false);
            this.gb_CuinCtrl.ResumeLayout(false);
            this.gb_CuinCtrl.PerformLayout();
            this.gb_Aconfig.ResumeLayout(false);
            this.gb_Aconfig.PerformLayout();
            this.gb_Bconfig.ResumeLayout(false);
            this.gb_Bconfig.PerformLayout();
            this.gb_A_clutch_FBK.ResumeLayout(false);
            this.gb_A_clutch_FBK.PerformLayout();
            this.gb_A_clutch_COM.ResumeLayout(false);
            this.gb_A_clutch_COM.PerformLayout();
            this.gb_B_clutch_COM.ResumeLayout(false);
            this.gb_B_clutch_COM.PerformLayout();
            this.gb_B_clutch_FBK.ResumeLayout(false);
            this.gb_B_clutch_FBK.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_0;
        private UC_CANMessageOut uC_FFD0_A;
        private System.Windows.Forms.TableLayoutPanel tb_canout_B;
        private UC_CANMessageOut uC_FFD1_A;
        private UC_CANMessageOut uC_FFD3_A;
        private UC_CANMessageOut uC_FFD2_A;
        private UC_CANMessageOut uC_FFCB_A;
        private UC_CANMessageOut uC_FFCA_A;
        private UC_CANMessageOut uC_FFA1_A;
        private UC_CANMessageOut uC_FF40_A;
        private UC_CANMessageOut uC_FF31_A;
        private UC_CANMessageOut uC_FFCC_A;
        private UC_CANMessageOut uC_FFA1_B;
        private UC_CANMessageOut uC_FF40_B;
        private UC_CANMessageOut uC_FF31_B;
        private UC_CANMessageOut uC_FFCC_B;
        private UC_CANMessageOut uC_FFCB_B;
        private UC_CANMessageOut uC_FFCA_B;
        private UC_CANMessageOut uC_FFD3_B;
        private UC_CANMessageOut uC_FFD2_B;
        private UC_CANMessageOut uC_FFD1_B;
        private UC_CANMessageOut uC_FFD0_B;
        private System.Windows.Forms.TableLayoutPanel tb_canout_A;
        private UC_SteerEnginSliders uC_SteerEnginSliders1;
        private UC_AzimthSliders uC_AzimthSliders1;
        private UC_SteerEnginSliders uC_SteerEnginSliders2;
        private UC_AzimthSliders uC_AzimthSliders2;
        private System.Windows.Forms.Timer timer1_CanSEND;
        private System.Windows.Forms.Button btnToggleTimer;
        private System.Windows.Forms.Timer timer2_sysinfo;
        private System.Windows.Forms.RadioButton rb_CU_A_intCtrl;
        private System.Windows.Forms.RadioButton rb_CU_b_intCtrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_CuinCtrl;
        private System.Windows.Forms.GroupBox gb_Aconfig;
        private System.Windows.Forms.RadioButton rb_A_confPORT;
        private System.Windows.Forms.RadioButton rb_A_confSTBD;
        private System.Windows.Forms.GroupBox gb_Bconfig;
        private System.Windows.Forms.RadioButton rb_B_confPORT;
        private System.Windows.Forms.RadioButton rb_B_confSTBD;
        private System.Windows.Forms.CheckBox cb_A_allowClutch;
        private System.Windows.Forms.CheckBox cb_B_allowClutch;
        private System.Windows.Forms.GroupBox gb_A_clutch_FBK;
        private System.Windows.Forms.RadioButton rb_A_clutchFBK_AHD;
        private System.Windows.Forms.RadioButton rb_A_clutchFBK_AST;
        private System.Windows.Forms.RadioButton rb_A_clutchFBK_DIS;
        private System.Windows.Forms.GroupBox gb_A_clutch_COM;
        private System.Windows.Forms.RadioButton rb_A_clutchCOM_DIS;
        private System.Windows.Forms.RadioButton rb_A_clutchCOM_AHD;
        private System.Windows.Forms.RadioButton rb_A_clutchCOM_AST;
        private System.Windows.Forms.GroupBox gb_B_clutch_COM;
        private System.Windows.Forms.RadioButton rb_B_clutchCOM_DIS;
        private System.Windows.Forms.RadioButton rb_B_clutchCOM_AHD;
        private System.Windows.Forms.RadioButton rb_B_clutchCOM_AST;
        private System.Windows.Forms.GroupBox gb_B_clutch_FBK;
        private System.Windows.Forms.RadioButton rb_B_clutchFBK_DIS;
        private System.Windows.Forms.RadioButton rb_B_clutchFBK_AHD;
        private System.Windows.Forms.RadioButton rb_B_clutchFBK_AST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_B_clutchCOM_DIS2;
        private System.Windows.Forms.RadioButton rb_B_clutchCOM_AHD2;
        private System.Windows.Forms.RadioButton rb_B_clutchCOM_AST2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_A_clutchCOM_DIS2;
        private System.Windows.Forms.RadioButton rb_A_clutchCOM_AHD2;
        private System.Windows.Forms.RadioButton rb_A_clutchCOM_AST2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_B_clutchFBK_DIS2;
        private System.Windows.Forms.RadioButton rb_B_clutchFBK_AHD2;
        private System.Windows.Forms.RadioButton rb_B_clutchFBK_AST2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_A_clutchFBK_DIS2;
        private System.Windows.Forms.RadioButton rb_A_clutchFBK_AHD2;
        private System.Windows.Forms.RadioButton rb_A_clutchFBK_AST2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_useInternal_A;
        private System.Windows.Forms.Label label4;
    }
}

