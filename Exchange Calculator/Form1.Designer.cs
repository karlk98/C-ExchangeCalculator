namespace Exchange_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCurrentAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnExchange = new System.Windows.Forms.Button();
            this.comboSecondCurrency = new System.Windows.Forms.ComboBox();
            this.lblExchangeTo = new System.Windows.Forms.Label();
            this.comboCurrent = new System.Windows.Forms.ComboBox();
            this.lblCurrentCurrency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Name = "lblTitle";
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.ForeColor = System.Drawing.Color.Yellow;
            this.lblResult.Name = "lblResult";
            // 
            // lblCurrentAmount
            // 
            resources.ApplyResources(this.lblCurrentAmount, "lblCurrentAmount");
            this.lblCurrentAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrentAmount.Name = "lblCurrentAmount";
            // 
            // txtAmount
            // 
            resources.ApplyResources(this.txtAmount, "txtAmount");
            this.txtAmount.Name = "txtAmount";
            // 
            // txtResult
            // 
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.btnExchange, "btnExchange");
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // comboSecondCurrency
            // 
            this.comboSecondCurrency.FormattingEnabled = true;
            this.comboSecondCurrency.Items.AddRange(new object[] {
            resources.GetString("comboSecondCurrency.Items"),
            resources.GetString("comboSecondCurrency.Items1"),
            resources.GetString("comboSecondCurrency.Items2")});
            resources.ApplyResources(this.comboSecondCurrency, "comboSecondCurrency");
            this.comboSecondCurrency.Name = "comboSecondCurrency";
            // 
            // lblExchangeTo
            // 
            resources.ApplyResources(this.lblExchangeTo, "lblExchangeTo");
            this.lblExchangeTo.ForeColor = System.Drawing.Color.Yellow;
            this.lblExchangeTo.Name = "lblExchangeTo";
            // 
            // comboCurrent
            // 
            this.comboCurrent.Items.AddRange(new object[] {
            resources.GetString("comboCurrent.Items"),
            resources.GetString("comboCurrent.Items1"),
            resources.GetString("comboCurrent.Items2")});
            resources.ApplyResources(this.comboCurrent, "comboCurrent");
            this.comboCurrent.Name = "comboCurrent";
            // 
            // lblCurrentCurrency
            // 
            resources.ApplyResources(this.lblCurrentCurrency, "lblCurrentCurrency");
            this.lblCurrentCurrency.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrentCurrency.Name = "lblCurrentCurrency";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.lblCurrentCurrency);
            this.Controls.Add(this.comboCurrent);
            this.Controls.Add(this.lblExchangeTo);
            this.Controls.Add(this.comboSecondCurrency);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblCurrentAmount);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCurrentAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.ComboBox comboSecondCurrency;
        private System.Windows.Forms.Label lblExchangeTo;
        private System.Windows.Forms.ComboBox comboCurrent;
        private System.Windows.Forms.Label lblCurrentCurrency;
    }
}

