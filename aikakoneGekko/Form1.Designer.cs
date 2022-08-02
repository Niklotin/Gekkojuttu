
namespace aikakoneGekko
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GetData = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeSheenButton = new System.Windows.Forms.Button();
            this.BearishButton = new System.Windows.Forms.Button();
            this.VolumeButton = new System.Windows.Forms.Button();
            this.bearishBox = new System.Windows.Forms.TextBox();
            this.TradingVolumeBox = new System.Windows.Forms.TextBox();
            this.TimeSheenBox = new System.Windows.Forms.TextBox();
            this.varoitusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadedDataLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetData
            // 
            this.GetData.BackColor = System.Drawing.Color.MediumPurple;
            this.GetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetData.Location = new System.Drawing.Point(12, 172);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(200, 81);
            this.GetData.TabIndex = 1;
            this.GetData.Text = "Get Data";
            this.GetData.UseVisualStyleBackColor = false;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 127);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2021, 12, 14, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Starting date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ending date";
            // 
            // TimeSheenButton
            // 
            this.TimeSheenButton.BackColor = System.Drawing.Color.MediumPurple;
            this.TimeSheenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSheenButton.Location = new System.Drawing.Point(318, 298);
            this.TimeSheenButton.Name = "TimeSheenButton";
            this.TimeSheenButton.Size = new System.Drawing.Size(186, 100);
            this.TimeSheenButton.TabIndex = 6;
            this.TimeSheenButton.Text = "When to buy, When to sell (Timemachine)";
            this.TimeSheenButton.UseVisualStyleBackColor = false;
            this.TimeSheenButton.Click += new System.EventHandler(this.manipulateButton_Click);
            // 
            // BearishButton
            // 
            this.BearishButton.BackColor = System.Drawing.Color.MediumPurple;
            this.BearishButton.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.BearishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BearishButton.Location = new System.Drawing.Point(318, 12);
            this.BearishButton.Name = "BearishButton";
            this.BearishButton.Size = new System.Drawing.Size(186, 108);
            this.BearishButton.TabIndex = 7;
            this.BearishButton.Text = "Longest bearish trend";
            this.BearishButton.UseVisualStyleBackColor = false;
            this.BearishButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // VolumeButton
            // 
            this.VolumeButton.BackColor = System.Drawing.Color.MediumPurple;
            this.VolumeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeButton.Location = new System.Drawing.Point(318, 151);
            this.VolumeButton.Name = "VolumeButton";
            this.VolumeButton.Size = new System.Drawing.Size(186, 102);
            this.VolumeButton.TabIndex = 8;
            this.VolumeButton.Text = "Highest trading volume";
            this.VolumeButton.UseVisualStyleBackColor = false;
            this.VolumeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // bearishBox
            // 
            this.bearishBox.BackColor = System.Drawing.Color.MediumPurple;
            this.bearishBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bearishBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bearishBox.Location = new System.Drawing.Point(581, 12);
            this.bearishBox.Multiline = true;
            this.bearishBox.Name = "bearishBox";
            this.bearishBox.Size = new System.Drawing.Size(599, 114);
            this.bearishBox.TabIndex = 9;
            // 
            // TradingVolumeBox
            // 
            this.TradingVolumeBox.BackColor = System.Drawing.Color.MediumPurple;
            this.TradingVolumeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TradingVolumeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradingVolumeBox.Location = new System.Drawing.Point(581, 151);
            this.TradingVolumeBox.Multiline = true;
            this.TradingVolumeBox.Name = "TradingVolumeBox";
            this.TradingVolumeBox.Size = new System.Drawing.Size(599, 102);
            this.TradingVolumeBox.TabIndex = 10;
            // 
            // TimeSheenBox
            // 
            this.TimeSheenBox.BackColor = System.Drawing.Color.MediumPurple;
            this.TimeSheenBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeSheenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSheenBox.Location = new System.Drawing.Point(581, 298);
            this.TimeSheenBox.Multiline = true;
            this.TimeSheenBox.Name = "TimeSheenBox";
            this.TimeSheenBox.Size = new System.Drawing.Size(599, 100);
            this.TimeSheenBox.TabIndex = 11;
            // 
            // varoitusLabel
            // 
            this.varoitusLabel.AutoSize = true;
            this.varoitusLabel.Location = new System.Drawing.Point(12, 266);
            this.varoitusLabel.Name = "varoitusLabel";
            this.varoitusLabel.Size = new System.Drawing.Size(0, 13);
            this.varoitusLabel.TabIndex = 13;
            // 
            // loadedDataLabel
            // 
            this.loadedDataLabel.AutoSize = true;
            this.loadedDataLabel.Location = new System.Drawing.Point(12, 428);
            this.loadedDataLabel.Name = "loadedDataLabel";
            this.loadedDataLabel.Size = new System.Drawing.Size(0, 13);
            this.loadedDataLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1220, 450);
            this.Controls.Add(this.loadedDataLabel);
            this.Controls.Add(this.varoitusLabel);
            this.Controls.Add(this.TimeSheenBox);
            this.Controls.Add(this.TradingVolumeBox);
            this.Controls.Add(this.bearishBox);
            this.Controls.Add(this.VolumeButton);
            this.Controls.Add(this.BearishButton);
            this.Controls.Add(this.TimeSheenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.GetData);
            this.Name = "Form1";
            this.Text = "Gekko Kone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TimeSheenButton;
        private System.Windows.Forms.Button BearishButton;
        private System.Windows.Forms.Button VolumeButton;
        private System.Windows.Forms.TextBox bearishBox;
        private System.Windows.Forms.TextBox TradingVolumeBox;
        private System.Windows.Forms.TextBox TimeSheenBox;
        private System.Windows.Forms.Label varoitusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label loadedDataLabel;
    }
}

