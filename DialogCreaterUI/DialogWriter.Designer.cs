
namespace DialogCreaterUI
{
    partial class DialogWriter 
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
            this.MoveLast = new System.Windows.Forms.Button();
            this.MoveToNext = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputNPC_PHRASE = new System.Windows.Forms.RichTextBox();
            this.InputAnswer1 = new System.Windows.Forms.RichTextBox();
            this.Answer1 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.Label();
            this.InputAnswer2 = new System.Windows.Forms.RichTextBox();
            this.Answer3 = new System.Windows.Forms.Label();
            this.InputAnswer3 = new System.Windows.Forms.RichTextBox();
            this.Answer6 = new System.Windows.Forms.Label();
            this.InputAnswer6 = new System.Windows.Forms.RichTextBox();
            this.Answer5 = new System.Windows.Forms.Label();
            this.InputAnswer5 = new System.Windows.Forms.RichTextBox();
            this.Answer4 = new System.Windows.Forms.Label();
            this.InputAnswer4 = new System.Windows.Forms.RichTextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MoveLast
            // 
            this.MoveLast.Location = new System.Drawing.Point(69, 512);
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.Size = new System.Drawing.Size(141, 41);
            this.MoveLast.TabIndex = 0;
            this.MoveLast.Text = "Назад";
            this.MoveLast.UseVisualStyleBackColor = true;
            this.MoveLast.Click += new System.EventHandler(this.MoveLast_Click);
            // 
            // MoveToNext
            // 
            this.MoveToNext.Location = new System.Drawing.Point(291, 512);
            this.MoveToNext.Name = "MoveToNext";
            this.MoveToNext.Size = new System.Drawing.Size(141, 41);
            this.MoveToNext.TabIndex = 1;
            this.MoveToNext.Text = "Вперед";
            this.MoveToNext.UseVisualStyleBackColor = true;
            this.MoveToNext.Click += new System.EventHandler(this.MoveToNext_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(69, 575);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(363, 41);
            this.Save.TabIndex = 2;
            this.Save.Text = "Записать в файл";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фраза NPC";
            // 
            // InputNPC_PHRASE
            // 
            this.InputNPC_PHRASE.Location = new System.Drawing.Point(69, 106);
            this.InputNPC_PHRASE.Name = "InputNPC_PHRASE";
            this.InputNPC_PHRASE.Size = new System.Drawing.Size(363, 96);
            this.InputNPC_PHRASE.TabIndex = 4;
            this.InputNPC_PHRASE.Text = "";
            this.InputNPC_PHRASE.TextChanged += new System.EventHandler(this.InputNPC_PHRASE_TextChanged);
            // 
            // InputAnswer1
            // 
            this.InputAnswer1.Location = new System.Drawing.Point(69, 243);
            this.InputAnswer1.Name = "InputAnswer1";
            this.InputAnswer1.Size = new System.Drawing.Size(141, 60);
            this.InputAnswer1.TabIndex = 5;
            this.InputAnswer1.Text = "";
            this.InputAnswer1.TextChanged += new System.EventHandler(this.InputAnswer1_TextChanged);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(69, 225);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(47, 15);
            this.Answer1.TabIndex = 6;
            this.Answer1.Text = "Ответ 1";
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(69, 313);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(47, 15);
            this.Answer2.TabIndex = 8;
            this.Answer2.Text = "Ответ 2";
            // 
            // InputAnswer2
            // 
            this.InputAnswer2.Location = new System.Drawing.Point(69, 331);
            this.InputAnswer2.Name = "InputAnswer2";
            this.InputAnswer2.Size = new System.Drawing.Size(141, 60);
            this.InputAnswer2.TabIndex = 7;
            this.InputAnswer2.Text = "";
            this.InputAnswer2.TextChanged += new System.EventHandler(this.InputAnswer2_TextChanged);
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Location = new System.Drawing.Point(69, 405);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(47, 15);
            this.Answer3.TabIndex = 10;
            this.Answer3.Text = "Ответ 3";
            // 
            // InputAnswer3
            // 
            this.InputAnswer3.Location = new System.Drawing.Point(69, 423);
            this.InputAnswer3.Name = "InputAnswer3";
            this.InputAnswer3.Size = new System.Drawing.Size(141, 60);
            this.InputAnswer3.TabIndex = 9;
            this.InputAnswer3.Text = "";
            this.InputAnswer3.TextChanged += new System.EventHandler(this.InputAnswer3_TextChanged);
            // 
            // Answer6
            // 
            this.Answer6.AutoSize = true;
            this.Answer6.Location = new System.Drawing.Point(291, 405);
            this.Answer6.Name = "Answer6";
            this.Answer6.Size = new System.Drawing.Size(47, 15);
            this.Answer6.TabIndex = 16;
            this.Answer6.Text = "Ответ 6";
            // 
            // InputAnswer6
            // 
            this.InputAnswer6.Location = new System.Drawing.Point(291, 423);
            this.InputAnswer6.Name = "InputAnswer6";
            this.InputAnswer6.Size = new System.Drawing.Size(141, 60);
            this.InputAnswer6.TabIndex = 15;
            this.InputAnswer6.Text = "";
            this.InputAnswer6.TextChanged += new System.EventHandler(this.InputAnswer6_TextChanged);
            // 
            // Answer5
            // 
            this.Answer5.AutoSize = true;
            this.Answer5.Location = new System.Drawing.Point(291, 313);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(47, 15);
            this.Answer5.TabIndex = 14;
            this.Answer5.Text = "Ответ 5";
            // 
            // InputAnswer5
            // 
            this.InputAnswer5.Location = new System.Drawing.Point(291, 331);
            this.InputAnswer5.Name = "InputAnswer5";
            this.InputAnswer5.Size = new System.Drawing.Size(141, 60);
            this.InputAnswer5.TabIndex = 13;
            this.InputAnswer5.Text = "";
            this.InputAnswer5.TextChanged += new System.EventHandler(this.InputAnswer5_TextChanged);
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Location = new System.Drawing.Point(291, 225);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(47, 15);
            this.Answer4.TabIndex = 12;
            this.Answer4.Text = "Ответ 4";
            // 
            // InputAnswer4
            // 
            this.InputAnswer4.Location = new System.Drawing.Point(291, 243);
            this.InputAnswer4.Name = "InputAnswer4";
            this.InputAnswer4.Size = new System.Drawing.Size(141, 60);
            this.InputAnswer4.TabIndex = 11;
            this.InputAnswer4.Text = "";
            this.InputAnswer4.TextChanged += new System.EventHandler(this.InputAnswer4_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(69, 48);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 23);
            this.ID.TabIndex = 17;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(69, 27);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 15);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "ID фразы";
            // 
            // DialogWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 672);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Answer6);
            this.Controls.Add(this.InputAnswer6);
            this.Controls.Add(this.Answer5);
            this.Controls.Add(this.InputAnswer5);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.InputAnswer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.InputAnswer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.InputAnswer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.InputAnswer1);
            this.Controls.Add(this.InputNPC_PHRASE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.MoveToNext);
            this.Controls.Add(this.MoveLast);
            this.Name = "DialogWriter";
            this.Text = "DialogWriter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.Button MoveToNext;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox InputNPC_PHRASE;
        private System.Windows.Forms.RichTextBox InputAnswer1;
        private System.Windows.Forms.Label Answer1;
        private System.Windows.Forms.Label Answer2;
        private System.Windows.Forms.RichTextBox InputAnswer2;
        private System.Windows.Forms.Label Answer3;
        private System.Windows.Forms.RichTextBox InputAnswer3;
        private System.Windows.Forms.Label Answer6;
        private System.Windows.Forms.RichTextBox InputAnswer6;
        private System.Windows.Forms.Label Answer5;
        private System.Windows.Forms.RichTextBox InputAnswer5;
        private System.Windows.Forms.Label Answer4;
        private System.Windows.Forms.RichTextBox InputAnswer4;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label lbl;
    }
}