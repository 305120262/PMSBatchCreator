using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Output;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMSBatchCreator
{
    public partial class PictureSymbolCreator : Form
    {
        public PictureSymbolCreator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.tbxInput.Text;
            string cat = this.tbxSet.Text;
            string folder = this.tbxOutput.Text;
            string target = this.tbxTarget.Text;
            string depth = this.cbxDepth.Text;

            IStyleGalleryStorage sgs = new StyleGalleryClass();
            while (sgs.FileCount > 0)
            {
                sgs.RemoveFile(sgs.get_File(0));
            }
            IStyleGallery sg = sgs as IStyleGallery;
            sgs.AddFile(input);
            sgs.TargetFile = target;

            IPageLayout3 layout = new PageLayoutClass();
            IGraphicsContainer con = layout as IGraphicsContainer;
            IPage page = layout.Page;
            page.Units = esriUnits.esriPoints;
            
            IRgbColor bgc = new RgbColorClass();
            bgc.Red = 255;
            bgc.Green = 255;
            bgc.Blue = 254;
            IFrameProperties fp = page as IFrameProperties;
            ISymbolBackground bg = new SymbolBackgroundClass();
            bg.Gap = 0;
            ISimpleFillSymbol sfs = new SimpleFillSymbolClass();
            sfs.Color = bgc as IColor;
            ISimpleLineSymbol sls = new SimpleLineSymbolClass();
            sls.Style = esriSimpleLineStyle.esriSLSNull;
            sfs.Outline = sls;
            bg.FillSymbol = sfs as IFillSymbol;
            fp.Background = bg;

            IEnumStyleGalleryItem items = sg.get_Items("Marker Symbols", input, cat);
            IStyleGalleryItem item = items.Next();
            while (item != null)
            {
                //con.DeleteAllElements();
                IMarkerElement mele = new MarkerElementClass();
                IMarkerSymbol sym_m = item.Item as IMarkerSymbol;
                IMultiLayerMarkerSymbol sym_ml = sym_m as IMultiLayerMarkerSymbol;
                double pic_size;
                if (sym_ml.Size % 2 == 0)
                {
                    pic_size = sym_ml.Size+4;
                }
                else
                {
                    pic_size = sym_ml.Size+5;
                }
                page.PutCustomSize(pic_size, pic_size);
                IPoint ptn = new PointClass();
                ptn.PutCoords(pic_size / 2, pic_size / 2);
                IElement ele_i = mele as IElement;
                ele_i.Geometry = ptn;

                sym_m.Size = sym_ml.Size;
                mele.Symbol = sym_m;
                con.AddElement(ele_i, 0);
                IActiveView av = layout as IActiveView;
                string pic_file = folder+"\\"+item.Name + ".png";
                ExportPNG(av, pic_file,bgc,depth);
                con.DeleteElement(ele_i);

                ISymbol sym = CreatePictureMarkerSymbol(esriIPictureType.esriIPicturePNG, pic_file, pic_size) as ISymbol;
                IStyleGalleryItem newitem = new StyleGalleryItemClass();
                newitem.Name = item.Name;
                newitem.Item = sym;
                newitem.Category = cat;
                sg.AddItem(newitem);

                item = items.Next();
            }
            MessageBox.Show("成功导出图标");
        }

        private void ExportPNG(IActiveView activeView, string pathFileName,IColor bg,string depth)
        {
            IExport export = new ExportPNGClass();
            export.ExportFileName = pathFileName;
            IExportPNG png = export as IExportPNG;
            png.TransparentColor = bg;
            IExportImage img = export as IExportImage;
            if(depth=="8bit")
            { img.ImageType = esriExportImageType.esriExportImageTypeIndexed; }
            else if(depth=="32bit")
            { img.ImageType = esriExportImageType.esriExportImageTypeTrueColor; }
            

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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "style|*.style";
            DialogResult res = dlg.ShowDialog(this);
            
            if (res == DialogResult.OK)
            {
                this.tbxInput.Text = dlg.FileName;
            }
        }

        private ESRI.ArcGIS.Display.IPictureMarkerSymbol CreatePictureMarkerSymbol(ESRI.ArcGIS.Display.esriIPictureType pictureType, System.String filename, System.Double markerSize)
        {

            // Set the Transparent background color for the Picture Marker symbol to white.
            ESRI.ArcGIS.Display.IRgbColor rgbColor = new ESRI.ArcGIS.Display.RgbColorClass();
            rgbColor.Red = 255;
            rgbColor.Green = 255;
            rgbColor.Blue = 255;

            // Create the Marker and assign properties.
            ESRI.ArcGIS.Display.IPictureMarkerSymbol pictureMarkerSymbol = new ESRI.ArcGIS.Display.PictureMarkerSymbolClass();
            pictureMarkerSymbol.CreateMarkerSymbolFromFile(pictureType, filename);
            pictureMarkerSymbol.Angle = 0;
            pictureMarkerSymbol.BitmapTransparencyColor = rgbColor;
            pictureMarkerSymbol.Size = markerSize;
            pictureMarkerSymbol.XOffset = 0;
            pictureMarkerSymbol.YOffset = 0;

            return pictureMarkerSymbol;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            DialogResult res = dlg.ShowDialog(this);
            if(res==DialogResult.OK)
            {
                this.tbxOutput.Text = dlg.SelectedPath;
            }
        }

    }
}
