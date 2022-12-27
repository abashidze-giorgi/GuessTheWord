namespace GuessTheWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.List_words = new System.Windows.Forms.ListBox();
            this.List_positions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_answer = new System.Windows.Forms.Label();
            this.Txt_answer = new System.Windows.Forms.TextBox();
            this.Btn_answer = new System.Windows.Forms.Button();
            this.Lbl_secret_text = new System.Windows.Forms.Label();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_step = new System.Windows.Forms.Label();
            this.Btn_show = new System.Windows.Forms.Button();
            this.Lbl_gameover = new System.Windows.Forms.Label();
            this.Cmb_Language = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // List_words
            // 
            this.List_words.FormattingEnabled = true;
            resources.ApplyResources(this.List_words, "List_words");
            this.List_words.Name = "List_words";
            // 
            // List_positions
            // 
            this.List_positions.FormattingEnabled = true;
            resources.ApplyResources(this.List_positions, "List_positions");
            this.List_positions.Name = "List_positions";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // list_answer
            // 
            resources.ApplyResources(this.list_answer, "list_answer");
            this.list_answer.Name = "list_answer";
            // 
            // Txt_answer
            // 
            resources.ApplyResources(this.Txt_answer, "Txt_answer");
            this.Txt_answer.Name = "Txt_answer";
            this.Txt_answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_answer_KeyPress);
            // 
            // Btn_answer
            // 
            resources.ApplyResources(this.Btn_answer, "Btn_answer");
            this.Btn_answer.Name = "Btn_answer";
            this.Btn_answer.UseVisualStyleBackColor = true;
            this.Btn_answer.Click += new System.EventHandler(this.Btn_answer_Click);
            // 
            // Lbl_secret_text
            // 
            resources.ApplyResources(this.Lbl_secret_text, "Lbl_secret_text");
            this.Lbl_secret_text.Name = "Lbl_secret_text";
            // 
            // Btn_reset
            // 
            resources.ApplyResources(this.Btn_reset, "Btn_reset");
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Lbl_step
            // 
            resources.ApplyResources(this.Lbl_step, "Lbl_step");
            this.Lbl_step.Name = "Lbl_step";
            // 
            // Btn_show
            // 
            resources.ApplyResources(this.Btn_show, "Btn_show");
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.UseVisualStyleBackColor = true;
            this.Btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // Lbl_gameover
            // 
            resources.ApplyResources(this.Lbl_gameover, "Lbl_gameover");
            this.Lbl_gameover.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_gameover.Name = "Lbl_gameover";
            // 
            // Cmb_Language
            // 
            this.Cmb_Language.FormattingEnabled = true;
            this.Cmb_Language.Items.AddRange(new object[] {
            resources.GetString("Cmb_Language.Items"),
            resources.GetString("Cmb_Language.Items1"),
            resources.GetString("Cmb_Language.Items2")});
            resources.ApplyResources(this.Cmb_Language, "Cmb_Language");
            this.Cmb_Language.Name = "Cmb_Language";
            this.Cmb_Language.DropDownClosed += new System.EventHandler(this.Cmb_Language_DropDownClosed);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cmb_Language);
            this.Controls.Add(this.Lbl_gameover);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.Lbl_step);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Lbl_secret_text);
            this.Controls.Add(this.Btn_answer);
            this.Controls.Add(this.Txt_answer);
            this.Controls.Add(this.list_answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_positions);
            this.Controls.Add(this.List_words);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox List_words;
        private ListBox List_positions;
        private Label label1;
        private Label list_answer;
        private TextBox Txt_answer;
        private Button Btn_answer;
        private Label Lbl_secret_text;
        private Button Btn_reset;
        private Label label2;
        private Label Lbl_step;
        private Button Btn_show;
        private Label Lbl_gameover;
        private ComboBox Cmb_Language;
        private Label label3;
    }
}