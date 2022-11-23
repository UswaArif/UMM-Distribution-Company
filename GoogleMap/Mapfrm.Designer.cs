
namespace GoogleMap
{
    partial class Mapfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lattxt = new System.Windows.Forms.TextBox();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.Longtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gMapDisplayArea = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Lattxt
            // 
            this.Lattxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lattxt.Location = new System.Drawing.Point(608, 64);
            this.Lattxt.Name = "Lattxt";
            this.Lattxt.Size = new System.Drawing.Size(100, 20);
            this.Lattxt.TabIndex = 3;
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadMap.Location = new System.Drawing.Point(633, 187);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMap.TabIndex = 4;
            this.btnLoadMap.Text = "button1";
            this.btnLoadMap.UseVisualStyleBackColor = true;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // Longtxt
            // 
            this.Longtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Longtxt.Location = new System.Drawing.Point(608, 127);
            this.Longtxt.Name = "Longtxt";
            this.Longtxt.Size = new System.Drawing.Size(100, 20);
            this.Longtxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // gMapDisplayArea
            // 
            this.gMapDisplayArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gMapDisplayArea.Bearing = 0F;
            this.gMapDisplayArea.CanDragMap = true;
            this.gMapDisplayArea.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapDisplayArea.GrayScaleMode = false;
            this.gMapDisplayArea.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapDisplayArea.LevelsKeepInMemory = 5;
            this.gMapDisplayArea.Location = new System.Drawing.Point(3, 0);
            this.gMapDisplayArea.MarkersEnabled = true;
            this.gMapDisplayArea.MaxZoom = 2;
            this.gMapDisplayArea.MinZoom = 2;
            this.gMapDisplayArea.MouseWheelZoomEnabled = true;
            this.gMapDisplayArea.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapDisplayArea.Name = "gMapDisplayArea";
            this.gMapDisplayArea.NegativeMode = false;
            this.gMapDisplayArea.PolygonsEnabled = true;
            this.gMapDisplayArea.RetryLoadTile = 0;
            this.gMapDisplayArea.RoutesEnabled = true;
            this.gMapDisplayArea.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapDisplayArea.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapDisplayArea.ShowTileGridLines = false;
            this.gMapDisplayArea.Size = new System.Drawing.Size(565, 453);
            this.gMapDisplayArea.TabIndex = 7;
            this.gMapDisplayArea.Zoom = 0D;
            // 
            // Mapfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gMapDisplayArea);
            this.Controls.Add(this.Longtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadMap);
            this.Controls.Add(this.Lattxt);
            this.Controls.Add(this.label1);
            this.Name = "Mapfrm";
            this.Text = "Mapfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lattxt;
        private System.Windows.Forms.Button btnLoadMap;
        private System.Windows.Forms.TextBox Longtxt;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl gMapDisplayArea;
    }
}