
namespace Exercise_with_List_2
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
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btnReadStudents = new System.Windows.Forms.Button();
            this.btnReadPoints = new System.Windows.Forms.Button();
            this.btnPassOrNot = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(20, 25);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(315, 394);
            this.lbResult.TabIndex = 0;
            // 
            // btnReadStudents
            // 
            this.btnReadStudents.Location = new System.Drawing.Point(367, 32);
            this.btnReadStudents.Name = "btnReadStudents";
            this.btnReadStudents.Size = new System.Drawing.Size(224, 68);
            this.btnReadStudents.TabIndex = 1;
            this.btnReadStudents.Text = "Read students + Overview";
            this.btnReadStudents.UseVisualStyleBackColor = true;
            this.btnReadStudents.Click += new System.EventHandler(this.btnReadStudents_Click);
            // 
            // btnReadPoints
            // 
            this.btnReadPoints.Location = new System.Drawing.Point(367, 157);
            this.btnReadPoints.Name = "btnReadPoints";
            this.btnReadPoints.Size = new System.Drawing.Size(223, 66);
            this.btnReadPoints.TabIndex = 2;
            this.btnReadPoints.Text = "Read Points + Overview";
            this.btnReadPoints.UseVisualStyleBackColor = true;
            // 
            // btnPassOrNot
            // 
            this.btnPassOrNot.Location = new System.Drawing.Point(367, 252);
            this.btnPassOrNot.Name = "btnPassOrNot";
            this.btnPassOrNot.Size = new System.Drawing.Size(223, 63);
            this.btnPassOrNot.TabIndex = 3;
            this.btnPassOrNot.Text = "Passed / Not passed";
            this.btnPassOrNot.UseVisualStyleBackColor = true;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(367, 342);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(222, 56);
            this.btnEmpty.TabIndex = 4;
            this.btnEmpty.Text = "Empty View";
            this.btnEmpty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnPassOrNot);
            this.Controls.Add(this.btnReadPoints);
            this.Controls.Add(this.btnReadStudents);
            this.Controls.Add(this.lbResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btnReadStudents;
        private System.Windows.Forms.Button btnReadPoints;
        private System.Windows.Forms.Button btnPassOrNot;
        private System.Windows.Forms.Button btnEmpty;
    }
}

