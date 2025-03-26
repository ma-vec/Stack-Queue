namespace example_stack_queue
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
            buttonStop_St = new Button();
            buttonStop_Qu = new Button();
            listBoxSt = new ListBox();
            listBoxQu = new ListBox();
            buttonStart_St = new Button();
            buttonStart_Qu = new Button();
            SuspendLayout();
            // 
            // buttonStop_St
            // 
            buttonStop_St.Location = new Point(84, 264);
            buttonStop_St.Name = "buttonStop_St";
            buttonStop_St.Size = new Size(202, 23);
            buttonStop_St.TabIndex = 0;
            buttonStop_St.Text = "Stop Stack";
            buttonStop_St.UseVisualStyleBackColor = true;
            buttonStop_St.Click += buttonSt_Click;
            // 
            // buttonStop_Qu
            // 
            buttonStop_Qu.Location = new Point(433, 264);
            buttonStop_Qu.Name = "buttonStop_Qu";
            buttonStop_Qu.Size = new Size(202, 23);
            buttonStop_Qu.TabIndex = 1;
            buttonStop_Qu.Text = "Stop Queue";
            buttonStop_Qu.UseVisualStyleBackColor = true;
            buttonStop_Qu.Click += buttonStop_Qu_Click;
            // 
            // listBoxSt
            // 
            listBoxSt.FormattingEnabled = true;
            listBoxSt.ItemHeight = 15;
            listBoxSt.Location = new Point(84, 48);
            listBoxSt.Name = "listBoxSt";
            listBoxSt.Size = new Size(202, 199);
            listBoxSt.TabIndex = 2;
            // 
            // listBoxQu
            // 
            listBoxQu.FormattingEnabled = true;
            listBoxQu.ItemHeight = 15;
            listBoxQu.Location = new Point(433, 48);
            listBoxQu.Name = "listBoxQu";
            listBoxQu.Size = new Size(202, 199);
            listBoxQu.TabIndex = 3;
            // 
            // buttonStart_St
            // 
            buttonStart_St.Location = new Point(84, 19);
            buttonStart_St.Name = "buttonStart_St";
            buttonStart_St.Size = new Size(202, 23);
            buttonStart_St.TabIndex = 4;
            buttonStart_St.Text = "START";
            buttonStart_St.UseVisualStyleBackColor = true;
            buttonStart_St.Click += buttonStart_Click;
            // 
            // buttonStart_Qu
            // 
            buttonStart_Qu.Location = new Point(433, 19);
            buttonStart_Qu.Name = "buttonStart_Qu";
            buttonStart_Qu.Size = new Size(202, 23);
            buttonStart_Qu.TabIndex = 5;
            buttonStart_Qu.Text = "START";
            buttonStart_Qu.UseVisualStyleBackColor = true;
            buttonStart_Qu.Click += buttonStart_Qu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStart_Qu);
            Controls.Add(buttonStart_St);
            Controls.Add(listBoxQu);
            Controls.Add(listBoxSt);
            Controls.Add(buttonStop_Qu);
            Controls.Add(buttonStop_St);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStop_St;
        private Button buttonStop_Qu;
        private ListBox listBoxSt;
        private ListBox listBoxQu;
        private Button buttonStart_St;
        private Button buttonStart_Qu;
    }
}
