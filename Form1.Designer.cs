namespace GeometrischeAlgorithmen
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
            this.cmdPktEinf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPunktwolke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGeradenbueschel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdGerEinf = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.cmdIntersect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSchnittpunkte = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdLoeschen = new System.Windows.Forms.Button();
            this.lstAuswahl = new System.Windows.Forms.ListBox();
            this.lblAuswahl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkAuswahl = new System.Windows.Forms.CheckBox();
            this.checkConvex = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdPolyline = new System.Windows.Forms.Button();
            this.cmdGerade = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblPoly = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblLine1L = new System.Windows.Forms.Label();
            this.lblLine2L = new System.Windows.Forms.Label();
            this.lblLine1T = new System.Windows.Forms.Label();
            this.lblLine2T = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPN = new System.Windows.Forms.Label();
            this.lblPFlaeche = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPktEinf
            // 
            this.cmdPktEinf.Location = new System.Drawing.Point(282, 42);
            this.cmdPktEinf.Name = "cmdPktEinf";
            this.cmdPktEinf.Size = new System.Drawing.Size(91, 24);
            this.cmdPktEinf.TabIndex = 1;
            this.cmdPktEinf.Text = "Einfügen";
            this.cmdPktEinf.UseVisualStyleBackColor = true;
            this.cmdPktEinf.Click += new System.EventHandler(this.cmdPktEinf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Punktwolke generieren:";
            // 
            // txtPunktwolke
            // 
            this.txtPunktwolke.Location = new System.Drawing.Point(116, 46);
            this.txtPunktwolke.Name = "txtPunktwolke";
            this.txtPunktwolke.Size = new System.Drawing.Size(96, 20);
            this.txtPunktwolke.TabIndex = 0;
            this.txtPunktwolke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geradenbüschel generieren:";
            // 
            // txtGeradenbueschel
            // 
            this.txtGeradenbueschel.Location = new System.Drawing.Point(116, 309);
            this.txtGeradenbueschel.Name = "txtGeradenbueschel";
            this.txtGeradenbueschel.Size = new System.Drawing.Size(96, 20);
            this.txtGeradenbueschel.TabIndex = 2;
            this.txtGeradenbueschel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anzahl Punkte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Anzahl Geraden:";
            // 
            // cmdGerEinf
            // 
            this.cmdGerEinf.Location = new System.Drawing.Point(282, 305);
            this.cmdGerEinf.Name = "cmdGerEinf";
            this.cmdGerEinf.Size = new System.Drawing.Size(91, 24);
            this.cmdGerEinf.TabIndex = 3;
            this.cmdGerEinf.Text = "Einfügen";
            this.cmdGerEinf.UseVisualStyleBackColor = true;
            this.cmdGerEinf.Click += new System.EventHandler(this.cmdGerEinf_Click);
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picBox.Location = new System.Drawing.Point(418, 42);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(600, 600);
            this.picBox.TabIndex = 8;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // cmdBeenden
            // 
            this.cmdBeenden.Location = new System.Drawing.Point(253, 666);
            this.cmdBeenden.Name = "cmdBeenden";
            this.cmdBeenden.Size = new System.Drawing.Size(120, 36);
            this.cmdBeenden.TabIndex = 10;
            this.cmdBeenden.Text = "Beenden";
            this.cmdBeenden.UseVisualStyleBackColor = true;
            this.cmdBeenden.Click += new System.EventHandler(this.cmdBeenden_Click);
            // 
            // cmdIntersect
            // 
            this.cmdIntersect.Location = new System.Drawing.Point(282, 344);
            this.cmdIntersect.Name = "cmdIntersect";
            this.cmdIntersect.Size = new System.Drawing.Size(91, 40);
            this.cmdIntersect.TabIndex = 11;
            this.cmdIntersect.Text = "Berechne Schnittpunkte";
            this.cmdIntersect.UseVisualStyleBackColor = true;
            this.cmdIntersect.Click += new System.EventHandler(this.cmdIntersect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Anzahl Schnittpunkte:";
            // 
            // lblSchnittpunkte
            // 
            this.lblSchnittpunkte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSchnittpunkte.Location = new System.Drawing.Point(148, 366);
            this.lblSchnittpunkte.Name = "lblSchnittpunkte";
            this.lblSchnittpunkte.Size = new System.Drawing.Size(64, 18);
            this.lblSchnittpunkte.TabIndex = 13;
            this.lblSchnittpunkte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "max 1000 Punkte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "max 50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ausgewählte Punkte:";
            // 
            // cmdLoeschen
            // 
            this.cmdLoeschen.Location = new System.Drawing.Point(282, 184);
            this.cmdLoeschen.Name = "cmdLoeschen";
            this.cmdLoeschen.Size = new System.Drawing.Size(91, 35);
            this.cmdLoeschen.TabIndex = 17;
            this.cmdLoeschen.Text = "Auswahl löschen";
            this.cmdLoeschen.UseVisualStyleBackColor = true;
            this.cmdLoeschen.Click += new System.EventHandler(this.cmdLoeschen_Click);
            // 
            // lstAuswahl
            // 
            this.lstAuswahl.FormattingEnabled = true;
            this.lstAuswahl.Location = new System.Drawing.Point(19, 111);
            this.lstAuswahl.Name = "lstAuswahl";
            this.lstAuswahl.ScrollAlwaysVisible = true;
            this.lstAuswahl.Size = new System.Drawing.Size(226, 108);
            this.lstAuswahl.TabIndex = 18;
            // 
            // lblAuswahl
            // 
            this.lblAuswahl.Location = new System.Drawing.Point(140, 222);
            this.lblAuswahl.Name = "lblAuswahl";
            this.lblAuswahl.Size = new System.Drawing.Size(45, 21);
            this.lblAuswahl.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Anzahl Auswahl:";
            // 
            // checkAuswahl
            // 
            this.checkAuswahl.AutoSize = true;
            this.checkAuswahl.Enabled = false;
            this.checkAuswahl.Location = new System.Drawing.Point(267, 118);
            this.checkAuswahl.Name = "checkAuswahl";
            this.checkAuswahl.Size = new System.Drawing.Size(112, 17);
            this.checkAuswahl.TabIndex = 21;
            this.checkAuswahl.Text = "Auswahl anzeigen";
            this.checkAuswahl.UseVisualStyleBackColor = true;
            this.checkAuswahl.CheckedChanged += new System.EventHandler(this.checkAuswahl_CheckedChanged);
            // 
            // checkConvex
            // 
            this.checkConvex.AutoSize = true;
            this.checkConvex.Location = new System.Drawing.Point(267, 95);
            this.checkConvex.Name = "checkConvex";
            this.checkConvex.Size = new System.Drawing.Size(141, 17);
            this.checkConvex.TabIndex = 22;
            this.checkConvex.Text = "Konvexe Hülle anzeigen";
            this.checkConvex.UseVisualStyleBackColor = true;
            this.checkConvex.CheckedChanged += new System.EventHandler(this.checkConvex_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Manuelle Testfälle:";
            // 
            // cmdPolyline
            // 
            this.cmdPolyline.Location = new System.Drawing.Point(19, 556);
            this.cmdPolyline.Name = "cmdPolyline";
            this.cmdPolyline.Size = new System.Drawing.Size(120, 44);
            this.cmdPolyline.TabIndex = 24;
            this.cmdPolyline.Text = "Punkt in Polygon";
            this.cmdPolyline.UseVisualStyleBackColor = true;
            this.cmdPolyline.Click += new System.EventHandler(this.cmdPolyline_Click);
            // 
            // cmdGerade
            // 
            this.cmdGerade.Location = new System.Drawing.Point(19, 470);
            this.cmdGerade.Name = "cmdGerade";
            this.cmdGerade.Size = new System.Drawing.Size(120, 44);
            this.cmdGerade.TabIndex = 26;
            this.cmdGerade.Text = "Streckenschnitt";
            this.cmdGerade.UseVisualStyleBackColor = true;
            this.cmdGerade.Click += new System.EventHandler(this.cmdGerade_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(367, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "---------------------------------------------------------------------------------" +
                "---------------------------------------";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 403);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(367, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "---------------------------------------------------------------------------------" +
                "---------------------------------------";
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(170, 416);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(186, 47);
            this.lblMessage.TabIndex = 29;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPoly
            // 
            this.lblPoly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPoly.Location = new System.Drawing.Point(265, 558);
            this.lblPoly.Name = "lblPoly";
            this.lblPoly.Size = new System.Drawing.Size(108, 20);
            this.lblPoly.TabIndex = 30;
            this.lblPoly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Längen:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(170, 520);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Richtungswinkel:";
            // 
            // lblLine1L
            // 
            this.lblLine1L.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine1L.Location = new System.Drawing.Point(264, 489);
            this.lblLine1L.Name = "lblLine1L";
            this.lblLine1L.Size = new System.Drawing.Size(46, 22);
            this.lblLine1L.TabIndex = 33;
            this.lblLine1L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine2L
            // 
            this.lblLine2L.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine2L.Location = new System.Drawing.Point(327, 489);
            this.lblLine2L.Name = "lblLine2L";
            this.lblLine2L.Size = new System.Drawing.Size(46, 22);
            this.lblLine2L.TabIndex = 34;
            this.lblLine2L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine1T
            // 
            this.lblLine1T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine1T.Location = new System.Drawing.Point(264, 520);
            this.lblLine1T.Name = "lblLine1T";
            this.lblLine1T.Size = new System.Drawing.Size(46, 22);
            this.lblLine1T.TabIndex = 35;
            this.lblLine1T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine2T
            // 
            this.lblLine2T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine2T.Location = new System.Drawing.Point(327, 520);
            this.lblLine2T.Name = "lblLine2T";
            this.lblLine2T.Size = new System.Drawing.Size(46, 22);
            this.lblLine2T.TabIndex = 36;
            this.lblLine2T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(161, 565);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Einfaches Polygon:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(178, 609);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Polygonpunkte:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(217, 587);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Fläche:";
            // 
            // lblPN
            // 
            this.lblPN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPN.Location = new System.Drawing.Point(265, 609);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(45, 20);
            this.lblPN.TabIndex = 40;
            this.lblPN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPFlaeche
            // 
            this.lblPFlaeche.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPFlaeche.Location = new System.Drawing.Point(265, 583);
            this.lblPFlaeche.Name = "lblPFlaeche";
            this.lblPFlaeche.Size = new System.Drawing.Size(108, 20);
            this.lblPFlaeche.TabIndex = 41;
            this.lblPFlaeche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 629);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(367, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "---------------------------------------------------------------------------------" +
                "---------------------------------------";
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(362, 416);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(41, 41);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 43;
            this.picBox2.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(277, 470);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "S1:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(339, 470);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "S2:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(161, 542);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(211, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "--------------------------------------------------------------------";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(161, 457);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(211, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "--------------------------------------------------------------------";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 396);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(367, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "---------------------------------------------------------------------------------" +
                "---------------------------------------";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 251);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(367, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "---------------------------------------------------------------------------------" +
                "---------------------------------------";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(16, 637);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(367, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "---------------------------------------------------------------------------------" +
                "---------------------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 731);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblPFlaeche);
            this.Controls.Add(this.lblPN);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblLine2T);
            this.Controls.Add(this.lblLine1T);
            this.Controls.Add(this.lblLine2L);
            this.Controls.Add(this.lblLine1L);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPoly);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdGerade);
            this.Controls.Add(this.cmdPolyline);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkConvex);
            this.Controls.Add(this.checkAuswahl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAuswahl);
            this.Controls.Add(this.lstAuswahl);
            this.Controls.Add(this.cmdLoeschen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSchnittpunkte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdIntersect);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.cmdGerEinf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGeradenbueschel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPunktwolke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPktEinf);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Bachelorarbeit - Geometrische Algorithmen - Michael Mühlegger - 2013";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPktEinf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPunktwolke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGeradenbueschel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdGerEinf;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.Button cmdIntersect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSchnittpunkte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdLoeschen;
        private System.Windows.Forms.ListBox lstAuswahl;
        private System.Windows.Forms.Label lblAuswahl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkAuswahl;
        private System.Windows.Forms.CheckBox checkConvex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdPolyline;
        private System.Windows.Forms.Button cmdGerade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPoly;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLine1L;
        private System.Windows.Forms.Label lblLine2L;
        private System.Windows.Forms.Label lblLine1T;
        private System.Windows.Forms.Label lblLine2T;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.Label lblPFlaeche;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;

    }
}

