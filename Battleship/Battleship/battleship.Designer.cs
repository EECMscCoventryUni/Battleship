namespace Battleship
{
    partial class battleship
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
            this.Board1 = new System.Windows.Forms.DataGridView();
            this.Board2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gameResult = new System.Windows.Forms.Label();
            this.player1shiplist = new System.Windows.Forms.ComboBox();
            this.player1shipalign = new System.Windows.Forms.ComboBox();
            this.player1message = new System.Windows.Forms.Label();
            this.player2message = new System.Windows.Forms.Label();
            this.player2shipalign = new System.Windows.Forms.ComboBox();
            this.player2shiplist = new System.Windows.Forms.ComboBox();
            this.player1doneplacing = new System.Windows.Forms.Button();
            this.player2doneplacing = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Board1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board2)).BeginInit();
            this.SuspendLayout();
            // 
            // Board1
            // 
            this.Board1.AllowUserToAddRows = false;
            this.Board1.AllowUserToDeleteRows = false;
            this.Board1.AllowUserToResizeColumns = false;
            this.Board1.AllowUserToResizeRows = false;
            this.Board1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Board1.Location = new System.Drawing.Point(69, 67);
            this.Board1.MultiSelect = false;
            this.Board1.Name = "Board1";
            this.Board1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Board1.Size = new System.Drawing.Size(965, 345);
            this.Board1.TabIndex = 0;
            // 
            // Board2
            // 
            this.Board2.AllowUserToAddRows = false;
            this.Board2.AllowUserToDeleteRows = false;
            this.Board2.AllowUserToResizeColumns = false;
            this.Board2.AllowUserToResizeRows = false;
            this.Board2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Board2.Location = new System.Drawing.Point(69, 503);
            this.Board2.MultiSelect = false;
            this.Board2.Name = "Board2";
            this.Board2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Board2.Size = new System.Drawing.Size(965, 352);
            this.Board2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1078, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Player 1 Place Ships";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1078, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Player 2 Place Ships";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(1078, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Player 1 Take Shot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(1078, 617);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "Player 2 Take Shot";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gameResult
            // 
            this.gameResult.AutoSize = true;
            this.gameResult.Location = new System.Drawing.Point(410, 13);
            this.gameResult.Name = "gameResult";
            this.gameResult.Size = new System.Drawing.Size(0, 13);
            this.gameResult.TabIndex = 6;
            // 
            // player1shiplist
            // 
            this.player1shiplist.FormattingEnabled = true;
            this.player1shiplist.Location = new System.Drawing.Point(1078, 71);
            this.player1shiplist.Name = "player1shiplist";
            this.player1shiplist.Size = new System.Drawing.Size(159, 21);
            this.player1shiplist.TabIndex = 7;
            // 
            // player1shipalign
            // 
            this.player1shipalign.FormattingEnabled = true;
            this.player1shipalign.Location = new System.Drawing.Point(1269, 71);
            this.player1shipalign.Name = "player1shipalign";
            this.player1shipalign.Size = new System.Drawing.Size(141, 21);
            this.player1shipalign.TabIndex = 8;
            // 
            // player1message
            // 
            this.player1message.AutoSize = true;
            this.player1message.Location = new System.Drawing.Point(66, 430);
            this.player1message.Name = "player1message";
            this.player1message.Size = new System.Drawing.Size(61, 13);
            this.player1message.TabIndex = 9;
            this.player1message.Text = "                  ";
            // 
            // player2message
            // 
            this.player2message.AutoSize = true;
            this.player2message.Location = new System.Drawing.Point(66, 878);
            this.player2message.Name = "player2message";
            this.player2message.Size = new System.Drawing.Size(46, 13);
            this.player2message.TabIndex = 10;
            this.player2message.Text = "             ";
            // 
            // player2shipalign
            // 
            this.player2shipalign.FormattingEnabled = true;
            this.player2shipalign.Location = new System.Drawing.Point(1269, 503);
            this.player2shipalign.Name = "player2shipalign";
            this.player2shipalign.Size = new System.Drawing.Size(141, 21);
            this.player2shipalign.TabIndex = 12;
            // 
            // player2shiplist
            // 
            this.player2shiplist.FormattingEnabled = true;
            this.player2shiplist.Location = new System.Drawing.Point(1078, 503);
            this.player2shiplist.Name = "player2shiplist";
            this.player2shiplist.Size = new System.Drawing.Size(159, 21);
            this.player2shiplist.TabIndex = 11;
            // 
            // player1doneplacing
            // 
            this.player1doneplacing.Location = new System.Drawing.Point(1269, 107);
            this.player1doneplacing.Name = "player1doneplacing";
            this.player1doneplacing.Size = new System.Drawing.Size(159, 36);
            this.player1doneplacing.TabIndex = 13;
            this.player1doneplacing.Text = "Player 1 Done Placing Ships";
            this.player1doneplacing.UseVisualStyleBackColor = true;
            this.player1doneplacing.Click += new System.EventHandler(this.player1doneplacing_Click);
            // 
            // player2doneplacing
            // 
            this.player2doneplacing.Location = new System.Drawing.Point(1269, 548);
            this.player2doneplacing.Name = "player2doneplacing";
            this.player2doneplacing.Size = new System.Drawing.Size(159, 36);
            this.player2doneplacing.TabIndex = 14;
            this.player2doneplacing.Text = "Player 2 Done Placing Ships";
            this.player2doneplacing.UseVisualStyleBackColor = true;
            this.player2doneplacing.Click += new System.EventHandler(this.player2doneplacing_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Location = new System.Drawing.Point(69, 936);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(159, 37);
            this.btnrestart.TabIndex = 15;
            this.btnrestart.Text = "Restart Game";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // battleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 1021);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.player2doneplacing);
            this.Controls.Add(this.player1doneplacing);
            this.Controls.Add(this.player2shipalign);
            this.Controls.Add(this.player2shiplist);
            this.Controls.Add(this.player2message);
            this.Controls.Add(this.player1message);
            this.Controls.Add(this.player1shipalign);
            this.Controls.Add(this.player1shiplist);
            this.Controls.Add(this.gameResult);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Board2);
            this.Controls.Add(this.Board1);
            this.Name = "battleship";
            this.Text = "Battleship";
            ((System.ComponentModel.ISupportInitialize)(this.Board1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Board1;
        private System.Windows.Forms.DataGridView Board2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label gameResult;
        private System.Windows.Forms.ComboBox player1shiplist;
        private System.Windows.Forms.ComboBox player1shipalign;
        private System.Windows.Forms.Label player1message;
        private System.Windows.Forms.Label player2message;
        private System.Windows.Forms.ComboBox player2shipalign;
        private System.Windows.Forms.ComboBox player2shiplist;
        private System.Windows.Forms.Button player1doneplacing;
        private System.Windows.Forms.Button player2doneplacing;
        private System.Windows.Forms.Button btnrestart;
    }
}

