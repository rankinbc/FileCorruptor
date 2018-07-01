using Be.Windows.Forms;
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

namespace FileCorruptor
{
    public partial class Form1 : Form
    {
        readonly string SOURCE_HEXBOX_ID = "source";
        readonly string TARGET_HEXBOX_ID = "target";

        FileCorruptorProgram FileCorruptorProgram;
        HexBoxManager HexBoxManager;
        string selectedFileIdentifier;
        string selectedPassIdentifier;
 
        public Form1()
        {
            FileCorruptorProgram = new FileCorruptorProgram();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_targetFiles.DrawMode = DrawMode.OwnerDrawFixed;

            HexBoxManager = new HexBoxManager();
            HexBoxManager.AddHexBox(SOURCE_HEXBOX_ID, ref hex_source_file);
            HexBoxManager.AddHexBox(TARGET_HEXBOX_ID, ref hex_target_file);
        }

        private void UpdateTargetFilesListBox()
        {
            lb_targetFiles.Items.Clear();

            var loadedFiles = FileCorruptorProgram.FileManager.LoadedFiles;
            foreach (KeyValuePair<string,LoadedFile> fileEntry in loadedFiles)
            {
                string identifier = fileEntry.Key;
                LoadedFile file = fileEntry.Value;
                lb_targetFiles.Items.Add(identifier);
            }
            
            if (selectedFileIdentifier == null && lb_targetFiles.Items.Count > 0)
            {
                lb_targetFiles.SelectedIndex = 0;
            }
        }

      

        private void UpdatePassesListBox()
        {
            lb_passes.Items.Clear();

            var passes = FileCorruptorProgram.Corruptor.CorruptorPasses;
            foreach (KeyValuePair<string, CorruptorPass> pass in passes)
            {
                string identifier = pass.Key;
                CorruptorPass file = pass.Value;
                lb_passes.Items.Add(identifier);
            }

            if (selectedPassIdentifier == null && lb_passes.Items.Count > 0)
            {
                lb_passes.SelectedIndex = 0;
            }
        }

        private void UpdateSelectedFileInfo()
        {
            LoadedFile file = FileCorruptorProgram.SelectFile(selectedFileIdentifier);
            if (file != null)
            {
                tb_file_identifier.Text = selectedFileIdentifier;
                cb_protectFromOverwrite.Checked = file.ReadOnly;
                lbl_file_bytes.Text = file.BinaryContent.Length.ToString();
                lbl_selected_file_path.Text = file.FilePath;
                lbl_hash.Text = file.GetSHA1();
            }
        }

        private void UpdateSelectedPassInfo()
        {
            CorruptorPass selectedPass = FileCorruptorProgram.Corruptor.CorruptorPasses[selectedPassIdentifier];
            if (selectedPass != null)
            {
                tb_pass_identifier.Text = selectedPass.Identifier;
                tb_pass_interval.Text = selectedPass.Interval.ToString();
                tb_pass_chunk_size.Text = selectedPass.ChunkSize.ToString();
                tb_pass_start_address.Text = selectedPass.StartAddress.ToString();
                tb_pass_end_address.Text = selectedPass.EndAddress.ToString();
                tb_pass_writevalue_max.Text = selectedPass.WriteValueMax.ToString();
                tb_pass_writevalue_min.Text = selectedPass.WriteValueMin.ToString();
            }
        }

        private void lb_targetFiles_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                bool currentItemIsSourceFile = lb_targetFiles.Items[e.Index].ToString() == FileCorruptorProgram.CurrentSourceFileIdentifier;

                e.DrawBackground();
                if (currentItemIsSourceFile)
                {
                    e.Graphics.DrawString(lb_targetFiles.Items[e.Index].ToString(), new Font("Microsoft Sans Serif", 8, FontStyle.Bold), Brushes.DarkGray, e.Bounds);
                }
                else
                {
                    e.Graphics.DrawString(lb_targetFiles.Items[e.Index].ToString(), new Font("Microsoft Sans Serif", 8, FontStyle.Regular), Brushes.Black, e.Bounds);
                }
                e.DrawFocusRectangle();
            }
        }

        private void lb_targetFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_targetFiles.SelectedItem != null)
            {
                selectedFileIdentifier = lb_targetFiles.SelectedItem.ToString();
                UpdateSelectedFileInfo();
            }
        }

        private void lb_passes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_passes.SelectedItem != null)
            {
                selectedPassIdentifier = lb_passes.SelectedItem.ToString();
                UpdateSelectedPassInfo();
            }
            
        }

        private void btn_file_create_copy_Click(object sender, EventArgs e)
        {
            LoadedFile sourceFile = FileCorruptorProgram.FileManager.LoadedFiles[selectedFileIdentifier];

            string copiedFileIdentifier = FileCorruptorProgram.FileManager.GenerateFileIdentifier(selectedFileIdentifier);
            FileCorruptorProgram.MakeCopy(copiedFileIdentifier, selectedFileIdentifier);

            selectedFileIdentifier = copiedFileIdentifier;

            UpdateSelectedFileInfo();
            UpdateTargetFilesListBox();
        }

        private void btn_save_changes_Click(object sender, EventArgs e)
        {
            LoadedFile file = FileCorruptorProgram.SelectFile(selectedFileIdentifier);
            file.BinaryContent = HexBoxManager.GetHexBoxContent(TARGET_HEXBOX_ID);
        }

        private void menu_import_file_Click(object sender, EventArgs e)
        {
            DialogResult result = ImportFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = ImportFileDialog.FileName;

                FileCorruptorProgram.LoadExternalFile(filePath);
                UpdateTargetFilesListBox();

                LoadedFile currentSourceFile = FileCorruptorProgram.GetCurrentSourceFile();
                HexBoxManager.SetHexBoxFile(SOURCE_HEXBOX_ID, ref currentSourceFile);
            }
        }

        private void btn_set_target_file_Click(object sender, EventArgs e)
        {
            LoadedFile file = FileCorruptorProgram.SelectFile(selectedFileIdentifier);
            HexBoxManager.SetHexBoxFile(TARGET_HEXBOX_ID, ref file);

            lbl_target_hexbox.Text = selectedFileIdentifier;
            UpdateSelectedFileInfo();
        }

        private void btn_set_source_file_Click(object sender, EventArgs e)
        {
            LoadedFile file = FileCorruptorProgram.SelectFile(selectedFileIdentifier);
            HexBoxManager.SetHexBoxFile(SOURCE_HEXBOX_ID, ref file);
            FileCorruptorProgram.SetCurrentSourceFile(selectedFileIdentifier);

            lbl_source_hexbox.Text = selectedFileIdentifier;
            UpdateSelectedFileInfo();
        }

        private void btn_create_new_pass_Click(object sender, EventArgs e)
        {
            CorruptorPass corruptorPass = new CorruptorPass()
            {
                Identifier = tb_pass_identifier.Text,
                Interval = Convert.ToInt32(tb_pass_interval.Text),
                ChunkSize = Convert.ToInt32(tb_pass_chunk_size.Text),
                StartAddress = Convert.ToInt32(tb_pass_start_address.Text),
                EndAddress = Convert.ToInt32(tb_pass_end_address.Text),
                WriteValueMin = Convert.ToByte(tb_pass_writevalue_min.Text),
                WriteValueMax = Convert.ToByte(tb_pass_writevalue_max.Text)
            };

            FileCorruptorProgram.Corruptor.CorruptorPasses.Add(corruptorPass.Identifier,corruptorPass);
            selectedPassIdentifier = corruptorPass.Identifier;
            UpdatePassesListBox();
            UpdateSelectedPassInfo();
        }

       
    }
}
