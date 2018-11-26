namespace AspNetVS2017.Capitulo01.Troco
{
    partial class TrocoForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 14F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocoForm));
            this.valores_grpbox = new System.Windows.Forms.GroupBox();
            this.trocoTextBox = new System.Windows.Forms.TextBox();
            this.valorPagoTextBox = new System.Windows.Forms.TextBox();
            this.valorCompraTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moedasListView = new System.Windows.Forms.ListView();
            this.moedasImageList = new System.Windows.Forms.ImageList(this.components);
            this.valores_grpbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valores_grpbox
            // 
            this.valores_grpbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valores_grpbox.Controls.Add(this.trocoTextBox);
            this.valores_grpbox.Controls.Add(this.valorPagoTextBox);
            this.valores_grpbox.Controls.Add(this.valorCompraTextBox);
            this.valores_grpbox.Controls.Add(this.calcularButton);
            this.valores_grpbox.Controls.Add(this.label3);
            this.valores_grpbox.Controls.Add(this.label2);
            this.valores_grpbox.Controls.Add(this.label1);
            this.valores_grpbox.Location = new System.Drawing.Point(12, 12);
            this.valores_grpbox.Name = "valores_grpbox";
            this.valores_grpbox.Size = new System.Drawing.Size(315, 426);
            this.valores_grpbox.TabIndex = 0;
            this.valores_grpbox.TabStop = false;
            this.valores_grpbox.Text = "valores";
            // 
            // trocoTextBox
            // 
            this.trocoTextBox.Location = new System.Drawing.Point(113, 82);
            this.trocoTextBox.Name = "trocoTextBox";
            this.trocoTextBox.ReadOnly = true;
            this.trocoTextBox.Size = new System.Drawing.Size(170, 20);
            this.trocoTextBox.TabIndex = 5;
            // 
            // valorPagoTextBox
            // 
            this.valorPagoTextBox.Location = new System.Drawing.Point(113, 54);
            this.valorPagoTextBox.Name = "valorPagoTextBox";
            this.valorPagoTextBox.Size = new System.Drawing.Size(170, 20);
            this.valorPagoTextBox.TabIndex = 3;
            // 
            // valorCompraTextBox
            // 
            this.valorCompraTextBox.Location = new System.Drawing.Point(113, 26);
            this.valorCompraTextBox.Name = "valorCompraTextBox";
            this.valorCompraTextBox.Size = new System.Drawing.Size(170, 20);
            this.valorCompraTextBox.TabIndex = 1;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(19, 116);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(264, 23);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "C&alcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Troco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor da &Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da &Compra:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.moedasListView);
            this.groupBox1.Location = new System.Drawing.Point(333, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Troco";
            // 
            // moedasListView
            // 
            this.moedasListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moedasListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.moedasListView.LargeImageList = this.moedasImageList;
            this.moedasListView.Location = new System.Drawing.Point(3, 16);
            this.moedasListView.Name = "moedasListView";
            this.moedasListView.Size = new System.Drawing.Size(449, 407);
            this.moedasListView.TabIndex = 2;
            this.moedasListView.UseCompatibleStateImageBehavior = false;
            this.moedasListView.SelectedIndexChanged += new System.EventHandler(this.moedasListView_SelectedIndexChanged);
            // 
            // moedasImageList
            // 
            this.moedasImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moedasImageList.ImageStream")));
            this.moedasImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.moedasImageList.Images.SetKeyName(0, "1.png");
            this.moedasImageList.Images.SetKeyName(1, "5.png");
            this.moedasImageList.Images.SetKeyName(2, "10.png");
            this.moedasImageList.Images.SetKeyName(3, "25.png");
            this.moedasImageList.Images.SetKeyName(4, "50.png");
            this.moedasImageList.Images.SetKeyName(5, "100.png");
            // 
            // TrocoForm
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.valores_grpbox);
            this.Name = "TrocoForm";
            this.Text = "Troco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.valores_grpbox.ResumeLayout(false);
            this.valores_grpbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox valores_grpbox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trocoTextBox;
        private System.Windows.Forms.TextBox valorPagoTextBox;
        private System.Windows.Forms.TextBox valorCompraTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList moedasImageList;
        private System.Windows.Forms.ListView moedasListView;
    }
}

