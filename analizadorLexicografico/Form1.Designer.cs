namespace analizadorLexicografico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.btnMostarReporte1 = new System.Windows.Forms.Button();
            this.btnMostrarReporte2 = new System.Windows.Forms.Button();
            this.lblRutaArchivo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.White;
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarArchivo.ImageIndex = 1;
            this.btnCargarArchivo.ImageList = this.imageList1;
            this.btnCargarArchivo.Location = new System.Drawing.Point(210, 114);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(164, 37);
            this.btnCargarArchivo.TabIndex = 0;
            this.btnCargarArchivo.Text = "Cargar archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnMostarReporte1
            // 
            this.btnMostarReporte1.BackColor = System.Drawing.Color.White;
            this.btnMostarReporte1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostarReporte1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostarReporte1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostarReporte1.ImageIndex = 0;
            this.btnMostarReporte1.ImageList = this.imageList1;
            this.btnMostarReporte1.Location = new System.Drawing.Point(364, 176);
            this.btnMostarReporte1.Name = "btnMostarReporte1";
            this.btnMostarReporte1.Size = new System.Drawing.Size(125, 32);
            this.btnMostarReporte1.TabIndex = 1;
            this.btnMostarReporte1.Text = "Reporte 1";
            this.btnMostarReporte1.UseVisualStyleBackColor = false;
            this.btnMostarReporte1.Click += new System.EventHandler(this.btnMostarReporte1_Click);
            // 
            // btnMostrarReporte2
            // 
            this.btnMostrarReporte2.BackColor = System.Drawing.Color.White;
            this.btnMostrarReporte2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarReporte2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarReporte2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarReporte2.ImageIndex = 0;
            this.btnMostrarReporte2.ImageList = this.imageList1;
            this.btnMostrarReporte2.Location = new System.Drawing.Point(364, 228);
            this.btnMostrarReporte2.Name = "btnMostrarReporte2";
            this.btnMostrarReporte2.Size = new System.Drawing.Size(125, 35);
            this.btnMostrarReporte2.TabIndex = 3;
            this.btnMostrarReporte2.Text = "Reporte 2";
            this.btnMostrarReporte2.UseVisualStyleBackColor = false;
            this.btnMostrarReporte2.Click += new System.EventHandler(this.btnMostrarReporte2_Click);
            // 
            // lblRutaArchivo
            // 
            this.lblRutaArchivo.AutoSize = true;
            this.lblRutaArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.lblRutaArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaArchivo.ForeColor = System.Drawing.Color.White;
            this.lblRutaArchivo.Location = new System.Drawing.Point(209, 79);
            this.lblRutaArchivo.Name = "lblRutaArchivo";
            this.lblRutaArchivo.Size = new System.Drawing.Size(0, 21);
            this.lblRutaArchivo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Generar Reporte 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Generar Reporte 2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "report.png");
            this.imageList1.Images.SetKeyName(1, "open.png");
            this.imageList1.Images.SetKeyName(2, "folder.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(36)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutaArchivo);
            this.Controls.Add(this.btnMostrarReporte2);
            this.Controls.Add(this.btnMostarReporte1);
            this.Controls.Add(this.btnCargarArchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnMostarReporte1;
        private System.Windows.Forms.Button btnMostrarReporte2;
        private System.Windows.Forms.Label lblRutaArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

