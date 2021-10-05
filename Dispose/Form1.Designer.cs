
namespace Dispose
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.clone1 = new System.Windows.Forms.Button();
            this.clone2 = new System.Windows.Forms.Button();
            this.gc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clone1
            // 
            this.clone1.Location = new System.Drawing.Point(87, 49);
            this.clone1.Name = "clone1";
            this.clone1.Size = new System.Drawing.Size(75, 23);
            this.clone1.TabIndex = 0;
            this.clone1.Text = "Clone #1";
            this.clone1.UseVisualStyleBackColor = true;
            this.clone1.Click += new System.EventHandler(this.clone1_Click);
            // 
            // clone2
            // 
            this.clone2.Location = new System.Drawing.Point(87, 97);
            this.clone2.Name = "clone2";
            this.clone2.Size = new System.Drawing.Size(75, 23);
            this.clone2.TabIndex = 1;
            this.clone2.Text = "Clone #2";
            this.clone2.UseVisualStyleBackColor = true;
            this.clone2.Click += new System.EventHandler(this.clone2_Click);
            // 
            // gc
            // 
            this.gc.Location = new System.Drawing.Point(87, 144);
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(75, 23);
            this.gc.TabIndex = 2;
            this.gc.Text = "GC";
            this.gc.UseVisualStyleBackColor = true;
            this.gc.Click += new System.EventHandler(this.gc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 195);
            this.Controls.Add(this.gc);
            this.Controls.Add(this.clone2);
            this.Controls.Add(this.clone1);
            this.Name = "Form1";
            this.Text = "Clones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clone1;
        private System.Windows.Forms.Button clone2;
        private System.Windows.Forms.Button gc;
    }
}

