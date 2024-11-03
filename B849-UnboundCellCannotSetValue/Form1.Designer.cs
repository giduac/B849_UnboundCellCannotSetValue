namespace B849_UnboundCellCannotSetValue
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dgv1 = new Krypton.Toolkit.KryptonDataGridView();
            dgv1Col1 = new DataGridViewTextBoxColumn();
            dgv1Col2 = new DataGridViewTextBoxColumn();
            dgv2 = new DataGridView();
            dgv2Col1 = new DataGridViewTextBoxColumn();
            dgv2Col2 = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.BorderStyle = BorderStyle.None;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { dgv1Col1, dgv1Col2 });
            dgv1.Location = new Point(56, 12);
            dgv1.Name = "dgv1";
            dgv1.Size = new Size(625, 190);
            dgv1.TabIndex = 0;
            // 
            // dgv1Col1
            // 
            dgv1Col1.DataPropertyName = "col1";
            dgv1Col1.HeaderText = "Col1";
            dgv1Col1.Name = "dgv1Col1";
            // 
            // dgv1Col2
            // 
            dgv1Col2.DataPropertyName = "col2";
            dgv1Col2.HeaderText = "Col2";
            dgv1Col2.Name = "dgv1Col2";
            // 
            // dgv2
            // 
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Columns.AddRange(new DataGridViewColumn[] { dgv2Col1, dgv2Col2 });
            dgv2.Location = new Point(56, 289);
            dgv2.Name = "dgv2";
            dgv2.Size = new Size(625, 205);
            dgv2.TabIndex = 1;
            // 
            // dgv2Col1
            // 
            dgv2Col1.DataPropertyName = "col1";
            dgv2Col1.HeaderText = "Col1";
            dgv2Col1.Name = "dgv2Col1";
            // 
            // dgv2Col2
            // 
            dgv2Col2.DataPropertyName = "col2";
            dgv2Col2.HeaderText = "Col2";
            dgv2Col2.Name = "dgv2Col2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 699);
            Controls.Add(dgv2);
            Controls.Add(dgv1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgv1;
        private DataGridView dgv2;
        private DataGridViewTextBoxColumn dgv1Col1;
        private DataGridViewTextBoxColumn dgv1Col2;
        private DataGridViewTextBoxColumn dgv2Col1;
        private DataGridViewTextBoxColumn dgv2Col2;
        private BindingSource bindingSource1;
    }
}
