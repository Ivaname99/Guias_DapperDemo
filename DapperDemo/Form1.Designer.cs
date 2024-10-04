namespace DapperDemo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.tboxObtenerID = new System.Windows.Forms.TextBox();
            this.btnObtenerId = new System.Windows.Forms.Button();
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxContactTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(776, 198);
            this.dgvCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id Cliente";
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(681, 222);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(107, 28);
            this.btnObtenerTodos.TabIndex = 2;
            this.btnObtenerTodos.Text = "Obtener Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // tboxObtenerID
            // 
            this.tboxObtenerID.Location = new System.Drawing.Point(70, 227);
            this.tboxObtenerID.Name = "tboxObtenerID";
            this.tboxObtenerID.Size = new System.Drawing.Size(100, 20);
            this.tboxObtenerID.TabIndex = 3;
            // 
            // btnObtenerId
            // 
            this.btnObtenerId.Location = new System.Drawing.Point(188, 225);
            this.btnObtenerId.Name = "btnObtenerId";
            this.btnObtenerId.Size = new System.Drawing.Size(75, 23);
            this.btnObtenerId.TabIndex = 4;
            this.btnObtenerId.Text = "Buscar";
            this.btnObtenerId.UseVisualStyleBackColor = true;
            this.btnObtenerId.Click += new System.EventHandler(this.btnObtenerId_Click);
            // 
            // tbxContactName
            // 
            this.tbxContactName.Location = new System.Drawing.Point(681, 326);
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.Size = new System.Drawing.Size(100, 20);
            this.tbxContactName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ContactName";
            // 
            // tbxContactTitle
            // 
            this.tbxContactTitle.Location = new System.Drawing.Point(681, 352);
            this.tbxContactTitle.Name = "tbxContactTitle";
            this.tbxContactTitle.Size = new System.Drawing.Size(100, 20);
            this.tbxContactTitle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ContactTitle";
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(681, 300);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(100, 20);
            this.tbxCompanyName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CompanyName";
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(681, 274);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.Size = new System.Drawing.Size(100, 20);
            this.tbxCustomerID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CustomerID";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(681, 378);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(100, 20);
            this.tbxAddress.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(436, 274);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(98, 27);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar Cliente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(436, 319);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 27);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(436, 367);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 27);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCustomerID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxContactTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxContactName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObtenerId);
            this.Controls.Add(this.tboxObtenerID);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.TextBox tboxObtenerID;
        private System.Windows.Forms.Button btnObtenerId;
        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxContactTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

