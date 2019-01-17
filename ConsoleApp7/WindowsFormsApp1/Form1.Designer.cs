namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fieldAdd = new System.Windows.Forms.Button();
            this.fieldDelete = new System.Windows.Forms.Button();
            this.fieldUpdate = new System.Windows.Forms.Button();
            this.fieldSalaryAverage = new System.Windows.Forms.Button();
            this.fieldBestWorker = new System.Windows.Forms.Button();
            this.fieldHigherSalaryWorker = new System.Windows.Forms.Button();
            this.fieldLowerWorker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // fieldAdd
            // 
            this.fieldAdd.Location = new System.Drawing.Point(492, 131);
            this.fieldAdd.Name = "fieldAdd";
            this.fieldAdd.Size = new System.Drawing.Size(279, 23);
            this.fieldAdd.TabIndex = 1;
            this.fieldAdd.Text = "Add";
            this.fieldAdd.UseVisualStyleBackColor = true;
            // 
            // fieldDelete
            // 
            this.fieldDelete.Location = new System.Drawing.Point(492, 160);
            this.fieldDelete.Name = "fieldDelete";
            this.fieldDelete.Size = new System.Drawing.Size(279, 23);
            this.fieldDelete.TabIndex = 2;
            this.fieldDelete.Text = "Delete";
            this.fieldDelete.UseVisualStyleBackColor = true;
            // 
            // fieldUpdate
            // 
            this.fieldUpdate.Location = new System.Drawing.Point(492, 189);
            this.fieldUpdate.Name = "fieldUpdate";
            this.fieldUpdate.Size = new System.Drawing.Size(279, 23);
            this.fieldUpdate.TabIndex = 3;
            this.fieldUpdate.Text = "Update";
            this.fieldUpdate.UseVisualStyleBackColor = true;
            // 
            // fieldSalaryAverage
            // 
            this.fieldSalaryAverage.Location = new System.Drawing.Point(12, 278);
            this.fieldSalaryAverage.Name = "fieldSalaryAverage";
            this.fieldSalaryAverage.Size = new System.Drawing.Size(279, 23);
            this.fieldSalaryAverage.TabIndex = 4;
            this.fieldSalaryAverage.Text = "Salary Average";
            this.fieldSalaryAverage.UseVisualStyleBackColor = true;
            // 
            // fieldBestWorker
            // 
            this.fieldBestWorker.Location = new System.Drawing.Point(12, 307);
            this.fieldBestWorker.Name = "fieldBestWorker";
            this.fieldBestWorker.Size = new System.Drawing.Size(279, 23);
            this.fieldBestWorker.TabIndex = 5;
            this.fieldBestWorker.Text = "Best Worker";
            this.fieldBestWorker.UseVisualStyleBackColor = true;
            // 
            // fieldHigherSalaryWorker
            // 
            this.fieldHigherSalaryWorker.Location = new System.Drawing.Point(12, 336);
            this.fieldHigherSalaryWorker.Name = "fieldHigherSalaryWorker";
            this.fieldHigherSalaryWorker.Size = new System.Drawing.Size(279, 23);
            this.fieldHigherSalaryWorker.TabIndex = 6;
            this.fieldHigherSalaryWorker.Text = "Higher salary workers";
            this.fieldHigherSalaryWorker.UseVisualStyleBackColor = true;
            // 
            // fieldLowerWorker
            // 
            this.fieldLowerWorker.Location = new System.Drawing.Point(12, 365);
            this.fieldLowerWorker.Name = "fieldLowerWorker";
            this.fieldLowerWorker.Size = new System.Drawing.Size(279, 23);
            this.fieldLowerWorker.TabIndex = 7;
            this.fieldLowerWorker.Text = "Lower Worker";
            this.fieldLowerWorker.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 428);
            this.Controls.Add(this.fieldLowerWorker);
            this.Controls.Add(this.fieldHigherSalaryWorker);
            this.Controls.Add(this.fieldBestWorker);
            this.Controls.Add(this.fieldSalaryAverage);
            this.Controls.Add(this.fieldUpdate);
            this.Controls.Add(this.fieldDelete);
            this.Controls.Add(this.fieldAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button fieldAdd;
        private System.Windows.Forms.Button fieldDelete;
        private System.Windows.Forms.Button fieldUpdate;
        private System.Windows.Forms.Button fieldSalaryAverage;
        private System.Windows.Forms.Button fieldBestWorker;
        private System.Windows.Forms.Button fieldHigherSalaryWorker;
        private System.Windows.Forms.Button fieldLowerWorker;
    }
}

