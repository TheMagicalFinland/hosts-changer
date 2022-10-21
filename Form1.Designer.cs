namespace hosts_changer
{
    partial class changeHosts
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
            this.label1 = new System.Windows.Forms.Label();
            this.enigmaBtn = new System.Windows.Forms.Button();
            this.rgtBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press the button to change hosts file";
            // 
            // enigmaBtn
            // 
            this.enigmaBtn.Location = new System.Drawing.Point(95, 153);
            this.enigmaBtn.Name = "enigmaBtn";
            this.enigmaBtn.Size = new System.Drawing.Size(233, 104);
            this.enigmaBtn.TabIndex = 1;
            this.enigmaBtn.Text = "Click to add Enigma\'s ip to your hosts file";
            this.enigmaBtn.UseVisualStyleBackColor = true;
            this.enigmaBtn.Click += new System.EventHandler(this.enigmaBtn_Click);
            // 
            // rgtBtn
            // 
            this.rgtBtn.Location = new System.Drawing.Point(431, 153);
            this.rgtBtn.Name = "rgtBtn";
            this.rgtBtn.Size = new System.Drawing.Size(233, 104);
            this.rgtBtn.TabIndex = 2;
            this.rgtBtn.Text = "Remove Enigma\'s ip from your hosts file";
            this.rgtBtn.UseVisualStyleBackColor = true;
            this.rgtBtn.Click += new System.EventHandler(this.rgtBtn_Click);
            // 
            // changeHosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rgtBtn);
            this.Controls.Add(this.enigmaBtn);
            this.Controls.Add(this.label1);
            this.Name = "changeHosts";
            this.Text = "Hosts changer";
            this.Load += new System.EventHandler(this.changeHosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enigmaBtn;
        private System.Windows.Forms.Button rgtBtn;
    }
}

