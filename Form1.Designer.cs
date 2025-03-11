namespace TicTacToe
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
            this.components = new System.ComponentModel.Container();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblComputerWins = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.tlpGameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPlayerName = new System.Windows.Forms.TextBox();
            this.txtGameStatus = new System.Windows.Forms.TextBox();
            this.TxtPlayerName = new System.Windows.Forms.TextBox();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.NewGamebtn = new System.Windows.Forms.Button();
            this.tlpGameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(22, 0);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(127, 20);
            this.lblPlayerWins.TabIndex = 0;
            this.lblPlayerWins.Text = "Player Wins : 0";
            this.lblPlayerWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComputerWins
            // 
            this.lblComputerWins.AutoSize = true;
            this.lblComputerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWins.Location = new System.Drawing.Point(575, 0);
            this.lblComputerWins.Name = "lblComputerWins";
            this.lblComputerWins.Size = new System.Drawing.Size(112, 20);
            this.lblComputerWins.TabIndex = 1;
            this.lblComputerWins.Text = "Computer : 0";
            this.lblComputerWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(304, 0);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(67, 20);
            this.lblTies.TabIndex = 2;
            this.lblTies.Text = "Ties : 0";
            this.lblTies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpGameBoard
            // 
            this.tlpGameBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpGameBoard.ColumnCount = 3;
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tlpGameBoard.Controls.Add(this.btn9, 2, 2);
            this.tlpGameBoard.Controls.Add(this.btn8, 1, 2);
            this.tlpGameBoard.Controls.Add(this.btn7, 0, 2);
            this.tlpGameBoard.Controls.Add(this.btn6, 2, 1);
            this.tlpGameBoard.Controls.Add(this.btn5, 1, 1);
            this.tlpGameBoard.Controls.Add(this.btn4, 0, 1);
            this.tlpGameBoard.Controls.Add(this.btn3, 2, 0);
            this.tlpGameBoard.Controls.Add(this.btn2, 1, 0);
            this.tlpGameBoard.Controls.Add(this.btn1, 0, 0);
            this.tlpGameBoard.Location = new System.Drawing.Point(250, 82);
            this.tlpGameBoard.MaximumSize = new System.Drawing.Size(400, 400);
            this.tlpGameBoard.Name = "tlpGameBoard";
            this.tlpGameBoard.RowCount = 3;
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.40425F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.59575F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpGameBoard.Size = new System.Drawing.Size(396, 396);
            this.tlpGameBoard.TabIndex = 5;
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(260, 258);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(132, 134);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(126, 258);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(127, 134);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(4, 258);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(115, 134);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(260, 127);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(132, 124);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(126, 127);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(127, 124);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(4, 127);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(115, 124);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(260, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(132, 116);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(126, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(127, 116);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(115, 116);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(217, 560);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 32);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(563, 560);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(154, 32);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(531, 33);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(212, 26);
            this.lblPlayerName.TabIndex = 8;
            // 
            // txtGameStatus
            // 
            this.txtGameStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameStatus.Location = new System.Drawing.Point(356, 484);
            this.txtGameStatus.Multiline = true;
            this.txtGameStatus.Name = "txtGameStatus";
            this.txtGameStatus.ReadOnly = true;
            this.txtGameStatus.Size = new System.Drawing.Size(200, 61);
            this.txtGameStatus.TabIndex = 9;
            this.txtGameStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPlayerName
            // 
            this.TxtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlayerName.Location = new System.Drawing.Point(308, 33);
            this.TxtPlayerName.Name = "TxtPlayerName";
            this.TxtPlayerName.Size = new System.Drawing.Size(204, 26);
            this.TxtPlayerName.TabIndex = 10;
            // 
            // txtEnterName
            // 
            this.txtEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterName.Location = new System.Drawing.Point(201, 33);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(111, 26);
            this.txtEnterName.TabIndex = 11;
            this.txtEnterName.Text = "Enter Name:";
            // 
            // NewGamebtn
            // 
            this.NewGamebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NewGamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGamebtn.Location = new System.Drawing.Point(392, 560);
            this.NewGamebtn.Name = "NewGamebtn";
            this.NewGamebtn.Size = new System.Drawing.Size(154, 32);
            this.NewGamebtn.TabIndex = 12;
            this.NewGamebtn.Text = "New Game";
            this.NewGamebtn.UseVisualStyleBackColor = true;
            this.NewGamebtn.TextChanged += new System.EventHandler(this.NewGamebtn_Click);
            this.NewGamebtn.Click += new System.EventHandler(this.NewGamebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.NewGamebtn);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.TxtPlayerName);
            this.Controls.Add(this.txtGameStatus);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tlpGameBoard);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.lblComputerWins);
            this.Controls.Add(this.lblPlayerWins);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.tlpGameBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblComputerWins;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.TableLayoutPanel tlpGameBoard;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox lblPlayerName;
        private System.Windows.Forms.TextBox txtGameStatus;
        private System.Windows.Forms.TextBox TxtPlayerName;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Button NewGamebtn;
    }
}

