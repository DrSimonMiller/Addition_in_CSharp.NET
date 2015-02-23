namespace Addition_in_CSharp.NET
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
            this.btnIntegerAdd = new System.Windows.Forms.Button();
            this.lblInteger = new System.Windows.Forms.Label();
            this.txtIntegerA = new System.Windows.Forms.TextBox();
            this.txtIntegerB = new System.Windows.Forms.TextBox();
            this.txtIntegerResult = new System.Windows.Forms.TextBox();
            this.txtDoubleA = new System.Windows.Forms.TextBox();
            this.txtDoubleB = new System.Windows.Forms.TextBox();
            this.txtDoubleAdd = new System.Windows.Forms.Button();
            this.txtDoubleResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIntegerAdd
            // 
            this.btnIntegerAdd.Location = new System.Drawing.Point(296, 50);
            this.btnIntegerAdd.Name = "btnIntegerAdd";
            this.btnIntegerAdd.Size = new System.Drawing.Size(52, 23);
            this.btnIntegerAdd.TabIndex = 3;
            this.btnIntegerAdd.Text = "Add";
            this.btnIntegerAdd.UseVisualStyleBackColor = true;
            this.btnIntegerAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInteger
            // 
            this.lblInteger.AutoSize = true;
            this.lblInteger.Location = new System.Drawing.Point(23, 52);
            this.lblInteger.Name = "lblInteger";
            this.lblInteger.Size = new System.Drawing.Size(43, 13);
            this.lblInteger.TabIndex = 0;
            this.lblInteger.Text = "Integer:";
            // 
            // txtIntegerA
            // 
            this.txtIntegerA.Location = new System.Drawing.Point(73, 52);
            this.txtIntegerA.Name = "txtIntegerA";
            this.txtIntegerA.Size = new System.Drawing.Size(100, 20);
            this.txtIntegerA.TabIndex = 1;
            this.txtIntegerA.Text = "0";
            this.txtIntegerA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntegerA_KeyPress);
            // 
            // txtIntegerB
            // 
            this.txtIntegerB.Location = new System.Drawing.Point(180, 52);
            this.txtIntegerB.Name = "txtIntegerB";
            this.txtIntegerB.Size = new System.Drawing.Size(100, 20);
            this.txtIntegerB.TabIndex = 2;
            this.txtIntegerB.Text = "0";
            // 
            // txtIntegerResult
            // 
            this.txtIntegerResult.Location = new System.Drawing.Point(374, 52);
            this.txtIntegerResult.Name = "txtIntegerResult";
            this.txtIntegerResult.Size = new System.Drawing.Size(100, 20);
            this.txtIntegerResult.TabIndex = 4;
            // 
            // txtDoubleA
            // 
            this.txtDoubleA.Location = new System.Drawing.Point(74, 109);
            this.txtDoubleA.Name = "txtDoubleA";
            this.txtDoubleA.Size = new System.Drawing.Size(100, 20);
            this.txtDoubleA.TabIndex = 5;
            this.txtDoubleA.Text = "0";
            // 
            // txtDoubleB
            // 
            this.txtDoubleB.Location = new System.Drawing.Point(180, 109);
            this.txtDoubleB.Name = "txtDoubleB";
            this.txtDoubleB.Size = new System.Drawing.Size(100, 20);
            this.txtDoubleB.TabIndex = 6;
            this.txtDoubleB.Text = "0";
            // 
            // txtDoubleAdd
            // 
            this.txtDoubleAdd.Location = new System.Drawing.Point(296, 109);
            this.txtDoubleAdd.Name = "txtDoubleAdd";
            this.txtDoubleAdd.Size = new System.Drawing.Size(52, 23);
            this.txtDoubleAdd.TabIndex = 7;
            this.txtDoubleAdd.Text = "Add";
            this.txtDoubleAdd.UseVisualStyleBackColor = true;
            this.txtDoubleAdd.Click += new System.EventHandler(this.txtDoubleAdd_Click);
            // 
            // txtDoubleResult
            // 
            this.txtDoubleResult.Location = new System.Drawing.Point(374, 109);
            this.txtDoubleResult.Name = "txtDoubleResult";
            this.txtDoubleResult.Size = new System.Drawing.Size(100, 20);
            this.txtDoubleResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 262);
            this.Controls.Add(this.txtDoubleResult);
            this.Controls.Add(this.txtDoubleAdd);
            this.Controls.Add(this.txtDoubleB);
            this.Controls.Add(this.txtDoubleA);
            this.Controls.Add(this.txtIntegerResult);
            this.Controls.Add(this.txtIntegerB);
            this.Controls.Add(this.txtIntegerA);
            this.Controls.Add(this.lblInteger);
            this.Controls.Add(this.btnIntegerAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIntegerAdd;
        private System.Windows.Forms.Label lblInteger;
        private System.Windows.Forms.TextBox txtIntegerA;
        private System.Windows.Forms.TextBox txtIntegerB;
        private System.Windows.Forms.TextBox txtIntegerResult;
        private System.Windows.Forms.TextBox txtDoubleA;
        private System.Windows.Forms.TextBox txtDoubleB;
        private System.Windows.Forms.Button txtDoubleAdd;
        private System.Windows.Forms.TextBox txtDoubleResult;
    }
}

