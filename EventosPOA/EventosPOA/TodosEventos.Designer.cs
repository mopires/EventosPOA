namespace EventosPOA
{
    partial class TodosEventos
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
            this.dataGridEventos = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnParticipar = new System.Windows.Forms.Button();
            this.boxEvento = new System.Windows.Forms.ComboBox();
            this.btnCancelarParticipacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEventos
            // 
            this.dataGridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEventos.Location = new System.Drawing.Point(12, 39);
            this.dataGridEventos.Name = "dataGridEventos";
            this.dataGridEventos.Size = new System.Drawing.Size(776, 196);
            this.dataGridEventos.TabIndex = 0;
            // 
            // btnParticipar
            // 
            this.btnParticipar.Location = new System.Drawing.Point(12, 241);
            this.btnParticipar.Name = "btnParticipar";
            this.btnParticipar.Size = new System.Drawing.Size(160, 41);
            this.btnParticipar.TabIndex = 1;
            this.btnParticipar.Text = "Participar do evento";
            this.btnParticipar.UseVisualStyleBackColor = true;
            this.btnParticipar.Click += new System.EventHandler(this.btnParticipar_Click);
            // 
            // boxEvento
            // 
            this.boxEvento.FormattingEnabled = true;
            this.boxEvento.Items.AddRange(new object[] {
            "Todos os eventos",
            "Eventos que participo"});
            this.boxEvento.Location = new System.Drawing.Point(12, 12);
            this.boxEvento.Name = "boxEvento";
            this.boxEvento.Size = new System.Drawing.Size(160, 21);
            this.boxEvento.TabIndex = 2;
            this.boxEvento.Text = "Todos os eventos";
            this.boxEvento.SelectedIndexChanged += new System.EventHandler(this.boxEvento_SelectedIndexChanged);
            // 
            // btnCancelarParticipacao
            // 
            this.btnCancelarParticipacao.Location = new System.Drawing.Point(178, 241);
            this.btnCancelarParticipacao.Name = "btnCancelarParticipacao";
            this.btnCancelarParticipacao.Size = new System.Drawing.Size(153, 41);
            this.btnCancelarParticipacao.TabIndex = 3;
            this.btnCancelarParticipacao.Text = "Cancelar participação";
            this.btnCancelarParticipacao.UseVisualStyleBackColor = true;
            this.btnCancelarParticipacao.Visible = false;
            this.btnCancelarParticipacao.Click += new System.EventHandler(this.btnCancelarParticipacao_Click);
            // 
            // TodosEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarParticipacao);
            this.Controls.Add(this.boxEvento);
            this.Controls.Add(this.btnParticipar);
            this.Controls.Add(this.dataGridEventos);
            this.Name = "TodosEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodosEventos";
            this.Load += new System.EventHandler(this.TodosEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridEventos;
        private System.Windows.Forms.Button btnParticipar;
        private System.Windows.Forms.ComboBox boxEvento;
        private System.Windows.Forms.Button btnCancelarParticipacao;
    }
}