using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork20200430_Notepad
{
    public partial class Notepad : Form
    {
        public static readonly int COUNT_PUNCTS =8;

        Document child;
        public Notepad()
        {
            InitializeComponent();
          
            
            //Розмір шрифту по замовчуванню
            for (int i = 8; i < 72; i += 2) { toolStripComboBox1.Items.Add(i); }
            toolStripComboBox1.Text = Font.Size.ToString();


            //Додаємо шрифти в комбокс 2
            foreach (FontFamily font in FontFamily.Families)     { toolStripComboBox2.Items.Add(font.Name.ToString()); }
            //Вигляд шрифту по замовчуванню           
           toolStripComboBox2.Text = Font.ToString();

        }

        #region Metody
        //Save file
        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Files RTF|*.rtf|Document Office Open XML(*.docx)|*.docx|Text OpenDocument(*.odt)|*.odt|All files|*.*";
            saveFileDialog1.InitialDirectory = @"C:\Users\ADMIN\Desktop\Folder";//Початкова папка
            saveFileDialog1.FileName = openFileDialog1.FileName;
            saveFileDialog1.OverwritePrompt = true; //Перевіряє чи існує файл
            saveFileDialog1.Title = "Save file";

            //File.WriteAllText(saveFileDialog1.FileName,richTextBox1.Text); //Запис текстового файлу без форматування

            child.Richtextbox.SaveFile(saveFileDialog1.FileName);

            var dialogResult = saveFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                // var result = File.ReadAllText(openFileDialog1.FileName);// Зчитує текст файлу без форматування і записує в result
                //richTextBox1.Text = result;
                if (Path.GetExtension(openFileDialog1.FileName) == ".rtf") // Відділяємо .rtf розширення в файлі
                {
                    child.Richtextbox.SaveFile(saveFileDialog1.FileName); //збереження файлу з форматуванням
                    //MessageBox.Show("File is saved");
                }
                else
                {
                    child.Richtextbox.SaveFile(saveFileDialog1.FileName /*, RichTextBoxStreamType.PlainText*/); //відкриття файлу без форматування
                   // MessageBox.Show("File is saved");
                }
            }
            toolStripStatusLabel1.Text = $"Save file {saveFileDialog1.FileName}";

            if (dialogResult == DialogResult.Cancel)
                return;


        }
        //Open file
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Перевірка чи зберігати попередній файл
            var result = MessageBox.Show("Do you want to save changes to this file?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            { return; }


            openFileDialog1.Title = "Open file";
            openFileDialog1.Filter = "All files|*.*|Text files(*.txt)|*.txt|Files RTF|*.rtf|Document Office Open XML(*.docx)|*.docx|Text OpenDocument(*.odt)|*.odt"; // фільтр для файлів: Назва фільтру|маска фільтру
            openFileDialog1.FileName = "Type name here"; //Властивіть Filename
            openFileDialog1.InitialDirectory = @"C:\Users\ADMIN\Desktop\Folder";//Початкова папка

            var dialogResult = openFileDialog1.ShowDialog();
            toolStripStatusLabel1.Text = $"Open file {openFileDialog1.FileName}";

            if (dialogResult == DialogResult.OK)
            {
                // var result = File.ReadAllText(openFileDialog1.FileName);// Зчитує текст файлу без форматування і записує в result
                //richTextBox1.Text = result;
                if (Path.GetExtension(openFileDialog1.FileName) == ".rtf") // Відділяємо .rtf розширення в файлі
                {                                                         // Main_richTextBox1.LoadFile(openFileDialog1.FileName); //відкритя файлу з форматуванням
                    child.Richtextbox.LoadFile(openFileDialog1.FileName);
                }
                else
                {
                    // Main_richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText); //відкриття файлу без форматування
                    child.Richtextbox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.UnicodePlainText);
                    // MessageBox.Show("File is Open");
                }

            }
        }
        //Close form
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Font Closing";
            this.Text = "Wait for closing....";
            Thread.Sleep(1000);
            this.Close();
           // Application.Exit();
            
        }
        //Ctrl+Z
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.Richtextbox.Undo();
            toolStripStatusLabel1.Text = $"Undo";
        }
        //Ctrl+Y
        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            child.Richtextbox.Redo();
            toolStripStatusLabel1.Text = $"Redo";
        }
       //Change font
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Font";
           
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта

            if (child.Richtextbox.SelectionLength != 0)//якщо є виділений текст
            {
                child.Richtextbox.SelectionFont = fontDialog1.Font; //міняємо шрифт лише для виділеного тексту 
                child.Richtextbox.SelectionColor = fontDialog1.Color; // міняємо колір шрифту
            }
            else
            {
                child.Richtextbox.Font = fontDialog1.Font;
                child.Richtextbox.SelectAll();
                child.Richtextbox.SelectionColor = fontDialog1.Color;

            }
        }
        //Color dialog
        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // установка кольору шрифта
           // colorDialog1.ShowDialog();
            toolStripStatusLabel1.Text = $"Change Color";

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            if (child.Richtextbox.SelectionLength != 0)//якщо є виділений текст
                child.Richtextbox.SelectionColor = colorDialog1.Color; // Заливаємо лише виділений текст
            else
                child.Richtextbox.ForeColor = colorDialog1.Color; //заливаємо весь текст файлу
        }
        //View
        private void StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Visible = !trackBar1.Visible;
            statusStrip1.Visible = !statusStrip1.Visible;
            statusToolStripMenuItem.Checked = !statusToolStripMenuItem.Checked;


        }
        //Text Bold
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Text BOLD";
            //if (richTextBox1.SelectionFont != null)
            //{
            //    System.Drawing.Font currentFont =richTextBox1.SelectionFont;
            //    System.Drawing.FontStyle newFontStyle;

            //    if (richTextBox1.SelectionFont.Bold == true)
            //    {
            //        newFontStyle = FontStyle.Regular;
            //    }
            //    else
            //    {
            //        newFontStyle = FontStyle.Bold;
            //    }

            //   richTextBox1.SelectionFont = new Font(
            //       currentFont.FontFamily,
            //       currentFont.Size,
            //       newFontStyle
            //    );
            //}


            Font new1, old1;
            old1 = child.Richtextbox.SelectionFont;
            if (old1.Bold)
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Bold);

            child.Richtextbox.SelectionFont = new1;
            child.Richtextbox.Focus();

        }
        //Text Italic
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Text ITALIC";
          
            Font new1, old1;
            old1 = child.Richtextbox.SelectionFont;
            if (old1.Italic)
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Italic);

            child.Richtextbox.SelectionFont = new1;

            child.Richtextbox.Focus();
        }
        //Text Underline
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Text UNDERLINE";
           

            Font new1, old1;
            old1 = child.Richtextbox.SelectionFont;
            if (old1.Underline)
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Underline);

            child.Richtextbox.SelectionFont = new1;
            child.Richtextbox.Focus();
        }
        //Text Strikeout
        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Text STRIKEOUT";

            Font new1, old1;
            old1 = child.Richtextbox.SelectionFont;
            if (old1.Strikeout)
                new1 = new Font(old1, old1.Style & ~FontStyle.Strikeout);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Strikeout);

            child.Richtextbox.SelectionFont = new1;
            child.Richtextbox.Focus();
        }
        //Change Size
        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Size Font";

            if (child.Richtextbox.SelectionLength != 0)//якщо є виділений текст
            {
                child.Richtextbox.SelectionFont = new Font(child.Richtextbox.Font.FontFamily, Convert.ToSingle(toolStripComboBox1.SelectedItem));
            }
            else
            {
                child.Richtextbox.Font = new Font(child.Richtextbox.Font.FontFamily, Convert.ToSingle(toolStripComboBox1.SelectedItem));
            }
        }
        //Alignment Center
        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Alignment: Center";
            child.Richtextbox.SelectionAlignment = HorizontalAlignment.Center;
        }
        //Alignment Left
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Alignment: Left";
            child.Richtextbox.SelectionAlignment = HorizontalAlignment.Left;
        }
        //Alignment Right
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Alignment: Right";
            child.Richtextbox.SelectionAlignment = HorizontalAlignment.Right;
        }
        //Background
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Backcolor";
            colorDialog1.ShowDialog();
            child.Richtextbox.SelectionBackColor = colorDialog1.Color;
        }
        //Zoom
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Zoom";
            try
            {
                float factor = (float)trackBar1.Value * 2;
                child.Richtextbox.ZoomFactor = factor;
                this.Text = $"Text: {child.Richtextbox.ZoomFactor} Track: {trackBar1.Value}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exeption: {ex}");
            }
            if (trackBar1.Value == 1 || child.Richtextbox.ZoomFactor == 1)
                return;
        }
        //Change Font
        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Font";
            
            try
            {
               

                if (child.Richtextbox.SelectionLength != 0)//якщо є виділений текст
                {
                    child.Richtextbox.SelectionFont = new Font(toolStripComboBox2.Text, toolStripComboBox2.Font.Size);
                 
                }
                else
                {
                    child.Richtextbox.Font = new Font(toolStripComboBox2.Text, toolStripComboBox2.Font.Size);
                }
            }
            catch { }

        }
        //Formatting by list (список)
        private void toolStripButton14_Click(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = $"Create List";

            child.Richtextbox.SelectionBullet = !child.Richtextbox.SelectionBullet;

        }
        //Cleare all
        private void cleareAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Cleare ALL text";
            child.Richtextbox.Text = String.Empty;
        }
        //Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"CUT selected text";

            child.Richtextbox.Cut();

            //try
            //{
            //    if (richTextBox1.SelectedText.Length != 0)
            //    {
            //        Clipboard.SetData(DataFormats.Rtf,richTextBox1.Rtf);
            //       // Clipboard.SetText(richTextBox1.SelectedText);
            //       richTextBox1.SelectedText = String.Empty;

            //    }
            //    else
            //    {
            //        MessageBox.Show("No item is selected to cut");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Can't cut the selected item", ex.ToString());
            //}
        }
        //Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"PASTE selected text";

            child.Richtextbox.Paste();
            //try
            //{
            //    if (Clipboard.ContainsText(TextDataFormat.Rtf))
            //    {
            //       richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
                    
            //    }
            //    else if (Clipboard.ContainsText(TextDataFormat.Text))
            //    {
            //       richTextBox1.SelectedText = Clipboard.GetData(DataFormats.Text).ToString();
            //       // MessageBox.Show($"2{richTextBox1.SelectedText}");
            //    }

            //    else
            //    {
            //        MessageBox.Show("Clipboard is not contained with the valid text format");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Can't paste the item", ex.ToString());
            //}


        }
        //Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"COPY selected text";
            child.Richtextbox.Copy();
        }

        //Windows Cascade
        private void tileCascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        //Windows Horizontal
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        //    //Windows Vertical
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        //Windows Minimazed
        private void minimazeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Minimized;
            }
        }
        //Windows Maximazed
        private void maximazeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Maximized;
            }
        }
        //Windows restore
        private void restoreAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Normal;
            }
        }
        //Help
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!!!!!!!!!!!!!!!!");
        }
        #endregion


        int id = 0;
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if (Main_richTextBox1.Text != String.Empty)
            //{
            //    var result = MessageBox.Show("Do you want to save changes to this file?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //        return;
            //}

            //Main_richTextBox1.Text = "ФФФФФ";
            //Main_richTextBox1.Clear();

            child = new Document();
         
            child.Text += $" {++id}";
            child.MdiParent = this;

            child.Show();
            

            if (id == 1)
            windowToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            ToolStripMenuItem newItem = new ToolStripMenuItem(); // створили пункт меню
            newItem.Text = child.Text;
            #region click via anonimous delegate
            //newItem.Click += new EventHandler(
            //    delegate(object s, EventArgs args)
            //    {
            //        child.Focus();
            //    }
            //    ); 
            #endregion
            #region click via labmda
            newItem.Click += (o, s) =>
            {
                child.Focus();
                if (child.WindowState == FormWindowState.Minimized)
                    child.WindowState = FormWindowState.Normal;
            };
            #endregion
            windowToolStripMenuItem.DropDownItems.Add(newItem); // додали щойно створений пункт
            newItem.Checked = true;
            toolStripStatusLabel1.Text = child.Text;
        }

        public ToolStripMenuItem WindowPunct
        {
            get
            {
                return this.windowToolStripMenuItem;
            }
        }

        //Включає і виключає активне вікно
        private void Notepad_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
                return;

            Document child = (Document)this.ActiveMdiChild;
            if (child == null)
            {
                toolStripStatusLabel1.Text = "";
                id = 0;
                return;
            }
            foreach (ToolStripItem item in windowToolStripMenuItem.DropDownItems)
            {
                if (item is ToolStripMenuItem)
                    if (item.Text.Contains(child.Text))
                    {
                        (item as ToolStripMenuItem).Checked = true;
                       
                    }
                    else
                        (item as ToolStripMenuItem).Checked = false;
                        
            }

            toolStripStatusLabel1.Text = child.Text;

            this.child = child; //Запам'ятовуємо посилання активної форми
            
        }


       

    }
}
