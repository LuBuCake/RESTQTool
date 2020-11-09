/*
This file is part of RESIDENT EVIL XSEW Tool.

RESIDENT EVIL STQ Tool is free software: you can redistribute it
and/or modify it under the terms of the GNU General Public License
as published by the Free Software Foundation, either version 3 of
the License, or (at your option) any later version.

RESIDENT EVIL STQ Tool is distributed in the hope that it will
be useful, but WITHOUT ANY WARRANTY; without even the implied
warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with RESIDENT EVIL STQ Tool. If not, see <https://www.gnu.org/licenses/>6.
*/

namespace RESTQTool
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.STQFileGPBox = new System.Windows.Forms.GroupBox();
            this.STQFileNameBox = new System.Windows.Forms.TextBox();
            this.SaveSTQButton = new System.Windows.Forms.Button();
            this.OpenSTQButton = new System.Windows.Forms.Button();
            this.STQDataGPBox = new System.Windows.Forms.GroupBox();
            this.ApplyDataButton = new System.Windows.Forms.Button();
            this.ChannelBox = new System.Windows.Forms.TextBox();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.LoopEndBox = new System.Windows.Forms.TextBox();
            this.LoopELabel = new System.Windows.Forms.Label();
            this.LoopStartBox = new System.Windows.Forms.TextBox();
            this.LoopSLabel = new System.Windows.Forms.Label();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.FileSizeBox = new System.Windows.Forms.TextBox();
            this.FSizeLabel = new System.Windows.Forms.Label();
            this.SoundFileBox = new System.Windows.Forms.TextBox();
            this.SoundComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.STQFileGPBox.SuspendLayout();
            this.STQDataGPBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // STQFileGPBox
            // 
            this.STQFileGPBox.Controls.Add(this.STQFileNameBox);
            this.STQFileGPBox.Controls.Add(this.SaveSTQButton);
            this.STQFileGPBox.Controls.Add(this.OpenSTQButton);
            this.STQFileGPBox.Location = new System.Drawing.Point(12, 12);
            this.STQFileGPBox.Name = "STQFileGPBox";
            this.STQFileGPBox.Size = new System.Drawing.Size(403, 59);
            this.STQFileGPBox.TabIndex = 0;
            this.STQFileGPBox.TabStop = false;
            this.STQFileGPBox.Text = "STQ File";
            // 
            // STQFileNameBox
            // 
            this.STQFileNameBox.Enabled = false;
            this.STQFileNameBox.Location = new System.Drawing.Point(204, 22);
            this.STQFileNameBox.Name = "STQFileNameBox";
            this.STQFileNameBox.ReadOnly = true;
            this.STQFileNameBox.Size = new System.Drawing.Size(176, 23);
            this.STQFileNameBox.TabIndex = 2;
            // 
            // SaveSTQButton
            // 
            this.SaveSTQButton.Location = new System.Drawing.Point(103, 22);
            this.SaveSTQButton.Name = "SaveSTQButton";
            this.SaveSTQButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSTQButton.TabIndex = 1;
            this.SaveSTQButton.Text = "Save";
            this.SaveSTQButton.UseVisualStyleBackColor = true;
            this.SaveSTQButton.Click += new System.EventHandler(this.SaveSTQButton_Click);
            // 
            // OpenSTQButton
            // 
            this.OpenSTQButton.Location = new System.Drawing.Point(22, 22);
            this.OpenSTQButton.Name = "OpenSTQButton";
            this.OpenSTQButton.Size = new System.Drawing.Size(75, 23);
            this.OpenSTQButton.TabIndex = 0;
            this.OpenSTQButton.Text = "Open";
            this.OpenSTQButton.UseVisualStyleBackColor = true;
            this.OpenSTQButton.Click += new System.EventHandler(this.OpenSTQButton_Click);
            // 
            // STQDataGPBox
            // 
            this.STQDataGPBox.Controls.Add(this.ApplyDataButton);
            this.STQDataGPBox.Controls.Add(this.ChannelBox);
            this.STQDataGPBox.Controls.Add(this.ChannelLabel);
            this.STQDataGPBox.Controls.Add(this.LoopEndBox);
            this.STQDataGPBox.Controls.Add(this.LoopELabel);
            this.STQDataGPBox.Controls.Add(this.LoopStartBox);
            this.STQDataGPBox.Controls.Add(this.LoopSLabel);
            this.STQDataGPBox.Controls.Add(this.DurationBox);
            this.STQDataGPBox.Controls.Add(this.DurationLabel);
            this.STQDataGPBox.Controls.Add(this.FileSizeBox);
            this.STQDataGPBox.Controls.Add(this.FSizeLabel);
            this.STQDataGPBox.Controls.Add(this.SoundFileBox);
            this.STQDataGPBox.Controls.Add(this.SoundComboBox);
            this.STQDataGPBox.Location = new System.Drawing.Point(12, 77);
            this.STQDataGPBox.Name = "STQDataGPBox";
            this.STQDataGPBox.Size = new System.Drawing.Size(403, 126);
            this.STQDataGPBox.TabIndex = 1;
            this.STQDataGPBox.TabStop = false;
            this.STQDataGPBox.Text = "STQ Data";
            // 
            // ApplyDataButton
            // 
            this.ApplyDataButton.Location = new System.Drawing.Point(290, 91);
            this.ApplyDataButton.Name = "ApplyDataButton";
            this.ApplyDataButton.Size = new System.Drawing.Size(94, 23);
            this.ApplyDataButton.TabIndex = 14;
            this.ApplyDataButton.Text = "Apply";
            this.ApplyDataButton.UseVisualStyleBackColor = true;
            this.ApplyDataButton.Click += new System.EventHandler(this.ApplyDataButton_Click);
            // 
            // ChannelBox
            // 
            this.ChannelBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.ChannelBox.Location = new System.Drawing.Point(344, 63);
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(39, 22);
            this.ChannelBox.TabIndex = 13;
            this.ChannelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.ChannelLabel.Location = new System.Drawing.Point(286, 66);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(52, 13);
            this.ChannelLabel.TabIndex = 12;
            this.ChannelLabel.Text = "Channels";
            // 
            // LoopEndBox
            // 
            this.LoopEndBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LoopEndBox.Location = new System.Drawing.Point(205, 91);
            this.LoopEndBox.Name = "LoopEndBox";
            this.LoopEndBox.Size = new System.Drawing.Size(75, 22);
            this.LoopEndBox.TabIndex = 11;
            this.LoopEndBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoopELabel
            // 
            this.LoopELabel.AutoSize = true;
            this.LoopELabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LoopELabel.Location = new System.Drawing.Point(150, 94);
            this.LoopELabel.Name = "LoopELabel";
            this.LoopELabel.Size = new System.Drawing.Size(51, 13);
            this.LoopELabel.TabIndex = 10;
            this.LoopELabel.Text = "Loop En.";
            // 
            // LoopStartBox
            // 
            this.LoopStartBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LoopStartBox.Location = new System.Drawing.Point(69, 91);
            this.LoopStartBox.Name = "LoopStartBox";
            this.LoopStartBox.Size = new System.Drawing.Size(75, 22);
            this.LoopStartBox.TabIndex = 9;
            this.LoopStartBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoopSLabel
            // 
            this.LoopSLabel.AutoSize = true;
            this.LoopSLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LoopSLabel.Location = new System.Drawing.Point(14, 94);
            this.LoopSLabel.Name = "LoopSLabel";
            this.LoopSLabel.Size = new System.Drawing.Size(49, 13);
            this.LoopSLabel.TabIndex = 8;
            this.LoopSLabel.Text = "Loop St.";
            // 
            // DurationBox
            // 
            this.DurationBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.DurationBox.Location = new System.Drawing.Point(205, 63);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(75, 22);
            this.DurationBox.TabIndex = 7;
            this.DurationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.DurationLabel.Location = new System.Drawing.Point(150, 66);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(51, 13);
            this.DurationLabel.TabIndex = 6;
            this.DurationLabel.Text = "Duration";
            // 
            // FileSizeBox
            // 
            this.FileSizeBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.FileSizeBox.Location = new System.Drawing.Point(69, 63);
            this.FileSizeBox.Name = "FileSizeBox";
            this.FileSizeBox.Size = new System.Drawing.Size(75, 22);
            this.FileSizeBox.TabIndex = 5;
            this.FileSizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FSizeLabel
            // 
            this.FSizeLabel.AutoSize = true;
            this.FSizeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.FSizeLabel.Location = new System.Drawing.Point(14, 66);
            this.FSizeLabel.Name = "FSizeLabel";
            this.FSizeLabel.Size = new System.Drawing.Size(38, 13);
            this.FSizeLabel.TabIndex = 4;
            this.FSizeLabel.Text = "F. Size";
            // 
            // SoundFileBox
            // 
            this.SoundFileBox.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundFileBox.Location = new System.Drawing.Point(98, 24);
            this.SoundFileBox.Name = "SoundFileBox";
            this.SoundFileBox.Size = new System.Drawing.Size(286, 21);
            this.SoundFileBox.TabIndex = 3;
            // 
            // SoundComboBox
            // 
            this.SoundComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoundComboBox.FormattingEnabled = true;
            this.SoundComboBox.Location = new System.Drawing.Point(17, 23);
            this.SoundComboBox.Name = "SoundComboBox";
            this.SoundComboBox.Size = new System.Drawing.Size(75, 23);
            this.SoundComboBox.TabIndex = 0;
            this.SoundComboBox.SelectedIndexChanged += new System.EventHandler(this.SoundComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(240, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copyright © 2020 by LuBuCake";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.STQDataGPBox);
            this.Controls.Add(this.STQFileGPBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESIDENT EVIL STQ Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.STQFileGPBox.ResumeLayout(false);
            this.STQFileGPBox.PerformLayout();
            this.STQDataGPBox.ResumeLayout(false);
            this.STQDataGPBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox STQFileGPBox;
        private System.Windows.Forms.Button OpenSTQButton;
        private System.Windows.Forms.TextBox STQFileNameBox;
        private System.Windows.Forms.Button SaveSTQButton;
        private System.Windows.Forms.GroupBox STQDataGPBox;
        private System.Windows.Forms.TextBox SoundFileBox;
        private System.Windows.Forms.ComboBox SoundComboBox;
        private System.Windows.Forms.Label FSizeLabel;
        private System.Windows.Forms.TextBox FileSizeBox;
        private System.Windows.Forms.TextBox ChannelBox;
        private System.Windows.Forms.Label ChannelLabel;
        private System.Windows.Forms.TextBox LoopEndBox;
        private System.Windows.Forms.Label LoopELabel;
        private System.Windows.Forms.TextBox LoopStartBox;
        private System.Windows.Forms.Label LoopSLabel;
        private System.Windows.Forms.TextBox DurationBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Button ApplyDataButton;
        private System.Windows.Forms.Label label1;
    }
}

