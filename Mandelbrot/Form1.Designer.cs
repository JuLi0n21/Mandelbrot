
namespace Mandelbrot
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_move_up = new System.Windows.Forms.Button();
            this.btn_move_down = new System.Windows.Forms.Button();
            this.btn_move_right = new System.Windows.Forms.Button();
            this.btn_move_left = new System.Windows.Forms.Button();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.btn_Render = new System.Windows.Forms.Button();
            this.txt_Xmin = new System.Windows.Forms.TextBox();
            this.txt_Xmax = new System.Windows.Forms.TextBox();
            this.txt_Ymax = new System.Windows.Forms.TextBox();
            this.txt_Ymin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_savecoords = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Zoomout = new System.Windows.Forms.Button();
            this.pnl_mousecheck = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mandelbrot.Properties.Resources.Solid_white_svg;
            this.pictureBox1.Location = new System.Drawing.Point(15, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1877, 940);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseCaptureChanged);
            // 
            // btn_move_up
            // 
            this.btn_move_up.Location = new System.Drawing.Point(10, 974);
            this.btn_move_up.Name = "btn_move_up";
            this.btn_move_up.Size = new System.Drawing.Size(75, 23);
            this.btn_move_up.TabIndex = 1;
            this.btn_move_up.Text = "up";
            this.btn_move_up.UseVisualStyleBackColor = true;
            this.btn_move_up.Click += new System.EventHandler(this.btn_move_up_Click);
            // 
            // btn_move_down
            // 
            this.btn_move_down.Location = new System.Drawing.Point(10, 1003);
            this.btn_move_down.Name = "btn_move_down";
            this.btn_move_down.Size = new System.Drawing.Size(75, 23);
            this.btn_move_down.TabIndex = 2;
            this.btn_move_down.Text = "down";
            this.btn_move_down.UseVisualStyleBackColor = true;
            this.btn_move_down.Click += new System.EventHandler(this.btn_move_down_Click);
            // 
            // btn_move_right
            // 
            this.btn_move_right.Location = new System.Drawing.Point(91, 1003);
            this.btn_move_right.Name = "btn_move_right";
            this.btn_move_right.Size = new System.Drawing.Size(75, 23);
            this.btn_move_right.TabIndex = 4;
            this.btn_move_right.Text = "right";
            this.btn_move_right.UseVisualStyleBackColor = true;
            this.btn_move_right.Click += new System.EventHandler(this.btn_move_right_Click);
            // 
            // btn_move_left
            // 
            this.btn_move_left.Location = new System.Drawing.Point(91, 974);
            this.btn_move_left.Name = "btn_move_left";
            this.btn_move_left.Size = new System.Drawing.Size(75, 23);
            this.btn_move_left.TabIndex = 3;
            this.btn_move_left.Text = "left";
            this.btn_move_left.UseVisualStyleBackColor = true;
            this.btn_move_left.Click += new System.EventHandler(this.btn_move_left_Click);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(12, 12);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(14, 13);
            this.lbl_x.TabIndex = 5;
            this.lbl_x.Text = "X";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(12, 34);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(14, 13);
            this.lbl_y.TabIndex = 6;
            this.lbl_y.Text = "Y";
            // 
            // btn_Render
            // 
            this.btn_Render.Location = new System.Drawing.Point(286, 976);
            this.btn_Render.Name = "btn_Render";
            this.btn_Render.Size = new System.Drawing.Size(75, 23);
            this.btn_Render.TabIndex = 7;
            this.btn_Render.Text = "btn_Render";
            this.btn_Render.UseVisualStyleBackColor = true;
            this.btn_Render.Click += new System.EventHandler(this.btn_Render_Click);
            // 
            // txt_Xmin
            // 
            this.txt_Xmin.Location = new System.Drawing.Point(408, 976);
            this.txt_Xmin.Name = "txt_Xmin";
            this.txt_Xmin.Size = new System.Drawing.Size(100, 20);
            this.txt_Xmin.TabIndex = 8;
            this.txt_Xmin.Text = "-2";
            // 
            // txt_Xmax
            // 
            this.txt_Xmax.Location = new System.Drawing.Point(554, 976);
            this.txt_Xmax.Name = "txt_Xmax";
            this.txt_Xmax.Size = new System.Drawing.Size(100, 20);
            this.txt_Xmax.TabIndex = 9;
            this.txt_Xmax.Text = "1";
            // 
            // txt_Ymax
            // 
            this.txt_Ymax.Location = new System.Drawing.Point(554, 1002);
            this.txt_Ymax.Name = "txt_Ymax";
            this.txt_Ymax.Size = new System.Drawing.Size(100, 20);
            this.txt_Ymax.TabIndex = 11;
            this.txt_Ymax.Text = "1";
            // 
            // txt_Ymin
            // 
            this.txt_Ymin.Location = new System.Drawing.Point(408, 1002);
            this.txt_Ymin.Name = "txt_Ymin";
            this.txt_Ymin.Size = new System.Drawing.Size(100, 20);
            this.txt_Ymin.TabIndex = 10;
            this.txt_Ymin.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 979);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Xmin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 1005);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ymin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 1005);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ymax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 979);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Xmax";
            // 
            // btn_savecoords
            // 
            this.btn_savecoords.Location = new System.Drawing.Point(665, 990);
            this.btn_savecoords.Name = "btn_savecoords";
            this.btn_savecoords.Size = new System.Drawing.Size(75, 23);
            this.btn_savecoords.TabIndex = 17;
            this.btn_savecoords.Text = "save changes";
            this.btn_savecoords.UseVisualStyleBackColor = true;
            this.btn_savecoords.Click += new System.EventHandler(this.btn_savecoords_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 1006);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Zoomin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Zoomout
            // 
            this.btn_Zoomout.Location = new System.Drawing.Point(172, 974);
            this.btn_Zoomout.Name = "btn_Zoomout";
            this.btn_Zoomout.Size = new System.Drawing.Size(75, 23);
            this.btn_Zoomout.TabIndex = 19;
            this.btn_Zoomout.Text = "Zoomout";
            this.btn_Zoomout.UseVisualStyleBackColor = true;
            this.btn_Zoomout.Click += new System.EventHandler(this.btn_Zoomout_Click);
            // 
            // pnl_mousecheck
            // 
            this.pnl_mousecheck.Location = new System.Drawing.Point(847, 976);
            this.pnl_mousecheck.Name = "pnl_mousecheck";
            this.pnl_mousecheck.Size = new System.Drawing.Size(156, 53);
            this.pnl_mousecheck.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnl_mousecheck);
            this.Controls.Add(this.btn_Zoomout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_savecoords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ymax);
            this.Controls.Add(this.txt_Ymin);
            this.Controls.Add(this.txt_Xmax);
            this.Controls.Add(this.txt_Xmin);
            this.Controls.Add(this.btn_Render);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.btn_move_right);
            this.Controls.Add(this.btn_move_left);
            this.Controls.Add(this.btn_move_down);
            this.Controls.Add(this.btn_move_up);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_move_up;
        private System.Windows.Forms.Button btn_move_down;
        private System.Windows.Forms.Button btn_move_right;
        private System.Windows.Forms.Button btn_move_left;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Button btn_Render;
        private System.Windows.Forms.TextBox txt_Xmin;
        private System.Windows.Forms.TextBox txt_Xmax;
        private System.Windows.Forms.TextBox txt_Ymax;
        private System.Windows.Forms.TextBox txt_Ymin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_savecoords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Zoomout;
        private System.Windows.Forms.Panel pnl_mousecheck;
    }
}

