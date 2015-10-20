using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.esriSystem;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;

namespace PMSBatchCreator
{
    public partial class SymbolBookCreator : Form
    {
        public SymbolBookCreator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string target = this.tbxInput.Text;
            string cat = this.tbxSet.Text;
            int size = int.Parse(this.tbxSize.Text);
            string pdf = this.tbxOutput.Text;
            int labelsize = int.Parse(this.tbxLabelSize.Text);
            int lwidth = int.Parse(this.tbxWidth.Text);
            int label_h = labelsize;
            int size_w = size;
            int size_h = size + label_h;
            List<string> pdfpages = new List<string>();

            IPageLayout3 layout = new PageLayoutClass();
            IGraphicsContainer con = layout as IGraphicsContainer;
            IPage page = layout.Page;
            page.FormID = esriPageFormID.esriPageFormA4;
            page.Units = esriUnits.esriPoints;
            double width;
            double height;
            page.QuerySize(out width, out height);
            int col = (int)Math.Floor(width / size_w);
            int row = (int)Math.Floor(height / size_h);
            
            IStyleGalleryStorage sgs = new StyleGalleryClass();
            while (sgs.FileCount > 0)
            {
                sgs.RemoveFile(sgs.get_File(0));
            }
            IStyleGallery sg = sgs as IStyleGallery;
            sgs.AddFile(target);
            sgs.TargetFile = target;
            if (cbPoint.Checked)
            {
                List<string> ps = ExportSymbol(sg, "Marker Symbols", col, row, size, lwidth,labelsize, label_h, size_w, size_h, height, cat, layout);
                pdfpages.AddRange(ps);
            }
            if(cbLine.Checked)
            {
                List<string> ps = ExportSymbol(sg, "Line Symbols", col, row, size, lwidth, labelsize, label_h, size_w, size_h, height, cat, layout);
                pdfpages.AddRange(ps);
            }
            if (cbArea.Checked)
            {
                List<string> ps = ExportSymbol(sg, "Fill Symbols", col, row, size, lwidth, labelsize, label_h, size_w, size_h, height, cat, layout);
                pdfpages.AddRange(ps);
            }

            PdfDocument doc = new PdfDocument();
            foreach (string temp in pdfpages)
            {
                PdfDocument temp_doc = PdfReader.Open(temp, PdfDocumentOpenMode.Import);
                doc.AddPage(temp_doc.Pages[0]);
            }
            if (doc.PageCount > 0)
            {
                doc.Save(pdf);
            }
            doc.Close();
            MessageBox.Show("成功生成符号图集");
        }

        private List<string> ExportSymbol(IStyleGallery sg,string symbolType, int col, int row, int size,int width, int labelsize, int label_h, int size_w, int size_h, double height, string cat, IPageLayout3 layout)
        {
            List<string> pdfpages = new List<string>();
            IGraphicsContainer con = layout as IGraphicsContainer;
            IPage page = layout.Page;
            int r = 0;
            int c = 0; 
            int p = 0;
            IEnumStyleGalleryItem items = sg.get_Items(symbolType, "", cat);
            IStyleGalleryItem item = items.Next();
            while (item != null)
            {
                #region Symbol              
                if (symbolType == "Marker Symbols")
                {
                    IMarkerElement mele = new MarkerElementClass();
                    IPoint ptn = new PointClass();
                    ptn.PutCoords(c * size_w + size / 2, height - (r * size_h + size / 2));
                    IElement ele_i = mele as IElement;
                    ele_i.Geometry = ptn;
                    IMarkerSymbol sym_m = item.Item as IMarkerSymbol;
                    sym_m.Size = size;
                    mele.Symbol = sym_m;
                    con.AddElement(ele_i, 0);
                }
                else if (symbolType == "Line Symbols")
                {
                    ILineElement lele = new LineElementClass();
                    IPolyline line = new PolylineClass();
                    IPoint ptn_f = new PointClass();
                    ptn_f.PutCoords(c * size_w + size / 4, height - (r * size_h + size * 3 / 4));
                    IPoint ptn_t = new PointClass();
                    ptn_t.PutCoords(c * size_w + size * 3 / 4, height - (r * size_h + size / 4));
                    line.FromPoint = ptn_f;
                    line.ToPoint = ptn_t;
                    IElement ele_i = lele as IElement;
                    ele_i.Geometry = line;
                    ILineSymbol sym_l = item.Item as ILineSymbol;
                    sym_l.Width = width;
                    lele.Symbol = sym_l;
                    con.AddElement(ele_i, 0);
                }
                else if (symbolType == "Fill Symbols")
                {
                    IRectangleElement fele = new RectangleElementClass();
                    IFillShapeElement fsele = fele as IFillShapeElement;
                    IEnvelope env_f = new EnvelopeClass();
                    env_f.PutCoords(c * size_w + size / 4, height - (r * size_h + size * 3 / 4), c * size_w + size * 3 / 4, height - (r * size_h + size / 4));
                    IElement ele_i = fele as IElement;
                    ele_i.Geometry = env_f;
                    IFillSymbol sym_f = item.Item as IFillSymbol;
                    fsele.Symbol = sym_f;
                    con.AddElement(ele_i, 0);
                }
                
                #endregion

                if (cbGrid.Checked)
                {
                    #region Grid
                    IEnvelope env_g = new EnvelopeClass();
                    env_g.PutCoords(c * size_w, height - r * size_h, c * size_w + size_w, height - r * size_h - size_h);
                    IRectangleElement gele = new RectangleElementClass();
                    IElement ele_g = gele as IElement;
                    ele_g.Geometry = env_g;
                    IFillSymbol sym_g = new SimpleFillSymbolClass();
                    IRgbColor color_g = new RgbColorClass();
                    color_g.NullColor = true;
                    sym_g.Color = color_g;
                    IFillShapeElement fshp_g = ele_g as IFillShapeElement;
                    fshp_g.Symbol = sym_g;
                    con.AddElement(ele_g, 0);
                    #endregion
                }

                #region Label
                ITextElement tele = new ParagraphTextElementClass();
                IElement ele_t = tele as IElement;
                tele.Text = item.Name;
                IEnvelope env_l = new EnvelopeClass();
                env_l.PutCoords(c * size_w, height - r * size_h - size_h + label_h, c * size_w + size_w, height - r * size_h - size_h);
                env_l.PutCoords(c * size_w, height - r * size_h - size_h + label_h, c * size_w + size_w, height - r * size_h - size_h);
                env_l.PutCoords(c * size_w, height - r * size_h - size_h + label_h, c * size_w + size_w, height - r * size_h - size_h);
                env_l.PutCoords(c * size_w, height - r * size_h - size_h + label_h, c * size_w + size_w, height - r * size_h - size_h);
                env_l.PutCoords(c * size_w, height - r * size_h - size_h + label_h, c * size_w + size_w, height - r * size_h - size_h);
                ele_t.Geometry = env_l;
                ITextSymbol sym_label = new TextSymbolClass();
                sym_label.Size = labelsize/2;
                IRgbColor color = new RgbColorClass();
                color.NullColor = true;
                ISimpleLineSymbol sym_border = new SimpleLineSymbolClass();
                sym_border.Color = color;
                ISymbolBorder border = new SymbolBorderClass();
                border.LineSymbol = sym_border;
                IFrameProperties fp = ele_t as IFrameProperties;
                fp.Border = border; 
                con.AddElement(ele_t, 0);
                #endregion

                if (c < col - 1)
                {
                    c++;
                }
                else
                {
                    c = 0;
                    if (r < row - 1)
                    {
                        r++;
                    }
                    else
                    {
                        IActiveView av = layout as IActiveView;
                        string temp_pdf = System.IO.Path.GetTempFileName() + ".pdf";
                        ExportPDF(av, temp_pdf);
                        pdfpages.Add(temp_pdf);
                        con.DeleteAllElements();
                        r = 0;
                        c = 0;
                        p++;
                    }
                }
                item = items.Next();
            }
            if (con.Next() != null)
            {
                IActiveView av = layout as IActiveView;
                string temp_pdf = System.IO.Path.GetTempFileName() + ".pdf";
                ExportPDF(av, temp_pdf);
                pdfpages.Add(temp_pdf);
                con.DeleteAllElements();
            }
            return pdfpages;
        }

        private void ExportPDF(IActiveView activeView, string pathFileName)
        {
            IExport export = new ExportPDFClass();
            export.ExportFileName = pathFileName;

            // Microsoft Windows default DPI resolution
            export.Resolution = 96;
            tagRECT exportRECT = activeView.ExportFrame;
            ESRI.ArcGIS.Geometry.IEnvelope envelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            envelope.PutCoords(exportRECT.left, exportRECT.top, exportRECT.right, exportRECT.bottom);
            export.PixelBounds = envelope;
            System.Int32 hDC = export.StartExporting();
            activeView.Output(hDC, (System.Int16)export.Resolution, ref exportRECT, null, null);

            // Finish writing the export file and cleanup any intermediate files
            export.FinishExporting();
            export.Cleanup();

        }
    }
}
