
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200511_TreeView
{
    public partial class Explorer : Form
    {
      
        //Конструктор
        public Explorer()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
        }
        
        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateTreeView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateTreeView();
   
        }

        private void PopulateTreeView()
        {

            folderBrowserDialog1.ShowDialog();
            TreeNode rootNode;
            browseToolStripMenuItem.Checked = !browseToolStripMenuItem.Checked;
        
            DirectoryInfo info = new DirectoryInfo(folderBrowserDialog1.SelectedPath); //Створюємо каталог, яким будемо керувати
            if (info.Exists) //якщо існує такий каталог
            {
                rootNode = new TreeNode(info.Name); //створюємо ноду
                rootNode.Tag = info; //вказуємо тег для ноди
                GetDirectories(info.GetDirectories(), rootNode); // повертає підкаталоги діючого каталога
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs; 
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories(); // Отримайте посилання на кожен каталог у цьому каталозі.
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                int totalSize =(int) dir.EnumerateFiles().Sum(file => file.Length);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
                     new ListViewItem.ListViewSubItem(item,  dir.LastAccessTime.ToShortDateString()),
                     new ListViewItem.ListViewSubItem(item, totalSize.ToString() + " Kb")};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);

                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"), //Type
                      new ListViewItem.ListViewSubItem(item,  file.LastAccessTime.ToShortDateString()), //Date
                      new ListViewItem.ListViewSubItem(item,  file.Length.ToString()+" Kb") };//Size

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //delete and back
        string path = "";
        string backupDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string fName;

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            string[] files = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath);
        
            if (e.KeyCode == Keys.Back)
            {               
                listView1.Items.Add(path);
                File.Create(path);
                foreach (ListViewItem item in listView1.Items)
                {
                    item.SubItems.Add(Path.GetExtension(path));//Type
                    item.SubItems.Add(File.GetCreationTime(path).ToShortDateString().ToString());//Date
                    item.SubItems.Add(path.Length.ToString());//Size
                    
                }

          

                //Копіюється файл в потрібну папку
                foreach (string f in Directory.GetFiles(backupDir))
                {
                    // Remove path from the file name.
                    fName = f.Substring(backupDir.Length + 1); //ім'я файлу
                    if (path == fName)
                    {
                        File.Copy(Path.Combine(backupDir, fName), Path.Combine(folderBrowserDialog1.SelectedPath, fName), true);
                        File.Delete(f);
                    }
                }



            }

            //Якщо нічого не виділено для видалення
            if (listView1.SelectedIndices.Count == 0)
                return;

            //коли натискаємо Delete
            try
            {
               int index;
               if (e.KeyCode == Keys.Delete)
                 {

                   while (listView1.SelectedIndices.Count != 0)
                   {
                       index = listView1.SelectedIndices[0];//запам'ятовуємо індекс виділеного item
                       path = listView1.SelectedItems[0].Text.ToString(); //ім'я файлу
                       listView1.Items.RemoveAt(index); //видаляємо файл з listView
                    
                        //Копіюємо в іншу папку і видаляємо з цієї
                        foreach (string f in files)
                        {
                            // Remove path from the file name.
                            fName = f.Substring(folderBrowserDialog1.SelectedPath.Length + 1); //Повний шлях з ім'ям файлу
                            // MessageBox.Show($"Path: {path}  fName:{fName}");
                            if (path == fName)
                            {
                                File.Copy(Path.Combine(folderBrowserDialog1.SelectedPath, fName), Path.Combine(backupDir, fName), true);
                                File.Delete(f);
                            }
                        }
                    

                    }




                }

               Refresh();

            }
            catch
            {
                MessageBox.Show("You did not click delete");
            }

        }

        //Open folder input folder
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = folderBrowserDialog1.SelectedPath + $"\\{listView1.SelectedItems[0].Text}";
            string[] files = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath); //витягуємо шляхи до всіх файлів у каталозі
            listView1.Items.Clear();
            for (int i = 0; i < files.Length; i++)
            {
                listView1.Items.Add(new ListViewItem(Path.GetFileNameWithoutExtension(files[i])));//додаємо назви файлів до listView
            }

            int j = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                item.SubItems.Add(Path.GetExtension(files[j]));//Type
                item.SubItems.Add(File.GetCreationTime(files[j++]).ToShortDateString().ToString());//Date
               // item.SubItems.Add(files[j++].Length.ToString());//Size

            }

        }

        //Add text to Label and Path to textbox
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = $"Name: {e.Item.SubItems[0].Text}    Type: {e.Item.SubItems[1].Text}     Date: {e.Item.SubItems[2].Text}";
            TbPath.Text = folderBrowserDialog1.SelectedPath;
        }
        
        //View by Radiobutton
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (RadioButton item in groupBox1.Controls)
                {
                    if (item.Checked)
                    {
                        // перетворюємо текст кнопки до значення enum View
                        View view = (View)Enum.Parse(typeof(View), item.Text);

                        listView1.View = view;
                        errorProvider1.SetError((Control)sender, null);
                        break;
                    }
                }
                //Переключаємо значення контекстного меню
                foreach (ToolStripMenuItem item in viewToolStripMenuItem.DropDownItems)
                {
                    if (item.Text == listView1.View.ToString())
                        item.Checked = true;
                    else
                        item.Checked = false;
                }


            }
            catch
            {
                if (sender == radioButton5)
                    errorProvider1.SetError((Control)sender, "Change style in context menu");
            }



        }
     
        //View by ContextMenuStrip
        private void largeIconToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;

            if ((sender as ToolStripMenuItem).Checked)
            {
                // перетворюємо текст кнопки до значення enum View
                View view = (View)Enum.Parse(typeof(View), (sender as ToolStripMenuItem).Text);
                //Змінюємо вигляд перегляду
                listView1.View = view;

                if (tileToolStripMenuItem1.Checked)
                {
                    listView1.CheckBoxes = false;
                }
                foreach (RadioButton item in groupBox1.Controls)
                {
                    if (item.Text == listView1.View.ToString())
                        item.Checked = true;
                    else
                        item.Checked = false;
                }

            }


        }
      
        //З'являється галочка в контекстне меню Style, яке включає або виключає checkBox
        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!radioButton5.Checked)
            {
                styleToolStripMenuItem.Checked = !styleToolStripMenuItem.Checked;
                listView1.CheckBoxes = styleToolStripMenuItem.Checked;
            }
        }
    
        //Sorting by ColumnsClick
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }



    }

}
