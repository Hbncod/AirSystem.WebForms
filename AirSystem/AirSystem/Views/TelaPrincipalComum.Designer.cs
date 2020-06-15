namespace AirSystem.Views
{
    partial class TelaPrincipalComum
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(387, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 126);
            this.button5.TabIndex = 8;
            this.button5.Text = "Gerenciar Relatórios";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(129, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 126);
            this.button4.TabIndex = 7;
            this.button4.Text = "Gerenciar Companhia";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 126);
            this.button3.TabIndex = 6;
            this.button3.Text = "Gerenciar Avião";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 126);
            this.button1.TabIndex = 5;
            this.button1.Text = "Listar Usuários";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaPrincipalComum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "TelaPrincipalComum";
            this.Text = "Tela Principal - AirSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}