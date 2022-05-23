
namespace WindowsFormsApp23
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPlayerID = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelNationality = new System.Windows.Forms.Label();
            this.labelTeam = new System.Windows.Forms.Label();
            this.labelTeamNumber = new System.Windows.Forms.Label();
            this.textBoxPlayerID = new System.Windows.Forms.TextBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.numericUpDownTeamNumber = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerLahir = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(12, 12);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(109, 61);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(227, 12);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(107, 61);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(472, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(105, 61);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(675, 12);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(113, 61);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(84, 383);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(250, 30);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(472, 383);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(248, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPlayerID
            // 
            this.labelPlayerID.AutoSize = true;
            this.labelPlayerID.Location = new System.Drawing.Point(81, 121);
            this.labelPlayerID.Name = "labelPlayerID";
            this.labelPlayerID.Size = new System.Drawing.Size(65, 17);
            this.labelPlayerID.TabIndex = 6;
            this.labelPlayerID.Text = "Player ID";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(81, 150);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(89, 17);
            this.labelPlayerName.TabIndex = 7;
            this.labelPlayerName.Text = "Player Name";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(81, 176);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(71, 17);
            this.labelBirthDate.TabIndex = 8;
            this.labelBirthDate.Text = "Birth Date";
            this.labelBirthDate.Click += new System.EventHandler(this.labelBirthDate_Click);
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(81, 202);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(74, 17);
            this.labelNationality.TabIndex = 9;
            this.labelNationality.Text = "Nationality";
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(81, 229);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(44, 17);
            this.labelTeam.TabIndex = 10;
            this.labelTeam.Text = "Team";
            // 
            // labelTeamNumber
            // 
            this.labelTeamNumber.AutoSize = true;
            this.labelTeamNumber.Location = new System.Drawing.Point(81, 257);
            this.labelTeamNumber.Name = "labelTeamNumber";
            this.labelTeamNumber.Size = new System.Drawing.Size(98, 17);
            this.labelTeamNumber.TabIndex = 11;
            this.labelTeamNumber.Text = "Team Number";
            // 
            // textBoxPlayerID
            // 
            this.textBoxPlayerID.Location = new System.Drawing.Point(188, 121);
            this.textBoxPlayerID.Name = "textBoxPlayerID";
            this.textBoxPlayerID.Size = new System.Drawing.Size(532, 22);
            this.textBoxPlayerID.TabIndex = 12;
            this.textBoxPlayerID.TextChanged += new System.EventHandler(this.textBoxPlayerID_TextChanged);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(188, 150);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(532, 22);
            this.textBoxPlayerName.TabIndex = 13;
            this.textBoxPlayerName.TextChanged += new System.EventHandler(this.textBoxPlayerName_TextChanged);
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(188, 202);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(532, 24);
            this.comboBoxNationality.TabIndex = 18;
            this.comboBoxNationality.SelectedIndexChanged += new System.EventHandler(this.comboBoxNationality_SelectedIndexChanged);
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(188, 226);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(532, 24);
            this.comboBoxTeam.TabIndex = 19;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeam_SelectedIndexChanged);
            // 
            // numericUpDownTeamNumber
            // 
            this.numericUpDownTeamNumber.Location = new System.Drawing.Point(188, 251);
            this.numericUpDownTeamNumber.Name = "numericUpDownTeamNumber";
            this.numericUpDownTeamNumber.Size = new System.Drawing.Size(532, 22);
            this.numericUpDownTeamNumber.TabIndex = 20;
            this.numericUpDownTeamNumber.ValueChanged += new System.EventHandler(this.numericUpDownTeamNumber_ValueChanged);
            // 
            // dateTimePickerLahir
            // 
            this.dateTimePickerLahir.Location = new System.Drawing.Point(188, 178);
            this.dateTimePickerLahir.Name = "dateTimePickerLahir";
            this.dateTimePickerLahir.Size = new System.Drawing.Size(532, 22);
            this.dateTimePickerLahir.TabIndex = 21;
            this.dateTimePickerLahir.ValueChanged += new System.EventHandler(this.dateTimePickerLahir_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerLahir);
            this.Controls.Add(this.numericUpDownTeamNumber);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.comboBoxNationality);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.textBoxPlayerID);
            this.Controls.Add(this.labelTeamNumber);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.labelNationality);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.labelPlayerID);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPlayerID;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.Label labelTeamNumber;
        private System.Windows.Forms.TextBox textBoxPlayerID;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.NumericUpDown numericUpDownTeamNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerLahir;
    }
}

