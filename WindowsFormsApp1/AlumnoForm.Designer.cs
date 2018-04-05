namespace WindowsFormsApp1
{
    partial class AlumnoForm
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
            this.buttontxt = new System.Windows.Forms.Button();
            this.buttonjson = new System.Windows.Forms.Button();
            this.buttonxml = new System.Windows.Forms.Button();
            this.boxid = new System.Windows.Forms.TextBox();
            this.boxapellido = new System.Windows.Forms.TextBox();
            this.boxfecha = new System.Windows.Forms.TextBox();
            this.boxnombre = new System.Windows.Forms.TextBox();
            this.boxdni = new System.Windows.Forms.TextBox();
            this.textdni = new System.Windows.Forms.Label();
            this.textnombre = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.Label();
            this.textfecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttontxt
            // 
            this.buttontxt.Location = new System.Drawing.Point(406, 128);
            this.buttontxt.Name = "buttontxt";
            this.buttontxt.Size = new System.Drawing.Size(75, 23);
            this.buttontxt.TabIndex = 0;
            this.buttontxt.Text = "txt";
            this.buttontxt.UseVisualStyleBackColor = true;
            this.buttontxt.Click += new System.EventHandler(this.buttontxt_Click);
            // 
            // buttonjson
            // 
            this.buttonjson.Location = new System.Drawing.Point(406, 236);
            this.buttonjson.Name = "buttonjson";
            this.buttonjson.Size = new System.Drawing.Size(75, 23);
            this.buttonjson.TabIndex = 1;
            this.buttonjson.Text = "json";
            this.buttonjson.UseVisualStyleBackColor = true;
            this.buttonjson.Click += new System.EventHandler(this.buttonjson_Click);
            // 
            // buttonxml
            // 
            this.buttonxml.Location = new System.Drawing.Point(406, 345);
            this.buttonxml.Name = "buttonxml";
            this.buttonxml.Size = new System.Drawing.Size(75, 23);
            this.buttonxml.TabIndex = 2;
            this.buttonxml.Text = "xml";
            this.buttonxml.UseVisualStyleBackColor = true;
            this.buttonxml.Click += new System.EventHandler(this.buttonxml_Click);
            // 
            // boxid
            // 
            this.boxid.Location = new System.Drawing.Point(243, 326);
            this.boxid.Name = "boxid";
            this.boxid.Size = new System.Drawing.Size(100, 20);
            this.boxid.TabIndex = 3;
            // 
            // boxapellido
            // 
            this.boxapellido.Location = new System.Drawing.Point(243, 239);
            this.boxapellido.Name = "boxapellido";
            this.boxapellido.Size = new System.Drawing.Size(100, 20);
            this.boxapellido.TabIndex = 4;
            // 
            // boxfecha
            // 
            this.boxfecha.Location = new System.Drawing.Point(243, 404);
            this.boxfecha.Name = "boxfecha";
            this.boxfecha.Size = new System.Drawing.Size(100, 20);
            this.boxfecha.TabIndex = 5;
            // 
            // boxnombre
            // 
            this.boxnombre.Location = new System.Drawing.Point(243, 140);
            this.boxnombre.Name = "boxnombre";
            this.boxnombre.Size = new System.Drawing.Size(100, 20);
            this.boxnombre.TabIndex = 6;
            // 
            // boxdni
            // 
            this.boxdni.Location = new System.Drawing.Point(243, 56);
            this.boxdni.Name = "boxdni";
            this.boxdni.Size = new System.Drawing.Size(100, 20);
            this.boxdni.TabIndex = 7;
            // 
            // textdni
            // 
            this.textdni.AutoSize = true;
            this.textdni.Location = new System.Drawing.Point(71, 63);
            this.textdni.Name = "textdni";
            this.textdni.Size = new System.Drawing.Size(21, 13);
            this.textdni.TabIndex = 8;
            this.textdni.Text = "dni";
            // 
            // textnombre
            // 
            this.textnombre.AutoSize = true;
            this.textnombre.Location = new System.Drawing.Point(74, 146);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(42, 13);
            this.textnombre.TabIndex = 9;
            this.textnombre.Text = "nombre";
            // 
            // txtapellido
            // 
            this.txtapellido.AutoSize = true;
            this.txtapellido.Location = new System.Drawing.Point(74, 246);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(43, 13);
            this.txtapellido.TabIndex = 10;
            this.txtapellido.Text = "apellido";
            // 
            // textid
            // 
            this.textid.AutoSize = true;
            this.textid.Location = new System.Drawing.Point(74, 333);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(15, 13);
            this.textid.TabIndex = 11;
            this.textid.Text = "id";
            // 
            // textfecha
            // 
            this.textfecha.AutoSize = true;
            this.textfecha.Location = new System.Drawing.Point(74, 410);
            this.textfecha.Name = "textfecha";
            this.textfecha.Size = new System.Drawing.Size(34, 13);
            this.textfecha.TabIndex = 12;
            this.textfecha.Text = "fecha";
            // 
            // AlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textfecha);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textdni);
            this.Controls.Add(this.boxdni);
            this.Controls.Add(this.boxnombre);
            this.Controls.Add(this.boxfecha);
            this.Controls.Add(this.boxapellido);
            this.Controls.Add(this.boxid);
            this.Controls.Add(this.buttonxml);
            this.Controls.Add(this.buttonjson);
            this.Controls.Add(this.buttontxt);
            this.Name = "AlumnoForm";
            this.Text = "AlumnoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttontxt;
        private System.Windows.Forms.Button buttonjson;
        private System.Windows.Forms.Button buttonxml;
        private System.Windows.Forms.TextBox boxid;
        private System.Windows.Forms.TextBox boxapellido;
        private System.Windows.Forms.TextBox boxfecha;
        private System.Windows.Forms.TextBox boxnombre;
        private System.Windows.Forms.TextBox boxdni;
        private System.Windows.Forms.Label textdni;
        private System.Windows.Forms.Label textnombre;
        private System.Windows.Forms.Label txtapellido;
        private System.Windows.Forms.Label textid;
        private System.Windows.Forms.Label textfecha;
    }
}