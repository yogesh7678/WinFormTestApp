namespace WinFormsTestApp
{
    partial class FormCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirstNum = new System.Windows.Forms.Label();
            this.labelSecondNum = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.textBoxFirstNum = new System.Windows.Forms.TextBox();
            this.textBoxSecondNum = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.comboBoxSelectHobby = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSelectHobby = new System.Windows.Forms.Label();
            this.buttonAddHobby = new System.Windows.Forms.Button();
            this.labelAddHobby = new System.Windows.Forms.Label();
            this.textBoxAddHobby = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator Application";
            // 
            // labelFirstNum
            // 
            this.labelFirstNum.AutoSize = true;
            this.labelFirstNum.Location = new System.Drawing.Point(55, 88);
            this.labelFirstNum.Name = "labelFirstNum";
            this.labelFirstNum.Size = new System.Drawing.Size(135, 17);
            this.labelFirstNum.TabIndex = 1;
            this.labelFirstNum.Text = "Enter First Number: ";
            // 
            // labelSecondNum
            // 
            this.labelSecondNum.AutoSize = true;
            this.labelSecondNum.Location = new System.Drawing.Point(55, 133);
            this.labelSecondNum.Name = "labelSecondNum";
            this.labelSecondNum.Size = new System.Drawing.Size(156, 17);
            this.labelSecondNum.TabIndex = 2;
            this.labelSecondNum.Text = "Enter Second Number: ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(58, 182);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(340, 182);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(88, 27);
            this.buttonDivide.TabIndex = 4;
            this.buttonDivide.Text = "Divide";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(246, 182);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(88, 27);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "Multiply";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(152, 182);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(88, 27);
            this.buttonSubtract.TabIndex = 6;
            this.buttonSubtract.Text = "Subtract";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // textBoxFirstNum
            // 
            this.textBoxFirstNum.Location = new System.Drawing.Point(215, 90);
            this.textBoxFirstNum.Name = "textBoxFirstNum";
            this.textBoxFirstNum.Size = new System.Drawing.Size(213, 22);
            this.textBoxFirstNum.TabIndex = 7;
            // 
            // textBoxSecondNum
            // 
            this.textBoxSecondNum.Location = new System.Drawing.Point(215, 130);
            this.textBoxSecondNum.Name = "textBoxSecondNum";
            this.textBoxSecondNum.Size = new System.Drawing.Size(213, 22);
            this.textBoxSecondNum.TabIndex = 8;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(57, 226);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(370, 22);
            this.textBoxResult.TabIndex = 9;
            this.textBoxResult.Visible = false;
            // 
            // comboBoxSelectHobby
            // 
            this.comboBoxSelectHobby.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSelectHobby.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSelectHobby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectHobby.FormattingEnabled = true;
            this.comboBoxSelectHobby.Items.AddRange(new object[] {
            "WRITING",
            "READING",
            "SINGING",
            "DANCING",
            "LISTENING",
            "SWIMMING",
            "CRICKET"});
            this.comboBoxSelectHobby.Location = new System.Drawing.Point(215, 406);
            this.comboBoxSelectHobby.Name = "comboBoxSelectHobby";
            this.comboBoxSelectHobby.Size = new System.Drawing.Size(213, 24);
            this.comboBoxSelectHobby.TabIndex = 10;
            this.comboBoxSelectHobby.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Test Combo Box";
            // 
            // labelSelectHobby
            // 
            this.labelSelectHobby.AutoSize = true;
            this.labelSelectHobby.Location = new System.Drawing.Point(65, 413);
            this.labelSelectHobby.Name = "labelSelectHobby";
            this.labelSelectHobby.Size = new System.Drawing.Size(108, 17);
            this.labelSelectHobby.TabIndex = 12;
            this.labelSelectHobby.Text = "Select a Hobby:";
            // 
            // buttonAddHobby
            // 
            this.buttonAddHobby.Location = new System.Drawing.Point(215, 373);
            this.buttonAddHobby.Name = "buttonAddHobby";
            this.buttonAddHobby.Size = new System.Drawing.Size(88, 27);
            this.buttonAddHobby.TabIndex = 13;
            this.buttonAddHobby.Text = "Add";
            this.buttonAddHobby.UseVisualStyleBackColor = true;
            this.buttonAddHobby.Click += new System.EventHandler(this.buttonAddHobby_Click);
            // 
            // labelAddHobby
            // 
            this.labelAddHobby.AutoSize = true;
            this.labelAddHobby.Location = new System.Drawing.Point(65, 348);
            this.labelAddHobby.Name = "labelAddHobby";
            this.labelAddHobby.Size = new System.Drawing.Size(94, 17);
            this.labelAddHobby.TabIndex = 14;
            this.labelAddHobby.Text = "Add a Hobby:";
            // 
            // textBoxAddHobby
            // 
            this.textBoxAddHobby.Location = new System.Drawing.Point(215, 345);
            this.textBoxAddHobby.Name = "textBoxAddHobby";
            this.textBoxAddHobby.Size = new System.Drawing.Size(213, 22);
            this.textBoxAddHobby.TabIndex = 15;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(231, 305);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(55, 17);
            this.labelCount.TabIndex = 16;
            this.labelCount.Text = "(Count)";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(340, 373);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(88, 27);
            this.buttonRemove.TabIndex = 17;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(339, 461);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(88, 27);
            this.buttonNext.TabIndex = 18;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 500);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxAddHobby);
            this.Controls.Add(this.labelAddHobby);
            this.Controls.Add(this.buttonAddHobby);
            this.Controls.Add(this.labelSelectHobby);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSelectHobby);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSecondNum);
            this.Controls.Add(this.textBoxFirstNum);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSecondNum);
            this.Controls.Add(this.labelFirstNum);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirstNum;
        private System.Windows.Forms.Label labelSecondNum;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.TextBox textBoxFirstNum;
        private System.Windows.Forms.TextBox textBoxSecondNum;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.ComboBox comboBoxSelectHobby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSelectHobby;
        private System.Windows.Forms.Button buttonAddHobby;
        private System.Windows.Forms.Label labelAddHobby;
        private System.Windows.Forms.TextBox textBoxAddHobby;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonNext;
    }
}

