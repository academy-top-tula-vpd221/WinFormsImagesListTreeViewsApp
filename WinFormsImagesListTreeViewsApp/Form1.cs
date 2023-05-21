using System.Windows.Forms.VisualStyles;

namespace WinFormsImagesListTreeViewsApp
{
    public partial class MainForm : Form
    {
        Dictionary<string, int> fileTypes = new();
        public MainForm()
        {
            InitializeComponent();

            dirListView.View = View.List;

            ReadDrives();

            //TreeNode node = new TreeNode("TV");
            //node.Nodes.Add(new TreeNode("Sumsung TV"));
            //node.Nodes.Add(new TreeNode("LG SuperSonic"));
            //treeView1.Nodes[0].Nodes.Add(node);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string filesPath = @"X:\RPO\maxim efimov\VPD 221\files types img";
            string[] files = Directory.GetFiles(filesPath);
            int index = 0;
            foreach (string file in files)
            {
                string ext = file.Substring(file.LastIndexOf('.') + 1);
                string name = file.Remove(0, file.LastIndexOf('\\') + 1);
                name = name.Remove(name.LastIndexOf('.'));
                if (ext == "png" || ext == "jpg")
                {
                    fileTypes.Add(name, index++);
                    filesLargeImageList.Images.Add(Image.FromFile(file));
                    filesSmallImageList.Images.Add(Image.FromFile(file));
                }

            }



        }

        private void viewDirButton_Click(object sender, EventArgs e)
        {
            dirListView.Items.Clear();

            string path = pathTextBox.Text;

            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dir.Remove(0, dir.LastIndexOf('\\') + 1);
                item.ImageIndex = fileTypes["folder"]; ;
                dirListView.Items.Add(item);
            }

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                ListViewItem item = new ListViewItem();
                item.Text = file.Remove(0, file.LastIndexOf('\\') + 1);

                string ext = file.Substring(file.LastIndexOf('.') + 1);
                if (fileTypes.ContainsKey(ext))
                    item.ImageIndex = fileTypes[ext];
                else
                    item.ImageIndex = fileTypes["file"];
                dirListView.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string s = "";
            //foreach (var item in fileTypes)
            //{
            //    s += $"{item.Key} {item.Value}\n";
            //}

            //MessageBox.Show(s);
        }

        private void vmListRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                switch (radioButton.Text)
                {
                    case "List": dirListView.View = View.List; break;
                    case "Tile": dirListView.View = View.Tile; break;
                    case "Small Icon": dirListView.View = View.SmallIcon; break;
                    case "Large Icon": dirListView.View = View.LargeIcon; break;
                }
            }
        }

        void ReadDrives()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady)
                    {
                        TreeNode driveNode = new() { Text = drive.Name };
                        ReadDirectory(driveNode, drive.Name);
                        dirsTreeView.Nodes.Add(driveNode);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ReadDirectory(TreeNode parentNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf('\\') + 1);
                    parentNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}