namespace WEEK4
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
            this.label_soccerteamlist = new System.Windows.Forms.Label();
            this.label_choosecountry = new System.Windows.Forms.Label();
            this.label_chooseteam = new System.Windows.Forms.Label();
            this.listbox_list = new System.Windows.Forms.ListBox();
            this.combobox_choosecountry = new System.Windows.Forms.ComboBox();
            this.combobox_chooseteam = new System.Windows.Forms.ComboBox();
            this.label_addingteam = new System.Windows.Forms.Label();
            this.label_addingplayer = new System.Windows.Forms.Label();
            this.label_teamname = new System.Windows.Forms.Label();
            this.label_teamcountry = new System.Windows.Forms.Label();
            this.label_teamcity = new System.Windows.Forms.Label();
            this.txtbox_teamname = new System.Windows.Forms.TextBox();
            this.txtbox_teamcountry = new System.Windows.Forms.TextBox();
            this.txtbox_teamcity = new System.Windows.Forms.TextBox();
            this.label_playername = new System.Windows.Forms.Label();
            this.label_playernum = new System.Windows.Forms.Label();
            this.label_playerpos = new System.Windows.Forms.Label();
            this.txtbox_playername = new System.Windows.Forms.TextBox();
            this.txtbox_playernumber = new System.Windows.Forms.TextBox();
            this.combobox_playerposition = new System.Windows.Forms.ComboBox();
            this.button_addteam = new System.Windows.Forms.Button();
            this.button_addplayer = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_soccerteamlist
            // 
            this.label_soccerteamlist.AutoSize = true;
            this.label_soccerteamlist.Location = new System.Drawing.Point(12, 9);
            this.label_soccerteamlist.Name = "label_soccerteamlist";
            this.label_soccerteamlist.Size = new System.Drawing.Size(111, 15);
            this.label_soccerteamlist.TabIndex = 0;
            this.label_soccerteamlist.Text = "SOCCER TEAM LIST";
            // 
            // label_choosecountry
            // 
            this.label_choosecountry.AutoSize = true;
            this.label_choosecountry.Location = new System.Drawing.Point(12, 46);
            this.label_choosecountry.Name = "label_choosecountry";
            this.label_choosecountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_choosecountry.Size = new System.Drawing.Size(93, 15);
            this.label_choosecountry.TabIndex = 1;
            this.label_choosecountry.Text = "Choose Country";
            // 
            // label_chooseteam
            // 
            this.label_chooseteam.AutoSize = true;
            this.label_chooseteam.Location = new System.Drawing.Point(12, 80);
            this.label_chooseteam.Name = "label_chooseteam";
            this.label_chooseteam.Size = new System.Drawing.Size(80, 15);
            this.label_chooseteam.TabIndex = 2;
            this.label_chooseteam.Text = "Choose Team";
            // 
            // listbox_list
            // 
            this.listbox_list.FormattingEnabled = true;
            this.listbox_list.ItemHeight = 15;
            this.listbox_list.Location = new System.Drawing.Point(29, 181);
            this.listbox_list.Name = "listbox_list";
            this.listbox_list.Size = new System.Drawing.Size(301, 199);
            this.listbox_list.TabIndex = 3;
            this.listbox_list.SelectedValueChanged += new System.EventHandler(this.listbox_valuechange);
            // 
            // combobox_choosecountry
            // 
            this.combobox_choosecountry.FormattingEnabled = true;
            this.combobox_choosecountry.Location = new System.Drawing.Point(125, 46);
            this.combobox_choosecountry.Name = "combobox_choosecountry";
            this.combobox_choosecountry.Size = new System.Drawing.Size(121, 23);
            this.combobox_choosecountry.TabIndex = 4;
            this.combobox_choosecountry.SelectionChangeCommitted += new System.EventHandler(this.pilih_negara);
            // 
            // combobox_chooseteam
            // 
            this.combobox_chooseteam.FormattingEnabled = true;
            this.combobox_chooseteam.Location = new System.Drawing.Point(125, 77);
            this.combobox_chooseteam.Name = "combobox_chooseteam";
            this.combobox_chooseteam.Size = new System.Drawing.Size(121, 23);
            this.combobox_chooseteam.TabIndex = 5;
            this.combobox_chooseteam.SelectionChangeCommitted += new System.EventHandler(this.pilih_team);
            // 
            // label_addingteam
            // 
            this.label_addingteam.AutoSize = true;
            this.label_addingteam.Location = new System.Drawing.Point(350, 9);
            this.label_addingteam.Name = "label_addingteam";
            this.label_addingteam.Size = new System.Drawing.Size(86, 15);
            this.label_addingteam.TabIndex = 6;
            this.label_addingteam.Text = "ADDING TEAM";
            // 
            // label_addingplayer
            // 
            this.label_addingplayer.AutoSize = true;
            this.label_addingplayer.Location = new System.Drawing.Point(612, 9);
            this.label_addingplayer.Name = "label_addingplayer";
            this.label_addingplayer.Size = new System.Drawing.Size(95, 15);
            this.label_addingplayer.TabIndex = 7;
            this.label_addingplayer.Text = "ADDING PLAYER";
            // 
            // label_teamname
            // 
            this.label_teamname.AutoSize = true;
            this.label_teamname.Location = new System.Drawing.Point(309, 46);
            this.label_teamname.Name = "label_teamname";
            this.label_teamname.Size = new System.Drawing.Size(72, 15);
            this.label_teamname.TabIndex = 8;
            this.label_teamname.Text = "Team Name";
            // 
            // label_teamcountry
            // 
            this.label_teamcountry.AutoSize = true;
            this.label_teamcountry.Location = new System.Drawing.Point(309, 77);
            this.label_teamcountry.Name = "label_teamcountry";
            this.label_teamcountry.Size = new System.Drawing.Size(83, 15);
            this.label_teamcountry.TabIndex = 9;
            this.label_teamcountry.Text = "Team Country";
            // 
            // label_teamcity
            // 
            this.label_teamcity.AutoSize = true;
            this.label_teamcity.Location = new System.Drawing.Point(309, 106);
            this.label_teamcity.Name = "label_teamcity";
            this.label_teamcity.Size = new System.Drawing.Size(61, 15);
            this.label_teamcity.TabIndex = 10;
            this.label_teamcity.Text = "Team City";
            // 
            // txtbox_teamname
            // 
            this.txtbox_teamname.Location = new System.Drawing.Point(401, 46);
            this.txtbox_teamname.Name = "txtbox_teamname";
            this.txtbox_teamname.Size = new System.Drawing.Size(100, 23);
            this.txtbox_teamname.TabIndex = 11;
            // 
            // txtbox_teamcountry
            // 
            this.txtbox_teamcountry.Location = new System.Drawing.Point(401, 77);
            this.txtbox_teamcountry.Name = "txtbox_teamcountry";
            this.txtbox_teamcountry.Size = new System.Drawing.Size(100, 23);
            this.txtbox_teamcountry.TabIndex = 12;
            // 
            // txtbox_teamcity
            // 
            this.txtbox_teamcity.Location = new System.Drawing.Point(401, 106);
            this.txtbox_teamcity.Name = "txtbox_teamcity";
            this.txtbox_teamcity.Size = new System.Drawing.Size(100, 23);
            this.txtbox_teamcity.TabIndex = 13;
            // 
            // label_playername
            // 
            this.label_playername.AutoSize = true;
            this.label_playername.Location = new System.Drawing.Point(556, 49);
            this.label_playername.Name = "label_playername";
            this.label_playername.Size = new System.Drawing.Size(74, 15);
            this.label_playername.TabIndex = 14;
            this.label_playername.Text = "Player Name";
            // 
            // label_playernum
            // 
            this.label_playernum.AutoSize = true;
            this.label_playernum.Location = new System.Drawing.Point(556, 77);
            this.label_playernum.Name = "label_playernum";
            this.label_playernum.Size = new System.Drawing.Size(86, 15);
            this.label_playernum.TabIndex = 15;
            this.label_playernum.Text = "Player Number";
            // 
            // label_playerpos
            // 
            this.label_playerpos.AutoSize = true;
            this.label_playerpos.Location = new System.Drawing.Point(556, 106);
            this.label_playerpos.Name = "label_playerpos";
            this.label_playerpos.Size = new System.Drawing.Size(85, 15);
            this.label_playerpos.TabIndex = 16;
            this.label_playerpos.Text = "Player Position";
            // 
            // txtbox_playername
            // 
            this.txtbox_playername.Location = new System.Drawing.Point(660, 49);
            this.txtbox_playername.Name = "txtbox_playername";
            this.txtbox_playername.Size = new System.Drawing.Size(100, 23);
            this.txtbox_playername.TabIndex = 17;
            // 
            // txtbox_playernumber
            // 
            this.txtbox_playernumber.Location = new System.Drawing.Point(660, 78);
            this.txtbox_playernumber.Name = "txtbox_playernumber";
            this.txtbox_playernumber.Size = new System.Drawing.Size(100, 23);
            this.txtbox_playernumber.TabIndex = 18;
            // 
            // combobox_playerposition
            // 
            this.combobox_playerposition.FormattingEnabled = true;
            this.combobox_playerposition.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.combobox_playerposition.Location = new System.Drawing.Point(660, 106);
            this.combobox_playerposition.Name = "combobox_playerposition";
            this.combobox_playerposition.Size = new System.Drawing.Size(121, 23);
            this.combobox_playerposition.TabIndex = 19;
            // 
            // button_addteam
            // 
            this.button_addteam.Location = new System.Drawing.Point(401, 155);
            this.button_addteam.Name = "button_addteam";
            this.button_addteam.Size = new System.Drawing.Size(75, 23);
            this.button_addteam.TabIndex = 20;
            this.button_addteam.Text = "ADD";
            this.button_addteam.UseVisualStyleBackColor = true;
            this.button_addteam.Click += new System.EventHandler(this.button_addteam_Click);
            // 
            // button_addplayer
            // 
            this.button_addplayer.Location = new System.Drawing.Point(660, 155);
            this.button_addplayer.Name = "button_addplayer";
            this.button_addplayer.Size = new System.Drawing.Size(75, 23);
            this.button_addplayer.TabIndex = 21;
            this.button_addplayer.Text = "ADD";
            this.button_addplayer.UseVisualStyleBackColor = true;
            this.button_addplayer.Click += new System.EventHandler(this.button_addplayer_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(370, 322);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 22;
            this.button_remove.Text = "REMOVE";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_addplayer);
            this.Controls.Add(this.button_addteam);
            this.Controls.Add(this.combobox_playerposition);
            this.Controls.Add(this.txtbox_playernumber);
            this.Controls.Add(this.txtbox_playername);
            this.Controls.Add(this.label_playerpos);
            this.Controls.Add(this.label_playernum);
            this.Controls.Add(this.label_playername);
            this.Controls.Add(this.txtbox_teamcity);
            this.Controls.Add(this.txtbox_teamcountry);
            this.Controls.Add(this.txtbox_teamname);
            this.Controls.Add(this.label_teamcity);
            this.Controls.Add(this.label_teamcountry);
            this.Controls.Add(this.label_teamname);
            this.Controls.Add(this.label_addingplayer);
            this.Controls.Add(this.label_addingteam);
            this.Controls.Add(this.combobox_chooseteam);
            this.Controls.Add(this.combobox_choosecountry);
            this.Controls.Add(this.listbox_list);
            this.Controls.Add(this.label_chooseteam);
            this.Controls.Add(this.label_choosecountry);
            this.Controls.Add(this.label_soccerteamlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_soccerteamlist;
        private Label label_choosecountry;
        private Label label_chooseteam;
        private ListBox listbox_list;
        private ComboBox combobox_choosecountry;
        private ComboBox combobox_chooseteam;
        private Label label_addingteam;
        private Label label_addingplayer;
        private Label label_teamname;
        private Label label_teamcountry;
        private Label label_teamcity;
        private TextBox txtbox_teamname;
        private TextBox txtbox_teamcountry;
        private TextBox txtbox_teamcity;
        private Label label_playername;
        private Label label_playernum;
        private Label label_playerpos;
        private TextBox txtbox_playername;
        private TextBox txtbox_playernumber;
        private ComboBox combobox_playerposition;
        private Button button_addteam;
        private Button button_addplayer;
        private Button button_remove;
    }
}