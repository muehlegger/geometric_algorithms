using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeometrischeAlgorithmen
{
    public partial class Form1 : Form
    {
        private float max = 0;
        private float min = 0;
        private Point[] punktwolke;
        private int z;
        private Polygon CH;
        private Graphics g;

        private Line[] geradenmenge;

        private PointF initialMousePos;
        private PointF finalMousePos;

        private Tree T;
        private Point[] Auswahl;

        private List<Point> polygonpunkte = new List<Point>();
        private Polygon polyEingabe;
        private Point gerP1;
        private Line Gerade1, Gerade2;
        private bool PolyDone;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.picBox.CreateGraphics();
            g.Clear(this.picBox.BackColor);
            checkAuswahl.Enabled = false;
            checkConvex.Enabled = false;
            cmdLoeschen.Enabled = false;
        }

        private void cmdPktEinf_Click(object sender, EventArgs e)
        {
            try
            {
                z = Convert.ToInt32(txtPunktwolke.Text);
                if (z > 0 && z <= 1000)
                {
                    resetPoly();
                    resetStrecke();
                    resetPunktwolke();
                    resetSweepIntersect();

                    punktwolke = new Point [z];
                    punktwolke = RandomObjects.getPunktwolke(z);

                    CH = ConvexHull.GetConvexHull(punktwolke);
                    checkConvex.Enabled = true;

                    T = new Tree(punktwolke);

                    max = 0;
                    for (int i = 0; i < z; i++)
                    {
                        if (punktwolke[i].X > max) max = (float)punktwolke[i].X;
                        if (punktwolke[i].Y > max) max = (float)punktwolke[i].Y;
                    }

                    max = picBox.Width / (max + max / 10);

                    g.ResetTransform();
                    g = this.picBox.CreateGraphics();
                    g.Clear(this.picBox.BackColor);
                    g.RotateTransform(-90);
                    g.TranslateTransform(-picBox.Height, 0);
                    g.ScaleTransform(max, max);

                    PunktwolkeZeichnen();
                    checkConvex.Enabled = true;
                }
                else MessageBox.Show("Wert darf nur im Bereich 1 bis 1000 liegen.", "Außerhalb Grenzbereich!");
            }
            catch
            {
                MessageBox.Show("Bitte gültige Ganzzahl eingeben.", "Eingabe ungültig!");
            }
        }

        private void PunktwolkeZeichnen()
        {
            for (int i = 0; i < z; i++)
            {
                float pktX = (float)punktwolke[i].X;
                float pktY = (float)punktwolke[i].Y;

                g.FillRectangle(Brushes.Black, pktX-2, pktY-2, 4, 4);
            }
        }

        private void convexZeichnen()
        {
            for (int i = 0; i < CH.PointList.Length - 1; i++)
            {
                float pktAX = (float)CH.Strecken[i].StartPoint.X;
                float pktAY = (float)CH.Strecken[i].StartPoint.Y;
                float pktBX = (float)CH.Strecken[i].EndPoint.X;
                float pktBY = (float)CH.Strecken[i].EndPoint.Y;
                PointF pktA = new PointF(pktAX, pktAY);
                PointF pktB = new PointF(pktBX, pktBY);

                g.DrawLine(new Pen(Brushes.Black), pktA, pktB);
            }
        }

        private void cmdGerEinf_Click(object sender, EventArgs e)
        {
            try
            {
                int v = Convert.ToInt32(txtGeradenbueschel.Text);

                if (v <= 50)
                {
                    resetPunktwolke();
                    resetStrecke();
                    resetPoly();

                    g = this.picBox.CreateGraphics();
                    g.Clear(this.picBox.BackColor);
                    Pen P = new Pen(Brushes.Black);

                    geradenmenge = RandomObjects.getZufallsgeraden(v);

                    for (int i = 0; i < v; i++)
                    {
                        if (geradenmenge[i].StartPoint.X > max) max = (float)geradenmenge[i].StartPoint.X;
                        if (geradenmenge[i].StartPoint.X < min) min = (float)geradenmenge[i].StartPoint.X;

                        if (geradenmenge[i].EndPoint.X > max) max = (float)geradenmenge[i].EndPoint.X;
                        if (geradenmenge[i].EndPoint.X < min) min = (float)geradenmenge[i].EndPoint.X;

                        if (geradenmenge[i].StartPoint.Y > max) max = (float)geradenmenge[i].StartPoint.Y;
                        if (geradenmenge[i].StartPoint.Y < min) min = (float)geradenmenge[i].StartPoint.Y;

                        if (geradenmenge[i].EndPoint.Y > max) max = (float)geradenmenge[i].EndPoint.Y;
                        if (geradenmenge[i].EndPoint.Y < min) min = (float)geradenmenge[i].EndPoint.Y;
                    }

                    float ratio = picBox.Width / (max + Math.Abs(min) + max / 20);
                    
                    g.TranslateTransform(-min * ratio - min * ratio / 20, -min * ratio - min * ratio / 20);
                    g.ScaleTransform(ratio, ratio);

                    for (int i = 0; i < geradenmenge.Length; i++)
                    {
                        float pktAX = (float)geradenmenge[i].StartPoint.X;
                        float pktAY = (float)geradenmenge[i].StartPoint.Y;
                        float pktBX = (float)geradenmenge[i].EndPoint.X;
                        float pktBY = (float)geradenmenge[i].EndPoint.Y;
                        PointF pktA = new PointF(pktAX, pktAY);
                        PointF pktB = new PointF(pktBX, pktBY);

                        g.DrawLine(new Pen(Brushes.Black), pktA, pktB);
                    }

                    cmdIntersect.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Wert darf nicht über 50 sein.", "Grenze überschritten!");
                }
            }
            catch
            {
                MessageBox.Show("Bitte gültige Ganzzahl eingeben.", "Eingabe ungültig!");
            }
        }

        private void cmdIntersect_Click(object sender, EventArgs e)
        {
            Point[] Schnittpunkte = SweepLine.LineIntersection(geradenmenge);

            lblSchnittpunkte.Text = Convert.ToString(Schnittpunkte.Length);

            for (int i = 0; i < Schnittpunkte.Length; i++)
            {
                float pktX = (float)Schnittpunkte[i].X;
                float pktY = (float)Schnittpunkte[i].Y;

                g.DrawEllipse(new Pen(Brushes.Red), pktX - 8, pktY - 8, 16, 16);

                cmdIntersect.Enabled = false;
            }
        }

        private void cmdBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            initialMousePos = e.Location;

            if (punktwolke != null)
            {
                lblAuswahl.Text = "";
                Auswahl = null;
                checkAuswahl.Checked = false;
            }

            if (PolyDone == true)
            {
                cmdPolyline.Enabled = true;

                string CurrPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
                Image imgPos = Image.FromFile(Application.StartupPath + "\\Images\\pos.gif");
                Image imgNeg = Image.FromFile(Application.StartupPath + "\\Images\\neg.gif");
                lblMessage.Text = "Erstellen Sie einen Punkt!";
                Point Punkt = new Point((initialMousePos.Y * -1 + picBox.Height), initialMousePos.X);
                if (PointInPolygon.PointIsInPolygon(polyEingabe, Punkt))
                {
                    lblMessage.Text = "Punkt liegt INNERHALB des Polygons.";
                    g.FillRectangle(Brushes.Green, initialMousePos.X - 1, initialMousePos.Y - 1, 2, 2);
                    picBox2.Image = imgPos;
                }
                else
                {
                    g.FillRectangle(Brushes.Red, initialMousePos.X - 1, initialMousePos.Y - 1, 2, 2);               
                    lblMessage.Text = "Punkt liegt AUSSERHALB des Polygons.";
                    picBox2.Image = imgNeg;
                }
            }

            if (cmdPolyline.Enabled == false)
            {
                Point polyP = new Point((initialMousePos.Y * -1 + picBox.Height), initialMousePos.X );
                if (polygonpunkte.Count > 1 && Math.Abs(polyP.X - polygonpunkte[0].X) < 5 && Math.Abs(polyP.Y - polygonpunkte[0].Y) < 5)
                {
                    polygonpunkte.Add(polygonpunkte[0]);
                    g.DrawLine(new Pen(Brushes.Blue), (float)polygonpunkte[polygonpunkte.Count - 2].Y, (float)-polygonpunkte[polygonpunkte.Count - 2].X + picBox.Height, (float)polygonpunkte[0].Y, (float)-polygonpunkte[0].X + picBox.Height);
                    Point[] PolyPoints = polygonpunkte.ToArray();
                    polyEingabe = new Polygon(PolyPoints);
                    lblPN.Text = polyEingabe.N.ToString();
                    lblPFlaeche.Text = String.Format("{0:f1}",polyEingabe.Flaeche);
                    PolyDone = true;
                    lblMessage.Text = "Wählen Sie einen Punkt.";
                    if (polyEingabe.IsSimplePolygon)
                    {
                        lblPoly.Text = "true";
                        lblPoly.BackColor = System.Drawing.Color.GreenYellow;
                    }
                    else
                    {
                        lblPoly.Text = "false";
                        lblPoly.BackColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    g.FillRectangle(Brushes.Black, initialMousePos.X - 1, initialMousePos.Y - 1, 2, 2);
                    //g.DrawEllipse(new Pen(Brushes.Blue), initialMousePos.X - 1, initialMousePos.Y - 1, 2, 2);
                    polygonpunkte.Add(polyP);
                    if (polygonpunkte.Count > 1)
                    {
                        g.DrawLine(new Pen(Brushes.Blue), initialMousePos.X, initialMousePos.Y, (float)polygonpunkte[polygonpunkte.Count - 2].Y, (float)-polygonpunkte[polygonpunkte.Count - 2].X + picBox.Height);
                    }
                }
            }
            if (cmdGerade.Enabled == false)
            {
                gerP1 = new Point((initialMousePos.Y * -1 + picBox.Height), initialMousePos.X);
                if (Gerade2 != null)
                {
                    Gerade1 = null;
                    Gerade2 = null;
                    lblMessage.Text = "";
                    lblLine1L.Text = "";
                    lblLine2L.Text = "";
                    lblLine1T.Text = "";
                    lblLine2T.Text = "";
                    g.Clear(this.picBox.BackColor);
                }
                g.DrawEllipse(new Pen(Brushes.Blue), initialMousePos.X - 1, initialMousePos.Y - 1, 2, 2);
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            finalMousePos = e.Location;

            if (punktwolke != null)
            {
                try
                {
                    Point firstP = new Point((initialMousePos.Y * -1 + picBox.Height) / max, initialMousePos.X / max);
                    Point secondP = new Point((finalMousePos.Y * -1 + picBox.Height) / max, finalMousePos.X / max);

                    Rectangle recAus = new Rectangle(firstP, secondP);
                    Auswahl = TreeSearch.PointsInRange(T, recAus);

                    if (Auswahl.Length > 0)
                    {
                        lblAuswahl.Text = Convert.ToString(Auswahl.Length);
                        checkAuswahl.Enabled = true;
                        checkAuswahl.Checked = true;
                        cmdLoeschen.Enabled = true;
                    }
                    else lstAuswahl.Items.Clear();
                }   

                catch
                {
                    Auswahl = null;
                    lblAuswahl.Text = "";
                    lstAuswahl.Items.Clear();
                    checkAuswahl.Checked = false;
                    checkAuswahl.Enabled = false;
                    cmdLoeschen.Enabled = false;
                }
            }

            if (cmdGerade.Enabled == false)
            {
                Point gerP2 = new Point((finalMousePos.Y * -1 + picBox.Height), finalMousePos.X);
                g.DrawEllipse(new Pen(Brushes.Blue), finalMousePos.X - 1, finalMousePos.Y - 1, 2, 2);
                g.DrawLine(new Pen(Brushes.Blue), initialMousePos, finalMousePos);
                
                if (Gerade1 == null)
                {
                    Gerade1 = new Line(gerP1, gerP2);
                    lblLine1L.Text = String.Format("{0:f1}", Gerade1.Length);
                    lblLine1T.Text = String.Format("{0:f1} °", Gerade1.T * 180 / Math.PI);
                }
                else
                {
                    Gerade2 = new Line(gerP1, gerP2);
                    lblLine2L.Text = String.Format("{0:f1}", Gerade2.Length);
                    lblLine2T.Text = String.Format("{0:f1} °", Gerade2.T * 180 / Math.PI);
                    if (Intersect.DoIntersect(Gerade1, Gerade2))
                    {
                        try
                        {
                            Point GSP = Intersect.Intersection(Gerade1, Gerade2);
                            g.DrawEllipse(new Pen(Brushes.Red), (float)GSP.Y - 3, (float)-GSP.X + picBox.Height - 3, 6, 6);
                            lblMessage.Text = String.Format("Die Strecken schneiden sich im Punkt X: {0:f2} - Y: {1:f2}", GSP.X, GSP.Y);
                        }
                        catch
                        {
                            MessageBox.Show("Die Geraden liegen aufeinander.");
                        } 
                    }
                    else lblMessage.Text = "Die Strecken schneiden sich NICHT.";
  
                }  
            }
        }

        private void auswahlZeichnen()
        {
            lstAuswahl.Items.Clear();
            for (int i = 0; i < Auswahl.Length; i++)
            {
                lstAuswahl.Items.Add(String.Format("X:     {0,8:f2}    -    Y:     {1,8:f2}", Auswahl[i].X, Auswahl[i].Y));
                float ax = (float) Auswahl[i].X;
                float ay = (float) Auswahl[i].Y;

                g.DrawEllipse(new Pen(Brushes.Blue), ax - 5, ay - 5, 10, 10);
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
        }

        private void cmdLoeschen_Click(object sender, EventArgs e)
        {
                Auswahl = null;
                lblAuswahl.Text = "";
                lstAuswahl.Items.Clear();
                checkAuswahl.Checked = false;              
                checkAuswahl.Enabled = false;
                cmdLoeschen.Enabled = false;
        }

        private void checkAuswahl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAuswahl.Checked == true)
            {
                if (Auswahl != null) auswahlZeichnen();
            }

            else
            {
                g.Clear(this.picBox.BackColor);
                if (punktwolke != null) PunktwolkeZeichnen();
                if (checkConvex.Checked == true && CH != null) convexZeichnen();
            }
        }

        private void checkConvex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkConvex.Checked == true)
            {
                if (CH != null) convexZeichnen();
            }
            else
            {
                g.Clear(this.picBox.BackColor);
                if (punktwolke != null) PunktwolkeZeichnen();
                if (checkAuswahl.Checked == true && Auswahl != null) auswahlZeichnen();
            }
        }

        private void resetPoly()
        {
            lblMessage.Text = "";
            polygonpunkte.Clear();
            polyEingabe = null;
            lblPoly.BackColor = BackColor;
            PolyDone = false;
            cmdPolyline.Enabled = true;
            lblPoly.Text = "";
            lblPN.Text = "";
            lblPFlaeche.Text = "";
            picBox2.Image = null;
        }

        private void resetStrecke()
        {
            lblMessage.Text = "";
            Gerade1 = null;
            Gerade2 = null;
            cmdGerade.Enabled = true;
            lblLine1L.Text = "";
            lblLine2L.Text = "";
            lblLine1T.Text = "";
            lblLine2T.Text = "";
        }

        private void resetSweepIntersect()
        {
            lblMessage.Text = "";
            geradenmenge = null;
            cmdIntersect.Enabled = false;
            lblSchnittpunkte.Text = "";
        }

        private void resetPunktwolke()
        {
            lblMessage.Text = "";
            punktwolke = null;
            CH = null;
            Auswahl = null;
            lstAuswahl.Items.Clear();
            checkAuswahl.Checked = false;
            checkConvex.Checked = false;
            checkAuswahl.Enabled = false;
            checkConvex.Enabled = false;
            cmdLoeschen.Enabled = false;
            lblAuswahl.Text = "";
        }
        
        private void cmdPolyline_Click(object sender, EventArgs e)
        {
            resetPunktwolke();
            resetSweepIntersect();
            resetPoly();
            resetStrecke();

            g.ResetTransform();
            g = this.picBox.CreateGraphics();
            g.Clear(this.picBox.BackColor);
            
            cmdPolyline.Enabled = false;
            lblMessage.Text = "Erstellen Sie ein Polygon";
        }

        private void cmdGerade_Click(object sender, EventArgs e)
        {
            resetSweepIntersect();
            resetPunktwolke();
            resetPoly();

            g.ResetTransform();
            g = this.picBox.CreateGraphics();
            g.Clear(this.picBox.BackColor);
            cmdGerade.Enabled = false;
            lblMessage.Text = "Zeichnen Sie zwei Geraden um zu sehen ob sie sich schneiden.";
        }
    }
}
