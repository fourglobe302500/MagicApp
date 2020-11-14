
namespace MagicUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.playerNickName = new System.Windows.Forms.Label();
            this.header2Label = new System.Windows.Forms.Label();
            this.changePasswordLink = new System.Windows.Forms.LinkLabel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.playerID = new System.Windows.Forms.Label();
            this.decksLabel = new System.Windows.Forms.Label();
            this.playerCurrentDeck = new System.Windows.Forms.ComboBox();
            this.cardsInDeck = new System.Windows.Forms.ListBox();
            this.manageDeckscmd = new System.Windows.Forms.Button();
            this.battleDivision = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.headerLabel.Location = new System.Drawing.Point(12, -1);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(136, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Player: ";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.playerName.Location = new System.Drawing.Point(125, -1);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(150, 50);
            this.playerName.TabIndex = 1;
            this.playerName.Text = "<none>";
            // 
            // playerNickName
            // 
            this.playerNickName.AutoSize = true;
            this.playerNickName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNickName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.playerNickName.Location = new System.Drawing.Point(583, -1);
            this.playerNickName.Name = "playerNickName";
            this.playerNickName.Size = new System.Drawing.Size(150, 50);
            this.playerNickName.TabIndex = 3;
            this.playerNickName.Text = "<none>";
            // 
            // header2Label
            // 
            this.header2Label.AutoSize = true;
            this.header2Label.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.header2Label.Location = new System.Drawing.Point(407, -1);
            this.header2Label.Name = "header2Label";
            this.header2Label.Size = new System.Drawing.Size(189, 50);
            this.header2Label.TabIndex = 2;
            this.header2Label.Text = "NickName:";
            // 
            // changePasswordLink
            // 
            this.changePasswordLink.AutoSize = true;
            this.changePasswordLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.changePasswordLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.changePasswordLink.Location = new System.Drawing.Point(15, 49);
            this.changePasswordLink.Name = "changePasswordLink";
            this.changePasswordLink.Size = new System.Drawing.Size(144, 21);
            this.changePasswordLink.TabIndex = 4;
            this.changePasswordLink.TabStop = true;
            this.changePasswordLink.Text = "Change Password";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.IDLabel.Location = new System.Drawing.Point(184, 49);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(28, 21);
            this.IDLabel.TabIndex = 5;
            this.IDLabel.Text = "ID:";
            // 
            // playerID
            // 
            this.playerID.AutoSize = true;
            this.playerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.playerID.Location = new System.Drawing.Point(208, 49);
            this.playerID.Name = "playerID";
            this.playerID.Size = new System.Drawing.Size(67, 21);
            this.playerID.TabIndex = 6;
            this.playerID.Text = "<none>";
            // 
            // decksLabel
            // 
            this.decksLabel.AutoSize = true;
            this.decksLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.decksLabel.Location = new System.Drawing.Point(16, 79);
            this.decksLabel.Name = "decksLabel";
            this.decksLabel.Size = new System.Drawing.Size(73, 30);
            this.decksLabel.TabIndex = 7;
            this.decksLabel.Text = "Decks:";
            // 
            // playerCurrentDeck
            // 
            this.playerCurrentDeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.playerCurrentDeck.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.playerCurrentDeck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerCurrentDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerCurrentDeck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCurrentDeck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.playerCurrentDeck.FormattingEnabled = true;
            this.playerCurrentDeck.Location = new System.Drawing.Point(85, 75);
            this.playerCurrentDeck.Name = "playerCurrentDeck";
            this.playerCurrentDeck.Size = new System.Drawing.Size(168, 34);
            this.playerCurrentDeck.TabIndex = 8;
            // 
            // cardsInDeck
            // 
            this.cardsInDeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.cardsInDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardsInDeck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.cardsInDeck.FormattingEnabled = true;
            this.cardsInDeck.ItemHeight = 30;
            this.cardsInDeck.Location = new System.Drawing.Point(21, 115);
            this.cardsInDeck.Name = "cardsInDeck";
            this.cardsInDeck.Size = new System.Drawing.Size(381, 422);
            this.cardsInDeck.TabIndex = 9;
            // 
            // manageDeckscmd
            // 
            this.manageDeckscmd.AutoSize = true;
            this.manageDeckscmd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.manageDeckscmd.FlatAppearance.BorderSize = 4;
            this.manageDeckscmd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDeckscmd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.manageDeckscmd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.manageDeckscmd.Location = new System.Drawing.Point(259, 74);
            this.manageDeckscmd.Name = "manageDeckscmd";
            this.manageDeckscmd.Size = new System.Drawing.Size(143, 35);
            this.manageDeckscmd.TabIndex = 10;
            this.manageDeckscmd.Text = "Manage decks";
            this.manageDeckscmd.UseVisualStyleBackColor = false;
            // 
            // battleDivision
            // 
            this.battleDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.battleDivision.Location = new System.Drawing.Point(416, 49);
            this.battleDivision.Name = "battleDivision";
            this.battleDivision.Size = new System.Drawing.Size(431, 488);
            this.battleDivision.TabIndex = 11;
            this.battleDivision.TabStop = false;
            this.battleDivision.Text = "Battle Stuff TODO";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(3)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.battleDivision);
            this.Controls.Add(this.manageDeckscmd);
            this.Controls.Add(this.cardsInDeck);
            this.Controls.Add(this.playerCurrentDeck);
            this.Controls.Add(this.decksLabel);
            this.Controls.Add(this.playerID);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.changePasswordLink);
            this.Controls.Add(this.playerNickName);
            this.Controls.Add(this.header2Label);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.headerLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(113)))), ((int)(((byte)(131)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainForm";
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label playerNickName;
        private System.Windows.Forms.Label header2Label;
        private System.Windows.Forms.LinkLabel changePasswordLink;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label playerID;
        private System.Windows.Forms.Label decksLabel;
        private System.Windows.Forms.ComboBox playerCurrentDeck;
        private System.Windows.Forms.ListBox cardsInDeck;
        private System.Windows.Forms.Button manageDeckscmd;
        private System.Windows.Forms.GroupBox battleDivision;
    }
}

