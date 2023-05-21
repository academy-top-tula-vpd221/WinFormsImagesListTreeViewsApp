namespace WinFormsImagesListTreeViewsApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            filesLargeImageList = new ImageList(components);
            dirListView = new ListView();
            filesSmallImageList = new ImageList(components);
            pathTextBox = new TextBox();
            viewDirButton = new Button();
            button1 = new Button();
            viewModeGroupBox = new GroupBox();
            vmLargeIconRadioButton = new RadioButton();
            vmTileRadioButton = new RadioButton();
            vmSmallIconRadioButton = new RadioButton();
            vmListRadioButton = new RadioButton();
            dirsTreeView = new TreeView();
            viewModeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // filesLargeImageList
            // 
            filesLargeImageList.ColorDepth = ColorDepth.Depth8Bit;
            filesLargeImageList.ImageSize = new Size(100, 100);
            filesLargeImageList.TransparentColor = Color.Transparent;
            // 
            // dirListView
            // 
            dirListView.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dirListView.LargeImageList = filesLargeImageList;
            dirListView.Location = new Point(344, 65);
            dirListView.Name = "dirListView";
            dirListView.Size = new Size(488, 373);
            dirListView.SmallImageList = filesSmallImageList;
            dirListView.TabIndex = 2;
            dirListView.UseCompatibleStateImageBehavior = false;
            // 
            // filesSmallImageList
            // 
            filesSmallImageList.ColorDepth = ColorDepth.Depth8Bit;
            filesSmallImageList.ImageSize = new Size(32, 32);
            filesSmallImageList.TransparentColor = Color.Transparent;
            // 
            // pathTextBox
            // 
            pathTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pathTextBox.Location = new Point(344, 13);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new Size(488, 32);
            pathTextBox.TabIndex = 3;
            // 
            // viewDirButton
            // 
            viewDirButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            viewDirButton.Location = new Point(898, 12);
            viewDirButton.Name = "viewDirButton";
            viewDirButton.Size = new Size(171, 32);
            viewDirButton.TabIndex = 4;
            viewDirButton.Text = "View Directory";
            viewDirButton.UseVisualStyleBackColor = true;
            viewDirButton.Click += viewDirButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(994, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // viewModeGroupBox
            // 
            viewModeGroupBox.Controls.Add(vmLargeIconRadioButton);
            viewModeGroupBox.Controls.Add(vmTileRadioButton);
            viewModeGroupBox.Controls.Add(vmSmallIconRadioButton);
            viewModeGroupBox.Controls.Add(vmListRadioButton);
            viewModeGroupBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            viewModeGroupBox.Location = new Point(869, 65);
            viewModeGroupBox.Name = "viewModeGroupBox";
            viewModeGroupBox.Size = new Size(200, 196);
            viewModeGroupBox.TabIndex = 6;
            viewModeGroupBox.TabStop = false;
            viewModeGroupBox.Text = "View Mode";
            // 
            // vmLargeIconRadioButton
            // 
            vmLargeIconRadioButton.AutoSize = true;
            vmLargeIconRadioButton.Location = new Point(20, 136);
            vmLargeIconRadioButton.Name = "vmLargeIconRadioButton";
            vmLargeIconRadioButton.Size = new Size(118, 29);
            vmLargeIconRadioButton.TabIndex = 0;
            vmLargeIconRadioButton.TabStop = true;
            vmLargeIconRadioButton.Text = "Large Icon";
            vmLargeIconRadioButton.UseVisualStyleBackColor = true;
            vmLargeIconRadioButton.CheckedChanged += vmListRadioButton_CheckedChanged;
            // 
            // vmTileRadioButton
            // 
            vmTileRadioButton.AutoSize = true;
            vmTileRadioButton.Location = new Point(20, 66);
            vmTileRadioButton.Name = "vmTileRadioButton";
            vmTileRadioButton.Size = new Size(60, 29);
            vmTileRadioButton.TabIndex = 0;
            vmTileRadioButton.TabStop = true;
            vmTileRadioButton.Text = "Tile";
            vmTileRadioButton.UseVisualStyleBackColor = true;
            vmTileRadioButton.CheckedChanged += vmListRadioButton_CheckedChanged;
            // 
            // vmSmallIconRadioButton
            // 
            vmSmallIconRadioButton.AutoSize = true;
            vmSmallIconRadioButton.Location = new Point(20, 101);
            vmSmallIconRadioButton.Name = "vmSmallIconRadioButton";
            vmSmallIconRadioButton.Size = new Size(117, 29);
            vmSmallIconRadioButton.TabIndex = 0;
            vmSmallIconRadioButton.TabStop = true;
            vmSmallIconRadioButton.Text = "Small Icon";
            vmSmallIconRadioButton.UseVisualStyleBackColor = true;
            vmSmallIconRadioButton.CheckedChanged += vmListRadioButton_CheckedChanged;
            // 
            // vmListRadioButton
            // 
            vmListRadioButton.AutoSize = true;
            vmListRadioButton.Location = new Point(20, 31);
            vmListRadioButton.Name = "vmListRadioButton";
            vmListRadioButton.Size = new Size(58, 29);
            vmListRadioButton.TabIndex = 0;
            vmListRadioButton.TabStop = true;
            vmListRadioButton.Text = "List";
            vmListRadioButton.UseVisualStyleBackColor = true;
            vmListRadioButton.CheckedChanged += vmListRadioButton_CheckedChanged;
            // 
            // dirsTreeView
            // 
            dirsTreeView.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dirsTreeView.Location = new Point(12, 12);
            dirsTreeView.Name = "dirsTreeView";
            dirsTreeView.Size = new Size(311, 426);
            dirsTreeView.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 450);
            Controls.Add(dirsTreeView);
            Controls.Add(viewModeGroupBox);
            Controls.Add(button1);
            Controls.Add(viewDirButton);
            Controls.Add(pathTextBox);
            Controls.Add(dirListView);
            Name = "MainForm";
            Text = "Explower";
            Load += MainForm_Load;
            viewModeGroupBox.ResumeLayout(false);
            viewModeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList filesLargeImageList;
        private ListView dirListView;
        private TextBox pathTextBox;
        private Button viewDirButton;
        private Button button1;
        private GroupBox viewModeGroupBox;
        private RadioButton vmListRadioButton;
        private RadioButton vmLargeIconRadioButton;
        private RadioButton vmTileRadioButton;
        private RadioButton vmSmallIconRadioButton;
        private ImageList filesSmallImageList;
        private TreeView dirsTreeView;
    }
}