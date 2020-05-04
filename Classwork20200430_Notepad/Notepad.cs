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
        public Notepad()
        {
            InitializeComponent();
            richTextBox1.Focus();

            //Розмір шрифту по замовчуванню
            for (int i = 8; i < 72; i += 2)        { toolStripComboBox1.Items.Add(i);}
            toolStripComboBox1.Text = richTextBox1.Font.Size.ToString();


            //Додаємо шрифти в комбокс 2
            foreach (FontFamily font in FontFamily.Families)     { toolStripComboBox2.Items.Add(font.Name.ToString()); }
            //Вигляд шрифту по замовчуванню           
            toolStripComboBox2.Text = richTextBox1.Font.ToString();

        }
        //Save file
        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Files RTF|*.rtf|Document Office Open XML(*.docx)|*.docx|Text OpenDocument(*.odt)|*.odt|All files|*.*";
            saveFileDialog1.InitialDirectory = @"C:\Users\ADMIN\Desktop\Folder";//Початкова папка
            saveFileDialog1.FileName = openFileDialog1.FileName;
            saveFileDialog1.OverwritePrompt = true; //Перевіряє чи існує файл
            saveFileDialog1.Title = "Save file";

            //File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text); //Запис текстового файлу без форматування
            
            richTextBox1.SaveFile(saveFileDialog1.FileName);

            var dialogResult = saveFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                // var result = File.ReadAllText(openFileDialog1.FileName);// Зчитує текст файлу без форматування і записує в result
                // richTextBox1.Text = result;
                if (Path.GetExtension(openFileDialog1.FileName) == ".rtf") // Відділяємо .rtf розширення в файлі
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName); //збереження файлу з форматуванням
                    //MessageBox.Show("File is saved");
                }
                else
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName /*, RichTextBoxStreamType.PlainText*/); //відкриття файлу без форматування
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
            var result = MessageBox.Show("Do you want to save changes to this file?","Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                   // richTextBox1.Text = result;
                    if (Path.GetExtension(openFileDialog1.FileName) == ".rtf") // Відділяємо .rtf розширення в файлі
                        richTextBox1.LoadFile(openFileDialog1.FileName); //відкритя файлу з форматуванням
             
                    else
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText); //відкриття файлу без форматування
                }
           // MessageBox.Show("File is Open");
     
        }
        //Close form
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Font Closing";
            this.Text = "Wait for closing....";
            Thread.Sleep(1000);
            this.Close();
        }
        //Ctrl+Z
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
            toolStripStatusLabel1.Text = $"Undo";
        }
        //Ctrl+Y
        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
            toolStripStatusLabel1.Text = $"Redo";
        }
       //Change font
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Font";
           
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта

            if (richTextBox1.SelectionLength != 0)//якщо є виділений текст
            {
                richTextBox1.SelectionFont = fontDialog1.Font; //міняємо шрифт лише для виділеного тексту 
                richTextBox1.SelectionColor = fontDialog1.Color; // міняємо колір шрифту
            }
            else
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.SelectAll();
                richTextBox1.SelectionColor = fontDialog1.Color;

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

            if (richTextBox1.SelectionLength != 0)//якщо є виділений текст
                richTextBox1.SelectionColor = colorDialog1.Color; // Заливаємо лише виділений текст
            else
            richTextBox1.ForeColor = colorDialog1.Color; //заливаємо весь текст файлу
        }
        //View
        private void StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
            trackBar1.Visible = true;
        }
        //Text Bold
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Text BOLD";
            //if (richTextBox1.SelectionFont != null)
            //{
            //    System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            //    System.Drawing.FontStyle newFontStyle;

            //    if (richTextBox1.SelectionFont.Bold == true)
            //    {
            //        newFontStyle = FontStyle.Regular;
            //    }
            //    else
            //    {
            //        newFontStyle = FontStyle.Bold;
            //    }

            //    richTextBox1.SelectionFont = new Font(
            //       currentFont.FontFamily,
            //       currentFont.Size,
            //       newFontStyle
            //    );
            //}


            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Bold)
                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Bold);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();

        }
        //Text Italic
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Text ITALIC";
          
            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Italic)
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Italic);

            richTextBox1.SelectionFont = new1;

            richTextBox1.Focus();
        }
        //Text Underline
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Text UNDERLINE";
           

            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Underline)
                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Underline);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }
        //Text Strikeout
        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Text STRIKEOUT";

            Font new1, old1;
            old1 = richTextBox1.SelectionFont;
            if (old1.Strikeout)
                new1 = new Font(old1, old1.Style & ~FontStyle.Strikeout);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Strikeout);

            richTextBox1.SelectionFont = new1;
            richTextBox1.Focus();
        }
        //Change Size
        private void ToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Size Font";

            if (richTextBox1.SelectionLength != 0)//якщо є виділений текст
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, Convert.ToSingle(toolStripComboBox1.SelectedItem));
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToSingle(toolStripComboBox1.SelectedItem));
            }
        }
        //Alignment Center
        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Alignment: Center";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        //Alignment Left
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Alignment: Left";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        //Alignment Right
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Alignment: Right";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        //Background
        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Backcolor";
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }
        //Zoom
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Zoom";
            float factor = (float)trackBar1.Value * 2; 
            richTextBox1.ZoomFactor = factor;
            this.Text = $"Text: {richTextBox1.ZoomFactor} Track: {trackBar1.Value}";
            if (trackBar1.Value == 1 || richTextBox1.ZoomFactor == 1)
                return;
        }
        //Change Font
        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Change Font";
            
            try
            {
               

                if (richTextBox1.SelectionLength != 0)//якщо є виділений текст
                {
                    richTextBox1.SelectionFont = new Font(toolStripComboBox2.Text, toolStripComboBox2.Font.Size);
                 
                }
                else
                {
                    richTextBox1.Font = new Font(toolStripComboBox2.Text, toolStripComboBox2.Font.Size);
                }
            }
            catch { }

        }
        //Formatting by list (список)
        private void toolStripButton14_Click(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = $"Create List";

            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;

        }
        //Cleare all
        private void cleareAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Cleare ALL text";
            richTextBox1.Text = String.Empty;
        }
        //Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"CUT selected text";

            richTextBox1.Cut();

            //try
            //{
            //    if (richTextBox1.SelectedText.Length != 0)
            //    {
            //        Clipboard.SetData(DataFormats.Rtf, richTextBox1.Rtf);
            //       // Clipboard.SetText(richTextBox1.SelectedText);
            //        richTextBox1.SelectedText = String.Empty;

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

            richTextBox1.Paste();
            //try
            //{
            //    if (Clipboard.ContainsText(TextDataFormat.Rtf))
            //    {
            //        richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
                    
            //    }
            //    else if (Clipboard.ContainsText(TextDataFormat.Text))
            //    {
            //        richTextBox1.SelectedText = Clipboard.GetData(DataFormats.Text).ToString();
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
            richTextBox1.Copy();
            //try
            //{
            //    if (richTextBox1.SelectedText.Length != 0)
            //    {
            //        Clipboard.SetData(DataFormats.Rtf, richTextBox1.Rtf);
            //        MessageBox.Show("Copy");
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
    }
}
