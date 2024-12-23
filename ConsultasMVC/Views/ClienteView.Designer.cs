namespace ConsultasMVC.Views
{
    partial class ClienteView
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
            TablaClientes = new DataGridView();
            tbBuscar = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)TablaClientes).BeginInit();
            SuspendLayout();
            // 
            // TablaClientes
            // 
            TablaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaClientes.Location = new Point(8, 45);
            TablaClientes.Name = "TablaClientes";
            TablaClientes.Size = new Size(780, 393);
            TablaClientes.TabIndex = 0;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(67, 16);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(100, 23);
            tbBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar";
            // 
            // ClienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tbBuscar);
            Controls.Add(TablaClientes);
            Name = "ClienteView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClienteView";
            ((System.ComponentModel.ISupportInitialize)TablaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView TablaClientes;
        public TextBox tbBuscar;
        private DataGridView dataGridView1;
        private Label label1;
    }
}