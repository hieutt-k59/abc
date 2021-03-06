﻿namespace RBI.PRE.subForm.InputDataForm
{
    public partial class UCAssessmentInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateAssessmentDate = new DevExpress.XtraEditors.DateEdit();
            this.txtRiskAnalysisPeriod = new System.Windows.Forms.TextBox();
            this.txtAssessmentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkRiskLinksEquipmentRisk = new System.Windows.Forms.CheckBox();
            this.txtComponentName = new System.Windows.Forms.TextBox();
            this.txtAPIComponentType = new System.Windows.Forms.TextBox();
            this.txtComponentType = new System.Windows.Forms.TextBox();
            this.txtComponentNumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateComissionDate = new DevExpress.XtraEditors.DateEdit();
            this.txtProcessDesciption = new System.Windows.Forms.TextBox();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtFacility = new System.Windows.Forms.TextBox();
            this.txtSites = new System.Windows.Forms.TextBox();
            this.txtDesignCode = new System.Windows.Forms.TextBox();
            this.txtEquipmentType = new System.Windows.Forms.TextBox();
            this.txtEquipmentNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateAssessmentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAssessmentDate.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateComissionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateComissionDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 510);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assessment General Information ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 489);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dateAssessmentDate);
            this.groupBox2.Controls.Add(this.txtRiskAnalysisPeriod);
            this.groupBox2.Controls.Add(this.txtAssessmentName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 107);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assessment";
            // 
            // dateAssessmentDate
            // 
            this.dateAssessmentDate.EditValue = null;
            this.dateAssessmentDate.Location = new System.Drawing.Point(183, 47);
            this.dateAssessmentDate.Name = "dateAssessmentDate";
            this.dateAssessmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAssessmentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAssessmentDate.Size = new System.Drawing.Size(240, 20);
            this.dateAssessmentDate.TabIndex = 2;
            this.dateAssessmentDate.DateTimeChanged += new System.EventHandler(this.dateAssessmentDate_DateTimeChanged);
            this.dateAssessmentDate.EditValueChanged += new System.EventHandler(this.txtAssessmentName_TextChanged);
            this.dateAssessmentDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAssessmentName_KeyDown);
            this.dateAssessmentDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRiskAnalysisPeriod_KeyPress);
            // 
            // txtRiskAnalysisPeriod
            // 
            this.txtRiskAnalysisPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiskAnalysisPeriod.Location = new System.Drawing.Point(183, 73);
            this.txtRiskAnalysisPeriod.Name = "txtRiskAnalysisPeriod";
            this.txtRiskAnalysisPeriod.Size = new System.Drawing.Size(120, 22);
            this.txtRiskAnalysisPeriod.TabIndex = 3;
            this.txtRiskAnalysisPeriod.Text = "36";
            this.txtRiskAnalysisPeriod.TextChanged += new System.EventHandler(this.txtRiskAnalysisPeriod_TextChanged);
            this.txtRiskAnalysisPeriod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAssessmentName_KeyDown);
            this.txtRiskAnalysisPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRiskAnalysisPeriod_KeyPress);
            // 
            // txtAssessmentName
            // 
            this.txtAssessmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssessmentName.Location = new System.Drawing.Point(183, 22);
            this.txtAssessmentName.Name = "txtAssessmentName";
            this.txtAssessmentName.Size = new System.Drawing.Size(240, 22);
            this.txtAssessmentName.TabIndex = 1;
            this.txtAssessmentName.TextChanged += new System.EventHandler(this.txtAssessmentName_TextChanged);
            this.txtAssessmentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAssessmentName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Risk Analysis Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Assessment Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chkRiskLinksEquipmentRisk);
            this.groupBox4.Controls.Add(this.txtComponentName);
            this.groupBox4.Controls.Add(this.txtAPIComponentType);
            this.groupBox4.Controls.Add(this.txtComponentType);
            this.groupBox4.Controls.Add(this.txtComponentNumber);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 351);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 134);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Component";
            // 
            // chkRiskLinksEquipmentRisk
            // 
            this.chkRiskLinksEquipmentRisk.AutoSize = true;
            this.chkRiskLinksEquipmentRisk.Enabled = false;
            this.chkRiskLinksEquipmentRisk.Location = new System.Drawing.Point(183, 112);
            this.chkRiskLinksEquipmentRisk.Name = "chkRiskLinksEquipmentRisk";
            this.chkRiskLinksEquipmentRisk.Size = new System.Drawing.Size(15, 14);
            this.chkRiskLinksEquipmentRisk.TabIndex = 4;
            this.chkRiskLinksEquipmentRisk.UseVisualStyleBackColor = true;
            this.chkRiskLinksEquipmentRisk.CheckedChanged += new System.EventHandler(this.txtAssessmentName_TextChanged);
            // 
            // txtComponentName
            // 
            this.txtComponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComponentName.Location = new System.Drawing.Point(183, 85);
            this.txtComponentName.Name = "txtComponentName";
            this.txtComponentName.ReadOnly = true;
            this.txtComponentName.Size = new System.Drawing.Size(240, 22);
            this.txtComponentName.TabIndex = 1;
            // 
            // txtAPIComponentType
            // 
            this.txtAPIComponentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPIComponentType.Location = new System.Drawing.Point(183, 61);
            this.txtAPIComponentType.Name = "txtAPIComponentType";
            this.txtAPIComponentType.ReadOnly = true;
            this.txtAPIComponentType.Size = new System.Drawing.Size(240, 22);
            this.txtAPIComponentType.TabIndex = 1;
            // 
            // txtComponentType
            // 
            this.txtComponentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComponentType.Location = new System.Drawing.Point(183, 37);
            this.txtComponentType.Name = "txtComponentType";
            this.txtComponentType.ReadOnly = true;
            this.txtComponentType.Size = new System.Drawing.Size(240, 22);
            this.txtComponentType.TabIndex = 1;
            // 
            // txtComponentNumber
            // 
            this.txtComponentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComponentNumber.Location = new System.Drawing.Point(183, 14);
            this.txtComponentNumber.Name = "txtComponentNumber";
            this.txtComponentNumber.ReadOnly = true;
            this.txtComponentNumber.Size = new System.Drawing.Size(240, 22);
            this.txtComponentNumber.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Risk Links to Equipment Risk";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Component Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "API Component Type";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Component Type";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 15);
            this.label23.TabIndex = 0;
            this.label23.Text = "Component Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dateComissionDate);
            this.groupBox3.Controls.Add(this.txtProcessDesciption);
            this.groupBox3.Controls.Add(this.txtEquipmentName);
            this.groupBox3.Controls.Add(this.txtManufacturer);
            this.groupBox3.Controls.Add(this.txtFacility);
            this.groupBox3.Controls.Add(this.txtSites);
            this.groupBox3.Controls.Add(this.txtDesignCode);
            this.groupBox3.Controls.Add(this.txtEquipmentType);
            this.groupBox3.Controls.Add(this.txtEquipmentNumber);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 229);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equipment";
            // 
            // dateComissionDate
            // 
            this.dateComissionDate.EditValue = null;
            this.dateComissionDate.Location = new System.Drawing.Point(183, 153);
            this.dateComissionDate.Name = "dateComissionDate";
            this.dateComissionDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateComissionDate.Properties.Appearance.Options.UseFont = true;
            this.dateComissionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateComissionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateComissionDate.Properties.ReadOnly = true;
            this.dateComissionDate.Size = new System.Drawing.Size(240, 22);
            this.dateComissionDate.TabIndex = 2;
            // 
            // txtProcessDesciption
            // 
            this.txtProcessDesciption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessDesciption.Location = new System.Drawing.Point(183, 200);
            this.txtProcessDesciption.Name = "txtProcessDesciption";
            this.txtProcessDesciption.ReadOnly = true;
            this.txtProcessDesciption.Size = new System.Drawing.Size(240, 22);
            this.txtProcessDesciption.TabIndex = 1;
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentName.Location = new System.Drawing.Point(183, 176);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.ReadOnly = true;
            this.txtEquipmentName.Size = new System.Drawing.Size(240, 22);
            this.txtEquipmentName.TabIndex = 1;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(183, 130);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(240, 22);
            this.txtManufacturer.TabIndex = 1;
            // 
            // txtFacility
            // 
            this.txtFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacility.Location = new System.Drawing.Point(183, 106);
            this.txtFacility.Name = "txtFacility";
            this.txtFacility.ReadOnly = true;
            this.txtFacility.Size = new System.Drawing.Size(240, 22);
            this.txtFacility.TabIndex = 1;
            // 
            // txtSites
            // 
            this.txtSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSites.Location = new System.Drawing.Point(183, 82);
            this.txtSites.Name = "txtSites";
            this.txtSites.ReadOnly = true;
            this.txtSites.Size = new System.Drawing.Size(240, 22);
            this.txtSites.TabIndex = 1;
            // 
            // txtDesignCode
            // 
            this.txtDesignCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignCode.Location = new System.Drawing.Point(183, 59);
            this.txtDesignCode.Name = "txtDesignCode";
            this.txtDesignCode.ReadOnly = true;
            this.txtDesignCode.Size = new System.Drawing.Size(240, 22);
            this.txtDesignCode.TabIndex = 1;
            // 
            // txtEquipmentType
            // 
            this.txtEquipmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentType.Location = new System.Drawing.Point(183, 35);
            this.txtEquipmentType.Name = "txtEquipmentType";
            this.txtEquipmentType.ReadOnly = true;
            this.txtEquipmentType.Size = new System.Drawing.Size(240, 22);
            this.txtEquipmentType.TabIndex = 1;
            // 
            // txtEquipmentNumber
            // 
            this.txtEquipmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentNumber.Location = new System.Drawing.Point(183, 11);
            this.txtEquipmentNumber.Name = "txtEquipmentNumber";
            this.txtEquipmentNumber.ReadOnly = true;
            this.txtEquipmentNumber.Size = new System.Drawing.Size(240, 22);
            this.txtEquipmentNumber.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Process Desciption";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Equipment Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Commission Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Manufacturer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Facility";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sites";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Design code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Equipment Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Equipment Number";
            // 
            // UCAssessmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCAssessmentInfo";
            this.Size = new System.Drawing.Size(445, 517);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateAssessmentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAssessmentDate.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateComissionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateComissionDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAssessmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEquipmentNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRiskAnalysisPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkRiskLinksEquipmentRisk;
        private System.Windows.Forms.TextBox txtComponentName;
        private System.Windows.Forms.TextBox txtAPIComponentType;
        private System.Windows.Forms.TextBox txtComponentType;
        private System.Windows.Forms.TextBox txtComponentNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtProcessDesciption;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtFacility;
        private System.Windows.Forms.TextBox txtSites;
        private System.Windows.Forms.TextBox txtDesignCode;
        private System.Windows.Forms.TextBox txtEquipmentType;
        private DevExpress.XtraEditors.DateEdit dateAssessmentDate;
        private DevExpress.XtraEditors.DateEdit dateComissionDate;
        private System.Windows.Forms.Panel panel1;
    }
}
