namespace PlayingWithActiveReports.Core.Reports {
	/// <summary>
	/// Summary description for rptBound.
	/// </summary>
	partial class ResultsReport
	{
		private DataDynamics.ActiveReports.PageHeader pageHeader;
		private DataDynamics.ActiveReports.Detail Results;
		private DataDynamics.ActiveReports.PageFooter pageFooter;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing ) {
			}
			base.Dispose( disposing );
		}

		#region ActiveReport Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager( typeof( ResultsReport ) );
			this.pageHeader = new DataDynamics.ActiveReports.PageHeader( );
			this.Results = new DataDynamics.ActiveReports.Detail( );
			this.label1 = new DataDynamics.ActiveReports.Label( );
			this.label2 = new DataDynamics.ActiveReports.Label( );
			this.subReport1 = new DataDynamics.ActiveReports.SubReport( );
			this.pageFooter = new DataDynamics.ActiveReports.PageFooter( );
			this.reportInfo1 = new DataDynamics.ActiveReports.ReportInfo( );
			( (System.ComponentModel.ISupportInitialize)( this.label1 ) ).BeginInit( );
			( (System.ComponentModel.ISupportInitialize)( this.label2 ) ).BeginInit( );
			( (System.ComponentModel.ISupportInitialize)( this.reportInfo1 ) ).BeginInit( );
			( (System.ComponentModel.ISupportInitialize)( this ) ).BeginInit( );
			// 
			// pageHeader
			// 
			this.pageHeader.BackColor = System.Drawing.Color.SandyBrown;
			this.pageHeader.Height = 0.25F;
			this.pageHeader.Name = "pageHeader";
			// 
			// Results
			// 
			this.Results.ColumnSpacing = 0F;
			this.Results.Controls.AddRange( new DataDynamics.ActiveReports.ARControl[] {
            this.label1,
            this.label2,
            this.subReport1} );
			this.Results.Height = 1.885417F;
			this.Results.Name = "Results";
			this.Results.NewPage = DataDynamics.ActiveReports.NewPage.After;
			this.Results.Format += new System.EventHandler( this.OnFormatDetailSection );
			// 
			// label1
			// 
			this.label1.Border.BottomColor = System.Drawing.Color.Black;
			this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.label1.Border.LeftColor = System.Drawing.Color.Black;
			this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.label1.Border.RightColor = System.Drawing.Color.Black;
			this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.label1.Border.TopColor = System.Drawing.Color.Black;
			this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.label1.Height = 0.1875F;
			this.label1.HyperLink = null;
			this.label1.Left = 0.0625F;
			this.label1.Name = "label1";
			this.label1.Style = "";
			this.label1.Text = "Q.";
			this.label1.Top = 0.0625F;
			this.label1.Width = 0.1875F;
			// 
			// label2
			// 
			this.label2.Border.BottomColor = System.Drawing.Color.Black;
			this.label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.label2.Border.LeftColor = System.Drawing.Color.Black;
			this.label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.label2.Border.RightColor = System.Drawing.Color.Black;
			this.label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.label2.Border.TopColor = System.Drawing.Color.Black;
			this.label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.label2.Height = 0.1875F;
			this.label2.HyperLink = null;
			this.label2.Left = 0.0625F;
			this.label2.Name = "label2";
			this.label2.Style = "";
			this.label2.Text = "A.";
			this.label2.Top = 0.3125F;
			this.label2.Width = 0.1875F;
			// 
			// subReport1
			// 
			this.subReport1.Border.BottomColor = System.Drawing.Color.Black;
			this.subReport1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.subReport1.Border.LeftColor = System.Drawing.Color.Black;
			this.subReport1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.subReport1.Border.RightColor = System.Drawing.Color.Black;
			this.subReport1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.subReport1.Border.TopColor = System.Drawing.Color.Black;
			this.subReport1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.subReport1.CloseBorder = false;
			this.subReport1.Height = 1F;
			this.subReport1.Left = 0.0625F;
			this.subReport1.Name = "subReport1";
			this.subReport1.Report = null;
			this.subReport1.ReportName = "subReport1";
			this.subReport1.Top = 0.625F;
			this.subReport1.Width = 6.3125F;
			// 
			// pageFooter
			// 
			this.pageFooter.BackColor = System.Drawing.Color.SandyBrown;
			this.pageFooter.Controls.AddRange( new DataDynamics.ActiveReports.ARControl[] {
            this.reportInfo1} );
			this.pageFooter.Height = 0.25F;
			this.pageFooter.Name = "pageFooter";
			// 
			// reportInfo1
			// 
			this.reportInfo1.Border.BottomColor = System.Drawing.Color.Black;
			this.reportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo1.Border.LeftColor = System.Drawing.Color.Black;
			this.reportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo1.Border.RightColor = System.Drawing.Color.Black;
			this.reportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo1.Border.TopColor = System.Drawing.Color.Black;
			this.reportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo1.FormatString = null;
			this.reportInfo1.Height = 0.1979167F;
			this.reportInfo1.Left = 5.1875F;
			this.reportInfo1.Name = "reportInfo1";
			this.reportInfo1.Style = "";
			this.reportInfo1.Top = 0F;
			this.reportInfo1.Width = 1F;
			// 
			// ResultsReport
			// 
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.Sections.Add( this.pageHeader );
			this.Sections.Add( this.Results );
			this.Sections.Add( this.pageFooter );
			this.StyleSheet.Add( new DDCssLib.StyleSheetRule( "font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ", "Normal" ) );
			this.StyleSheet.Add( new DDCssLib.StyleSheetRule( "font-size: 16pt; font-weight: bold; ", "Heading1", "Normal" ) );
			this.StyleSheet.Add( new DDCssLib.StyleSheetRule( "font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
						"lic; ", "Heading2", "Normal" ) );
			this.StyleSheet.Add( new DDCssLib.StyleSheetRule( "font-size: 13pt; font-weight: bold; ", "Heading3", "Normal" ) );
			( (System.ComponentModel.ISupportInitialize)( this.label1 ) ).EndInit( );
			( (System.ComponentModel.ISupportInitialize)( this.label2 ) ).EndInit( );
			( (System.ComponentModel.ISupportInitialize)( this.reportInfo1 ) ).EndInit( );
			( (System.ComponentModel.ISupportInitialize)( this ) ).EndInit( );

		}
		#endregion

		private DataDynamics.ActiveReports.ReportInfo reportInfo1;
		private DataDynamics.ActiveReports.Label label1;
		private DataDynamics.ActiveReports.Label label2;
		public DataDynamics.ActiveReports.SubReport subReport1;

	}
}