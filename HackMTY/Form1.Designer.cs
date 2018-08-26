using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace HackMTY
{
    partial class Ventana_1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        IFirebaseConfig Config = new FirebaseConfig
        {
            AuthSecret = "8wKdUxnh2sHrvFbG8rXYu9UpARtyO06nwpHaDffs",
            BasePath = "https://hackmty2018-8f5e9.firebaseio.com/",
        };
        IFirebaseClient client;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            //Text="Entro";
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            client = new FireSharp.FirebaseClient(Config);
            if (client != null) 
            {
                //MessageBox.show("conexion estable");
            }
            
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_1));
            this.MapaGoogle = new GMap.NET.WindowsForms.GMapControl();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnZonas = new System.Windows.Forms.Button();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MapaGoogle
            // 
            this.MapaGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapaGoogle.AutoScroll = true;
            this.MapaGoogle.AutoSize = true;
            this.MapaGoogle.Bearing = 0F;
            this.MapaGoogle.CanDragMap = true;
            this.MapaGoogle.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MapaGoogle.EmptyTileColor = System.Drawing.Color.Navy;
            this.MapaGoogle.GrayScaleMode = false;
            this.MapaGoogle.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MapaGoogle.LevelsKeepInMemmory = 5;
            this.MapaGoogle.Location = new System.Drawing.Point(168, 12);
            this.MapaGoogle.MarkersEnabled = true;
            this.MapaGoogle.MaxZoom = 2;
            this.MapaGoogle.MinZoom = 2;
            this.MapaGoogle.MouseWheelZoomEnabled = true;
            this.MapaGoogle.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MapaGoogle.Name = "MapaGoogle";
            this.MapaGoogle.NegativeMode = false;
            this.MapaGoogle.PolygonsEnabled = true;
            this.MapaGoogle.RetryLoadTile = 0;
            this.MapaGoogle.RoutesEnabled = true;
            this.MapaGoogle.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MapaGoogle.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MapaGoogle.ShowTileGridLines = false;
            this.MapaGoogle.Size = new System.Drawing.Size(620, 417);
            this.MapaGoogle.TabIndex = 0;
            this.MapaGoogle.Zoom = 0D;
            this.MapaGoogle.Load += new System.EventHandler(this.MapaGoogle_Load);
            this.MapaGoogle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MapaGoogle_MouseDoubleClick);
            // 
            // PanelInfo
            // 
            this.PanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelInfo.Controls.Add(this.panel1);
            this.PanelInfo.Controls.Add(this.pictureBox1);
            this.PanelInfo.Controls.Add(this.button4);
            this.PanelInfo.Controls.Add(this.button3);
            this.PanelInfo.Controls.Add(this.button2);
            this.PanelInfo.Controls.Add(this.btnZonas);
            this.PanelInfo.Location = new System.Drawing.Point(12, 12);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(150, 468);
            this.PanelInfo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(5, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 122);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::HackMTY.Properties.Resources.user__4_;
            this.pictureBox1.InitialImage = global::HackMTY.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(5, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(3, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Transeúnte";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(4, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Transporte publico";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(4, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "vehiculos Personales";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnZonas
            // 
            this.btnZonas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZonas.Location = new System.Drawing.Point(3, 134);
            this.btnZonas.Name = "btnZonas";
            this.btnZonas.Size = new System.Drawing.Size(140, 30);
            this.btnZonas.TabIndex = 1;
            this.btnZonas.Text = "Zonas";
            this.btnZonas.UseVisualStyleBackColor = true;
            // 
            // Ventana_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.MapaGoogle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Ventana_1";
            this.Text = "Gaidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MapaGoogle;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnZonas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

