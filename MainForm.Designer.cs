namespace DiabetesPredictionWinForms
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            lblPregnancies = new Label();
            txtPregnancies = new TextBox();
            lblGlucose = new Label();
            txtGlucose = new TextBox();
            lblBloodPressure = new Label();
            txtBloodPressure = new TextBox();
            lblSkinThickness = new Label();
            txtSkinThickness = new TextBox();
            lblInsulin = new Label();
            txtInsulin = new TextBox();
            lblBMI = new Label();
            txtBMI = new TextBox();
            lblDiabetesPedigreeFunction = new Label();
            txtDiabetesPedigreeFunction = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            btnPredict = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblPregnancies
            // 
            lblPregnancies.AutoSize = true;
            lblPregnancies.Location = new Point(12, 20);
            lblPregnancies.Name = "lblPregnancies";
            lblPregnancies.Size = new Size(91, 20);
            lblPregnancies.TabIndex = 0;
            lblPregnancies.Text = "Pregnancies:";
            // 
            // txtPregnancies
            // 
            txtPregnancies.Location = new Point(120, 17);
            txtPregnancies.Name = "txtPregnancies";
            txtPregnancies.Size = new Size(100, 27);
            txtPregnancies.TabIndex = 1;
            // 
            // lblGlucose
            // 
            lblGlucose.AutoSize = true;
            lblGlucose.Location = new Point(12, 50);
            lblGlucose.Name = "lblGlucose";
            lblGlucose.Size = new Size(64, 20);
            lblGlucose.TabIndex = 2;
            lblGlucose.Text = "Glucose:";
            // 
            // txtGlucose
            // 
            txtGlucose.Location = new Point(120, 47);
            txtGlucose.Name = "txtGlucose";
            txtGlucose.Size = new Size(100, 27);
            txtGlucose.TabIndex = 3;
            // 
            // lblBloodPressure
            // 
            lblBloodPressure.AutoSize = true;
            lblBloodPressure.Location = new Point(12, 80);
            lblBloodPressure.Name = "lblBloodPressure";
            lblBloodPressure.Size = new Size(110, 20);
            lblBloodPressure.TabIndex = 4;
            lblBloodPressure.Text = "Blood Pressure:";
            // 
            // txtBloodPressure
            // 
            txtBloodPressure.Location = new Point(120, 77);
            txtBloodPressure.Name = "txtBloodPressure";
            txtBloodPressure.Size = new Size(100, 27);
            txtBloodPressure.TabIndex = 5;
            // 
            // lblSkinThickness
            // 
            lblSkinThickness.AutoSize = true;
            lblSkinThickness.Location = new Point(12, 110);
            lblSkinThickness.Name = "lblSkinThickness";
            lblSkinThickness.Size = new Size(105, 20);
            lblSkinThickness.TabIndex = 6;
            lblSkinThickness.Text = "Skin Thickness:";
            // 
            // txtSkinThickness
            // 
            txtSkinThickness.Location = new Point(120, 107);
            txtSkinThickness.Name = "txtSkinThickness";
            txtSkinThickness.Size = new Size(100, 27);
            txtSkinThickness.TabIndex = 7;
            // 
            // lblInsulin
            // 
            lblInsulin.AutoSize = true;
            lblInsulin.Location = new Point(12, 140);
            lblInsulin.Name = "lblInsulin";
            lblInsulin.Size = new Size(54, 20);
            lblInsulin.TabIndex = 8;
            lblInsulin.Text = "Insulin:";
            // 
            // txtInsulin
            // 
            txtInsulin.Location = new Point(120, 137);
            txtInsulin.Name = "txtInsulin";
            txtInsulin.Size = new Size(100, 27);
            txtInsulin.TabIndex = 9;
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Location = new Point(12, 170);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(38, 20);
            lblBMI.TabIndex = 10;
            lblBMI.Text = "BMI:";
            // 
            // txtBMI
            // 
            txtBMI.Location = new Point(120, 167);
            txtBMI.Name = "txtBMI";
            txtBMI.Size = new Size(100, 27);
            txtBMI.TabIndex = 11;
            // 
            // lblDiabetesPedigreeFunction
            // 
            lblDiabetesPedigreeFunction.AutoSize = true;
            lblDiabetesPedigreeFunction.Location = new Point(12, 200);
            lblDiabetesPedigreeFunction.Name = "lblDiabetesPedigreeFunction";
            lblDiabetesPedigreeFunction.Size = new Size(193, 20);
            lblDiabetesPedigreeFunction.TabIndex = 12;
            lblDiabetesPedigreeFunction.Text = "Diabetes Pedigree Function:";
            // 
            // txtDiabetesPedigreeFunction
            // 
            txtDiabetesPedigreeFunction.Location = new Point(248, 193);
            txtDiabetesPedigreeFunction.Name = "txtDiabetesPedigreeFunction";
            txtDiabetesPedigreeFunction.Size = new Size(100, 27);
            txtDiabetesPedigreeFunction.TabIndex = 13;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(12, 230);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 14;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(120, 227);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 27);
            txtAge.TabIndex = 15;
            // 
            // btnPredict
            // 
            btnPredict.Location = new Point(186, 290);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(100, 23);
            btnPredict.TabIndex = 16;
            btnPredict.Text = "Predict";
            btnPredict.UseVisualStyleBackColor = true;
            btnPredict.Click += btnPredict_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 290);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 17;
            // 
            // MainForm
            // 
            ClientSize = new Size(442, 366);
            Controls.Add(lblResult);
            Controls.Add(btnPredict);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtDiabetesPedigreeFunction);
            Controls.Add(lblDiabetesPedigreeFunction);
            Controls.Add(txtBMI);
            Controls.Add(lblBMI);
            Controls.Add(txtInsulin);
            Controls.Add(lblInsulin);
            Controls.Add(txtSkinThickness);
            Controls.Add(lblSkinThickness);
            Controls.Add(txtBloodPressure);
            Controls.Add(lblBloodPressure);
            Controls.Add(txtGlucose);
            Controls.Add(lblGlucose);
            Controls.Add(txtPregnancies);
            Controls.Add(lblPregnancies);
            Name = "MainForm";
            Text = "Diabetes Prediction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPregnancies;
        private System.Windows.Forms.TextBox txtPregnancies;
        private System.Windows.Forms.Label lblGlucose;
        private System.Windows.Forms.TextBox txtGlucose;
        private System.Windows.Forms.Label lblBloodPressure;
        private System.Windows.Forms.TextBox txtBloodPressure;
        private System.Windows.Forms.Label lblSkinThickness;
        private System.Windows.Forms.TextBox txtSkinThickness;
        private System.Windows.Forms.Label lblInsulin;
        private System.Windows.Forms.TextBox txtInsulin;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.Label lblDiabetesPedigreeFunction;
        private System.Windows.Forms.TextBox txtDiabetesPedigreeFunction;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblResult;
    }

}
