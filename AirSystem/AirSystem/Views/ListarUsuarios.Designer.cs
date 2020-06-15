namespace AirSystem.Views
{
    partial class ListarUsuarios
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
            this.dgvListarUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarUsuarios
            // 
            this.dgvListarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListarUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvListarUsuarios.Name = "dgvListarUsuarios";
            this.dgvListarUsuarios.Size = new System.Drawing.Size(800, 450);
            this.dgvListarUsuarios.TabIndex = 0;
            this.dgvListarUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListarUsuarios);
            this.Name = "ListarUsuarios";
            this.Text = "ListarUsuarios";
            this.Load += new System.EventHandler(this.ListarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarUsuarios;
    }
}