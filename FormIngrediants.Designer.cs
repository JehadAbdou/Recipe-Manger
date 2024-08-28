namespace Assigenment_4
{
    partial class FormIngrediants
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
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnReove = new Button();
            LstIngradients = new ListBox();
            TxtIngradients = new TextBox();
            BtnOk = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(346, 34);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(346, 83);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(75, 23);
            BtnEdit.TabIndex = 1;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnReove
            // 
            BtnReove.Location = new Point(346, 129);
            BtnReove.Name = "BtnReove";
            BtnReove.Size = new Size(75, 23);
            BtnReove.TabIndex = 2;
            BtnReove.Text = "Remove";
            BtnReove.UseVisualStyleBackColor = true;
            BtnReove.Click += BtnReove_Click;
            // 
            // LstIngradients
            // 
            LstIngradients.FormattingEnabled = true;
            LstIngradients.ItemHeight = 15;
            LstIngradients.Location = new Point(26, 79);
            LstIngradients.Name = "LstIngradients";
            LstIngradients.Size = new Size(314, 289);
            LstIngradients.TabIndex = 3;
            // 
            // TxtIngradients
            // 
            TxtIngradients.Location = new Point(26, 33);
            TxtIngradients.Name = "TxtIngradients";
            TxtIngradients.Size = new Size(314, 23);
            TxtIngradients.TabIndex = 4;
            // 
            // BtnOk
            // 
            BtnOk.DialogResult = DialogResult.OK;
            BtnOk.Location = new Point(56, 390);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 5;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.DialogResult = DialogResult.Cancel;
            BtnCancel.Location = new Point(213, 390);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FormIngrediants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 426);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOk);
            Controls.Add(TxtIngradients);
            Controls.Add(LstIngradients);
            Controls.Add(BtnReove);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Name = "FormIngrediants";
            Text = "Ingrediants";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnReove;
        private ListBox LstIngradients;
        private TextBox TxtIngradients;
        private Button BtnOk;
        private Button BtnCancel;
    }
}