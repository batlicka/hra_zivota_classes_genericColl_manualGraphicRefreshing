namespace GraphicalGameOfLifeForm
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
            this.DrawAnotherGeneration = new System.Windows.Forms.Button();
            this.LoadFromTxt = new System.Windows.Forms.Button();
            this.SaveToTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawAnotherGeneration
            // 
            this.DrawAnotherGeneration.Location = new System.Drawing.Point(579, 38);
            this.DrawAnotherGeneration.Name = "DrawAnotherGeneration";
            this.DrawAnotherGeneration.Size = new System.Drawing.Size(82, 23);
            this.DrawAnotherGeneration.TabIndex = 0;
            this.DrawAnotherGeneration.Text = "draw next gen";
            this.DrawAnotherGeneration.UseVisualStyleBackColor = true;
            this.DrawAnotherGeneration.Click += new System.EventHandler(this.DrawAnotherGeneration_Click);
            // 
            // LoadFromTxt
            // 
            this.LoadFromTxt.Location = new System.Drawing.Point(579, 67);
            this.LoadFromTxt.Name = "LoadFromTxt";
            this.LoadFromTxt.Size = new System.Drawing.Size(82, 23);
            this.LoadFromTxt.TabIndex = 1;
            this.LoadFromTxt.Text = "load from txt";
            this.LoadFromTxt.UseVisualStyleBackColor = true;
            this.LoadFromTxt.Click += new System.EventHandler(this.LoadFromTxt_Click);
            // 
            // SaveToTxt
            // 
            this.SaveToTxt.Location = new System.Drawing.Point(579, 96);
            this.SaveToTxt.Name = "SaveToTxt";
            this.SaveToTxt.Size = new System.Drawing.Size(82, 23);
            this.SaveToTxt.TabIndex = 2;
            this.SaveToTxt.Text = "save to txt";
            this.SaveToTxt.UseVisualStyleBackColor = true;
            this.SaveToTxt.Click += new System.EventHandler(this.SaveToTxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.SaveToTxt);
            this.Controls.Add(this.LoadFromTxt);
            this.Controls.Add(this.DrawAnotherGeneration);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawAnotherGeneration;
        private System.Windows.Forms.Button LoadFromTxt;
        private System.Windows.Forms.Button SaveToTxt;
    }
}

