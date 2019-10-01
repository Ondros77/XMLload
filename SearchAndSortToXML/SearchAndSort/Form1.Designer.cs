using System.Windows.Forms;

namespace SearchAndSortToXML {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSortId = new System.Windows.Forms.Button();
            this.btSortName = new System.Windows.Forms.Button();
            this.btSearchName = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbSearchName = new System.Windows.Forms.Label();
            this.lbSearchResults = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.tbSearchResult = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(13, 55);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbId.Size = new System.Drawing.Size(137, 310);
            this.tbId.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(171, 55);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbName.Size = new System.Drawing.Size(189, 310);
            this.tbName.TabIndex = 1;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(385, 55);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCode.Size = new System.Drawing.Size(137, 310);
            this.tbCode.TabIndex = 2;
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(554, 55);
            this.tbRate.Multiline = true;
            this.tbRate.Name = "tbRate";
            this.tbRate.ReadOnly = true;
            this.tbRate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRate.Size = new System.Drawing.Size(137, 310);
            this.tbRate.TabIndex = 3;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbId.Location = new System.Drawing.Point(12, 23);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(39, 29);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "Id:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbName.Location = new System.Drawing.Point(171, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 29);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Name:";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCode.Location = new System.Drawing.Point(365, 23);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(177, 29);
            this.lbCode.TabIndex = 6;
            this.lbCode.Text = "Discount Code:";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRate.Location = new System.Drawing.Point(549, 23);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(168, 29);
            this.lbRate.TabIndex = 7;
            this.lbRate.Text = "Discount Rate:";
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(13, 397);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(120, 55);
            this.btLoad.TabIndex = 8;
            this.btLoad.Text = "Load data";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSortId
            // 
            this.btSortId.Location = new System.Drawing.Point(150, 397);
            this.btSortId.Name = "btSortId";
            this.btSortId.Size = new System.Drawing.Size(120, 55);
            this.btSortId.TabIndex = 9;
            this.btSortId.Text = "Sort by Id";
            this.btSortId.UseVisualStyleBackColor = true;
            this.btSortId.Click += new System.EventHandler(this.btSortId_Click);
            // 
            // btSortName
            // 
            this.btSortName.Location = new System.Drawing.Point(290, 397);
            this.btSortName.Name = "btSortName";
            this.btSortName.Size = new System.Drawing.Size(120, 55);
            this.btSortName.TabIndex = 10;
            this.btSortName.Text = "Sort by Name";
            this.btSortName.UseVisualStyleBackColor = true;
            this.btSortName.Click += new System.EventHandler(this.btSortName_Click);
            // 
            // btSearchName
            // 
            this.btSearchName.Location = new System.Drawing.Point(427, 397);
            this.btSearchName.Name = "btSearchName";
            this.btSearchName.Size = new System.Drawing.Size(120, 55);
            this.btSearchName.TabIndex = 11;
            this.btSearchName.Text = "Search by Name";
            this.btSearchName.UseVisualStyleBackColor = true;
            this.btSearchName.Click += new System.EventHandler(this.btSearchName_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(563, 397);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(120, 55);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbSearchName
            // 
            this.lbSearchName.AutoSize = true;
            this.lbSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSearchName.Location = new System.Drawing.Point(13, 489);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(138, 25);
            this.lbSearchName.TabIndex = 13;
            this.lbSearchName.Text = "Search Name:";
            // 
            // lbSearchResults
            // 
            this.lbSearchResults.AutoSize = true;
            this.lbSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSearchResults.Location = new System.Drawing.Point(13, 543);
            this.lbSearchResults.Name = "lbSearchResults";
            this.lbSearchResults.Size = new System.Drawing.Size(146, 25);
            this.lbSearchResults.TabIndex = 14;
            this.lbSearchResults.Text = "Search Resuts:";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSearchName.Location = new System.Drawing.Point(189, 489);
            this.tbSearchName.Multiline = true;
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(494, 38);
            this.tbSearchName.TabIndex = 15;
            // 
            // tbSearchResult
            // 
            this.tbSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSearchResult.Location = new System.Drawing.Point(189, 543);
            this.tbSearchResult.Multiline = true;
            this.tbSearchResult.Name = "tbSearchResult";
            this.tbSearchResult.ReadOnly = true;
            this.tbSearchResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbSearchResult.Size = new System.Drawing.Size(494, 38);
            this.tbSearchResult.TabIndex = 16;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(698, 397);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 55);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 589);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbSearchResult);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.lbSearchResults);
            this.Controls.Add(this.lbSearchName);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSearchName);
            this.Controls.Add(this.btSortName);
            this.Controls.Add(this.btSortId);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSortId;
        private System.Windows.Forms.Button btSortName;
        private System.Windows.Forms.Button btSearchName;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbSearchName;
        private System.Windows.Forms.Label lbSearchResults;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.TextBox tbSearchResult;
        private Button btSave;
    }
}

