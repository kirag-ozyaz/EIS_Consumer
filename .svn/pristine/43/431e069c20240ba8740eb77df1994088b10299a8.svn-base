using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using FormLbr.Classes;

namespace Prv.Forms.Reports
{
    public partial class FormActScan : FormLbr.FormBase
    {
        private int ID = -1;
        private DataRow drAddImg;
        System.Diagnostics.Process proc = new System.Diagnostics.Process();
        bool st = false; 

        public FormActScan()
        {
            InitializeComponent();
        }

        public FormActScan(int id)
        {
            InitializeComponent();
            ID = id;
        }


        private void FormActScan_Load(object sender, EventArgs e)
        {
            // загрузка сканов
            SelectSqlData(dataSetRep, dataSetRep.tPrv_JournalActImage, true, "where idJournal =" + ID.ToString() + " order by id asc");
            if (dataSetRep.tPrv_JournalActImage.Count > 0)
            {
                for (int i = 0; i < dataSetRep.tPrv_JournalActImage.Count; i++)
                {
                    if (dataSetRep.tPrv_JournalActImage.Rows[i]["Scan"] != System.DBNull.Value)
                        LoadDataToGridImages((byte[])dataSetRep.tPrv_JournalActImage.Rows[i]["Scan"], (int)dataSetRep.tPrv_JournalActImage.Rows[i]["id"]);
                }
                if (dataGridViewImages.CurrentRow != null)
                    pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void LoadDataToGridImages(Byte[] ImageData, int id)
        {
            try
            {
                using (Bitmap bmp = ImageCompress.LoadBitmap(ImageData))
                {
                    if (bmp != null)
                    {
                        dataGridViewImages.Rows.Add(new Bitmap(bmp, 120, 160), new Bitmap(bmp), true, id);
                    }
                }
                //                dataGridViewImages.Rows.Add(new Bitmap(ImageCompress.LoadBitmap(ImageData), 120, 160), ImageCompress.LoadBitmap(ImageData), true, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Multiselect = true;
            fileOpen.Filter = "JPEG Documents|*.jpg";
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in fileOpen.FileNames)
                {
                    using (Bitmap img = new Bitmap(fileName))
                    {
                        dataSetRep.tPrv_JournalActImage.Rows.Clear();

                        drAddImg = dataSetRep.tPrv_JournalActImage.NewRow();
                        drAddImg["idJournal"] = ID;
                        drAddImg["Scan"] = ImageCompress.GetCompressBytes((Image)img, 30L);
                        dataSetRep.tPrv_JournalActImage.Rows.Add(drAddImg);

                        int id = InsertSqlDataOneRow(dataSetRep, dataSetRep.tPrv_JournalActImage);

                        pbScanDoc.Image = ImageCompress.LoadBitmap(fileName);
                        pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
                        dataGridViewImages.Rows.Add(new Bitmap(img, 120, 160), ImageCompress.LoadBitmap(fileName), false, id);
                    }
                    //img.Dispose();
                }
            }

        }

        private void dataGridViewImages_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex >= 0) // если левой кнопкой
            {
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) // если правой кнопкой
            {
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;

                this.dataGridViewImages.Rows[e.RowIndex].Selected = true;
                dataGridViewImages.CurrentCell = dataGridViewImages[0, e.RowIndex]; //делаем текущей
                pbScanDoc.Image = (Bitmap)dataGridViewImages.CurrentRow.Cells["ImageOriginal"].Value;
                pbScanDoc.SizeMode = PictureBoxSizeMode.StretchImage;
                this.contextMenuStripImage.Show(System.Windows.Forms.Cursor.Position);
            }
        }

        private void tsbRemoveImage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (DeleteSqlDataById(dataSetRep.tPrv_JournalActImage, (int)dataGridViewImages.CurrentRow.Cells["id"].Value))
                            {
                                dataGridViewImages.Rows.RemoveAt(dataGridViewImages.CurrentRow.Index);
                                MessageBox.Show("Изображение удалено..");
                            }
                            else
                                MessageBox.Show("Изображение удалить не удалось..");
                        }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";

            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension(pbScanDoc.Image, fileSave.FileName);
                MessageBox.Show("Изображение успешно сохранено.");
            }
        }

        private void tsbOpenPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".jpg";
            fileSave.FileName = "Temp";
            fileSave.Title = "Сохраните файл с изображением в любой папке";
            if (fileSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageCompress.SaveBitmapUsingExtension(pbScanDoc.Image, fileSave.FileName);
            }

            if (fileSave.FileName != "")
            {
                proc.StartInfo.FileName = fileSave.FileName; //указываем имя файла с изображением
                if (!st)
                {
                    st = true; //указываем, что процесс запускается
                    proc.EnableRaisingEvents = true; //при закрытии файла будет вызвано событие Exited
                    proc.Exited += new EventHandler(proc_Exited); //добавляем обработчик события
                    proc.Start(); //запускаем программу просмотра изображения
                }
                else
                {
                    MessageBox.Show("Закройте файл с изображением, чтобы снова его запустить!");
                }
            }
            else
            {
                MessageBox.Show("Отсутствует имя файла!");
            }
        }

        void proc_Exited(object sender, EventArgs e)
        {
            st = false;
            proc.Exited -= new EventHandler(proc_Exited); //убираем обработчик
        }


    }
}
