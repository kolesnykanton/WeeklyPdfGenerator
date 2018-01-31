using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Controls;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Dialogs;
using Stimulsoft.Report.Components;

namespace Reports
{
    public class User_Inactivity_Levels : Stimulsoft.Report.StiReport
    {
        public User_Inactivity_Levels()        {
            this.InitializeComponent();	
			
			Stimulsoft.Report.StiOptions.Dictionary.EnableConnectOnStartOnSecondPass = true;		
        }	

        #region StiReport Designer generated code - do not modify
        public int? CustomerList;
        public bool AllCustomers;
        public bool ShowInvoices;
        public int InvoiceList;
        public bool AllInvoices;
        public bool ShowEngineer;
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiPageFooterBand PageFooterBand1;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiText Text17;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive4;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitle;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiPanel Panel2;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive2;
        public Stimulsoft.Report.Components.StiImage Image2;
        public Stimulsoft.Report.Components.StiText Text50;
        public Stimulsoft.Report.Components.StiText Text27;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive4;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive1;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive5;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive1;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive2;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive3;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand2;
        public Stimulsoft.Report.Chart.StiChart Chart1;
        public Stimulsoft.Report.Chart.StiPieArea Chart1_Area;
        public Stimulsoft.Report.Chart.StiLegend Chart1_Legend;
        public Stimulsoft.Report.Chart.StiPieSeries Item29;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item29_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSeriesTopN Item29_TopN;
        public Stimulsoft.Report.Chart.StiPieSeries Item30;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item30_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSeriesTopN Item30_TopN;
        public Stimulsoft.Report.Chart.StiPieSeries Item31;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item31_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSeriesTopN Item31_TopN;
        public Stimulsoft.Report.Chart.StiPieSeries Item32;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item32_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSeriesTopN Item32_TopN;
        public Stimulsoft.Report.Chart.StiPieSeries Item33;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item33_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSeriesTopN Item33_TopN;
        public Stimulsoft.Report.Chart.StiPieSeries Item34;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Item34_SeriesLabels;
        public Stimulsoft.Report.Chart.StiSeriesTopN Item34_TopN;
        public Stimulsoft.Report.Chart.StiCenterAxisLabels Chart1_SeriesLabels;
        public Stimulsoft.Report.Chart.StiChartTable Chart1_Table;
        public Stimulsoft.Report.Components.StiText Text30;
        public Stimulsoft.Report.Components.StiPanel Panel3;
        public Stimulsoft.Report.Components.StiPanel Panel13;
        public Stimulsoft.Report.Components.StiPanel Panel1;
        public Stimulsoft.Report.Components.StiPanel Panel4;
        public Stimulsoft.Report.Components.StiPanel Panel5;
        public Stimulsoft.Report.Components.StiPanel Panel6;
        public Stimulsoft.Report.Components.StiText Text60;
        public Stimulsoft.Report.Components.StiText Text61;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Components.StiText Text18;
        public Stimulsoft.Report.Components.StiText Text19;
        public Stimulsoft.Report.Components.StiText Text20;
        public Stimulsoft.Report.Components.StiText Text21;
        public Stimulsoft.Report.Components.StiText Text22;
        public Stimulsoft.Report.Components.StiText Text23;
        public Stimulsoft.Report.Components.StiText Text24;
        public Stimulsoft.Report.Components.StiText Text25;
        public Stimulsoft.Report.Components.StiText Text26;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive6;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive3;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive7;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive4;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive2;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive8;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive5;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive3;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive5;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive6;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive7;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand1;
        public Stimulsoft.Report.Components.StiText Text39;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive9;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand4;
        public Stimulsoft.Report.Components.StiText Text43;
        public Stimulsoft.Report.Components.StiText Text44;
        public Stimulsoft.Report.Components.StiText Text45;
        public Stimulsoft.Report.Components.StiText Text46;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiText Text15;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive1;
        public Stimulsoft.Report.Components.StiFooterBand FooterBand1;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive6;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand8;
        public Stimulsoft.Report.Components.StiText Text53;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive13;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive12;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand9;
        public Stimulsoft.Report.Components.StiText Text54;
        public Stimulsoft.Report.Components.StiText Text56;
        public Stimulsoft.Report.Components.StiText Text57;
        public Stimulsoft.Report.Components.StiDataBand DataBand4;
        public Stimulsoft.Report.Components.StiText Text58;
        public Stimulsoft.Report.Components.StiText Text59;
        public Stimulsoft.Report.Components.StiText Text63;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive10;
        public Stimulsoft.Report.Components.StiFooterBand FooterBand4;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive9;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand3;
        public Stimulsoft.Report.Components.StiText Text40;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive10;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand5;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Components.StiDataBand DataBand2;
        public Stimulsoft.Report.Components.StiText Text33;
        public Stimulsoft.Report.Components.StiText Text34;
        public Stimulsoft.Report.Components.StiText Text35;
        public Stimulsoft.Report.Components.StiText Text36;
        public Stimulsoft.Report.Components.StiText Text29;
        public Stimulsoft.Report.Components.StiText Text37;
        public Stimulsoft.Report.Components.StiText Text38;
        public Stimulsoft.Report.Components.StiText Text41;
        public Stimulsoft.Report.Components.StiText Text42;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive8;
        public Stimulsoft.Report.Components.StiFooterBand FooterBand2;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive7;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand6;
        public Stimulsoft.Report.Components.StiText Text16;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive11;
        public Stimulsoft.Report.Components.StiStartPointPrimitive StartPointPrimitive14;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand7;
        public Stimulsoft.Report.Components.StiText Text28;
        public Stimulsoft.Report.Components.StiText Text31;
        public Stimulsoft.Report.Components.StiText Text32;
        public Stimulsoft.Report.Components.StiDataBand DataBand3;
        public Stimulsoft.Report.Components.StiText Text47;
        public Stimulsoft.Report.Components.StiText Text48;
        public Stimulsoft.Report.Components.StiText Text49;
        public Stimulsoft.Report.Components.StiText Text51;
        public Stimulsoft.Report.Components.StiText Text52;
        public Stimulsoft.Report.Components.StiText Text55;
        public Stimulsoft.Report.Components.StiText Text62;
        public Stimulsoft.Report.Components.StiHorizontalLinePrimitive HorizontalLinePrimitive9;
        public Stimulsoft.Report.Components.StiFooterBand FooterBand3;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive8;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive11;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive23;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive2;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive1;
        public Stimulsoft.Report.Components.StiVerticalLinePrimitive VerticalLinePrimitive1;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive3;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive4;
        public Stimulsoft.Report.Components.StiEndPointPrimitive EndPointPrimitive10;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive6;
        public Stimulsoft.Report.Components.StiRectanglePrimitive RectanglePrimitive5;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Packaging_Summary_PrinterSettings;
        public Stimulsoft.Report.StiChartStyle StyleStyle1;
        public t_CustomerDataSource t_Customer;
        public t_InvoiceDataSource t_Invoice;
        public v_Summary_StatusDataSource v_Summary_Status;
        public v_Summary_Status_NoInvoiceDataSource v_Summary_Status_NoInvoice;
        public v_Summary_PackageDataSource v_Summary_Package;
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text5
            e.Value = "Report generated by Verismic";
        }
        
        public void Text17__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "#%#{PageNofM}";
            e.StoreToPrinted = true;
        }
        
        public string Text17_GetValue_End(Stimulsoft.Report.Components.StiComponent sender)
        {
            // CheckerInfo: Text Text17
            return ToString(sender, PageNofM, true);
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text10
            e.Value = "v1.09";
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text3
            e.Value = ToString(sender, ReportName, true);
        }
        
        public void Text50__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text50
            e.Value = this.Text50.TextFormat.Format(CheckExcelValue(sender, Format("{0:yyyy-MM-dd}", Today)));
        }
        
        public void Text27__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text27
            e.Value = " Customer: " + ToString(sender, IIF(AllCustomers == true, "All Customers", v_Summary_Status.CustomerName), true);
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text9
            e.Value = " Invoice: " + ToString(sender, IIF(AllInvoices == true, "All Invoices", v_Summary_Status.InvoceName), true);
        }
        
        public void Text9_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent Text9
            if (ShowInvoices == true) {Text9.Enabled = true;} else {Text9.Enabled = false;};
        }
        
        public void Item29__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            // CheckerInfo: Title Chart1.Series
            e.Value = "Series 1";
        }
        
        public void Item30__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            // CheckerInfo: Title Chart1.Series
            e.Value = "Series 2";
        }
        
        public void Item31__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            // CheckerInfo: Title Chart1.Series
            e.Value = "Series 3";
        }
        
        public void Item32__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            // CheckerInfo: Title Chart1.Series
            e.Value = "Series 4";
        }
        
        public void Item33__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            // CheckerInfo: Title Chart1.Series
            e.Value = "Series 5";
        }
        
        public void Item34__GetTitle(object sender, Stimulsoft.Report.Events.StiGetTitleEventArgs e)
        {
            // CheckerInfo: Title Chart1.Series
            e.Value = "Series 6";
        }
        
        public void Text30__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text30
            e.Value = "  Summary";
        }
        
        public void Text60__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text60
            e.Value = "Awaiting Software & Documentation";
        }
        
        public void Text61__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text61
            e.Value = ToString(sender, v_Summary_Status_NoInvoice.PackageNumber_00, true);
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text4
            e.Value = "On Hold";
        }
        
        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text8
            e.Value = ToString(sender, v_Summary_Status_NoInvoice.PackageNumber_03, true);
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text11
            e.Value = "Being Packaged";
        }
        
        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text13
            e.Value = ToString(sender, v_Summary_Status_NoInvoice.PackageNumber_02, true);
        }
        
        public void Text18__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text18
            e.Value = "Awaiting Acceptance";
        }
        
        public void Text19__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text19
            e.Value = ToString(sender, v_Summary_Status_NoInvoice.PackageNumber_04, true);
        }
        
        public void Text20__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text20
            e.Value = "Accepted";
        }
        
        public void Text21__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text21
            e.Value = ToString(sender, v_Summary_Status_NoInvoice.PackageNumber_05, true);
        }
        
        public void Text22__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text22
            e.Value = "Accepted by non rejection";
        }
        
        public void Text23__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text23
            e.Value = ToString(sender, v_Summary_Status_NoInvoice.PackageNumber_06, true);
        }
        
        public void Text24__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text24
            e.Value = "Released:";
        }
        
        public void Text25__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text25
            e.Value = "Total";
        }
        
        public void Text26__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text26
            e.Value = ToString(sender, v_Summary_Status_NoInvoice.Amount, true);
        }
        
        public void HeaderBand2_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent HeaderBand2
            if ((AllCustomers) == true) {HeaderBand2.Enabled = false;} else {HeaderBand2.Enabled = true;}
;
        }
        
        public void Text39__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text39
            e.Value = "  Invoices Total over Amount";
        }
        
        public void HeaderBand1_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent HeaderBand1
            if (AllInvoices == true && ShowInvoices == true) {HeaderBand1.Enabled = true;} else {HeaderBand1.Enabled = false;};
        }
        
        public void Text43__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text43
            e.Value = "Customer Name";
        }
        
        public void Text44__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text44
            e.Value = "Invoice Name";
        }
        
        public void Text45__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text45
            e.Value = "Used / Amount";
        }
        
        public void Text46__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text46
            e.Value = "Last Updated";
        }
        
        public void HeaderBand4_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent HeaderBand4
            if (AllInvoices == true && ShowInvoices == true) {HeaderBand4.Enabled = true;} else {HeaderBand4.Enabled = false;};
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text1
            e.Value = ToString(sender, v_Summary_Status.CustomerName, true);
        }
        
        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text15
            e.Value = ToString(sender, Format("{0:yyyy-MM-dd}", v_Summary_Status.I_LastUpdated), true);
        }
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text2
            e.Value = ToString(sender, v_Summary_Status.InvoceName, true);
        }
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text7
            e.Value = ToString(sender, v_Summary_Status.PackageNumber_01 + v_Summary_Status.PackageNumber_02 + v_Summary_Status.PackageNumber_03 + v_Summary_Status.PackageNumber_04 + v_Summary_Status.PackageNumber_05 + v_Summary_Status.PackageNumber_06, true) + " / " + ToString(sender, v_Summary_Status.Amount, true);
        }
        
        public void DataBand1_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent DataBand1
            if (AllInvoices == true && ShowInvoices == true) {DataBand1.Enabled = true;} else {DataBand1.Enabled = false;}
;
        }
        
        public void FooterBand1_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent FooterBand1
            if (AllInvoices == true && ShowInvoices == true) {FooterBand1.Enabled = true;} else {FooterBand1.Enabled = false;};
        }
        
        public void Text53__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text53
            e.Value = "  Invoices Total over Amount";
        }
        
        public void HeaderBand8_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent HeaderBand8
            if (AllInvoices == true && ShowInvoices == false) {HeaderBand8.Enabled = true;} else {HeaderBand8.Enabled = false;};
        }
        
        public void Text54__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text54
            e.Value = "Customer Name";
        }
        
        public void Text56__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text56
            e.Value = "Used / Amount";
        }
        
        public void Text57__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text57
            e.Value = "Last Updated";
        }
        
        public void HeaderBand9_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent HeaderBand9
            if (AllInvoices == true && ShowInvoices == false) {HeaderBand9.Enabled = true;} else {HeaderBand9.Enabled = false;};
        }
        
        public void Text58__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text58
            e.Value = ToString(sender, v_Summary_Status_NoInvoice.CustomerName, true);
        }
        
        public void Text59__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text59
            e.Value = ToString(sender, Format("{0:yyyy-MM-dd}", v_Summary_Status_NoInvoice.C_LastUpdated), true);
        }
        
        public void Text63__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text63
            e.Value = ToString(sender, v_Summary_Status_NoInvoice.PackageNumber_01 + v_Summary_Status_NoInvoice.PackageNumber_02 + v_Summary_Status_NoInvoice.PackageNumber_03 + v_Summary_Status_NoInvoice.PackageNumber_04 + v_Summary_Status_NoInvoice.PackageNumber_05 + v_Summary_Status_NoInvoice.PackageNumber_06, true) + " / " + ToString(sender, v_Summary_Status_NoInvoice.Amount, true);
        }
        
        public void DataBand4_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent DataBand4
            if (AllInvoices == true && ShowInvoices == false) {DataBand4.Enabled = true;} else {DataBand4.Enabled = false;}
;
        }
        
        public void FooterBand4_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent FooterBand4
            if (AllInvoices == true && ShowInvoices == false) {FooterBand4.Enabled = true;} else {FooterBand4.Enabled = false;};
        }
        
        public void Text40__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text40
            e.Value = "  Packages";
        }
        
        public void HeaderBand3_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent HeaderBand3
            if (AllCustomers == false & ShowInvoices == true) {HeaderBand3.Enabled = true;} else {HeaderBand3.Enabled = false;};
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text6
            e.Value = "Package Details";
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text12
            e.Value = "Date";
        }
        
        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text14
            e.Value = "Status";
        }
        
        public void HeaderBand5_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent HeaderBand5
            if (AllCustomers == false & ShowInvoices == true) {HeaderBand5.Enabled = true;} else {HeaderBand5.Enabled = false;}
;
        }
        
        public void Text33__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text33
            e.Value = ToString(sender, v_Summary_Package.PackageName, true);
        }
        
        public void Text34__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text34
            e.Value = ToString(sender, v_Summary_Package.StatusName, true);
        }
        
        public void Text35__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text35
            e.Value = "Revision: " + ToString(sender, v_Summary_Package.Revision, true);
        }
        
        public void Text36__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text36
            e.Value = "Receive: " + ToString(sender, Format("{0:yyyy-MM-dd}", v_Summary_Package.RecivedDate), true);
        }
        
        public void Text29__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text29
            e.Value = "Package Cost: " + ToString(sender, v_Summary_Package.Cost, true);
        }
        
        public void Text37__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text37
            e.Value = "Request ID: " + ToString(sender, v_Summary_Package.Request, true);
        }
        
        public void Text37_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent Text37
            if (v_Summary_Package.Request == "") {Text37.Enabled = false;} else {Text37.Enabled = true;};
        }
        
        public void Text38__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text38
            e.Value = "Release: " + ToString(sender, Format("{0:yyyy-MM-dd}", v_Summary_Package.EndDate), true);
        }
        
        public void Text41__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text41
            e.Value = "Invoice: " + ToString(sender, v_Summary_Package.InvoceName, true);
        }
        
        public void Text42__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text42
            e.Value = "Engineer: " + ToString(sender, v_Summary_Package.EngineerName, true);
        }
        
        public void Text42_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent Text42
            if (ShowEngineer == true) {Text42.Enabled = true;} else {Text42.Enabled = false;};
        }
        
        public void DataBand2_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent DataBand2
            if (AllCustomers == false & ShowInvoices == true) {DataBand2.Enabled = true;} else {DataBand2.Enabled = false;}
;
        }
        
        public void FooterBand2_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent FooterBand2
            if (AllCustomers == false & ShowInvoices == true) {FooterBand2.Enabled = true;} else {FooterBand2.Enabled = false;};
        }
        
        public void Text16__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text16
            e.Value = "  Packages";
        }
        
        public void HeaderBand6_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent HeaderBand6
            if (AllCustomers == false & ShowInvoices == false) {HeaderBand6.Enabled = true;} else {HeaderBand6.Enabled = false;}
;
        }
        
        public void Text28__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text28
            e.Value = "Package Details";
        }
        
        public void Text31__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text31
            e.Value = "Date";
        }
        
        public void Text32__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text32
            e.Value = "Status";
        }
        
        public void HeaderBand7_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent HeaderBand7
            if (AllCustomers == false & ShowInvoices == false) {HeaderBand7.Enabled = true;} else {HeaderBand7.Enabled = false;}
;
        }
        
        public void Text47__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text47
            e.Value = ToString(sender, v_Summary_Package.PackageName, true);
        }
        
        public void Text48__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text48
            e.Value = ToString(sender, v_Summary_Package.StatusName, true);
        }
        
        public void Text49__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text49
            e.Value = "Revision: " + ToString(sender, v_Summary_Package.Revision, true);
        }
        
        public void Text51__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text51
            e.Value = "Receive: " + ToString(sender, Format("{0:yyyy-MM-dd}", v_Summary_Package.RecivedDate), true);
        }
        
        public void Text52__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text52
            e.Value = "Package Cost: " + ToString(sender, v_Summary_Package.Cost, true);
        }
        
        public void Text55__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text55
            e.Value = "Request ID: " + ToString(sender, v_Summary_Package.Request, true);
        }
        
        public void Text55_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent Text55
            if (v_Summary_Package.Request == "") {Text55.Enabled = false;} else {Text55.Enabled = true;};
        }
        
        public void Text62__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Text62
            e.Value = "Release: " + ToString(sender, Format("{0:yyyy-MM-dd}", v_Summary_Package.EndDate), true);
        }
        
        public void DataBand3_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent DataBand3
            if (AllCustomers == false & ShowInvoices == false) {DataBand3.Enabled = true;} else {DataBand3.Enabled = false;}
;
        }
        
        public void FooterBand3_BeforePrint(object sender, System.EventArgs e)
        {
            // CheckerInfo: BeforePrintEvent FooterBand3
            if (AllCustomers == false & ShowInvoices == false) {FooterBand3.Enabled = true;} else {FooterBand3.Enabled = false;};
        }
        
        public void Packaging_SummaryWordsToEnd__EndRender(object sender, System.EventArgs e)
        {
            this.Text17.SetText(new Stimulsoft.Report.Components.StiGetValue(this.Text17_GetValue_End));
        }
        
        private void InitializeComponent()
        {
            this.v_Summary_Package = new v_Summary_PackageDataSource();
            this.v_Summary_Status_NoInvoice = new v_Summary_Status_NoInvoiceDataSource();
            this.v_Summary_Status = new v_Summary_StatusDataSource();
            this.t_Invoice = new t_InvoiceDataSource();
            this.t_Customer = new t_CustomerDataSource();
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "CustomerList", "Select Customer:", "", typeof(int?), "", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true, new Stimulsoft.Report.Dictionary.StiDialogInfo(Stimulsoft.Report.Dictionary.StiDateTimeType.Date, "", false, "t_Customer.ID", "t_Customer.CustomerName")));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "AllCustomers", "All Customers:", "", typeof(bool), "true", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "ShowInvoices", "Show Invoices:", "", typeof(bool), "false", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "InvoiceList", "Select Invoice:", "", typeof(int), "", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true, new Stimulsoft.Report.Dictionary.StiDialogInfo(Stimulsoft.Report.Dictionary.StiDateTimeType.Date, "", false, "t_Invoice.ID", "t_Invoice.InvoceName", true, new Stimulsoft.Report.Dictionary.StiVariable("", "CustomerList", "Select Customer:", "", typeof(int?), "", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true, new Stimulsoft.Report.Dictionary.StiDialogInfo(Stimulsoft.Report.Dictionary.StiDateTimeType.Date, "", false, "t_Customer.ID", "t_Customer.CustomerName")), "t_Invoice.CustomerID")));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "AllInvoices", "All Invoices", "", typeof(bool), "true", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true));
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "ShowEngineer", "Show Engineer:", "", typeof(bool), "false", false, Stimulsoft.Report.Dictionary.StiVariableInitBy.Value, true));
            this.NeedsCompiling = false;
            // 
            // Variables init
            // 
            // CheckerInfo: Value CustomerList
            this.CustomerList = 0;
            // CheckerInfo: Value AllCustomers
            this.AllCustomers = true;
            // CheckerInfo: Value ShowInvoices
            this.ShowInvoices = false;
            // CheckerInfo: Value InvoiceList
            this.InvoiceList = 0;
            // CheckerInfo: Value AllInvoices
            this.AllInvoices = true;
            // CheckerInfo: Value ShowEngineer
            this.ShowEngineer = false;
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ReferencedAssemblies = new string[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Packaging Summary";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2017, 9, 8, 15, 19, 22, 0);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2012, 10, 3, 11, 20, 36, 0);
            this.ReportDescription = "This report shows Packaging Summary";
            this.ReportFile = "D:\\Friday Report\\Packaging Summary - Copy.mrt";
            this.ReportGuid = "fcb18f10169840829354cd39095c527d";
            this.ReportName = "Packaging Summary";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.ReportVersion = "2015.1.0";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "a2ea09e7130f4cd8882b8b55c31a5888";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 11.69;
            this.Page1.PageWidth = 8.27;
            this.Page1.PaperSize = System.Drawing.Printing.PaperKind.A4;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // PageFooterBand1
            // 
            this.PageFooterBand1 = new Stimulsoft.Report.Components.StiPageFooterBand();
            this.PageFooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 22.28, 7.87, 0.3);
            this.PageFooterBand1.Guid = "8b265aed236143c6becea2d60727989d";
            this.PageFooterBand1.Name = "PageFooterBand1";
            this.PageFooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.SteelBlue, 3, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue), false);
            this.PageFooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 7.8, 0.2);
            this.Text5.Guid = "59cd46331f8549c3876f5f3fdc71db19";
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text5.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text17
            // 
            this.Text17 = new Stimulsoft.Report.Components.StiText();
            this.Text17.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7, 0, 0.8, 0.2);
            this.Text17.Guid = "6144dae2488f45f3a2dc56f8b02c9348";
            this.Text17.Name = "Text17";
            this.Text17.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text17__GetValue);
            this.Text17.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text17.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text17.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text17.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.Text17.Indicator = null;
            this.Text17.Interaction = null;
            this.Text17.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text17.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text17.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.01, 0.4, 0.2);
            this.Text10.Guid = "6b9152e4f2674894a41082a95d63118f";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text10.Font = new System.Drawing.Font("Segoe UI Light", 6F);
            this.Text10.Indicator = null;
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 127, 127, 127));
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // HorizontalLinePrimitive4
            // 
            this.HorizontalLinePrimitive4 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.01, 7.8, 0.01);
            this.HorizontalLinePrimitive4.Color = System.Drawing.Color.SteelBlue;
            this.HorizontalLinePrimitive4.Guid = "ae4dd107c7d84b979a081e061aaa4d8f";
            this.HorizontalLinePrimitive4.Name = "HorizontalLinePrimitive4";
            this.HorizontalLinePrimitive4.Size = 2F;
            this.HorizontalLinePrimitive4.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive4.Interaction = null;
            this.HorizontalLinePrimitive4.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.PageFooterBand1.Interaction = null;
            // 
            // ReportTitle
            // 
            this.ReportTitle = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitle.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.2, 7.87, 1.2);
            this.ReportTitle.Guid = "7f98020ba4c24069b22b4dd06772c23d";
            this.ReportTitle.Name = "ReportTitle";
            this.ReportTitle.Border = new Stimulsoft.Base.Drawing.StiAdvancedBorder(System.Drawing.Color.SteelBlue, 1, Stimulsoft.Base.Drawing.StiPenStyle.None, System.Drawing.Color.SteelBlue, 1, Stimulsoft.Base.Drawing.StiPenStyle.None, System.Drawing.Color.SteelBlue, 1, Stimulsoft.Base.Drawing.StiPenStyle.None, System.Drawing.Color.SteelBlue, 1, Stimulsoft.Base.Drawing.StiPenStyle.None, false, 1, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White), false);
            this.ReportTitle.Brush = new Stimulsoft.Base.Drawing.StiEmptyBrush();
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.4, 0, 5, 0.5);
            this.Text3.Guid = "0dc8e6561ee6462fb3a99bfcea58c2d2";
            this.Text3.Name = "Text3";
            this.Text3.ShrinkFontToFit = true;
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text3.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.Text3.Indicator = null;
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue);
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Panel2
            // 
            this.Panel2 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 0.3, 1.2);
            this.Panel2.Guid = "cc3aec5c4e724f95ac61975ae0eaad6c";
            this.Panel2.Name = "Panel2";
            this.Panel2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Panel2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue);
            // 
            // StartPointPrimitive2
            // 
            this.StartPointPrimitive2 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 0, 0);
            this.StartPointPrimitive2.Name = "StartPointPrimitive2";
            this.StartPointPrimitive2.ReferenceToGuid = "808708130c624f92942a49bea72eede6";
            this.StartPointPrimitive2.Guid = null;
            this.StartPointPrimitive2.Interaction = null;
            this.Panel2.Interaction = null;
            // 
            // Image2
            // 
            this.Image2 = new Stimulsoft.Report.Components.StiImage();
            this.Image2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.5, 0, 2.1, 0.9);
            this.Image2.Guid = "712b10e5aafc4276a8e654ef174fda98";
            this.Image2.Image = StiImageConverter.StringToImage("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");
            this.Image2.Name = "Image2";
            this.Image2.Stretch = true;
            this.Image2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Image2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Image2.Interaction = null;
            // 
            // Text50
            // 
            this.Text50 = new Stimulsoft.Report.Components.StiText();
            this.Text50.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.5, 0.9, 2.2, 0.2);
            this.Text50.Guid = "625b66dcb24345b49130178918374221";
            this.Text50.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text50.Name = "Text50";
            this.Text50.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text50__GetValue);
            this.Text50.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text50.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text50.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text50.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text50.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text50.Indicator = null;
            this.Text50.Interaction = null;
            this.Text50.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text50.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text50.TextFormat = new Stimulsoft.Report.Components.TextFormats.StiDateFormatService("D", " ");
            this.Text50.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text27
            // 
            this.Text27 = new Stimulsoft.Report.Components.StiText();
            this.Text27.CanGrow = true;
            this.Text27.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.4, 0.5, 5, 0.2);
            this.Text27.Guid = "f122e538ea11455ea6cdf45726b26941";
            this.Text27.Name = "Text27";
            this.Text27.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text27__GetValue);
            this.Text27.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text27.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text27.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text27.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text27.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text27.Indicator = null;
            this.Text27.Interaction = null;
            this.Text27.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text27.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text27.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.CanGrow = true;
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.4, 0.7, 5, 0.2);
            this.Text9.Guid = "b15b3f14579245049dce57b70600c2a8";
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text9.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Text9.BeforePrint += new System.EventHandler(this.Text9_BeforePrint);
            // 
            // StartPointPrimitive4
            // 
            this.StartPointPrimitive4 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(1.2, 0, 0, 0);
            this.StartPointPrimitive4.Guid = "3cee8275eb9b4ff895371a78571a1253";
            this.StartPointPrimitive4.Name = "StartPointPrimitive4";
            this.StartPointPrimitive4.ReferenceToGuid = "ea461414c70e4a0198faaba1a38657ce";
            this.StartPointPrimitive4.Interaction = null;
            // 
            // StartPointPrimitive1
            // 
            this.StartPointPrimitive1 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.4, -0.2, 0, 0);
            this.StartPointPrimitive1.Guid = "6a3b9059158341f2b0c451dceb8f05fc";
            this.StartPointPrimitive1.Name = "StartPointPrimitive1";
            this.StartPointPrimitive1.ReferenceToGuid = "c892db316f434ab99fe9fc8f21257778";
            this.StartPointPrimitive1.Interaction = null;
            // 
            // StartPointPrimitive5
            // 
            this.StartPointPrimitive5 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, -0.2, 0, 0);
            this.StartPointPrimitive5.Name = "StartPointPrimitive5";
            this.StartPointPrimitive5.ReferenceToGuid = "49622a9b9dda45cd994ac77fd93afd2f";
            this.StartPointPrimitive5.Guid = null;
            this.StartPointPrimitive5.Interaction = null;
            // 
            // EndPointPrimitive1
            // 
            this.EndPointPrimitive1 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.8, 1, 0, 0);
            this.EndPointPrimitive1.Name = "EndPointPrimitive1";
            this.EndPointPrimitive1.ReferenceToGuid = "49622a9b9dda45cd994ac77fd93afd2f";
            this.EndPointPrimitive1.Guid = null;
            this.EndPointPrimitive1.Interaction = null;
            // 
            // EndPointPrimitive2
            // 
            this.EndPointPrimitive2 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.8, 1.2, 0, 0);
            this.EndPointPrimitive2.Name = "EndPointPrimitive2";
            this.EndPointPrimitive2.ReferenceToGuid = "808708130c624f92942a49bea72eede6";
            this.EndPointPrimitive2.Guid = null;
            this.EndPointPrimitive2.Interaction = null;
            // 
            // StartPointPrimitive3
            // 
            this.StartPointPrimitive3 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.2, 0, 0);
            this.StartPointPrimitive3.Guid = "35fbb1ec61b54b97956476b139236c50";
            this.StartPointPrimitive3.Name = "StartPointPrimitive3";
            this.StartPointPrimitive3.ReferenceToGuid = "ea461414c70e4a0198faaba1a38657ce";
            this.StartPointPrimitive3.Interaction = null;
            this.ReportTitle.Interaction = null;
            // 
            // HeaderBand2
            // 
            this.HeaderBand2 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.8, 7.87, 4.3);
            this.HeaderBand2.Name = "HeaderBand2";
            this.HeaderBand2.PrintOnAllPages = false;
            this.HeaderBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Chart1
            // 
            this.Chart1 = new Stimulsoft.Report.Chart.StiChart();
            this.Chart1.AllowApplyStyle = false;
            this.Chart1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.4, 4.9, 3.9);
            this.Chart1.CustomStyleName = "Style1";
            this.Chart1.Name = "Chart1";
            this.Chart1.Sort = new string[0];
            this.Chart1_Area = new Stimulsoft.Report.Chart.StiPieArea();
            this.Chart1_Area.AllowApplyStyle = false;
            this.Chart1_Area.BorderColor = System.Drawing.Color.Transparent;
            this.Chart1_Area.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Chart1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255));
            this.Chart1.Guid = null;
            this.Chart1.Interaction = null;
            this.Chart1_Legend = new Stimulsoft.Report.Chart.StiLegend();
            this.Chart1_Legend.BorderColor = System.Drawing.Color.DimGray;
            this.Chart1_Legend.LabelsColor = System.Drawing.Color.DimGray;
            this.Chart1_Legend.MarkerSize = new System.Drawing.Size(10, 10);
            this.Chart1_Legend.TitleColor = System.Drawing.Color.DimGray;
            this.Chart1_Legend.Visible = false;
            this.Chart1_Legend.Brush = new Stimulsoft.Base.Drawing.StiGradientBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255), System.Drawing.Color.FromArgb(255, 255, 255, 255), 90);
            this.Chart1_Legend.Font = new System.Drawing.Font("Arial", 8F);
            this.Chart1_Legend.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Chart1.MasterComponent = null;
            // 
            // Item29
            // 
            this.Item29 = new Stimulsoft.Report.Chart.StiPieSeries();
            this.Item29.ArgumentDataColumn = "v_Summary_Status_NoInvoice.C_ID";
            this.Item29.BorderColor = System.Drawing.Color.FromArgb(255, 155, 115, 0);
            this.Item29.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item29__GetTitle);
            this.Item29.ValueDataColumn = "v_Summary_Status_NoInvoice.PackageNumber_00";
            this.Item29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Gold);
            this.Item29.DrillDownPageGuid = null;
            this.Item29_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item29_SeriesLabels.BorderColor = System.Drawing.Color.DimGray;
            this.Item29_SeriesLabels.LabelColor = System.Drawing.Color.DimGray;
            this.Item29_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item29_SeriesLabels.ValueTypeSeparator = "-";
            this.Item29_SeriesLabels.Width = 0;
            this.Item29_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Item29_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Item29_TopN = new Stimulsoft.Report.Chart.StiSeriesTopN();
            // 
            // Item30
            // 
            this.Item30 = new Stimulsoft.Report.Chart.StiPieSeries();
            this.Item30.ArgumentDataColumn = "v_Summary_Status_NoInvoice.C_ID";
            this.Item30.BorderColor = System.Drawing.Color.FromArgb(255, 155, 65, 0);
            this.Item30.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item30__GetTitle);
            this.Item30.ValueDataColumn = "v_Summary_Status_NoInvoice.PackageNumber_02";
            this.Item30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Orange);
            this.Item30.DrillDownPageGuid = null;
            this.Item30_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item30_SeriesLabels.BorderColor = System.Drawing.Color.DimGray;
            this.Item30_SeriesLabels.LabelColor = System.Drawing.Color.DimGray;
            this.Item30_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item30_SeriesLabels.ValueTypeSeparator = "-";
            this.Item30_SeriesLabels.Width = 0;
            this.Item30_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Item30_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Item30_TopN = new Stimulsoft.Report.Chart.StiSeriesTopN();
            // 
            // Item31
            // 
            this.Item31 = new Stimulsoft.Report.Chart.StiPieSeries();
            this.Item31.ArgumentDataColumn = "v_Summary_Status_NoInvoice.C_ID";
            this.Item31.BorderColor = System.Drawing.Color.FromArgb(255, 5, 5, 5);
            this.Item31.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item31__GetTitle);
            this.Item31.ValueDataColumn = "v_Summary_Status_NoInvoice.PackageNumber_03";
            this.Item31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Item31.DrillDownPageGuid = null;
            this.Item31_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item31_SeriesLabels.BorderColor = System.Drawing.Color.DimGray;
            this.Item31_SeriesLabels.LabelColor = System.Drawing.Color.DimGray;
            this.Item31_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item31_SeriesLabels.ValueTypeSeparator = "-";
            this.Item31_SeriesLabels.Width = 0;
            this.Item31_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Item31_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Item31_TopN = new Stimulsoft.Report.Chart.StiSeriesTopN();
            // 
            // Item32
            // 
            this.Item32 = new Stimulsoft.Report.Chart.StiPieSeries();
            this.Item32.ArgumentDataColumn = "v_Summary_Status_NoInvoice.C_ID";
            this.Item32.BorderColor = System.Drawing.Color.FromArgb(255, 0, 91, 155);
            this.Item32.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item32__GetTitle);
            this.Item32.ValueDataColumn = "v_Summary_Status_NoInvoice.PackageNumber_04";
            this.Item32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DeepSkyBlue);
            this.Item32.DrillDownPageGuid = null;
            this.Item32_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item32_SeriesLabels.BorderColor = System.Drawing.Color.DimGray;
            this.Item32_SeriesLabels.LabelColor = System.Drawing.Color.DimGray;
            this.Item32_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item32_SeriesLabels.ValueTypeSeparator = "-";
            this.Item32_SeriesLabels.Width = 0;
            this.Item32_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Item32_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Item32_TopN = new Stimulsoft.Report.Chart.StiSeriesTopN();
            // 
            // Item33
            // 
            this.Item33 = new Stimulsoft.Report.Chart.StiPieSeries();
            this.Item33.ArgumentDataColumn = "v_Summary_Status_NoInvoice.C_ID";
            this.Item33.BorderColor = System.Drawing.Color.FromArgb(255, 54, 105, 0);
            this.Item33.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item33__GetTitle);
            this.Item33.ValueDataColumn = "v_Summary_Status_NoInvoice.PackageNumber_05";
            this.Item33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.YellowGreen);
            this.Item33.DrillDownPageGuid = null;
            this.Item33_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item33_SeriesLabels.BorderColor = System.Drawing.Color.DimGray;
            this.Item33_SeriesLabels.LabelColor = System.Drawing.Color.DimGray;
            this.Item33_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item33_SeriesLabels.ValueTypeSeparator = "-";
            this.Item33_SeriesLabels.Width = 0;
            this.Item33_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Item33_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Item33_TopN = new Stimulsoft.Report.Chart.StiSeriesTopN();
            // 
            // Item34
            // 
            this.Item34 = new Stimulsoft.Report.Chart.StiPieSeries();
            this.Item34.ArgumentDataColumn = "v_Summary_Status_NoInvoice.C_ID";
            this.Item34.BorderColor = System.Drawing.Color.FromArgb(255, 0, 30, 80);
            this.Item34.GetTitle += new Stimulsoft.Report.Events.StiGetTitleEventHandler(this.Item34__GetTitle);
            this.Item34.ValueDataColumn = "v_Summary_Status_NoInvoice.PackageNumber_06";
            this.Item34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue);
            this.Item34.DrillDownPageGuid = null;
            this.Item34_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Item34_SeriesLabels.BorderColor = System.Drawing.Color.DimGray;
            this.Item34_SeriesLabels.LabelColor = System.Drawing.Color.DimGray;
            this.Item34_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Item34_SeriesLabels.ValueTypeSeparator = "-";
            this.Item34_SeriesLabels.Width = 0;
            this.Item34_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Item34_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Item34_TopN = new Stimulsoft.Report.Chart.StiSeriesTopN();
            this.Chart1_SeriesLabels = new Stimulsoft.Report.Chart.StiCenterAxisLabels();
            this.Chart1_SeriesLabels.BorderColor = System.Drawing.Color.DimGray;
            this.Chart1_SeriesLabels.LabelColor = System.Drawing.Color.DimGray;
            this.Chart1_SeriesLabels.MarkerSize = new System.Drawing.Size(8, 6);
            this.Chart1_SeriesLabels.ValueTypeSeparator = "-";
            this.Chart1_SeriesLabels.Width = 0;
            this.Chart1_SeriesLabels.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Chart1_SeriesLabels.Font = new System.Drawing.Font("Arial", 7F);
            this.Chart1.Style = new Stimulsoft.Report.Chart.StiCustomStyle();
            this.Chart1_Table = new Stimulsoft.Report.Chart.StiChartTable();
            this.Chart1_Table.GridLineColor = System.Drawing.Color.DimGray;
            this.Chart1_Table.TextColor = System.Drawing.Color.DimGray;
            this.Chart1_Table.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Chart1_Table.Header = new Stimulsoft.Report.Chart.StiChartTableHeader(new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White), new System.Drawing.Font("Arial", 8F), System.Drawing.Color.DarkGray, false);
            this.Chart1.Title = new Stimulsoft.Report.Chart.StiChartTitle(new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold), "", new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 105, 105, 105)), true, System.Drawing.StringAlignment.Center, Stimulsoft.Report.Chart.StiChartTitleDock.Top, 2, false, true);
            // 
            // Text30
            // 
            this.Text30 = new Stimulsoft.Report.Components.StiText();
            this.Text30.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 7.8, 0.3);
            this.Text30.Guid = "e8b98598fab14743b0ded86235540bbc";
            this.Text30.Name = "Text30";
            this.Text30.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text30__GetValue);
            this.Text30.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text30.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text30.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue);
            this.Text30.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.Text30.Indicator = null;
            this.Text30.Interaction = null;
            this.Text30.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text30.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text30.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Panel3
            // 
            this.Panel3 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.4, 2.3, 0.2, 0.2);
            this.Panel3.Guid = "7490ef0fac374d2c889866545a45b725";
            this.Panel3.Name = "Panel3";
            this.Panel3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Panel3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DeepSkyBlue);
            this.Panel3.Interaction = null;
            // 
            // Panel13
            // 
            this.Panel13 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.1, 1.7, 0.2, 0.2);
            this.Panel13.Guid = "de60e20d49b34dd6af7f3662abd17d89";
            this.Panel13.Name = "Panel13";
            this.Panel13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Panel13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Panel13.Interaction = null;
            // 
            // Panel1
            // 
            this.Panel1 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.1, 1.4, 0.2, 0.2);
            this.Panel1.Guid = "fca9da0b14884b448409531fe9f45085";
            this.Panel1.Name = "Panel1";
            this.Panel1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Panel1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Orange);
            this.Panel1.Interaction = null;
            // 
            // Panel4
            // 
            this.Panel4 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.1, 0.9, 0.2, 0.2);
            this.Panel4.Guid = "863db922170a45cfa7c4ba68a151054c";
            this.Panel4.Name = "Panel4";
            this.Panel4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Panel4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Gold);
            this.Panel4.Interaction = null;
            // 
            // Panel5
            // 
            this.Panel5 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.4, 2.9, 0.2, 0.2);
            this.Panel5.Guid = "13dbab73cf914cc494f7264bc5f5abc7";
            this.Panel5.Name = "Panel5";
            this.Panel5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Panel5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue);
            this.Panel5.Interaction = null;
            // 
            // Panel6
            // 
            this.Panel6 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.4, 2.6, 0.2, 0.2);
            this.Panel6.Guid = "0b3f0e5dc8ae4952b2d35b73b8b4d1be";
            this.Panel6.Name = "Panel6";
            this.Panel6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Panel6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.YellowGreen);
            this.Panel6.Interaction = null;
            // 
            // Text60
            // 
            this.Text60 = new Stimulsoft.Report.Components.StiText();
            this.Text60.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.4, 0.9, 1.8, 0.4);
            this.Text60.Guid = "8467f14cd53940ccad99eff22eb7511d";
            this.Text60.Name = "Text60";
            this.Text60.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text60__GetValue);
            this.Text60.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text60.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text60.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text60.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text60.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text60.Indicator = null;
            this.Text60.Interaction = null;
            this.Text60.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text60.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text60.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text61
            // 
            this.Text61 = new Stimulsoft.Report.Components.StiText();
            this.Text61.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.2, 0.9, 0.4, 0.2);
            this.Text61.Guid = "07ee5275ec89482f9ed7541722485f00";
            this.Text61.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text61.Name = "Text61";
            this.Text61.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text61__GetValue);
            this.Text61.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text61.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text61.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text61.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text61.Indicator = null;
            this.Text61.Interaction = null;
            this.Text61.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text61.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text61.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.4, 1.7, 1.8, 0.2);
            this.Text4.Guid = "2ee1c14c3ffd4eceb45b64026edd9948";
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text4.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text4.Indicator = null;
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.2, 1.4, 0.4, 0.2);
            this.Text8.Guid = "b89b24fb764e45cc9a31df80ba68cbcd";
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text8.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text8.Indicator = null;
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.4, 1.4, 1.8, 0.2);
            this.Text11.Guid = "6eb5602073b345bcba252b817b4aba30";
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text11.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text11.Indicator = null;
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.2, 1.7, 0.4, 0.2);
            this.Text13.Guid = "9cd2742c0e824e2d92db05daf978c780";
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text13.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text13.Indicator = null;
            this.Text13.Interaction = null;
            this.Text13.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text18
            // 
            this.Text18 = new Stimulsoft.Report.Components.StiText();
            this.Text18.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.7, 2.3, 1.5, 0.2);
            this.Text18.Guid = "132c9d6845f8403a942a6fbcde75f754";
            this.Text18.Name = "Text18";
            this.Text18.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text18__GetValue);
            this.Text18.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text18.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text18.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text18.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text18.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text18.Indicator = null;
            this.Text18.Interaction = null;
            this.Text18.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text18.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text18.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text19
            // 
            this.Text19 = new Stimulsoft.Report.Components.StiText();
            this.Text19.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.2, 2.3, 0.4, 0.2);
            this.Text19.Guid = "fe7093dfd22a4940b233e705c25966e5";
            this.Text19.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text19.Name = "Text19";
            this.Text19.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text19__GetValue);
            this.Text19.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text19.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text19.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text19.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text19.Indicator = null;
            this.Text19.Interaction = null;
            this.Text19.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text19.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text19.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text20
            // 
            this.Text20 = new Stimulsoft.Report.Components.StiText();
            this.Text20.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.7, 2.6, 1.5, 0.2);
            this.Text20.Guid = "7de374c204a34d0d92724a49cbaf1852";
            this.Text20.Name = "Text20";
            this.Text20.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text20__GetValue);
            this.Text20.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text20.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text20.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text20.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text20.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text20.Indicator = null;
            this.Text20.Interaction = null;
            this.Text20.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text20.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text20.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text21
            // 
            this.Text21 = new Stimulsoft.Report.Components.StiText();
            this.Text21.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.2, 2.6, 0.4, 0.2);
            this.Text21.Guid = "24dda043368f4463aa0ccb87990f0e8d";
            this.Text21.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text21.Name = "Text21";
            this.Text21.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text21__GetValue);
            this.Text21.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text21.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text21.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text21.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text21.Indicator = null;
            this.Text21.Interaction = null;
            this.Text21.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text21.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text21.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text22
            // 
            this.Text22 = new Stimulsoft.Report.Components.StiText();
            this.Text22.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.7, 2.9, 1.5, 0.2);
            this.Text22.Guid = "8b9b7918cdda44fa8139d339cce92ecf";
            this.Text22.Name = "Text22";
            this.Text22.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text22__GetValue);
            this.Text22.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text22.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text22.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text22.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text22.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text22.Indicator = null;
            this.Text22.Interaction = null;
            this.Text22.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text22.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text22.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text23
            // 
            this.Text23 = new Stimulsoft.Report.Components.StiText();
            this.Text23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.2, 2.9, 0.4, 0.2);
            this.Text23.Guid = "d99e866f7e9b4899b7f9e5057763c4ea";
            this.Text23.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text23.Name = "Text23";
            this.Text23.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text23__GetValue);
            this.Text23.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text23.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text23.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text23.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text23.Indicator = null;
            this.Text23.Interaction = null;
            this.Text23.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text23.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text23.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text24
            // 
            this.Text24 = new Stimulsoft.Report.Components.StiText();
            this.Text24.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.4, 2, 2.2, 0.2);
            this.Text24.Guid = "8276ddeb90ad4bdc8c80b121b10fbad0";
            this.Text24.Name = "Text24";
            this.Text24.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text24__GetValue);
            this.Text24.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text24.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text24.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text24.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text24.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text24.Indicator = null;
            this.Text24.Interaction = null;
            this.Text24.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text24.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text24.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text25
            // 
            this.Text25 = new Stimulsoft.Report.Components.StiText();
            this.Text25.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.4, 3.3, 1.8, 0.2);
            this.Text25.Guid = "85c4e1f05d6c4eefa1635f6f734bd2d2";
            this.Text25.Name = "Text25";
            this.Text25.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text25__GetValue);
            this.Text25.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text25.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text25.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text25.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text25.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text25.Indicator = null;
            this.Text25.Interaction = null;
            this.Text25.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text25.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text25.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text26
            // 
            this.Text26 = new Stimulsoft.Report.Components.StiText();
            this.Text26.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.2, 3.3, 0.4, 0.2);
            this.Text26.Guid = "73c8b721eb82444d8e60478a2532d86a";
            this.Text26.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text26.Name = "Text26";
            this.Text26.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text26__GetValue);
            this.Text26.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text26.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text26.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text26.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text26.Indicator = null;
            this.Text26.Interaction = null;
            this.Text26.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text26.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text26.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // StartPointPrimitive6
            // 
            this.StartPointPrimitive6 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 0, 0);
            this.StartPointPrimitive6.Name = "StartPointPrimitive6";
            this.StartPointPrimitive6.ReferenceToGuid = "4853e3511e5d4dc5bc9d93d81bbac922";
            this.StartPointPrimitive6.Guid = null;
            this.StartPointPrimitive6.Interaction = null;
            // 
            // EndPointPrimitive3
            // 
            this.EndPointPrimitive3 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.8, 4.3, 0, 0);
            this.EndPointPrimitive3.Name = "EndPointPrimitive3";
            this.EndPointPrimitive3.ReferenceToGuid = "4853e3511e5d4dc5bc9d93d81bbac922";
            this.EndPointPrimitive3.Guid = null;
            this.EndPointPrimitive3.Interaction = null;
            // 
            // StartPointPrimitive7
            // 
            this.StartPointPrimitive7 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5, 0.8, 0, 0);
            this.StartPointPrimitive7.Name = "StartPointPrimitive7";
            this.StartPointPrimitive7.ReferenceToGuid = "e873eee296e44c33988c05dd45312983";
            this.StartPointPrimitive7.Guid = null;
            this.StartPointPrimitive7.Interaction = null;
            // 
            // EndPointPrimitive4
            // 
            this.EndPointPrimitive4 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.7, 3.6, 0, 0);
            this.EndPointPrimitive4.Name = "EndPointPrimitive4";
            this.EndPointPrimitive4.ReferenceToGuid = "e873eee296e44c33988c05dd45312983";
            this.EndPointPrimitive4.Guid = null;
            this.EndPointPrimitive4.Interaction = null;
            // 
            // HorizontalLinePrimitive2
            // 
            this.HorizontalLinePrimitive2 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.1, 3.2, 2.5, 0.01);
            this.HorizontalLinePrimitive2.Color = System.Drawing.Color.DimGray;
            this.HorizontalLinePrimitive2.Guid = "a2e950877ec1480ebdcbcc62e750422d";
            this.HorizontalLinePrimitive2.Name = "HorizontalLinePrimitive2";
            this.HorizontalLinePrimitive2.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive2.Interaction = null;
            this.HorizontalLinePrimitive2.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            // 
            // StartPointPrimitive8
            // 
            this.StartPointPrimitive8 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.2, 2.1, 0, 0);
            this.StartPointPrimitive8.Name = "StartPointPrimitive8";
            this.StartPointPrimitive8.ReferenceToGuid = "4e75cca6241d448aab1086d90dfbf66f";
            this.StartPointPrimitive8.Guid = null;
            this.StartPointPrimitive8.Interaction = null;
            // 
            // EndPointPrimitive5
            // 
            this.EndPointPrimitive5 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.2, 3, 0, 0);
            this.EndPointPrimitive5.Name = "EndPointPrimitive5";
            this.EndPointPrimitive5.ReferenceToGuid = "4e75cca6241d448aab1086d90dfbf66f";
            this.EndPointPrimitive5.Guid = null;
            this.EndPointPrimitive5.Interaction = null;
            // 
            // HorizontalLinePrimitive3
            // 
            this.HorizontalLinePrimitive3 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.2, 3, 0.1, 0.01);
            this.HorizontalLinePrimitive3.Color = System.Drawing.Color.DimGray;
            this.HorizontalLinePrimitive3.Guid = "ff584585557b4e0cbb021360dc278617";
            this.HorizontalLinePrimitive3.Name = "HorizontalLinePrimitive3";
            this.HorizontalLinePrimitive3.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive3.Interaction = null;
            this.HorizontalLinePrimitive3.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            // 
            // HorizontalLinePrimitive5
            // 
            this.HorizontalLinePrimitive5 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.2, 2.7, 0.1, 0.01);
            this.HorizontalLinePrimitive5.Color = System.Drawing.Color.DimGray;
            this.HorizontalLinePrimitive5.Guid = "f985db56538c43e5bddeb6ed050ca8ea";
            this.HorizontalLinePrimitive5.Name = "HorizontalLinePrimitive5";
            this.HorizontalLinePrimitive5.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive5.Interaction = null;
            this.HorizontalLinePrimitive5.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            // 
            // HorizontalLinePrimitive6
            // 
            this.HorizontalLinePrimitive6 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.2, 2.4, 0.1, 0.01);
            this.HorizontalLinePrimitive6.Color = System.Drawing.Color.DimGray;
            this.HorizontalLinePrimitive6.Guid = "3a25d121f8be43ffa6dcb5c30368d0d4";
            this.HorizontalLinePrimitive6.Name = "HorizontalLinePrimitive6";
            this.HorizontalLinePrimitive6.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive6.Interaction = null;
            this.HorizontalLinePrimitive6.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            // 
            // HorizontalLinePrimitive7
            // 
            this.HorizontalLinePrimitive7 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.2, 2.1, 0.1, 0.01);
            this.HorizontalLinePrimitive7.Color = System.Drawing.Color.DimGray;
            this.HorizontalLinePrimitive7.Guid = "85f9e86b2ac544d5b17e591d023b1b50";
            this.HorizontalLinePrimitive7.Name = "HorizontalLinePrimitive7";
            this.HorizontalLinePrimitive7.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive7.Interaction = null;
            this.HorizontalLinePrimitive7.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HeaderBand2.Guid = null;
            this.HeaderBand2.Interaction = null;
            this.HeaderBand2.BeforePrint += new System.EventHandler(this.HeaderBand2_BeforePrint);
            // 
            // HeaderBand1
            // 
            this.HeaderBand1 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6.5, 7.87, 0.4);
            this.HeaderBand1.Name = "HeaderBand1";
            this.HeaderBand1.PrintOnAllPages = false;
            this.HeaderBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text39
            // 
            this.Text39 = new Stimulsoft.Report.Components.StiText();
            this.Text39.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 7.8, 0.3);
            this.Text39.Guid = "96cf485b7bb945f8b7b21fc8809e1311";
            this.Text39.Name = "Text39";
            this.Text39.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text39__GetValue);
            this.Text39.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text39.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text39.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue);
            this.Text39.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.Text39.Indicator = null;
            this.Text39.Interaction = null;
            this.Text39.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text39.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text39.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // StartPointPrimitive9
            // 
            this.StartPointPrimitive9 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 0, 0);
            this.StartPointPrimitive9.Name = "StartPointPrimitive9";
            this.StartPointPrimitive9.ReferenceToGuid = "dd1b260713f84f339f5932e2b5a54636";
            this.StartPointPrimitive9.Guid = null;
            this.StartPointPrimitive9.Interaction = null;
            this.HeaderBand1.Guid = null;
            this.HeaderBand1.Interaction = null;
            this.HeaderBand1.BeforePrint += new System.EventHandler(this.HeaderBand1_BeforePrint);
            // 
            // HeaderBand4
            // 
            this.HeaderBand4 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 7.3, 7.87, 0.3);
            this.HeaderBand4.Guid = "9e93cf385c8c49d4915d8787c14fd28a";
            this.HeaderBand4.Name = "HeaderBand4";
            this.HeaderBand4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text43
            // 
            this.Text43 = new Stimulsoft.Report.Components.StiText();
            this.Text43.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.1, 2.3, 0.2);
            this.Text43.Guid = "8e2422f729fd44b7891d2629cc7065a3";
            this.Text43.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text43.Name = "Text43";
            this.Text43.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text43__GetValue);
            this.Text43.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text43.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text43.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text43.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text43.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text43.Indicator = null;
            this.Text43.Interaction = null;
            this.Text43.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text43.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text43.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text44
            // 
            this.Text44 = new Stimulsoft.Report.Components.StiText();
            this.Text44.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.5, 0.1, 2.5, 0.2);
            this.InitializeComponent2();
            this.InitializeComponent3();
        }
        
        public void InitializeComponent2()
        {
            this.Text44.Guid = "0788c44ede204ed3971ca108cd05e871";
            this.Text44.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text44.Name = "Text44";
            this.Text44.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text44__GetValue);
            this.Text44.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text44.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text44.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text44.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text44.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text44.Indicator = null;
            this.Text44.Interaction = null;
            this.Text44.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text44.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text44.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text45
            // 
            this.Text45 = new Stimulsoft.Report.Components.StiText();
            this.Text45.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.1, 0.1, 1.3, 0.2);
            this.Text45.Guid = "898fc19b7a9e4b5e819980154a651256";
            this.Text45.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text45.Name = "Text45";
            this.Text45.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text45__GetValue);
            this.Text45.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text45.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text45.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text45.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text45.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text45.Indicator = null;
            this.Text45.Interaction = null;
            this.Text45.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text45.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text45.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text46
            // 
            this.Text46 = new Stimulsoft.Report.Components.StiText();
            this.Text46.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.5, 0.1, 1.2, 0.2);
            this.Text46.Guid = "55de71d5b77843ad982ce9d80a767511";
            this.Text46.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text46.Name = "Text46";
            this.Text46.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text46__GetValue);
            this.Text46.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text46.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text46.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text46.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text46.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text46.Indicator = null;
            this.Text46.Interaction = null;
            this.Text46.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text46.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text46.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand4.Interaction = null;
            this.HeaderBand4.BeforePrint += new System.EventHandler(this.HeaderBand4_BeforePrint);
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 8, 7.87, 0.2);
            this.DataBand1.DataSourceName = "v_Summary_Status";
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new string[] {
                    "ASC",
                    "CustomerName",
                    "ASC",
                    "InvoceName"};
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand1.BusinessObjectGuid = null;
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0, 2.3, 0.2);
            this.Text1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text1.Guid = null;
            this.Text1.Indicator = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.5, 0, 1.2, 0.2);
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text15.Name = "Text15";
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text15.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text15.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text15.Guid = null;
            this.Text15.Indicator = null;
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text15.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.5, 0, 2.5, 0.2);
            this.Text2.Guid = "4263c674aa81449ab976466dd7b71059";
            this.Text2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.1, 0, 1.3, 0.2);
            this.Text7.Guid = "62ef0237bb8445e19e392c294ca724fc";
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text7.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // HorizontalLinePrimitive1
            // 
            this.HorizontalLinePrimitive1 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.2, 7.6, 0.01);
            this.HorizontalLinePrimitive1.Color = System.Drawing.Color.LightGray;
            this.HorizontalLinePrimitive1.Name = "HorizontalLinePrimitive1";
            this.HorizontalLinePrimitive1.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive1.Guid = null;
            this.HorizontalLinePrimitive1.Interaction = null;
            this.HorizontalLinePrimitive1.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.DataBand1.DataRelationName = null;
            this.DataBand1.Guid = null;
            this.DataBand1.Interaction = null;
            this.DataBand1.MasterComponent = null;
            this.DataBand1.BeforePrint += new System.EventHandler(this.DataBand1_BeforePrint);
            // 
            // FooterBand1
            // 
            this.FooterBand1 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 8.6, 7.87, 0.1);
            this.FooterBand1.Name = "FooterBand1";
            this.FooterBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.FooterBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // EndPointPrimitive6
            // 
            this.EndPointPrimitive6 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.8, 0.1, 0, 0);
            this.EndPointPrimitive6.Name = "EndPointPrimitive6";
            this.EndPointPrimitive6.ReferenceToGuid = "dd1b260713f84f339f5932e2b5a54636";
            this.EndPointPrimitive6.Guid = null;
            this.EndPointPrimitive6.Interaction = null;
            this.FooterBand1.Guid = null;
            this.FooterBand1.Interaction = null;
            this.FooterBand1.BeforePrint += new System.EventHandler(this.FooterBand1_BeforePrint);
            // 
            // HeaderBand8
            // 
            this.HeaderBand8 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.1, 7.87, 0.4);
            this.HeaderBand8.Guid = "0cfb555b9ae04410b10d6986446e1bd1";
            this.HeaderBand8.Name = "HeaderBand8";
            this.HeaderBand8.PrintOnAllPages = false;
            this.HeaderBand8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text53
            // 
            this.Text53 = new Stimulsoft.Report.Components.StiText();
            this.Text53.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 7.8, 0.3);
            this.Text53.Guid = "e3b1364358354e828cc2e449d1813d54";
            this.Text53.Name = "Text53";
            this.Text53.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text53__GetValue);
            this.Text53.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text53.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text53.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue);
            this.Text53.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.Text53.Indicator = null;
            this.Text53.Interaction = null;
            this.Text53.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text53.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text53.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // StartPointPrimitive13
            // 
            this.StartPointPrimitive13 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, -0.1, 0, 0);
            this.StartPointPrimitive13.Name = "StartPointPrimitive13";
            this.StartPointPrimitive13.ReferenceToGuid = "a06e205bb127435e950acee3ea0c20e7";
            this.StartPointPrimitive13.Guid = null;
            this.StartPointPrimitive13.Interaction = null;
            // 
            // StartPointPrimitive12
            // 
            this.StartPointPrimitive12 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 0, 0);
            this.StartPointPrimitive12.Name = "StartPointPrimitive12";
            this.StartPointPrimitive12.ReferenceToGuid = "d4e0e270f07c4c3b910dc44ee0bc0ea4";
            this.StartPointPrimitive12.Guid = null;
            this.StartPointPrimitive12.Interaction = null;
            this.HeaderBand8.Interaction = null;
            this.HeaderBand8.BeforePrint += new System.EventHandler(this.HeaderBand8_BeforePrint);
            // 
            // HeaderBand9
            // 
            this.HeaderBand9 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.9, 7.87, 0.3);
            this.HeaderBand9.Guid = "955b2ce993ae4b9daac97b95a9a299f6";
            this.HeaderBand9.Name = "HeaderBand9";
            this.HeaderBand9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text54
            // 
            this.Text54 = new Stimulsoft.Report.Components.StiText();
            this.Text54.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.1, 4.9, 0.2);
            this.Text54.Guid = "e355b5c884d2445ebad56a5abb890056";
            this.Text54.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text54.Name = "Text54";
            this.Text54.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text54__GetValue);
            this.Text54.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text54.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text54.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text54.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text54.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text54.Indicator = null;
            this.Text54.Interaction = null;
            this.Text54.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text54.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text54.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text56
            // 
            this.Text56 = new Stimulsoft.Report.Components.StiText();
            this.Text56.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.1, 0.1, 1.3, 0.2);
            this.Text56.Guid = "597d0c0565ba4ddd82ac99a4d2663e24";
            this.Text56.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text56.Name = "Text56";
            this.Text56.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text56__GetValue);
            this.Text56.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text56.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text56.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text56.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text56.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text56.Indicator = null;
            this.Text56.Interaction = null;
            this.Text56.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text56.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text56.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text57
            // 
            this.Text57 = new Stimulsoft.Report.Components.StiText();
            this.Text57.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.5, 0.1, 1.2, 0.2);
            this.Text57.Guid = "0dd335fd645148048643f0bfd994d795";
            this.Text57.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text57.Name = "Text57";
            this.Text57.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text57__GetValue);
            this.Text57.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text57.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text57.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text57.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text57.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text57.Indicator = null;
            this.Text57.Interaction = null;
            this.Text57.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text57.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text57.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand9.Interaction = null;
            this.HeaderBand9.BeforePrint += new System.EventHandler(this.HeaderBand9_BeforePrint);
            // 
            // DataBand4
            // 
            this.DataBand4 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 10.6, 7.87, 0.2);
            this.DataBand4.DataSourceName = "v_Summary_Status_NoInvoice";
            this.DataBand4.Guid = "3a0a225688f447b898ce250fcd0bfed1";
            this.DataBand4.Name = "DataBand4";
            this.DataBand4.Sort = new string[0];
            this.DataBand4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.DataBand4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand4.BusinessObjectGuid = null;
            // 
            // Text58
            // 
            this.Text58 = new Stimulsoft.Report.Components.StiText();
            this.Text58.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0, 4.9, 0.2);
            this.Text58.Guid = "e91a567c656e4cf98968e144f03029a7";
            this.Text58.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text58.Name = "Text58";
            this.Text58.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text58__GetValue);
            this.Text58.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text58.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text58.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text58.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text58.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text58.Indicator = null;
            this.Text58.Interaction = null;
            this.Text58.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text58.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text58.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text59
            // 
            this.Text59 = new Stimulsoft.Report.Components.StiText();
            this.Text59.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.5, 0, 1.2, 0.2);
            this.Text59.Guid = "bfc78267d6f944c39398e14088c5617b";
            this.Text59.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text59.Name = "Text59";
            this.Text59.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text59__GetValue);
            this.Text59.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text59.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text59.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text59.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text59.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text59.Indicator = null;
            this.Text59.Interaction = null;
            this.Text59.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text59.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text59.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text63
            // 
            this.Text63 = new Stimulsoft.Report.Components.StiText();
            this.Text63.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.1, 0, 1.3, 0.2);
            this.Text63.Guid = "856790526710431485016d9012d0f404";
            this.Text63.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text63.Name = "Text63";
            this.Text63.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text63__GetValue);
            this.Text63.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text63.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text63.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text63.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text63.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text63.Indicator = null;
            this.Text63.Interaction = null;
            this.Text63.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text63.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text63.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // HorizontalLinePrimitive10
            // 
            this.HorizontalLinePrimitive10 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.2, 7.6, 0.01);
            this.HorizontalLinePrimitive10.Color = System.Drawing.Color.LightGray;
            this.HorizontalLinePrimitive10.Guid = "205b6408394f48d99a01dfc3018ac656";
            this.HorizontalLinePrimitive10.Name = "HorizontalLinePrimitive10";
            this.HorizontalLinePrimitive10.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive10.Interaction = null;
            this.HorizontalLinePrimitive10.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.DataBand4.DataRelationName = null;
            this.DataBand4.Interaction = null;
            this.DataBand4.MasterComponent = null;
            this.DataBand4.BeforePrint += new System.EventHandler(this.DataBand4_BeforePrint);
            // 
            // FooterBand4
            // 
            this.FooterBand4 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 11.2, 7.87, 0.1);
            this.FooterBand4.Guid = "216150c6acb44cbc92ba335a2a1c0d96";
            this.FooterBand4.Name = "FooterBand4";
            this.FooterBand4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.FooterBand4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // EndPointPrimitive9
            // 
            this.EndPointPrimitive9 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.8, 0.1, 0, 0);
            this.EndPointPrimitive9.Name = "EndPointPrimitive9";
            this.EndPointPrimitive9.ReferenceToGuid = "d4e0e270f07c4c3b910dc44ee0bc0ea4";
            this.EndPointPrimitive9.Guid = null;
            this.EndPointPrimitive9.Interaction = null;
            this.FooterBand4.Interaction = null;
            this.FooterBand4.BeforePrint += new System.EventHandler(this.FooterBand4_BeforePrint);
            // 
            // HeaderBand3
            // 
            this.HeaderBand3 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 11.7, 7.87, 0.4);
            this.HeaderBand3.Guid = "70a0876ce6e74617b93629852bb7807e";
            this.HeaderBand3.Name = "HeaderBand3";
            this.HeaderBand3.PrintOnAllPages = false;
            this.HeaderBand3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text40
            // 
            this.Text40 = new Stimulsoft.Report.Components.StiText();
            this.Text40.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 7.8, 0.3);
            this.Text40.Guid = "87aaa1c08de14360b1363756d396ac32";
            this.Text40.Name = "Text40";
            this.Text40.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text40__GetValue);
            this.Text40.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text40.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text40.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue);
            this.Text40.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.Text40.Indicator = null;
            this.Text40.Interaction = null;
            this.Text40.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text40.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text40.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // StartPointPrimitive10
            // 
            this.StartPointPrimitive10 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 0, 0);
            this.StartPointPrimitive10.Name = "StartPointPrimitive10";
            this.StartPointPrimitive10.ReferenceToGuid = "336db47056b34cabaef0036d16c64647";
            this.StartPointPrimitive10.Guid = null;
            this.StartPointPrimitive10.Interaction = null;
            this.HeaderBand3.Interaction = null;
            this.HeaderBand3.BeforePrint += new System.EventHandler(this.HeaderBand3_BeforePrint);
            // 
            // HeaderBand5
            // 
            this.HeaderBand5 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 12.5, 7.87, 0.3);
            this.HeaderBand5.Guid = "e0757462e70c45d79364a1bfd9499f6b";
            this.HeaderBand5.Name = "HeaderBand5";
            this.HeaderBand5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.1, 4.5, 0.2);
            this.Text6.Guid = "355272e7c08c48739114564d07431d83";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text6.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.7, 0.1, 1.3, 0.2);
            this.Text12.Guid = "f10fe1a1b826429f909d18e29bd6659f";
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text12.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text12.Indicator = null;
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.1, 0.1, 1.6, 0.2);
            this.Text14.Guid = "93e67bfa14544b40963f7c0831c2607a";
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text14.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text14.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text14.Indicator = null;
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand5.Interaction = null;
            this.HeaderBand5.BeforePrint += new System.EventHandler(this.HeaderBand5_BeforePrint);
            // 
            // DataBand2
            // 
            this.DataBand2 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 13.2, 7.87, 0.6);
            this.DataBand2.DataSourceName = "v_Summary_Package";
            this.DataBand2.Guid = "1ad1b49048ed4793bea52e596d3bdb39";
            this.DataBand2.Name = "DataBand2";
            this.DataBand2.Sort = new string[] {
                    "ASC",
                    "S_ID",
                    "DESC",
                    "EndDate"};
            this.DataBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.DataBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand2.BusinessObjectGuid = null;
            // 
            // Text33
            // 
            this.Text33 = new Stimulsoft.Report.Components.StiText();
            this.Text33.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0, 4.5, 0.2);
            this.Text33.Guid = "2c11f24993f842e1843883af9ea51a46";
            this.Text33.Name = "Text33";
            this.Text33.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text33__GetValue);
            this.Text33.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text33.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text33.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text33.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text33.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text33.Indicator = null;
            this.Text33.Interaction = null;
            this.Text33.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text33.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text33.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text34
            // 
            this.Text34 = new Stimulsoft.Report.Components.StiText();
            this.Text34.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.1, 0, 1.6, 0.6);
            this.Text34.Guid = "2384b6e433184a939a8a694b3dfe04e2";
            this.Text34.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text34.Name = "Text34";
            this.Text34.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text34__GetValue);
            this.Text34.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text34.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text34.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text34.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text34.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text34.Indicator = null;
            this.Text34.Interaction = null;
            this.Text34.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text34.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text34.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text35
            // 
            this.Text35 = new Stimulsoft.Report.Components.StiText();
            this.Text35.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.4, 1.1, 0.2);
            this.Text35.Guid = "a3bbca2afe6f4490af50ae983dca1399";
            this.Text35.Name = "Text35";
            this.Text35.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text35__GetValue);
            this.Text35.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text35.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text35.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text35.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text35.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text35.Indicator = null;
            this.Text35.Interaction = null;
            this.Text35.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text35.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text35.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text36
            // 
            this.Text36 = new Stimulsoft.Report.Components.StiText();
            this.Text36.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.7, 0, 1.3, 0.2);
            this.Text36.Guid = "908c71d3123545829e76d884a1950fa3";
            this.Text36.Name = "Text36";
            this.Text36.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text36__GetValue);
            this.Text36.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text36.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text36.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text36.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text36.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text36.Indicator = null;
            this.Text36.Interaction = null;
            this.Text36.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text36.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text36.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text29
            // 
            this.Text29 = new Stimulsoft.Report.Components.StiText();
            this.Text29.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(1.3, 0.4, 1.2, 0.2);
            this.Text29.Guid = "a69460fbd50f493190c82b141e18694c";
            this.Text29.Name = "Text29";
            this.Text29.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text29__GetValue);
            this.Text29.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text29.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text29.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text29.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text29.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text29.Indicator = null;
            this.Text29.Interaction = null;
            this.Text29.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text29.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text29.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text37
            // 
            this.Text37 = new Stimulsoft.Report.Components.StiText();
            this.Text37.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.6, 0.4, 2, 0.2);
            this.Text37.Guid = "71e97f1f41cd4d40bd8f1532e449a666";
            this.Text37.Name = "Text37";
            this.Text37.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text37__GetValue);
            this.Text37.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text37.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text37.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text37.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text37.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text37.Indicator = null;
            this.Text37.Interaction = null;
            this.Text37.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text37.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text37.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Text37.BeforePrint += new System.EventHandler(this.Text37_BeforePrint);
            // 
            // Text38
            // 
            this.Text38 = new Stimulsoft.Report.Components.StiText();
            this.Text38.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.7, 0.2, 1.3, 0.2);
            this.Text38.Guid = "adcbe23aac234ead8a4154b5959e6811";
            this.Text38.Name = "Text38";
            this.Text38.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text38__GetValue);
            this.Text38.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text38.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text38.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text38.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text38.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text38.Indicator = null;
            this.Text38.Interaction = null;
            this.Text38.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text38.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text38.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text41
            // 
            this.Text41 = new Stimulsoft.Report.Components.StiText();
            this.Text41.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.2, 4.5, 0.2);
            this.Text41.Guid = "f790ec0f3277471586fd6abcfa9bcc77";
            this.Text41.Name = "Text41";
            this.Text41.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text41__GetValue);
            this.Text41.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text41.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text41.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text41.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text41.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text41.Indicator = null;
            this.Text41.Interaction = null;
            this.Text41.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text41.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text41.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text42
            // 
            this.Text42 = new Stimulsoft.Report.Components.StiText();
            this.Text42.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.7, 0.4, 1.3, 0.2);
            this.Text42.Guid = "3335ccc4664e4da3b40ec515e6ed1a36";
            this.Text42.Name = "Text42";
            this.Text42.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text42__GetValue);
            this.Text42.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text42.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text42.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text42.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text42.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text42.Indicator = null;
            this.Text42.Interaction = null;
            this.Text42.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text42.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text42.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Text42.BeforePrint += new System.EventHandler(this.Text42_BeforePrint);
            // 
            // HorizontalLinePrimitive8
            // 
            this.HorizontalLinePrimitive8 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.6, 7.6, 0.01);
            this.HorizontalLinePrimitive8.Color = System.Drawing.Color.LightGray;
            this.HorizontalLinePrimitive8.Guid = "630e9659d0134ab685e2f94ccd5871f3";
            this.HorizontalLinePrimitive8.Name = "HorizontalLinePrimitive8";
            this.HorizontalLinePrimitive8.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive8.Interaction = null;
            this.HorizontalLinePrimitive8.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.DataBand2.DataRelationName = null;
            this.DataBand2.Interaction = null;
            this.DataBand2.MasterComponent = null;
            this.DataBand2.BeforePrint += new System.EventHandler(this.DataBand2_BeforePrint);
            // 
            // FooterBand2
            // 
            this.FooterBand2 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 14.2, 7.87, 0.1);
            this.FooterBand2.Name = "FooterBand2";
            this.FooterBand2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.FooterBand2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // EndPointPrimitive7
            // 
            this.EndPointPrimitive7 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.8, 0.1, 0, 0);
            this.EndPointPrimitive7.Name = "EndPointPrimitive7";
            this.EndPointPrimitive7.ReferenceToGuid = "336db47056b34cabaef0036d16c64647";
            this.EndPointPrimitive7.Guid = null;
            this.EndPointPrimitive7.Interaction = null;
            this.FooterBand2.Guid = null;
            this.FooterBand2.Interaction = null;
            this.FooterBand2.BeforePrint += new System.EventHandler(this.FooterBand2_BeforePrint);
            // 
            // HeaderBand6
            // 
            this.HeaderBand6 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 14.7, 7.87, 0.4);
            this.HeaderBand6.Guid = "b247bd20e77c48e888443e51406c1efd";
            this.HeaderBand6.Name = "HeaderBand6";
            this.HeaderBand6.PrintOnAllPages = false;
            this.HeaderBand6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text16
            // 
            this.Text16 = new Stimulsoft.Report.Components.StiText();
            this.Text16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 7.8, 0.3);
            this.Text16.Guid = "a73718c6f9304737850a95da50d31a7d";
            this.Text16.Name = "Text16";
            this.Text16.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text16__GetValue);
            this.Text16.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.SteelBlue);
            this.Text16.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold);
            this.Text16.Indicator = null;
            this.Text16.Interaction = null;
            this.Text16.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text16.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text16.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // StartPointPrimitive11
            // 
            this.StartPointPrimitive11 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.1, 0, 0);
            this.StartPointPrimitive11.Guid = "7032d33abaf54aebb8f23e1876995fe9";
            this.StartPointPrimitive11.Name = "StartPointPrimitive11";
            this.StartPointPrimitive11.ReferenceToGuid = "b0774d98fec14a1ab652bfaba40aad10";
            this.StartPointPrimitive11.Interaction = null;
            // 
            // StartPointPrimitive14
            // 
            this.StartPointPrimitive14 = new Stimulsoft.Report.Components.StiStartPointPrimitive();
            this.StartPointPrimitive14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 0, 0);
            this.StartPointPrimitive14.Name = "StartPointPrimitive14";
            this.StartPointPrimitive14.ReferenceToGuid = "b0774d98fec14a1ab652bfaba40aad10";
            this.StartPointPrimitive14.Guid = null;
            this.StartPointPrimitive14.Interaction = null;
            this.HeaderBand6.Interaction = null;
            this.HeaderBand6.BeforePrint += new System.EventHandler(this.HeaderBand6_BeforePrint);
            // 
            // HeaderBand7
            // 
            this.HeaderBand7 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 15.5, 7.87, 0.3);
            this.HeaderBand7.Guid = "1b079030f4624bb4b919aac1960be984";
            this.HeaderBand7.Name = "HeaderBand7";
            this.HeaderBand7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text28
            // 
            this.Text28 = new Stimulsoft.Report.Components.StiText();
            this.Text28.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.1, 4.5, 0.2);
            this.Text28.Guid = "f802149001be4acb813077d8d2f790e0";
            this.Text28.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text28.Name = "Text28";
            this.Text28.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text28__GetValue);
            this.Text28.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text28.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text28.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text28.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text28.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text28.Indicator = null;
            this.Text28.Interaction = null;
            this.Text28.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text28.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text28.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text31
            // 
            this.Text31 = new Stimulsoft.Report.Components.StiText();
            this.Text31.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.7, 0.1, 1.3, 0.2);
            this.Text31.Guid = "7f402ce758ec41138e859089ef2aa071";
            this.Text31.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text31.Name = "Text31";
            this.Text31.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text31__GetValue);
            this.Text31.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text31.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text31.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text31.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text31.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text31.Indicator = null;
            this.Text31.Interaction = null;
            this.Text31.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text31.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text31.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text32
            // 
            this.Text32 = new Stimulsoft.Report.Components.StiText();
            this.Text32.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.1, 0.1, 1.6, 0.2);
            this.Text32.Guid = "e5812b3ef35a4b88bc32fdd28ed17be1";
            this.Text32.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text32.Name = "Text32";
            this.Text32.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text32__GetValue);
            this.Text32.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text32.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text32.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text32.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.DimGray);
            this.Text32.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text32.Indicator = null;
            this.Text32.Interaction = null;
            this.Text32.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text32.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text32.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand7.Interaction = null;
            this.HeaderBand7.BeforePrint += new System.EventHandler(this.HeaderBand7_BeforePrint);
            // 
            // DataBand3
            // 
            this.DataBand3 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 16.2, 7.87, 0.4);
            this.DataBand3.DataSourceName = "v_Summary_Package";
            this.DataBand3.Guid = "ec34751871a6496b8c3ad7cc888d99e8";
            this.DataBand3.Name = "DataBand3";
            this.DataBand3.Sort = new string[] {
                    "ASC",
                    "S_ID",
                    "DESC",
                    "EndDate"};
            this.DataBand3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.DataBand3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand3.BusinessObjectGuid = null;
            // 
            // Text47
            // 
            this.Text47 = new Stimulsoft.Report.Components.StiText();
            this.Text47.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0, 4.5, 0.2);
            this.Text47.Guid = "1da7b54049754662806efb41f2fddd56";
            this.Text47.Name = "Text47";
            this.Text47.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text47__GetValue);
            this.Text47.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text47.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text47.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text47.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text47.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text47.Indicator = null;
            this.Text47.Interaction = null;
            this.Text47.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text47.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text47.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text48
            // 
            this.Text48 = new Stimulsoft.Report.Components.StiText();
            this.Text48.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(6.1, 0, 1.6, 0.4);
            this.Text48.Guid = "829bfa774c244dae9c918655d556a95c";
            this.Text48.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text48.Name = "Text48";
            this.Text48.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text48__GetValue);
            this.Text48.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text48.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text48.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text48.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text48.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.Text48.Indicator = null;
            this.Text48.Interaction = null;
            this.Text48.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text48.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text48.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text49
            // 
            this.Text49 = new Stimulsoft.Report.Components.StiText();
            this.Text49.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.2, 1.1, 0.2);
            this.Text49.Guid = "5d1df0d830c14c60b0c0ec85c3539eb9";
            this.Text49.Name = "Text49";
            this.Text49.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text49__GetValue);
            this.Text49.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text49.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text49.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text49.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text49.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text49.Indicator = null;
            this.Text49.Interaction = null;
            this.Text49.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text49.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text49.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text51
            // 
            this.Text51 = new Stimulsoft.Report.Components.StiText();
            this.Text51.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.7, 0, 1.3, 0.2);
            this.Text51.Guid = "a7f3fd56c8914180b4e48824483d0cdc";
            this.Text51.Name = "Text51";
            this.Text51.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text51__GetValue);
            this.Text51.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text51.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text51.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text51.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text51.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text51.Indicator = null;
            this.Text51.Interaction = null;
            this.Text51.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text51.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text51.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text52
            // 
            this.Text52 = new Stimulsoft.Report.Components.StiText();
            this.Text52.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(1.3, 0.2, 1.2, 0.2);
            this.Text52.Guid = "7551a4d8808a432da0241ce69ce31988";
            this.Text52.Name = "Text52";
            this.Text52.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text52__GetValue);
            this.Text52.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text52.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text52.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text52.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text52.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text52.Indicator = null;
            this.Text52.Interaction = null;
            this.Text52.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text52.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text52.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text55
            // 
            this.Text55 = new Stimulsoft.Report.Components.StiText();
            this.Text55.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.6, 0.2, 2, 0.2);
            this.Text55.Guid = "4ec38aa535ad4753af78fba46fad4920";
            this.Text55.Name = "Text55";
            this.Text55.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text55__GetValue);
            this.Text55.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text55.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text55.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text55.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text55.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text55.Indicator = null;
            this.Text55.Interaction = null;
            this.Text55.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text55.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text55.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Text55.BeforePrint += new System.EventHandler(this.Text55_BeforePrint);
            // 
            // Text62
            // 
            this.Text62 = new Stimulsoft.Report.Components.StiText();
            this.Text62.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.7, 0.2, 1.3, 0.2);
            this.Text62.Guid = "73f9fa4256534e8eb5cca3e9b5741461";
            this.Text62.Name = "Text62";
            this.Text62.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text62__GetValue);
            this.Text62.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text62.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text62.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text62.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text62.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Text62.Indicator = null;
            this.Text62.Interaction = null;
            this.Text62.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text62.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text62.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // HorizontalLinePrimitive9
            // 
            this.HorizontalLinePrimitive9 = new Stimulsoft.Report.Components.StiHorizontalLinePrimitive();
            this.HorizontalLinePrimitive9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.1, 0.4, 7.6, 0.01);
            this.HorizontalLinePrimitive9.Color = System.Drawing.Color.LightGray;
            this.HorizontalLinePrimitive9.Guid = "b2f02eaf6c7c4a7fb2b75b759965adf6";
            this.HorizontalLinePrimitive9.Name = "HorizontalLinePrimitive9";
            this.HorizontalLinePrimitive9.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.HorizontalLinePrimitive9.Interaction = null;
            this.HorizontalLinePrimitive9.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.DataBand3.DataRelationName = null;
            this.DataBand3.Interaction = null;
            this.DataBand3.MasterComponent = null;
            this.DataBand3.BeforePrint += new System.EventHandler(this.DataBand3_BeforePrint);
            // 
            // FooterBand3
            // 
            this.FooterBand3 = new Stimulsoft.Report.Components.StiFooterBand();
            this.FooterBand3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 17, 7.87, 0.1);
            this.FooterBand3.Guid = "a6ce3d8a37f946f0b02edaf2919af8e0";
            this.FooterBand3.Name = "FooterBand3";
            this.FooterBand3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.FooterBand3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // EndPointPrimitive8
            // 
            this.EndPointPrimitive8 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.8, 0.1, 0, 0);
            this.EndPointPrimitive8.Guid = "bb6adfa8899a4f22b7b3643ebf5ddc65";
            this.EndPointPrimitive8.Name = "EndPointPrimitive8";
        }
        
        public void InitializeComponent3()
        {
            this.EndPointPrimitive8.ReferenceToGuid = "b0774d98fec14a1ab652bfaba40aad10";
            this.EndPointPrimitive8.Interaction = null;
            // 
            // EndPointPrimitive11
            // 
            this.EndPointPrimitive11 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.8, 0, 0, 0);
            this.EndPointPrimitive11.Name = "EndPointPrimitive11";
            this.EndPointPrimitive11.ReferenceToGuid = "b0774d98fec14a1ab652bfaba40aad10";
            this.EndPointPrimitive11.Guid = null;
            this.EndPointPrimitive11.Interaction = null;
            this.FooterBand3.Interaction = null;
            this.FooterBand3.BeforePrint += new System.EventHandler(this.FooterBand3_BeforePrint);
            // 
            // RectanglePrimitive23
            // 
            this.RectanglePrimitive23 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive23.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.2, 7.8, 1.2);
            this.RectanglePrimitive23.Color = System.Drawing.Color.SteelBlue;
            this.RectanglePrimitive23.Guid = "808708130c624f92942a49bea72eede6";
            this.RectanglePrimitive23.Name = "RectanglePrimitive23";
            this.RectanglePrimitive23.Interaction = null;
            // 
            // RectanglePrimitive2
            // 
            this.RectanglePrimitive2 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.9, 7.8, 4.2);
            this.RectanglePrimitive2.Color = System.Drawing.Color.DimGray;
            this.RectanglePrimitive2.Guid = "4853e3511e5d4dc5bc9d93d81bbac922";
            this.RectanglePrimitive2.Name = "RectanglePrimitive2";
            this.RectanglePrimitive2.Interaction = null;
            // 
            // RectanglePrimitive1
            // 
            this.RectanglePrimitive1 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5, 2.6, 2.7, 2.8);
            this.RectanglePrimitive1.Color = System.Drawing.Color.DimGray;
            this.RectanglePrimitive1.Guid = "e873eee296e44c33988c05dd45312983";
            this.RectanglePrimitive1.Name = "RectanglePrimitive1";
            this.RectanglePrimitive1.Interaction = null;
            // 
            // VerticalLinePrimitive1
            // 
            this.VerticalLinePrimitive1 = new Stimulsoft.Report.Components.StiVerticalLinePrimitive();
            this.VerticalLinePrimitive1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.2, 3.9, 0.01, 0.9);
            this.VerticalLinePrimitive1.Color = System.Drawing.Color.DimGray;
            this.VerticalLinePrimitive1.Guid = "4e75cca6241d448aab1086d90dfbf66f";
            this.VerticalLinePrimitive1.Name = "VerticalLinePrimitive1";
            this.VerticalLinePrimitive1.EndCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            this.VerticalLinePrimitive1.Interaction = null;
            this.VerticalLinePrimitive1.StartCap = new Stimulsoft.Base.Drawing.StiCap(10, Stimulsoft.Base.Drawing.StiCapStyle.None, 10, true, System.Drawing.Color.Black);
            // 
            // RectanglePrimitive3
            // 
            this.RectanglePrimitive3 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 6.6, 7.8, 2.1);
            this.RectanglePrimitive3.Color = System.Drawing.Color.DimGray;
            this.RectanglePrimitive3.Guid = "dd1b260713f84f339f5932e2b5a54636";
            this.RectanglePrimitive3.Name = "RectanglePrimitive3";
            this.RectanglePrimitive3.Interaction = null;
            // 
            // RectanglePrimitive4
            // 
            this.RectanglePrimitive4 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 11.8, 7.8, 2.5);
            this.RectanglePrimitive4.Color = System.Drawing.Color.DimGray;
            this.RectanglePrimitive4.Guid = "336db47056b34cabaef0036d16c64647";
            this.RectanglePrimitive4.Name = "RectanglePrimitive4";
            this.RectanglePrimitive4.Interaction = null;
            // 
            // EndPointPrimitive10
            // 
            this.EndPointPrimitive10 = new Stimulsoft.Report.Components.StiEndPointPrimitive();
            this.EndPointPrimitive10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(8.2, 13.6, 0, 0);
            this.EndPointPrimitive10.Name = "EndPointPrimitive10";
            this.EndPointPrimitive10.ReferenceToGuid = "fb91cec5e4ac4056b141b2f995c611ef";
            this.EndPointPrimitive10.Guid = null;
            this.EndPointPrimitive10.Interaction = null;
            // 
            // RectanglePrimitive6
            // 
            this.RectanglePrimitive6 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 9.2, 7.8, 2.1);
            this.RectanglePrimitive6.Color = System.Drawing.Color.DimGray;
            this.RectanglePrimitive6.Guid = "d4e0e270f07c4c3b910dc44ee0bc0ea4";
            this.RectanglePrimitive6.Name = "RectanglePrimitive6";
            this.RectanglePrimitive6.Interaction = null;
            // 
            // RectanglePrimitive5
            // 
            this.RectanglePrimitive5 = new Stimulsoft.Report.Components.StiRectanglePrimitive();
            this.RectanglePrimitive5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 14.8, 7.8, 2.3);
            this.RectanglePrimitive5.Color = System.Drawing.Color.DimGray;
            this.RectanglePrimitive5.Guid = "b0774d98fec14a1ab652bfaba40aad10";
            this.RectanglePrimitive5.Name = "RectanglePrimitive5";
            this.RectanglePrimitive5.Interaction = null;
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(0.2, 0.2, 0.2, 0.2);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Packaging_Summary_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            // 
            // StyleStyle1
            // 
            this.StyleStyle1 = new Stimulsoft.Report.StiChartStyle();
            this.StyleStyle1.BasicStyleColor = System.Drawing.Color.Transparent;
            this.StyleStyle1.BrushType = Stimulsoft.Report.StiBrushType.Solid;
            this.StyleStyle1.Name = "Style1";
            this.StyleStyle1.StyleColors = new System.Drawing.Color[] {
                    System.Drawing.Color.Gold,
                    System.Drawing.Color.DimGray,
                    System.Drawing.Color.Orange,
                    System.Drawing.Color.DeepSkyBlue,
                    System.Drawing.Color.YellowGreen,
                    System.Drawing.Color.SteelBlue};
            this.PrinterSettings = this.Packaging_Summary_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.PageFooterBand1.Page = this.Page1;
            this.PageFooterBand1.Parent = this.Page1;
            this.Text5.Page = this.Page1;
            this.Text5.Parent = this.PageFooterBand1;
            this.Text17.Page = this.Page1;
            this.Text17.Parent = this.PageFooterBand1;
            this.Text10.Page = this.Page1;
            this.Text10.Parent = this.PageFooterBand1;
            this.HorizontalLinePrimitive4.Page = this.Page1;
            this.HorizontalLinePrimitive4.Parent = this.PageFooterBand1;
            this.ReportTitle.Page = this.Page1;
            this.ReportTitle.Parent = this.Page1;
            this.Text3.Page = this.Page1;
            this.Text3.Parent = this.ReportTitle;
            this.Panel2.Page = this.Page1;
            this.Panel2.Parent = this.ReportTitle;
            this.StartPointPrimitive2.Page = this.Page1;
            this.StartPointPrimitive2.Parent = this.Panel2;
            this.Image2.Page = this.Page1;
            this.Image2.Parent = this.ReportTitle;
            this.Text50.Page = this.Page1;
            this.Text50.Parent = this.ReportTitle;
            this.Text27.Page = this.Page1;
            this.Text27.Parent = this.ReportTitle;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.ReportTitle;
            this.StartPointPrimitive4.Page = this.Page1;
            this.StartPointPrimitive4.Parent = this.ReportTitle;
            this.StartPointPrimitive1.Page = this.Page1;
            this.StartPointPrimitive1.Parent = this.ReportTitle;
            this.StartPointPrimitive5.Page = this.Page1;
            this.StartPointPrimitive5.Parent = this.ReportTitle;
            this.EndPointPrimitive1.Page = this.Page1;
            this.EndPointPrimitive1.Parent = this.ReportTitle;
            this.EndPointPrimitive2.Page = this.Page1;
            this.EndPointPrimitive2.Parent = this.ReportTitle;
            this.StartPointPrimitive3.Page = this.Page1;
            this.StartPointPrimitive3.Parent = this.ReportTitle;
            this.HeaderBand2.Page = this.Page1;
            this.HeaderBand2.Parent = this.Page1;
            this.Chart1.Area = this.Chart1_Area;
            this.Chart1.Legend = this.Chart1_Legend;
            this.Chart1.Page = this.Page1;
            this.Chart1.Parent = this.HeaderBand2;
            this.Chart1.SeriesLabels = this.Chart1_SeriesLabels;
            this.Chart1.Table = this.Chart1_Table;
            this.Chart1_Area.Chart = this.Chart1;
            this.Chart1_Legend.Chart = this.Chart1;
            this.Item29.Chart = this.Chart1;
            this.Item29.SeriesLabels = this.Item29_SeriesLabels;
            this.Item29.TopN = this.Item29_TopN;
            this.Item29_SeriesLabels.Chart = this.Chart1;
            this.Item30.Chart = this.Chart1;
            this.Item30.SeriesLabels = this.Item30_SeriesLabels;
            this.Item30.TopN = this.Item30_TopN;
            this.Item30_SeriesLabels.Chart = this.Chart1;
            this.Item31.Chart = this.Chart1;
            this.Item31.SeriesLabels = this.Item31_SeriesLabels;
            this.Item31.TopN = this.Item31_TopN;
            this.Item31_SeriesLabels.Chart = this.Chart1;
            this.Item32.Chart = this.Chart1;
            this.Item32.SeriesLabels = this.Item32_SeriesLabels;
            this.Item32.TopN = this.Item32_TopN;
            this.Item32_SeriesLabels.Chart = this.Chart1;
            this.Item33.Chart = this.Chart1;
            this.Item33.SeriesLabels = this.Item33_SeriesLabels;
            this.Item33.TopN = this.Item33_TopN;
            this.Item33_SeriesLabels.Chart = this.Chart1;
            this.Item34.Chart = this.Chart1;
            this.Item34.SeriesLabels = this.Item34_SeriesLabels;
            this.Item34.TopN = this.Item34_TopN;
            this.Item34_SeriesLabels.Chart = this.Chart1;
            this.Chart1_SeriesLabels.Chart = this.Chart1;
            this.Text30.Page = this.Page1;
            this.Text30.Parent = this.HeaderBand2;
            this.Panel3.Page = this.Page1;
            this.Panel3.Parent = this.HeaderBand2;
            this.Panel13.Page = this.Page1;
            this.Panel13.Parent = this.HeaderBand2;
            this.Panel1.Page = this.Page1;
            this.Panel1.Parent = this.HeaderBand2;
            this.Panel4.Page = this.Page1;
            this.Panel4.Parent = this.HeaderBand2;
            this.Panel5.Page = this.Page1;
            this.Panel5.Parent = this.HeaderBand2;
            this.Panel6.Page = this.Page1;
            this.Panel6.Parent = this.HeaderBand2;
            this.Text60.Page = this.Page1;
            this.Text60.Parent = this.HeaderBand2;
            this.Text61.Page = this.Page1;
            this.Text61.Parent = this.HeaderBand2;
            this.Text4.Page = this.Page1;
            this.Text4.Parent = this.HeaderBand2;
            this.Text8.Page = this.Page1;
            this.Text8.Parent = this.HeaderBand2;
            this.Text11.Page = this.Page1;
            this.Text11.Parent = this.HeaderBand2;
            this.Text13.Page = this.Page1;
            this.Text13.Parent = this.HeaderBand2;
            this.Text18.Page = this.Page1;
            this.Text18.Parent = this.HeaderBand2;
            this.Text19.Page = this.Page1;
            this.Text19.Parent = this.HeaderBand2;
            this.Text20.Page = this.Page1;
            this.Text20.Parent = this.HeaderBand2;
            this.Text21.Page = this.Page1;
            this.Text21.Parent = this.HeaderBand2;
            this.Text22.Page = this.Page1;
            this.Text22.Parent = this.HeaderBand2;
            this.Text23.Page = this.Page1;
            this.Text23.Parent = this.HeaderBand2;
            this.Text24.Page = this.Page1;
            this.Text24.Parent = this.HeaderBand2;
            this.Text25.Page = this.Page1;
            this.Text25.Parent = this.HeaderBand2;
            this.Text26.Page = this.Page1;
            this.Text26.Parent = this.HeaderBand2;
            this.StartPointPrimitive6.Page = this.Page1;
            this.StartPointPrimitive6.Parent = this.HeaderBand2;
            this.EndPointPrimitive3.Page = this.Page1;
            this.EndPointPrimitive3.Parent = this.HeaderBand2;
            this.StartPointPrimitive7.Page = this.Page1;
            this.StartPointPrimitive7.Parent = this.HeaderBand2;
            this.EndPointPrimitive4.Page = this.Page1;
            this.EndPointPrimitive4.Parent = this.HeaderBand2;
            this.HorizontalLinePrimitive2.Page = this.Page1;
            this.HorizontalLinePrimitive2.Parent = this.HeaderBand2;
            this.StartPointPrimitive8.Page = this.Page1;
            this.StartPointPrimitive8.Parent = this.HeaderBand2;
            this.EndPointPrimitive5.Page = this.Page1;
            this.EndPointPrimitive5.Parent = this.HeaderBand2;
            this.HorizontalLinePrimitive3.Page = this.Page1;
            this.HorizontalLinePrimitive3.Parent = this.HeaderBand2;
            this.HorizontalLinePrimitive5.Page = this.Page1;
            this.HorizontalLinePrimitive5.Parent = this.HeaderBand2;
            this.HorizontalLinePrimitive6.Page = this.Page1;
            this.HorizontalLinePrimitive6.Parent = this.HeaderBand2;
            this.HorizontalLinePrimitive7.Page = this.Page1;
            this.HorizontalLinePrimitive7.Parent = this.HeaderBand2;
            this.HeaderBand1.Page = this.Page1;
            this.HeaderBand1.Parent = this.Page1;
            this.Text39.Page = this.Page1;
            this.Text39.Parent = this.HeaderBand1;
            this.StartPointPrimitive9.Page = this.Page1;
            this.StartPointPrimitive9.Parent = this.HeaderBand1;
            this.HeaderBand4.Page = this.Page1;
            this.HeaderBand4.Parent = this.Page1;
            this.Text43.Page = this.Page1;
            this.Text43.Parent = this.HeaderBand4;
            this.Text44.Page = this.Page1;
            this.Text44.Parent = this.HeaderBand4;
            this.Text45.Page = this.Page1;
            this.Text45.Parent = this.HeaderBand4;
            this.Text46.Page = this.Page1;
            this.Text46.Parent = this.HeaderBand4;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Page1;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.DataBand1;
            this.Text15.Page = this.Page1;
            this.Text15.Parent = this.DataBand1;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.DataBand1;
            this.Text7.Page = this.Page1;
            this.Text7.Parent = this.DataBand1;
            this.HorizontalLinePrimitive1.Page = this.Page1;
            this.HorizontalLinePrimitive1.Parent = this.DataBand1;
            this.FooterBand1.Page = this.Page1;
            this.FooterBand1.Parent = this.Page1;
            this.EndPointPrimitive6.Page = this.Page1;
            this.EndPointPrimitive6.Parent = this.FooterBand1;
            this.HeaderBand8.Page = this.Page1;
            this.HeaderBand8.Parent = this.Page1;
            this.Text53.Page = this.Page1;
            this.Text53.Parent = this.HeaderBand8;
            this.StartPointPrimitive13.Page = this.Page1;
            this.StartPointPrimitive13.Parent = this.HeaderBand8;
            this.StartPointPrimitive12.Page = this.Page1;
            this.StartPointPrimitive12.Parent = this.HeaderBand8;
            this.HeaderBand9.Page = this.Page1;
            this.HeaderBand9.Parent = this.Page1;
            this.Text54.Page = this.Page1;
            this.Text54.Parent = this.HeaderBand9;
            this.Text56.Page = this.Page1;
            this.Text56.Parent = this.HeaderBand9;
            this.Text57.Page = this.Page1;
            this.Text57.Parent = this.HeaderBand9;
            this.DataBand4.Page = this.Page1;
            this.DataBand4.Parent = this.Page1;
            this.Text58.Page = this.Page1;
            this.Text58.Parent = this.DataBand4;
            this.Text59.Page = this.Page1;
            this.Text59.Parent = this.DataBand4;
            this.Text63.Page = this.Page1;
            this.Text63.Parent = this.DataBand4;
            this.HorizontalLinePrimitive10.Page = this.Page1;
            this.HorizontalLinePrimitive10.Parent = this.DataBand4;
            this.FooterBand4.Page = this.Page1;
            this.FooterBand4.Parent = this.Page1;
            this.EndPointPrimitive9.Page = this.Page1;
            this.EndPointPrimitive9.Parent = this.FooterBand4;
            this.HeaderBand3.Page = this.Page1;
            this.HeaderBand3.Parent = this.Page1;
            this.Text40.Page = this.Page1;
            this.Text40.Parent = this.HeaderBand3;
            this.StartPointPrimitive10.Page = this.Page1;
            this.StartPointPrimitive10.Parent = this.HeaderBand3;
            this.HeaderBand5.Page = this.Page1;
            this.HeaderBand5.Parent = this.Page1;
            this.Text6.Page = this.Page1;
            this.Text6.Parent = this.HeaderBand5;
            this.Text12.Page = this.Page1;
            this.Text12.Parent = this.HeaderBand5;
            this.Text14.Page = this.Page1;
            this.Text14.Parent = this.HeaderBand5;
            this.DataBand2.Page = this.Page1;
            this.DataBand2.Parent = this.Page1;
            this.Text33.Page = this.Page1;
            this.Text33.Parent = this.DataBand2;
            this.Text34.Page = this.Page1;
            this.Text34.Parent = this.DataBand2;
            this.Text35.Page = this.Page1;
            this.Text35.Parent = this.DataBand2;
            this.Text36.Page = this.Page1;
            this.Text36.Parent = this.DataBand2;
            this.Text29.Page = this.Page1;
            this.Text29.Parent = this.DataBand2;
            this.Text37.Page = this.Page1;
            this.Text37.Parent = this.DataBand2;
            this.Text38.Page = this.Page1;
            this.Text38.Parent = this.DataBand2;
            this.Text41.Page = this.Page1;
            this.Text41.Parent = this.DataBand2;
            this.Text42.Page = this.Page1;
            this.Text42.Parent = this.DataBand2;
            this.HorizontalLinePrimitive8.Page = this.Page1;
            this.HorizontalLinePrimitive8.Parent = this.DataBand2;
            this.FooterBand2.Page = this.Page1;
            this.FooterBand2.Parent = this.Page1;
            this.EndPointPrimitive7.Page = this.Page1;
            this.EndPointPrimitive7.Parent = this.FooterBand2;
            this.HeaderBand6.Page = this.Page1;
            this.HeaderBand6.Parent = this.Page1;
            this.Text16.Page = this.Page1;
            this.Text16.Parent = this.HeaderBand6;
            this.StartPointPrimitive11.Page = this.Page1;
            this.StartPointPrimitive11.Parent = this.HeaderBand6;
            this.StartPointPrimitive14.Page = this.Page1;
            this.StartPointPrimitive14.Parent = this.HeaderBand6;
            this.HeaderBand7.Page = this.Page1;
            this.HeaderBand7.Parent = this.Page1;
            this.Text28.Page = this.Page1;
            this.Text28.Parent = this.HeaderBand7;
            this.Text31.Page = this.Page1;
            this.Text31.Parent = this.HeaderBand7;
            this.Text32.Page = this.Page1;
            this.Text32.Parent = this.HeaderBand7;
            this.DataBand3.Page = this.Page1;
            this.DataBand3.Parent = this.Page1;
            this.Text47.Page = this.Page1;
            this.Text47.Parent = this.DataBand3;
            this.Text48.Page = this.Page1;
            this.Text48.Parent = this.DataBand3;
            this.Text49.Page = this.Page1;
            this.Text49.Parent = this.DataBand3;
            this.Text51.Page = this.Page1;
            this.Text51.Parent = this.DataBand3;
            this.Text52.Page = this.Page1;
            this.Text52.Parent = this.DataBand3;
            this.Text55.Page = this.Page1;
            this.Text55.Parent = this.DataBand3;
            this.Text62.Page = this.Page1;
            this.Text62.Parent = this.DataBand3;
            this.HorizontalLinePrimitive9.Page = this.Page1;
            this.HorizontalLinePrimitive9.Parent = this.DataBand3;
            this.FooterBand3.Page = this.Page1;
            this.FooterBand3.Parent = this.Page1;
            this.EndPointPrimitive8.Page = this.Page1;
            this.EndPointPrimitive8.Parent = this.FooterBand3;
            this.EndPointPrimitive11.Page = this.Page1;
            this.EndPointPrimitive11.Parent = this.FooterBand3;
            this.RectanglePrimitive23.Page = this.Page1;
            this.RectanglePrimitive23.Parent = this.Page1;
            this.RectanglePrimitive2.Page = this.Page1;
            this.RectanglePrimitive2.Parent = this.Page1;
            this.RectanglePrimitive1.Page = this.Page1;
            this.RectanglePrimitive1.Parent = this.Page1;
            this.VerticalLinePrimitive1.Page = this.Page1;
            this.VerticalLinePrimitive1.Parent = this.Page1;
            this.RectanglePrimitive3.Page = this.Page1;
            this.RectanglePrimitive3.Parent = this.Page1;
            this.RectanglePrimitive4.Page = this.Page1;
            this.RectanglePrimitive4.Parent = this.Page1;
            this.EndPointPrimitive10.Page = this.Page1;
            this.EndPointPrimitive10.Parent = this.Page1;
            this.RectanglePrimitive6.Page = this.Page1;
            this.RectanglePrimitive6.Parent = this.Page1;
            this.RectanglePrimitive5.Page = this.Page1;
            this.RectanglePrimitive5.Parent = this.Page1;
            this.EndRender += new System.EventHandler(this.Packaging_SummaryWordsToEnd__EndRender);
            // 
            // Add to PageFooterBand1.Components
            // 
            this.PageFooterBand1.Components.Clear();
            this.PageFooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text5,
                        this.Text17,
                        this.Text10,
                        this.HorizontalLinePrimitive4});
            // 
            // Add to Panel2.Components
            // 
            this.Panel2.Components.Clear();
            this.Panel2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.StartPointPrimitive2});
            // 
            // Add to ReportTitle.Components
            // 
            this.ReportTitle.Components.Clear();
            this.ReportTitle.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text3,
                        this.Panel2,
                        this.Image2,
                        this.Text50,
                        this.Text27,
                        this.Text9,
                        this.StartPointPrimitive4,
                        this.StartPointPrimitive1,
                        this.StartPointPrimitive5,
                        this.EndPointPrimitive1,
                        this.EndPointPrimitive2,
                        this.StartPointPrimitive3});
            // 
            // Add to Chart1.Series
            // 
            this.Chart1.Series.Clear();
            this.Chart1.Series.AddRange(new Stimulsoft.Report.Chart.IStiSeries[] {
                        this.Item29,
                        this.Item30,
                        this.Item31,
                        this.Item32,
                        this.Item33,
                        this.Item34});
            // 
            // Add to HeaderBand2.Components
            // 
            this.HeaderBand2.Components.Clear();
            this.HeaderBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Chart1,
                        this.Text30,
                        this.Panel3,
                        this.Panel13,
                        this.Panel1,
                        this.Panel4,
                        this.Panel5,
                        this.Panel6,
                        this.Text60,
                        this.Text61,
                        this.Text4,
                        this.Text8,
                        this.Text11,
                        this.Text13,
                        this.Text18,
                        this.Text19,
                        this.Text20,
                        this.Text21,
                        this.Text22,
                        this.Text23,
                        this.Text24,
                        this.Text25,
                        this.Text26,
                        this.StartPointPrimitive6,
                        this.EndPointPrimitive3,
                        this.StartPointPrimitive7,
                        this.EndPointPrimitive4,
                        this.HorizontalLinePrimitive2,
                        this.StartPointPrimitive8,
                        this.EndPointPrimitive5,
                        this.HorizontalLinePrimitive3,
                        this.HorizontalLinePrimitive5,
                        this.HorizontalLinePrimitive6,
                        this.HorizontalLinePrimitive7});
            // 
            // Add to HeaderBand1.Components
            // 
            this.HeaderBand1.Components.Clear();
            this.HeaderBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text39,
                        this.StartPointPrimitive9});
            // 
            // Add to HeaderBand4.Components
            // 
            this.HeaderBand4.Components.Clear();
            this.HeaderBand4.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text43,
                        this.Text44,
                        this.Text45,
                        this.Text46});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text1,
                        this.Text15,
                        this.Text2,
                        this.Text7,
                        this.HorizontalLinePrimitive1});
            // 
            // Add to FooterBand1.Components
            // 
            this.FooterBand1.Components.Clear();
            this.FooterBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.EndPointPrimitive6});
            // 
            // Add to HeaderBand8.Components
            // 
            this.HeaderBand8.Components.Clear();
            this.HeaderBand8.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text53,
                        this.StartPointPrimitive13,
                        this.StartPointPrimitive12});
            // 
            // Add to HeaderBand9.Components
            // 
            this.HeaderBand9.Components.Clear();
            this.HeaderBand9.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text54,
                        this.Text56,
                        this.Text57});
            // 
            // Add to DataBand4.Components
            // 
            this.DataBand4.Components.Clear();
            this.DataBand4.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text58,
                        this.Text59,
                        this.Text63,
                        this.HorizontalLinePrimitive10});
            // 
            // Add to FooterBand4.Components
            // 
            this.FooterBand4.Components.Clear();
            this.FooterBand4.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.EndPointPrimitive9});
            // 
            // Add to HeaderBand3.Components
            // 
            this.HeaderBand3.Components.Clear();
            this.HeaderBand3.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text40,
                        this.StartPointPrimitive10});
            // 
            // Add to HeaderBand5.Components
            // 
            this.HeaderBand5.Components.Clear();
            this.HeaderBand5.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text6,
                        this.Text12,
                        this.Text14});
            // 
            // Add to DataBand2.Components
            // 
            this.DataBand2.Components.Clear();
            this.DataBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text33,
                        this.Text34,
                        this.Text35,
                        this.Text36,
                        this.Text29,
                        this.Text37,
                        this.Text38,
                        this.Text41,
                        this.Text42,
                        this.HorizontalLinePrimitive8});
            // 
            // Add to FooterBand2.Components
            // 
            this.FooterBand2.Components.Clear();
            this.FooterBand2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.EndPointPrimitive7});
            // 
            // Add to HeaderBand6.Components
            // 
            this.HeaderBand6.Components.Clear();
            this.HeaderBand6.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text16,
                        this.StartPointPrimitive11,
                        this.StartPointPrimitive14});
            // 
            // Add to HeaderBand7.Components
            // 
            this.HeaderBand7.Components.Clear();
            this.HeaderBand7.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text28,
                        this.Text31,
                        this.Text32});
            // 
            // Add to DataBand3.Components
            // 
            this.DataBand3.Components.Clear();
            this.DataBand3.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text47,
                        this.Text48,
                        this.Text49,
                        this.Text51,
                        this.Text52,
                        this.Text55,
                        this.Text62,
                        this.HorizontalLinePrimitive9});
            // 
            // Add to FooterBand3.Components
            // 
            this.FooterBand3.Components.Clear();
            this.FooterBand3.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.EndPointPrimitive8,
                        this.EndPointPrimitive11});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.PageFooterBand1,
                        this.ReportTitle,
                        this.HeaderBand2,
                        this.HeaderBand1,
                        this.HeaderBand4,
                        this.DataBand1,
                        this.FooterBand1,
                        this.HeaderBand8,
                        this.HeaderBand9,
                        this.DataBand4,
                        this.FooterBand4,
                        this.HeaderBand3,
                        this.HeaderBand5,
                        this.DataBand2,
                        this.FooterBand2,
                        this.HeaderBand6,
                        this.HeaderBand7,
                        this.DataBand3,
                        this.FooterBand3,
                        this.RectanglePrimitive23,
                        this.RectanglePrimitive2,
                        this.RectanglePrimitive1,
                        this.VerticalLinePrimitive1,
                        this.RectanglePrimitive3,
                        this.RectanglePrimitive4,
                        this.EndPointPrimitive10,
                        this.RectanglePrimitive6,
                        this.RectanglePrimitive5});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1});
            // 
            // Add to Styles
            // 
            this.Styles.Clear();
            this.Styles.AddRange(new Stimulsoft.Report.StiBaseStyle[] {
                        this.StyleStyle1});
            this.t_Customer.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Active", "Active", "Active", typeof(bool), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Checked", "Checked", "Checked", typeof(bool), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerName", "CustomerName", "CustomerName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ID", "ID", "ID", typeof(long), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("LastUpdated", "LastUpdated", "LastUpdated", typeof(DateTime), null)});
            this.DataSources.Add(this.t_Customer);
            this.t_Invoice.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Amount", "Amount", "Amount", typeof(decimal), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerID", "CustomerID", "CustomerID", typeof(long), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ID", "ID", "ID", typeof(long), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("InvoceName", "InvoceName", "InvoceName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("InvoiceDate", "InvoiceDate", "InvoiceDate", typeof(DateTime), null)});
            this.DataSources.Add(this.t_Invoice);
            this.v_Summary_Status.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("C_ID", "C_ID", "C_ID", typeof(int), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerName", "CustomerName", "CustomerName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("I_ID", "I_ID", "I_ID", typeof(int), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("InvoceName", "InvoceName", "InvoceName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Amount", "Amount", "Amount", typeof(decimal), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_00", "PackageNumber_00", "PackageNumber_00", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_01", "PackageNumber_01", "PackageNumber_01", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_02", "PackageNumber_02", "PackageNumber_02", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_03", "PackageNumber_03", "PackageNumber_03", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_04", "PackageNumber_04", "PackageNumber_04", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_05", "PackageNumber_05", "PackageNumber_05", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_06", "PackageNumber_06", "PackageNumber_06", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("C_LastUpdated", "C_LastUpdated", "C_LastUpdated", typeof(DateTime), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("I_LastUpdated", "I_LastUpdated", "I_LastUpdated", typeof(DateTime), null)});
            this.v_Summary_Status.Parameters.AddRange(new Stimulsoft.Report.Dictionary.StiDataParameter[] {
                        new Stimulsoft.Report.Dictionary.StiDataParameter("AllCust", 11, 0, null),
                        new Stimulsoft.Report.Dictionary.StiDataParameter("SelectedCust", 12, 0, null),
                        new Stimulsoft.Report.Dictionary.StiDataParameter("AllInv", 11, 0, null),
                        new Stimulsoft.Report.Dictionary.StiDataParameter("SelectedInv", 12, 0, null)});
            this.DataSources.Add(this.v_Summary_Status);
            this.v_Summary_Status_NoInvoice.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("C_ID", "C_ID", "C_ID", typeof(int), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerName", "CustomerName", "CustomerName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Amount", "Amount", "Amount", typeof(decimal), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_00", "PackageNumber_00", "PackageNumber_00", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_01", "PackageNumber_01", "PackageNumber_01", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_02", "PackageNumber_02", "PackageNumber_02", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_03", "PackageNumber_03", "PackageNumber_03", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_04", "PackageNumber_04", "PackageNumber_04", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_05", "PackageNumber_05", "PackageNumber_05", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageNumber_06", "PackageNumber_06", "PackageNumber_06", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("C_LastUpdated", "C_LastUpdated", "C_LastUpdated", typeof(DateTime), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("I_LastUpdated", "I_LastUpdated", "I_LastUpdated", typeof(DateTime), null)});
            this.v_Summary_Status_NoInvoice.Parameters.AddRange(new Stimulsoft.Report.Dictionary.StiDataParameter[] {
                        new Stimulsoft.Report.Dictionary.StiDataParameter("AllCust", 11, 0, null),
                        new Stimulsoft.Report.Dictionary.StiDataParameter("SelectedCust", 12, 0, null),
                        new Stimulsoft.Report.Dictionary.StiDataParameter("AllInv", 11, 0, null),
                        new Stimulsoft.Report.Dictionary.StiDataParameter("SelectedInv", 12, 0, null)});
            this.DataSources.Add(this.v_Summary_Status_NoInvoice);
            this.v_Summary_Package.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("C_ID", "C_ID", "C_ID", typeof(int), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CustomerName", "CustomerName", "CustomerName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("I_ID", "I_ID", "I_ID", typeof(int), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("InvoceName", "InvoceName", "InvoceName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("P_ID", "P_ID", "P_ID", typeof(int), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("PackageName", "PackageName", "PackageName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Cost", "Cost", "Cost", typeof(double), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("SeverityName", "SeverityName", "SeverityName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Revision", "Revision", "Revision", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Request", "Request", "Request", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("RecivedDate", "RecivedDate", "RecivedDate", typeof(DateTime), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EndDate", "EndDate", "EndDate", typeof(DateTime), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("StatusName", "StatusName", "StatusName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("EngineerName", "EngineerName", "EngineerName", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("S_ID", "S_ID", "S_ID", typeof(int), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("C_LastUpdated", "C_LastUpdated", "C_LastUpdated", typeof(DateTime), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("I_LastUpdated", "I_LastUpdated", "I_LastUpdated", typeof(DateTime), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("P_LastUpdated", "P_LastUpdated", "P_LastUpdated", typeof(DateTime), null)});
            this.v_Summary_Package.Parameters.AddRange(new Stimulsoft.Report.Dictionary.StiDataParameter[] {
                        new Stimulsoft.Report.Dictionary.StiDataParameter("AllCust", 11, 0, null),
                        new Stimulsoft.Report.Dictionary.StiDataParameter("SelectedCust", 12, 0, null),
                        new Stimulsoft.Report.Dictionary.StiDataParameter("AllInv", 11, 0, null),
                        new Stimulsoft.Report.Dictionary.StiDataParameter("SelectedInv", 12, 0, null)});
            this.DataSources.Add(this.v_Summary_Package);
            this.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiMSAccessDatabase("Connection", "Connection", "Provider=Microsoft.ACE.OLEDB.12.0;User ID=;Data Source=d:\\friday report\\Packaging.accdb ", false, null));
            this.t_Customer.Connecting += new System.EventHandler(this.Gett_Customer_SqlCommand);
            this.t_Invoice.Connecting += new System.EventHandler(this.Gett_Invoice_SqlCommand);
            this.v_Summary_Status.Connecting += new System.EventHandler(this.Getv_Summary_Status_SqlCommand);
            this.v_Summary_Status_NoInvoice.Connecting += new System.EventHandler(this.Getv_Summary_Status_NoInvoice_SqlCommand);
            this.v_Summary_Package.Connecting += new System.EventHandler(this.Getv_Summary_Package_SqlCommand);
        }
        
        public void Gett_Customer_SqlCommand(object sender, System.EventArgs e)
        {
            this.t_Customer.SqlCommand = "SELECT * FROM Customer WHERE Active = TRUE ORDER BY CustomerName";
        }
        
        public void Gett_Invoice_SqlCommand(object sender, System.EventArgs e)
        {
            this.t_Invoice.SqlCommand = "select * from Invoice WHERE Active = TRUE";
        }
        
        public void Getv_Summary_Status_SqlCommand(object sender, System.EventArgs e)
        {
            this.v_Summary_Status.SqlCommand = "SELECT * FROM Summary_Status\r\n\tWHERE\r\n\t(\r\n\t(@AllCust = TRUE OR\r\n\tC_ID = @SelectedCust)\r\n\tAND\r\n\t(@AllInv = TRUE OR\r\n\tI_ID = @SelectedInv)\r\n\t)";
            this.v_Summary_Status.Parameters["AllCust"].ParameterValue = AllCustomers;
            this.v_Summary_Status.Parameters["SelectedCust"].ParameterValue = CustomerList;
            this.v_Summary_Status.Parameters["AllInv"].ParameterValue = AllInvoices;
            this.v_Summary_Status.Parameters["SelectedInv"].ParameterValue = InvoiceList;
        }
        
        public void Getv_Summary_Status_NoInvoice_SqlCommand(object sender, System.EventArgs e)
        {
            this.v_Summary_Status_NoInvoice.SqlCommand = "SELECT DISTINCT\r\n\t C_ID\r\n\t,CustomerName\r\n\t,C_LastUpdated\r\n\t,SUM(Amount) AS Amount\r\n\t,SUM(PackageNumber_00) AS PackageNumber_00\r\n\t,SUM(PackageNumber_01) AS PackageNumber_01\r\n\t,SUM(PackageNumber_02) AS PackageNumber_02\r\n\t,SUM(PackageNumber_03) AS PackageNumber_03\r\n\t,SUM(PackageNumber_04) AS PackageNumber_04\r\n\t,SUM(PackageNumber_05) AS PackageNumber_05\r\n\t,SUM(PackageNumber_06) AS PackageNumber_06\r\nFROM\r\n\tSummary_Status\r\nWHERE\r\n\t(\r\n\t(@AllCust = TRUE OR\r\n\tC_ID = @SelectedCust)\r\n\tAND\r\n\t(@AllInv = TRUE OR\r\n\tI_ID = @SelectedInv)\r\n\t)\r\nGROUP BY\r\n\t C_ID\r\n\t,CustomerName\r\n\t,C_LastUpdated";
            this.v_Summary_Status_NoInvoice.Parameters["AllCust"].ParameterValue = AllCustomers;
            this.v_Summary_Status_NoInvoice.Parameters["SelectedCust"].ParameterValue = CustomerList;
            this.v_Summary_Status_NoInvoice.Parameters["AllInv"].ParameterValue = AllInvoices;
            this.v_Summary_Status_NoInvoice.Parameters["SelectedInv"].ParameterValue = InvoiceList;
        }
        
        public void Getv_Summary_Package_SqlCommand(object sender, System.EventArgs e)
        {
            this.v_Summary_Package.SqlCommand = "SELECT\r\n\t*\r\nFROM\r\n\tSummary_Package\r\nWHERE\r\n\t(\r\n\t(@AllCust = TRUE OR\r\n\tC_ID = @SelectedCust)\r\n\tAND\r\n\t(@AllInv = TRUE OR\r\n\tI_ID = @SelectedInv)\r\n\t)";
            this.v_Summary_Package.Parameters["AllCust"].ParameterValue = AllCustomers;
            this.v_Summary_Package.Parameters["SelectedCust"].ParameterValue = CustomerList;
            this.v_Summary_Package.Parameters["AllInv"].ParameterValue = AllInvoices;
            this.v_Summary_Package.Parameters["SelectedInv"].ParameterValue = InvoiceList;
        }
        
        #region DataSource t_Customer
        public class t_CustomerDataSource : Stimulsoft.Report.Dictionary.StiMSAccessSource
        {
            
            public t_CustomerDataSource() : 
                    base("Connection", "t_Customer", "t_Customer", "", true, false, 30, null)
            {
            }
            
            public virtual bool Active
            {
                get
                {
                    return ((bool)(StiReport.ChangeType(this["Active"], typeof(bool), true)));
                }
            }
            
            public virtual bool Checked
            {
                get
                {
                    return ((bool)(StiReport.ChangeType(this["Checked"], typeof(bool), true)));
                }
            }
            
            public virtual string CustomerName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerName"], typeof(string), true)));
                }
            }
            
            public virtual long ID
            {
                get
                {
                    return ((long)(StiReport.ChangeType(this["ID"], typeof(long), true)));
                }
            }
            
            public virtual DateTime LastUpdated
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["LastUpdated"], typeof(DateTime), true)));
                }
            }
        }
        #endregion DataSource t_Customer
        
        #region DataSource t_Invoice
        public class t_InvoiceDataSource : Stimulsoft.Report.Dictionary.StiMSAccessSource
        {
            
            public t_InvoiceDataSource() : 
                    base("Connection", "t_Invoice", "t_Invoice", "", true, false, 30, null)
            {
            }
            
            public virtual decimal Amount
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Amount"], typeof(decimal), true)));
                }
            }
            
            public virtual long CustomerID
            {
                get
                {
                    return ((long)(StiReport.ChangeType(this["CustomerID"], typeof(long), true)));
                }
            }
            
            public virtual long ID
            {
                get
                {
                    return ((long)(StiReport.ChangeType(this["ID"], typeof(long), true)));
                }
            }
            
            public virtual string InvoceName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["InvoceName"], typeof(string), true)));
                }
            }
            
            public virtual DateTime InvoiceDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["InvoiceDate"], typeof(DateTime), true)));
                }
            }
        }
        #endregion DataSource t_Invoice
        
        #region DataSource v_Summary_Status
        public class v_Summary_StatusDataSource : Stimulsoft.Report.Dictionary.StiMSAccessSource
        {
            
            public v_Summary_StatusDataSource() : 
                    base("Connection", "v_Summary_Status", "v_Summary_Status", "", true, false, 30, null)
            {
            }
            
            public virtual int C_ID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["C_ID"], typeof(int), true)));
                }
            }
            
            public virtual string CustomerName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerName"], typeof(string), true)));
                }
            }
            
            public virtual int I_ID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["I_ID"], typeof(int), true)));
                }
            }
            
            public virtual string InvoceName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["InvoceName"], typeof(string), true)));
                }
            }
            
            public virtual decimal Amount
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Amount"], typeof(decimal), true)));
                }
            }
            
            public virtual double PackageNumber_00
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_00"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_01
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_01"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_02
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_02"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_03
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_03"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_04
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_04"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_05
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_05"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_06
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_06"], typeof(double), true)));
                }
            }
            
            public virtual DateTime C_LastUpdated
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["C_LastUpdated"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime I_LastUpdated
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["I_LastUpdated"], typeof(DateTime), true)));
                }
            }
        }
        #endregion DataSource v_Summary_Status
        
        #region DataSource v_Summary_Status_NoInvoice
        public class v_Summary_Status_NoInvoiceDataSource : Stimulsoft.Report.Dictionary.StiMSAccessSource
        {
            
            public v_Summary_Status_NoInvoiceDataSource() : 
                    base("Connection", "v_Summary_Status_NoInvoice", "v_Summary_Status_NoInvoice", "", true, false, 30, null)
            {
            }
            
            public virtual int C_ID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["C_ID"], typeof(int), true)));
                }
            }
            
            public virtual string CustomerName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerName"], typeof(string), true)));
                }
            }
            
            public virtual decimal Amount
            {
                get
                {
                    return ((decimal)(StiReport.ChangeType(this["Amount"], typeof(decimal), true)));
                }
            }
            
            public virtual double PackageNumber_00
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_00"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_01
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_01"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_02
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_02"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_03
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_03"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_04
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_04"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_05
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_05"], typeof(double), true)));
                }
            }
            
            public virtual double PackageNumber_06
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["PackageNumber_06"], typeof(double), true)));
                }
            }
            
            public virtual DateTime C_LastUpdated
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["C_LastUpdated"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime I_LastUpdated
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["I_LastUpdated"], typeof(DateTime), true)));
                }
            }
        }
        #endregion DataSource v_Summary_Status_NoInvoice
        
        #region DataSource v_Summary_Package
        public class v_Summary_PackageDataSource : Stimulsoft.Report.Dictionary.StiMSAccessSource
        {
            
            public v_Summary_PackageDataSource() : 
                    base("Connection", "v_Summary_Package", "v_Summary_Package", "", true, false, 30, null)
            {
            }
            
            public virtual int C_ID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["C_ID"], typeof(int), true)));
                }
            }
            
            public virtual string CustomerName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CustomerName"], typeof(string), true)));
                }
            }
            
            public virtual int I_ID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["I_ID"], typeof(int), true)));
                }
            }
            
            public virtual string InvoceName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["InvoceName"], typeof(string), true)));
                }
            }
            
            public virtual int P_ID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["P_ID"], typeof(int), true)));
                }
            }
            
            public virtual string PackageName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["PackageName"], typeof(string), true)));
                }
            }
            
            public virtual double Cost
            {
                get
                {
                    return ((double)(StiReport.ChangeType(this["Cost"], typeof(double), true)));
                }
            }
            
            public virtual string SeverityName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["SeverityName"], typeof(string), true)));
                }
            }
            
            public virtual string Revision
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Revision"], typeof(string), true)));
                }
            }
            
            public virtual string Request
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Request"], typeof(string), true)));
                }
            }
            
            public virtual DateTime RecivedDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["RecivedDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime EndDate
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["EndDate"], typeof(DateTime), true)));
                }
            }
            
            public virtual string StatusName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["StatusName"], typeof(string), true)));
                }
            }
            
            public virtual string EngineerName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["EngineerName"], typeof(string), true)));
                }
            }
            
            public virtual int S_ID
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["S_ID"], typeof(int), true)));
                }
            }
            
            public virtual DateTime C_LastUpdated
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["C_LastUpdated"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime I_LastUpdated
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["I_LastUpdated"], typeof(DateTime), true)));
                }
            }
            
            public virtual DateTime P_LastUpdated
            {
                get
                {
                    return ((DateTime)(StiReport.ChangeType(this["P_LastUpdated"], typeof(DateTime), true)));
                }
            }
        }
        #endregion DataSource v_Summary_Package
        #endregion StiReport Designer generated code - do not modify
    }
}