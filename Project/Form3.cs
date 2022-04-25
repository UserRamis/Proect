using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаём объект документа
            Word.Document doc = null;
            try
            {
                // Создаём объект приложения
                Word.Application app = new Word.Application();
                // Путь до шаблона документа
                string source = "C:\\Users\\user9\\Desktop\\COVID_otkaz.DOCX";
                // Открываем
                doc = app.Documents.Add(source);
                doc.Activate();

                // Добавляем информацию
                // wBookmarks содержит все закладки
                Word.Bookmarks wBookmarks = doc.Bookmarks;
                Word.Range wRange;
                int i = 0;
                string[] data = new string[7] { textBoxFIO.Text, textBoxData.Text, textBoxMonth.Text, textBoxYear.Text, textBoxAdres.Text, textBoxFIOMED.Text, textBoxVAK.Text };
                foreach (Word.Bookmark mark in wBookmarks)
                {

                    wRange = mark.Range;
                    wRange.Text = data[i];
                    i++;
                }

                // Закрываем документ

                doc.Close();
                doc = null;

                
                MessageBox.Show("Файл успешно сохранен!");

                textBoxFIO.Clear();
                textBoxData.Clear();
                textBoxMonth.Clear();
                textBoxYear.Clear(); 
                textBoxAdres.Clear();
                textBoxFIOMED.Clear();
                textBoxVAK.Clear();
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, то
                // закрываем документ и выводим информацию
                doc.Close();
                doc = null;
                MessageBox.Show("Произошла ошибка!");
            }
        }
    }
    
}
