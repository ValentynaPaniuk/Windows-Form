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

namespace Classwork20200508_ListView
{
    

    public partial class FileSystem : Form
    {
      
        public FileSystem()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath);

              
                

                //Витягуємо імена рядку Name
                for (int i = 0; i < files.Length; i++)
                {
                    table.Items.Add(new ListViewItem(Path.GetFileName(files[i]))); //витягуємо назви файлів і папок в рядок
                    
                }
                int j = 0;
                foreach (ListViewItem item in table.Items)
                {

                    if (Directory.Exists(files[j]))
                    {
                        j++;

                        continue;
                    }

                    item.SubItems.Add(File.Open(files[j], FileMode.Open).Length.ToString());//Size
                    item.SubItems.Add(File.GetCreationTime(files[j++]).ToShortDateString().ToString());//Date
                    
                   // item.SubItems.Add(Path.GetExtension(files[j++])); //Extention
                }
            }       
        }


        //Delete and Back
        string path = "";
        private void table_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Back)
            {
                table.Items.Add(path);
                File.Create(path);
            }

            if (table.SelectedIndices.Count == 0)
                return;
            
           try
            {
                int index;
                if (e.KeyCode == Keys.Delete)
                {
                   
                    while (table.SelectedIndices.Count != 0)
                    {
                       
                        index = table.SelectedIndices[0];
                        path = table.SelectedItems[0].Text.ToString();
                       
                        File.Delete(path);
                        table.Items.RemoveAt(index);

                    }

                }
               
                Refresh();
               
            }
            catch
            {
                MessageBox.Show("You did not click delete");
            }
      
        }

        //Відкриття внутрішніх папок
        private void table_DoubleClick(object sender, EventArgs e)
        {
            ListView table1 = (ListView)sender;

            folderBrowserDialog1.SelectedPath = folderBrowserDialog1.SelectedPath + $"\\{table.SelectedItems[0].Text}";

            string[] files = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath);

            table.Items.Clear();
            for (int i = 0; i < files.Length; i++)
            {
                table.Items.Add(new ListViewItem(Path.GetFileNameWithoutExtension(files[i])));
            }
           
            int j = 0;
            foreach (ListViewItem item in table.Items)
            {

                item.SubItems.Add(File.Open(files[j], FileMode.Open).Length.ToString());//Size
                item.SubItems.Add(File.GetCreationTime(files[j++]).ToShortDateString().ToString());//Date
               //item.SubItems.Add(Path.GetExtension(files[j++])); //Extention
            }

        }

        private void table_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            toolStripStatusLabel1.Text = $"Name: {e.Item.SubItems[0].Text},Size: {e.Item.SubItems[1].Text}, Date: {e.Item.SubItems[2].Text}";
            TbPath.Text = folderBrowserDialog1.SelectedPath + $"\\{table.SelectedItems[0].Text}";
        }

        //Sorting
        private void table_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            table.ListViewItemSorter =
          
        }



        //View
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (RadioButton item in groupBox1.Controls)
                {
                    if (item.Checked)
                    {
                        // перетворюємо текст кнопки до значення enum View
                        View view = (View)Enum.Parse(typeof(View), item.Text);
                        table.View = view;
                        errorProvider1.SetError((Control)sender, null);
                        break;
                    }
                }
            }
            catch
            {
                if (sender == radioButton5)
                    errorProvider1.SetError((Control)sender, "Change style in context menu");
            }
        }

        //З'являється або ні конткстне меню, яке включає або виключає checkBox
        private void checkedStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!radioButton5.Checked)
                checkedStyleToolStripMenuItem.Checked = !checkedStyleToolStripMenuItem.Checked;
                table.CheckBoxes = checkedStyleToolStripMenuItem.Checked;
        }





    }
}
    