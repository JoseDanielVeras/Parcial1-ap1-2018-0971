
namespace Parcial1_ap1_2018_0971
{
    partial class RegistroDeCiudades
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDeCiudades));
            this.CiudadIdlabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.CiudadIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CiudadIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CiudadIdlabel
            // 
            this.CiudadIdlabel.AutoSize = true;
            this.CiudadIdlabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CiudadIdlabel.Location = new System.Drawing.Point(31, 33);
            this.CiudadIdlabel.Name = "CiudadIdlabel";
            this.CiudadIdlabel.Size = new System.Drawing.Size(73, 20);
            this.CiudadIdlabel.TabIndex = 0;
            this.CiudadIdlabel.Text = "Ciudad Id";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nombrelabel.Location = new System.Drawing.Point(34, 93);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(64, 20);
            this.Nombrelabel.TabIndex = 1;
            this.Nombrelabel.Text = "Nombre";
            // 
            // CiudadIdNumericUpDown
            // 
            this.CiudadIdNumericUpDown.Location = new System.Drawing.Point(110, 33);
            this.CiudadIdNumericUpDown.Name = "CiudadIdNumericUpDown";
            this.CiudadIdNumericUpDown.Size = new System.Drawing.Size(87, 23);
            this.CiudadIdNumericUpDown.TabIndex = 3;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(215, 33);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(69, 23);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(209, 159);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 30);
            this.EliminarButton.TabIndex = 5;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(119, 159);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 30);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(34, 158);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(70, 30);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(111, 90);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(173, 23);
            this.NombreTextBox.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroDeCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 230);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CiudadIdNumericUpDown);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.CiudadIdlabel);
            this.Name = "RegistroDeCiudades";
            this.Text = "Registro De Ciudades";
            ((System.ComponentModel.ISupportInitialize)(this.CiudadIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CiudadIdlabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.NumericUpDown CiudadIdNumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

