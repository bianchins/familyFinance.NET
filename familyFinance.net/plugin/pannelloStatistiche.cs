using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Tools.Graphs;
using Microsoft.Tools.Graphs.Bars;
using Microsoft.Tools.Graphs.Lines;
using Microsoft.Tools.Graphs.Lines.DateLines;
using Microsoft.Tools.Graphs.Pies;
using Microsoft.Tools.Graphs.Legends;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace familyFinance.net.plugin
{
    public partial class pannelloStatistiche : UserControl
    {
        private PieGraph pg = new PieGraph();
        private GraphBase currentGraph = null;
        private Legend l = new Legend(Size.Empty);
        
        public pannelloStatistiche()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pannelloStatistiche_Load(object sender, EventArgs e)
        {
            try
            {
                pg = new PieGraph(this.pictureBox1.Size);
                pg.Text = "Grafico a torta Entrate / Uscite";
                pg.Color = Color.White;
                pg.ColorGradient = Color.RosyBrown;
                double entrate = 0;
                double uscite = 0;
                library.libreria.leggi_entrate(out entrate);
                library.libreria.leggi_uscite(out uscite);
                pg.Slices.Add(new PieSlice(entrate, Color.LightGreen));
                pg.Slices.Add(new PieSlice(Math.Abs(uscite), Color.DarkRed));

                // Legenda
                l = new Legend(this.pictureBox1.Width, 50);
                l.Text = null;

                LegendEntryCollection lec = new LegendEntryCollection();

                lec.Add(new LegendEntry(Color.DarkRed, "Uscite"));
                lec.Add(new LegendEntry(Color.LightGreen, "Entrate"));
                l.LegendEntryCollection = lec;

                this.pictureBox1.Image = GraphRenderer.DrawGraphAndLegend(pg, l, this.pictureBox1.Size);
                currentGraph = pg;
            }
            catch
            {
            }
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                currentGraph.Size = this.pictureBox1.Size;
                this.pictureBox1.Image = GraphRenderer.DrawGraphAndLegend(pg, l, this.pictureBox1.Size);
            }
            catch
            {
            }
        }
    }
}
