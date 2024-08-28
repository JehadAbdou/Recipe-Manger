namespace Assigenment_4
{
    partial class MainForm
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
            comboBox1 = new ComboBox();
            BtnAddIng = new Button();
            LblName = new Label();
            lblCat = new Label();
            BtnAddRecipe = new Button();
            LstRecipes = new ListBox();
            btnEditRec = new Button();
            BtnFinish = new Button();
            BtnDel = new Button();
            BtnClear = new Button();
            NameLabel = new Label();
            CatagoryLabel = new Label();
            NumOfIngLbl = new Label();
            txtRecipeName = new TextBox();
            TxtInstrouctions = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(128, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // BtnAddIng
            // 
            BtnAddIng.Location = new Point(269, 84);
            BtnAddIng.Name = "BtnAddIng";
            BtnAddIng.Size = new Size(126, 24);
            BtnAddIng.TabIndex = 1;
            BtnAddIng.Text = "Add ingredients";
            BtnAddIng.UseVisualStyleBackColor = true;
            BtnAddIng.Click += BtnAddIng_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(39, 51);
            LblName.Name = "LblName";
            LblName.Size = new Size(91, 15);
            LblName.TabIndex = 2;
            LblName.Text = "Name of Recipe";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(39, 88);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(55, 15);
            lblCat.TabIndex = 3;
            lblCat.Text = "Catagory";
            // 
            // BtnAddRecipe
            // 
            BtnAddRecipe.Location = new Point(39, 399);
            BtnAddRecipe.Name = "BtnAddRecipe";
            BtnAddRecipe.Size = new Size(356, 24);
            BtnAddRecipe.TabIndex = 5;
            BtnAddRecipe.Text = "Add Recipe";
            BtnAddRecipe.UseVisualStyleBackColor = true;
            BtnAddRecipe.Click += BtnAddRecipe_Click;
            // 
            // LstRecipes
            // 
            LstRecipes.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LstRecipes.FormattingEnabled = true;
            LstRecipes.Location = new Point(416, 100);
            LstRecipes.Name = "LstRecipes";
            LstRecipes.Size = new Size(372, 260);
            LstRecipes.TabIndex = 6;
            LstRecipes.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            LstRecipes.MouseDoubleClick += listBox2_MouseDoubleClick;
            // 
            // btnEditRec
            // 
            btnEditRec.BackgroundImageLayout = ImageLayout.None;
            btnEditRec.Location = new Point(416, 400);
            btnEditRec.Name = "btnEditRec";
            btnEditRec.Size = new Size(89, 22);
            btnEditRec.TabIndex = 7;
            btnEditRec.Text = "Edit-Begin";
            btnEditRec.UseVisualStyleBackColor = true;
            btnEditRec.Click += btnEditRec_Click;
            // 
            // BtnFinish
            // 
            BtnFinish.Location = new Point(511, 400);
            BtnFinish.Name = "BtnFinish";
            BtnFinish.Size = new Size(75, 23);
            BtnFinish.TabIndex = 8;
            BtnFinish.Text = "Edit-Finish";
            BtnFinish.UseVisualStyleBackColor = true;
            BtnFinish.Click += BtnFinish_Click;
            // 
            // BtnDel
            // 
            BtnDel.Location = new Point(605, 399);
            BtnDel.Name = "BtnDel";
            BtnDel.Size = new Size(75, 23);
            BtnDel.TabIndex = 9;
            BtnDel.Text = "Delete";
            BtnDel.UseVisualStyleBackColor = true;
            BtnDel.Click += BtnDel_Click;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(692, 400);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(96, 23);
            BtnClear.TabIndex = 10;
            BtnClear.Text = "Clear-Selection";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(435, 71);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Name";
            // 
            // CatagoryLabel
            // 
            CatagoryLabel.AutoSize = true;
            CatagoryLabel.Location = new Point(563, 71);
            CatagoryLabel.Name = "CatagoryLabel";
            CatagoryLabel.Size = new Size(55, 15);
            CatagoryLabel.TabIndex = 12;
            CatagoryLabel.Text = "Category";
            // 
            // NumOfIngLbl
            // 
            NumOfIngLbl.AutoSize = true;
            NumOfIngLbl.Location = new Point(676, 71);
            NumOfIngLbl.Name = "NumOfIngLbl";
            NumOfIngLbl.Size = new Size(112, 15);
            NumOfIngLbl.TabIndex = 13;
            NumOfIngLbl.Text = "Num Of Ingradients";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(153, 51);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(242, 23);
            txtRecipeName.TabIndex = 14;
            // 
            // TxtInstrouctions
            // 
            TxtInstrouctions.Location = new Point(39, 124);
            TxtInstrouctions.Multiline = true;
            TxtInstrouctions.Name = "TxtInstrouctions";
            TxtInstrouctions.Size = new Size(356, 265);
            TxtInstrouctions.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtInstrouctions);
            Controls.Add(txtRecipeName);
            Controls.Add(NumOfIngLbl);
            Controls.Add(CatagoryLabel);
            Controls.Add(NameLabel);
            Controls.Add(BtnClear);
            Controls.Add(BtnDel);
            Controls.Add(BtnFinish);
            Controls.Add(btnEditRec);
            Controls.Add(LstRecipes);
            Controls.Add(BtnAddRecipe);
            Controls.Add(lblCat);
            Controls.Add(LblName);
            Controls.Add(BtnAddIng);
            Controls.Add(comboBox1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button BtnAddIng;
        private Label LblName;
        private Label lblCat;
        private Button BtnAddRecipe;
        private ListBox LstRecipes;
        private Button btnEditRec;
        private Button BtnFinish;
        private Button BtnDel;
        private Button BtnClear;
        private Label NameLabel;
        private Label CatagoryLabel;
        private Label NumOfIngLbl;
        private TextBox txtRecipeName;
        private TextBox TxtInstrouctions;
    }
}
