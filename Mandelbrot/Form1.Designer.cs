
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
            this.components = new System.ComponentModel.Container();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.txt_Xmin = new System.Windows.Forms.TextBox();
            this.txt_Xmax = new System.Windows.Forms.TextBox();
            this.txt_Ymax = new System.Windows.Forms.TextBox();
            this.txt_Ymin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_savecoords = new System.Windows.Forms.Button();
            this.lbl_Xtotal = new System.Windows.Forms.Label();
            this.lbl_Ytotal = new System.Windows.Forms.Label();
            this.lbl_xclick = new System.Windows.Forms.Label();
            this.lbl_yclick = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pnl_btns = new System.Windows.Forms.Panel();
            this.btn_smaller = new System.Windows.Forms.Button();
            this.btn_bigger = new System.Windows.Forms.Button();
            this.btn_savetopng = new System.Windows.Forms.Button();
            this.lbl_Zoom = new System.Windows.Forms.Label();
            this.txt_Zoomfactor = new System.Windows.Forms.TextBox();
            this.lbl_x50 = new System.Windows.Forms.Label();
            this.lbl_x25 = new System.Windows.Forms.Label();
            this.lbl_x75 = new System.Windows.Forms.Label();
            this.lbl_xy = new System.Windows.Forms.Label();
            this.lbl_y25 = new System.Windows.Forms.Label();
            this.lbl_y50 = new System.Windows.Forms.Label();
            this.lbl_y75 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_x100 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_xy_2 = new System.Windows.Forms.Label();
            this.lbl_y25_2 = new System.Windows.Forms.Label();
            this.lbl_y50_2 = new System.Windows.Forms.Label();
            this.lbl_y75_2 = new System.Windows.Forms.Label();
            this.lbl_x75_2 = new System.Windows.Forms.Label();
            this.lbl_x50_2 = new System.Windows.Forms.Label();
            this.lbl_x25_2 = new System.Windows.Forms.Label();
            this.tool_tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(61, 35);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(14, 13);
            this.lbl_x.TabIndex = 5;
            this.lbl_x.Text = "X";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(61, 57);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(14, 13);
            this.lbl_y.TabIndex = 6;
            this.lbl_y.Text = "Y";
            // 
            // txt_Xmin
            // 
            this.txt_Xmin.Location = new System.Drawing.Point(93, 12);
            this.txt_Xmin.Name = "txt_Xmin";
            this.txt_Xmin.Size = new System.Drawing.Size(53, 20);
            this.txt_Xmin.TabIndex = 8;
            this.txt_Xmin.Text = "-2";
            // 
            // txt_Xmax
            // 
            this.txt_Xmax.Location = new System.Drawing.Point(193, 12);
            this.txt_Xmax.Name = "txt_Xmax";
            this.txt_Xmax.Size = new System.Drawing.Size(53, 20);
            this.txt_Xmax.TabIndex = 9;
            this.txt_Xmax.Text = "1";
            // 
            // txt_Ymax
            // 
            this.txt_Ymax.Location = new System.Drawing.Point(193, 38);
            this.txt_Ymax.Name = "txt_Ymax";
            this.txt_Ymax.Size = new System.Drawing.Size(53, 20);
            this.txt_Ymax.TabIndex = 11;
            this.txt_Ymax.Text = "1";
            // 
            // txt_Ymin
            // 
            this.txt_Ymin.Location = new System.Drawing.Point(93, 38);
            this.txt_Ymin.Name = "txt_Ymin";
            this.txt_Ymin.Size = new System.Drawing.Size(53, 20);
            this.txt_Ymin.TabIndex = 10;
            this.txt_Ymin.Text = "-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Xmin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ymin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ymax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Xmax";
            // 
            // btn_savecoords
            // 
            this.btn_savecoords.Location = new System.Drawing.Point(255, 10);
            this.btn_savecoords.Name = "btn_savecoords";
            this.btn_savecoords.Size = new System.Drawing.Size(100, 23);
            this.btn_savecoords.TabIndex = 17;
            this.btn_savecoords.Text = "Save X / Y";
            this.btn_savecoords.UseVisualStyleBackColor = true;
            this.btn_savecoords.Click += new System.EventHandler(this.btn_savecoords_Click);
            this.btn_savecoords.MouseHover += new System.EventHandler(this.btn_savecoords_MouseHover);
            // 
            // lbl_Xtotal
            // 
            this.lbl_Xtotal.AutoSize = true;
            this.lbl_Xtotal.Location = new System.Drawing.Point(2, 15);
            this.lbl_Xtotal.Name = "lbl_Xtotal";
            this.lbl_Xtotal.Size = new System.Drawing.Size(34, 13);
            this.lbl_Xtotal.TabIndex = 21;
            this.lbl_Xtotal.Text = "Xtotal";
            // 
            // lbl_Ytotal
            // 
            this.lbl_Ytotal.AutoSize = true;
            this.lbl_Ytotal.Location = new System.Drawing.Point(2, 41);
            this.lbl_Ytotal.Name = "lbl_Ytotal";
            this.lbl_Ytotal.Size = new System.Drawing.Size(33, 13);
            this.lbl_Ytotal.TabIndex = 22;
            this.lbl_Ytotal.Text = "Xmax";
            // 
            // lbl_xclick
            // 
            this.lbl_xclick.AutoSize = true;
            this.lbl_xclick.Location = new System.Drawing.Point(190, 64);
            this.lbl_xclick.Name = "lbl_xclick";
            this.lbl_xclick.Size = new System.Drawing.Size(17, 13);
            this.lbl_xclick.TabIndex = 24;
            this.lbl_xclick.Text = "X:";
            // 
            // lbl_yclick
            // 
            this.lbl_yclick.AutoSize = true;
            this.lbl_yclick.Location = new System.Drawing.Point(190, 79);
            this.lbl_yclick.Name = "lbl_yclick";
            this.lbl_yclick.Size = new System.Drawing.Size(17, 13);
            this.lbl_yclick.TabIndex = 25;
            this.lbl_yclick.Text = "Y:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1500, 1000);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(255, 35);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 23);
            this.btn_reset.TabIndex = 28;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.MouseHover += new System.EventHandler(this.btn_reset_MouseHover);
            // 
            // pnl_btns
            // 
            this.pnl_btns.BackColor = System.Drawing.Color.Transparent;
            this.pnl_btns.Controls.Add(this.btn_smaller);
            this.pnl_btns.Controls.Add(this.btn_bigger);
            this.pnl_btns.Controls.Add(this.btn_savetopng);
            this.pnl_btns.Controls.Add(this.lbl_Zoom);
            this.pnl_btns.Controls.Add(this.txt_Zoomfactor);
            this.pnl_btns.Controls.Add(this.btn_reset);
            this.pnl_btns.Controls.Add(this.txt_Xmin);
            this.pnl_btns.Controls.Add(this.lbl_yclick);
            this.pnl_btns.Controls.Add(this.txt_Xmax);
            this.pnl_btns.Controls.Add(this.lbl_xclick);
            this.pnl_btns.Controls.Add(this.txt_Ymin);
            this.pnl_btns.Controls.Add(this.txt_Ymax);
            this.pnl_btns.Controls.Add(this.lbl_Ytotal);
            this.pnl_btns.Controls.Add(this.label2);
            this.pnl_btns.Controls.Add(this.lbl_Xtotal);
            this.pnl_btns.Controls.Add(this.label3);
            this.pnl_btns.Controls.Add(this.btn_savecoords);
            this.pnl_btns.Controls.Add(this.label5);
            this.pnl_btns.Controls.Add(this.label4);
            this.pnl_btns.Location = new System.Drawing.Point(0, 897);
            this.pnl_btns.Name = "pnl_btns";
            this.pnl_btns.Size = new System.Drawing.Size(366, 103);
            this.pnl_btns.TabIndex = 29;
            // 
            // btn_smaller
            // 
            this.btn_smaller.Location = new System.Drawing.Point(121, 64);
            this.btn_smaller.Name = "btn_smaller";
            this.btn_smaller.Size = new System.Drawing.Size(25, 23);
            this.btn_smaller.TabIndex = 33;
            this.btn_smaller.Text = "-";
            this.btn_smaller.UseVisualStyleBackColor = true;
            this.btn_smaller.Click += new System.EventHandler(this.btn_smaller_Click);
            this.btn_smaller.MouseHover += new System.EventHandler(this.btn_smaller_MouseHover);
            // 
            // btn_bigger
            // 
            this.btn_bigger.Location = new System.Drawing.Point(152, 64);
            this.btn_bigger.Name = "btn_bigger";
            this.btn_bigger.Size = new System.Drawing.Size(24, 23);
            this.btn_bigger.TabIndex = 32;
            this.btn_bigger.Text = "+";
            this.btn_bigger.UseVisualStyleBackColor = true;
            this.btn_bigger.Click += new System.EventHandler(this.btn_Zoom_Click);
            this.btn_bigger.MouseHover += new System.EventHandler(this.btn_bigger_MouseHover);
            // 
            // btn_savetopng
            // 
            this.btn_savetopng.Location = new System.Drawing.Point(255, 67);
            this.btn_savetopng.Name = "btn_savetopng";
            this.btn_savetopng.Size = new System.Drawing.Size(100, 23);
            this.btn_savetopng.TabIndex = 31;
            this.btn_savetopng.Text = "Save to png";
            this.btn_savetopng.UseVisualStyleBackColor = true;
            this.btn_savetopng.Click += new System.EventHandler(this.button1_Click);
            this.btn_savetopng.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // lbl_Zoom
            // 
            this.lbl_Zoom.AutoSize = true;
            this.lbl_Zoom.Location = new System.Drawing.Point(26, 67);
            this.lbl_Zoom.Name = "lbl_Zoom";
            this.lbl_Zoom.Size = new System.Drawing.Size(61, 13);
            this.lbl_Zoom.TabIndex = 30;
            this.lbl_Zoom.Text = "Zoomfactor";
            // 
            // txt_Zoomfactor
            // 
            this.txt_Zoomfactor.Location = new System.Drawing.Point(93, 64);
            this.txt_Zoomfactor.Name = "txt_Zoomfactor";
            this.txt_Zoomfactor.Size = new System.Drawing.Size(22, 20);
            this.txt_Zoomfactor.TabIndex = 29;
            this.txt_Zoomfactor.Text = "2";
            // 
            // lbl_x50
            // 
            this.lbl_x50.AutoSize = true;
            this.lbl_x50.Location = new System.Drawing.Point(755, 0);
            this.lbl_x50.Name = "lbl_x50";
            this.lbl_x50.Size = new System.Drawing.Size(14, 13);
            this.lbl_x50.TabIndex = 30;
            this.lbl_x50.Text = "X";
            // 
            // lbl_x25
            // 
            this.lbl_x25.AutoSize = true;
            this.lbl_x25.Location = new System.Drawing.Point(377, 0);
            this.lbl_x25.Name = "lbl_x25";
            this.lbl_x25.Size = new System.Drawing.Size(14, 13);
            this.lbl_x25.TabIndex = 31;
            this.lbl_x25.Text = "X";
            // 
            // lbl_x75
            // 
            this.lbl_x75.AutoSize = true;
            this.lbl_x75.Location = new System.Drawing.Point(1132, 0);
            this.lbl_x75.Name = "lbl_x75";
            this.lbl_x75.Size = new System.Drawing.Size(14, 13);
            this.lbl_x75.TabIndex = 32;
            this.lbl_x75.Text = "X";
            // 
            // lbl_xy
            // 
            this.lbl_xy.AutoSize = true;
            this.lbl_xy.Location = new System.Drawing.Point(0, 0);
            this.lbl_xy.Name = "lbl_xy";
            this.lbl_xy.Size = new System.Drawing.Size(14, 13);
            this.lbl_xy.TabIndex = 33;
            this.lbl_xy.Text = "X";
            // 
            // lbl_y25
            // 
            this.lbl_y25.AutoSize = true;
            this.lbl_y25.Location = new System.Drawing.Point(0, 250);
            this.lbl_y25.Name = "lbl_y25";
            this.lbl_y25.Size = new System.Drawing.Size(14, 13);
            this.lbl_y25.TabIndex = 34;
            this.lbl_y25.Text = "X";
            // 
            // lbl_y50
            // 
            this.lbl_y50.AutoSize = true;
            this.lbl_y50.Location = new System.Drawing.Point(0, 500);
            this.lbl_y50.Name = "lbl_y50";
            this.lbl_y50.Size = new System.Drawing.Size(14, 13);
            this.lbl_y50.TabIndex = 35;
            this.lbl_y50.Text = "X";
            // 
            // lbl_y75
            // 
            this.lbl_y75.AutoSize = true;
            this.lbl_y75.Location = new System.Drawing.Point(0, 750);
            this.lbl_y75.Name = "lbl_y75";
            this.lbl_y75.Size = new System.Drawing.Size(14, 13);
            this.lbl_y75.TabIndex = 36;
            this.lbl_y75.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 1000);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "X";
            // 
            // lbl_x100
            // 
            this.lbl_x100.AutoSize = true;
            this.lbl_x100.Location = new System.Drawing.Point(1470, 0);
            this.lbl_x100.Name = "lbl_x100";
            this.lbl_x100.Size = new System.Drawing.Size(14, 13);
            this.lbl_x100.TabIndex = 38;
            this.lbl_x100.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 1480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 1480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 1480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "X";
            // 
            // lbl_xy_2
            // 
            this.lbl_xy_2.AutoSize = true;
            this.lbl_xy_2.Location = new System.Drawing.Point(1470, 985);
            this.lbl_xy_2.Name = "lbl_xy_2";
            this.lbl_xy_2.Size = new System.Drawing.Size(14, 13);
            this.lbl_xy_2.TabIndex = 42;
            this.lbl_xy_2.Text = "X";
            // 
            // lbl_y25_2
            // 
            this.lbl_y25_2.AutoSize = true;
            this.lbl_y25_2.Location = new System.Drawing.Point(1470, 250);
            this.lbl_y25_2.Name = "lbl_y25_2";
            this.lbl_y25_2.Size = new System.Drawing.Size(14, 13);
            this.lbl_y25_2.TabIndex = 43;
            this.lbl_y25_2.Text = "X";
            // 
            // lbl_y50_2
            // 
            this.lbl_y50_2.AutoSize = true;
            this.lbl_y50_2.Location = new System.Drawing.Point(1470, 500);
            this.lbl_y50_2.Name = "lbl_y50_2";
            this.lbl_y50_2.Size = new System.Drawing.Size(14, 13);
            this.lbl_y50_2.TabIndex = 44;
            this.lbl_y50_2.Text = "X";
            // 
            // lbl_y75_2
            // 
            this.lbl_y75_2.AutoSize = true;
            this.lbl_y75_2.Location = new System.Drawing.Point(1470, 750);
            this.lbl_y75_2.Name = "lbl_y75_2";
            this.lbl_y75_2.Size = new System.Drawing.Size(14, 13);
            this.lbl_y75_2.TabIndex = 45;
            this.lbl_y75_2.Text = "X";
            // 
            // lbl_x75_2
            // 
            this.lbl_x75_2.AutoSize = true;
            this.lbl_x75_2.Location = new System.Drawing.Point(1132, 985);
            this.lbl_x75_2.Name = "lbl_x75_2";
            this.lbl_x75_2.Size = new System.Drawing.Size(14, 13);
            this.lbl_x75_2.TabIndex = 46;
            this.lbl_x75_2.Text = "X";
            // 
            // lbl_x50_2
            // 
            this.lbl_x50_2.AutoSize = true;
            this.lbl_x50_2.Location = new System.Drawing.Point(755, 985);
            this.lbl_x50_2.Name = "lbl_x50_2";
            this.lbl_x50_2.Size = new System.Drawing.Size(14, 13);
            this.lbl_x50_2.TabIndex = 47;
            this.lbl_x50_2.Text = "X";
            // 
            // lbl_x25_2
            // 
            this.lbl_x25_2.AutoSize = true;
            this.lbl_x25_2.Location = new System.Drawing.Point(377, 985);
            this.lbl_x25_2.Name = "lbl_x25_2";
            this.lbl_x25_2.Size = new System.Drawing.Size(14, 13);
            this.lbl_x25_2.TabIndex = 48;
            this.lbl_x25_2.Text = "X";
            // 
            // tool_tip
            // 
            this.tool_tip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1494, 998);
            this.Controls.Add(this.lbl_x25_2);
            this.Controls.Add(this.lbl_x50_2);
            this.Controls.Add(this.lbl_x75_2);
            this.Controls.Add(this.lbl_y75_2);
            this.Controls.Add(this.lbl_y50_2);
            this.Controls.Add(this.lbl_y25_2);
            this.Controls.Add(this.lbl_xy_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_x100);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_y75);
            this.Controls.Add(this.lbl_y50);
            this.Controls.Add(this.lbl_y25);
            this.Controls.Add(this.lbl_xy);
            this.Controls.Add(this.lbl_x75);
            this.Controls.Add(this.lbl_x25);
            this.Controls.Add(this.lbl_x50);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.pnl_btns);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_btns.ResumeLayout(false);
            this.pnl_btns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.TextBox txt_Xmin;
        private System.Windows.Forms.TextBox txt_Xmax;
        private System.Windows.Forms.TextBox txt_Ymax;
        private System.Windows.Forms.TextBox txt_Ymin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_savecoords;
        private System.Windows.Forms.Label lbl_Xtotal;
        private System.Windows.Forms.Label lbl_Ytotal;
        private System.Windows.Forms.Label lbl_xclick;
        private System.Windows.Forms.Label lbl_yclick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel pnl_btns;
        private System.Windows.Forms.Label lbl_Zoom;
        private System.Windows.Forms.TextBox txt_Zoomfactor;
        private System.Windows.Forms.Button btn_savetopng;
        private System.Windows.Forms.Label lbl_x50;
        private System.Windows.Forms.Label lbl_x25;
        private System.Windows.Forms.Label lbl_x75;
        private System.Windows.Forms.Label lbl_xy;
        private System.Windows.Forms.Label lbl_y25;
        private System.Windows.Forms.Label lbl_y50;
        private System.Windows.Forms.Label lbl_y75;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_x100;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_xy_2;
        private System.Windows.Forms.Label lbl_y25_2;
        private System.Windows.Forms.Label lbl_y50_2;
        private System.Windows.Forms.Label lbl_y75_2;
        private System.Windows.Forms.Label lbl_x75_2;
        private System.Windows.Forms.Label lbl_x50_2;
        private System.Windows.Forms.Label lbl_x25_2;
        private System.Windows.Forms.Button btn_bigger;
        private System.Windows.Forms.Button btn_smaller;
        private System.Windows.Forms.ToolTip tool_tip;
    }
}

