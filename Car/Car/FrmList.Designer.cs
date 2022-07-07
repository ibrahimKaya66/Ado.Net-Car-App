
namespace Car
{
    partial class FrmList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.txtMaxYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGasoline = new System.Windows.Forms.CheckBox();
            this.cbGasolineLpg = new System.Windows.Forms.CheckBox();
            this.cbDiesel = new System.Windows.Forms.CheckBox();
            this.cbHibrid = new System.Windows.Forms.CheckBox();
            this.cbElectric = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbManuel = new System.Windows.Forms.CheckBox();
            this.cbSemiAutomatic = new System.Windows.Forms.CheckBox();
            this.cbAutomatic = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinKm = new System.Windows.Forms.TextBox();
            this.txtMaxKm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbHatchback = new System.Windows.Forms.CheckBox();
            this.cbSedan = new System.Windows.Forms.CheckBox();
            this.cbSuv = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinPower = new System.Windows.Forms.TextBox();
            this.txtMaxPower = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(215, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(476, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fiyat";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(13, 36);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(80, 20);
            this.txtMinPrice.TabIndex = 2;
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(118, 36);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(80, 20);
            this.txtMaxPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yıl";
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(13, 84);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(80, 20);
            this.txtMinYear.TabIndex = 2;
            // 
            // txtMaxYear
            // 
            this.txtMaxYear.Location = new System.Drawing.Point(118, 84);
            this.txtMaxYear.Name = "txtMaxYear";
            this.txtMaxYear.Size = new System.Drawing.Size(80, 20);
            this.txtMaxYear.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yakıt Cinsi";
            // 
            // cbGasoline
            // 
            this.cbGasoline.AutoSize = true;
            this.cbGasoline.Location = new System.Drawing.Point(13, 135);
            this.cbGasoline.Name = "cbGasoline";
            this.cbGasoline.Size = new System.Drawing.Size(58, 17);
            this.cbGasoline.TabIndex = 5;
            this.cbGasoline.Text = "Benzin";
            this.cbGasoline.UseVisualStyleBackColor = true;
            // 
            // cbGasolineLpg
            // 
            this.cbGasolineLpg.AutoSize = true;
            this.cbGasolineLpg.Location = new System.Drawing.Point(13, 158);
            this.cbGasolineLpg.Name = "cbGasolineLpg";
            this.cbGasolineLpg.Size = new System.Drawing.Size(98, 17);
            this.cbGasolineLpg.TabIndex = 5;
            this.cbGasolineLpg.Text = "Benzin Ve LPG";
            this.cbGasolineLpg.UseVisualStyleBackColor = true;
            // 
            // cbDiesel
            // 
            this.cbDiesel.AutoSize = true;
            this.cbDiesel.Location = new System.Drawing.Point(12, 181);
            this.cbDiesel.Name = "cbDiesel";
            this.cbDiesel.Size = new System.Drawing.Size(49, 17);
            this.cbDiesel.TabIndex = 5;
            this.cbDiesel.Text = "Dizel";
            this.cbDiesel.UseVisualStyleBackColor = true;
            // 
            // cbHibrid
            // 
            this.cbHibrid.AutoSize = true;
            this.cbHibrid.Location = new System.Drawing.Point(12, 204);
            this.cbHibrid.Name = "cbHibrid";
            this.cbHibrid.Size = new System.Drawing.Size(53, 17);
            this.cbHibrid.TabIndex = 5;
            this.cbHibrid.Text = "Hibrid";
            this.cbHibrid.UseVisualStyleBackColor = true;
            // 
            // cbElectric
            // 
            this.cbElectric.AutoSize = true;
            this.cbElectric.Location = new System.Drawing.Point(12, 227);
            this.cbElectric.Name = "cbElectric";
            this.cbElectric.Size = new System.Drawing.Size(61, 17);
            this.cbElectric.TabIndex = 5;
            this.cbElectric.Text = "Elektrik";
            this.cbElectric.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vites";
            // 
            // cbManuel
            // 
            this.cbManuel.AutoSize = true;
            this.cbManuel.Location = new System.Drawing.Point(13, 263);
            this.cbManuel.Name = "cbManuel";
            this.cbManuel.Size = new System.Drawing.Size(61, 17);
            this.cbManuel.TabIndex = 5;
            this.cbManuel.Text = "Manuel";
            this.cbManuel.UseVisualStyleBackColor = true;
            // 
            // cbSemiAutomatic
            // 
            this.cbSemiAutomatic.AutoSize = true;
            this.cbSemiAutomatic.Location = new System.Drawing.Point(13, 286);
            this.cbSemiAutomatic.Name = "cbSemiAutomatic";
            this.cbSemiAutomatic.Size = new System.Drawing.Size(89, 17);
            this.cbSemiAutomatic.TabIndex = 5;
            this.cbSemiAutomatic.Text = "Yarı Otomatik";
            this.cbSemiAutomatic.UseVisualStyleBackColor = true;
            // 
            // cbAutomatic
            // 
            this.cbAutomatic.AutoSize = true;
            this.cbAutomatic.Location = new System.Drawing.Point(12, 309);
            this.cbAutomatic.Name = "cbAutomatic";
            this.cbAutomatic.Size = new System.Drawing.Size(68, 17);
            this.cbAutomatic.TabIndex = 5;
            this.cbAutomatic.Text = "Otomatik";
            this.cbAutomatic.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Km";
            // 
            // txtMinKm
            // 
            this.txtMinKm.Location = new System.Drawing.Point(13, 340);
            this.txtMinKm.Name = "txtMinKm";
            this.txtMinKm.Size = new System.Drawing.Size(80, 20);
            this.txtMinKm.TabIndex = 2;
            // 
            // txtMaxKm
            // 
            this.txtMaxKm.Location = new System.Drawing.Point(118, 340);
            this.txtMaxKm.Name = "txtMaxKm";
            this.txtMaxKm.Size = new System.Drawing.Size(80, 20);
            this.txtMaxKm.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Kasa Tipi";
            // 
            // cbHatchback
            // 
            this.cbHatchback.AutoSize = true;
            this.cbHatchback.Location = new System.Drawing.Point(12, 387);
            this.cbHatchback.Name = "cbHatchback";
            this.cbHatchback.Size = new System.Drawing.Size(79, 17);
            this.cbHatchback.TabIndex = 5;
            this.cbHatchback.Text = "Hatchback";
            this.cbHatchback.UseVisualStyleBackColor = true;
            // 
            // cbSedan
            // 
            this.cbSedan.AutoSize = true;
            this.cbSedan.Location = new System.Drawing.Point(12, 410);
            this.cbSedan.Name = "cbSedan";
            this.cbSedan.Size = new System.Drawing.Size(57, 17);
            this.cbSedan.TabIndex = 5;
            this.cbSedan.Text = "Sedan";
            this.cbSedan.UseVisualStyleBackColor = true;
            // 
            // cbSuv
            // 
            this.cbSuv.AutoSize = true;
            this.cbSuv.Location = new System.Drawing.Point(11, 433);
            this.cbSuv.Name = "cbSuv";
            this.cbSuv.Size = new System.Drawing.Size(48, 17);
            this.cbSuv.TabIndex = 5;
            this.cbSuv.Text = "SUV";
            this.cbSuv.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Motor Gücü";
            // 
            // txtMinPower
            // 
            this.txtMinPower.Location = new System.Drawing.Point(13, 462);
            this.txtMinPower.Name = "txtMinPower";
            this.txtMinPower.Size = new System.Drawing.Size(80, 20);
            this.txtMinPower.TabIndex = 2;
            // 
            // txtMaxPower
            // 
            this.txtMaxPower.Location = new System.Drawing.Point(118, 462);
            this.txtMaxPower.Name = "txtMaxPower";
            this.txtMaxPower.Size = new System.Drawing.Size(80, 20);
            this.txtMaxPower.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "--";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Location = new System.Drawing.Point(58, 499);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnList
            // 
            this.btnList.BackgroundImage = global::Car.Properties.Resources.list;
            this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnList.Location = new System.Drawing.Point(215, 7);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(50, 23);
            this.btnList.TabIndex = 7;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // cbSort
            // 
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Fiyata Göre(Önce En Yüksek)",
            "Fiyata Göre(Önce En Düşük)",
            "Km\'ye Göre(Önce En Yüksek)",
            "Km\'ye Göre(Önce En Düşük)",
            "Yıla Göre(Önce En Yüksek)",
            "Yıla Göre(Önce En Düşük)"});
            this.cbSort.Location = new System.Drawing.Point(441, 7);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(250, 21);
            this.cbSort.TabIndex = 8;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 534);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbElectric);
            this.Controls.Add(this.cbHibrid);
            this.Controls.Add(this.cbSuv);
            this.Controls.Add(this.cbAutomatic);
            this.Controls.Add(this.cbDiesel);
            this.Controls.Add(this.cbSedan);
            this.Controls.Add(this.cbSemiAutomatic);
            this.Controls.Add(this.cbGasolineLpg);
            this.Controls.Add(this.cbHatchback);
            this.Controls.Add(this.cbManuel);
            this.Controls.Add(this.cbGasoline);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaxPower);
            this.Controls.Add(this.txtMinPower);
            this.Controls.Add(this.txtMaxKm);
            this.Controls.Add(this.txtMinKm);
            this.Controls.Add(this.txtMaxYear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMinYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmList";
            this.Text = "Araç Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.TextBox txtMaxYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbGasoline;
        private System.Windows.Forms.CheckBox cbGasolineLpg;
        private System.Windows.Forms.CheckBox cbDiesel;
        private System.Windows.Forms.CheckBox cbHibrid;
        private System.Windows.Forms.CheckBox cbElectric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbManuel;
        private System.Windows.Forms.CheckBox cbSemiAutomatic;
        private System.Windows.Forms.CheckBox cbAutomatic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinKm;
        private System.Windows.Forms.TextBox txtMaxKm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbHatchback;
        private System.Windows.Forms.CheckBox cbSedan;
        private System.Windows.Forms.CheckBox cbSuv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinPower;
        private System.Windows.Forms.TextBox txtMaxPower;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox cbSort;
    }
}