namespace Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.addVitess = new System.Windows.Forms.Button();
            this.minusVitess = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("KaiTi", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "                  ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("KaiTi", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 119);
            this.label2.TabIndex = 8;
            this.label2.Text = "      ";
            // 
            // play
            // 
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(25, 79);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 30);
            this.play.TabIndex = 3;
            this.play.Text = "播放";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.Location = new System.Drawing.Point(25, 115);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 30);
            this.stop.TabIndex = 4;
            this.stop.Text = "暂停";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // addVitess
            // 
            this.addVitess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVitess.Location = new System.Drawing.Point(25, 187);
            this.addVitess.Name = "addVitess";
            this.addVitess.Size = new System.Drawing.Size(75, 30);
            this.addVitess.TabIndex = 5;
            this.addVitess.Text = "加速";
            this.addVitess.UseVisualStyleBackColor = true;
            this.addVitess.Click += new System.EventHandler(this.addVitess_Click);
            // 
            // minusVitess
            // 
            this.minusVitess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusVitess.Location = new System.Drawing.Point(25, 151);
            this.minusVitess.Name = "minusVitess";
            this.minusVitess.Size = new System.Drawing.Size(75, 30);
            this.minusVitess.TabIndex = 6;
            this.minusVitess.Text = "减速";
            this.minusVitess.UseVisualStyleBackColor = true;
            this.minusVitess.Click += new System.EventHandler(this.minusVitess_Click);
            // 
            // quit
            // 
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.Location = new System.Drawing.Point(25, 223);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(75, 30);
            this.quit.TabIndex = 7;
            this.quit.Text = "退出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile.Location = new System.Drawing.Point(25, 43);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 30);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "文件";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 501;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 283);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.minusVitess);
            this.Controls.Add(this.addVitess);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button addVitess;
        private System.Windows.Forms.Button minusVitess;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Timer timer1;
    }
}

