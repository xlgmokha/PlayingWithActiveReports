namespace PlayingWithActiveReports.Win.UI
{
	/// <summary>
	/// Summary description for SimpleReport.
	/// </summary>
	partial class SimpleReport
	{
		private DataDynamics.ActiveReports.PageHeader pageHeader;
		private DataDynamics.ActiveReports.Detail detail;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager( typeof( SimpleReport ) );
			this.pageHeader = new DataDynamics.ActiveReports.PageHeader( );
			this.detail = new DataDynamics.ActiveReports.Detail( );
			this.pageFooter = new DataDynamics.ActiveReports.PageFooter( );
			this.uxQuestionText = new DataDynamics.ActiveReports.Label( );
			this.uxAnswerText = new DataDynamics.ActiveReports.Label( );
			( (System.ComponentModel.ISupportInitialize)( this.uxQuestionText ) ).BeginInit( );
			( (System.ComponentModel.ISupportInitialize)( this.uxAnswerText ) ).BeginInit( );
			( (System.ComponentModel.ISupportInitialize)( this ) ).BeginInit( );
			// 
			// pageHeader
			// 
			this.pageHeader.Height = 0.25F;
			this.pageHeader.Name = "pageHeader";
			// 
			// detail
			// 
			this.detail.ColumnSpacing = 0F;
			this.detail.Controls.AddRange( new DataDynamics.ActiveReports.ARControl[] {
            this.uxQuestionText,
            this.uxAnswerText} );
			this.detail.Height = 0.7604167F;
			this.detail.Name = "detail";
			this.detail.NewPage = DataDynamics.ActiveReports.NewPage.After;
			// 
			// pageFooter
			// 
			this.pageFooter.Height = 0.25F;
			this.pageFooter.Name = "pageFooter";
			// 
			// uxQuestionText
			// 
			this.uxQuestionText.Border.BottomColor = System.Drawing.Color.Black;
			this.uxQuestionText.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxQuestionText.Border.LeftColor = System.Drawing.Color.Black;
			this.uxQuestionText.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxQuestionText.Border.RightColor = System.Drawing.Color.Black;
			this.uxQuestionText.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxQuestionText.Border.TopColor = System.Drawing.Color.Black;
			this.uxQuestionText.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxQuestionText.DataField = "Text";
			this.uxQuestionText.Height = 0.1875F;
			this.uxQuestionText.HyperLink = null;
			this.uxQuestionText.Left = 0.1875F;
			this.uxQuestionText.Name = "uxQuestionText";
			this.uxQuestionText.Style = "";
			this.uxQuestionText.Text = "Question Text";
			this.uxQuestionText.Top = 0.125F;
			this.uxQuestionText.Width = 6F;
			// 
			// uxAnswerText
			// 
			this.uxAnswerText.Border.BottomColor = System.Drawing.Color.Black;
			this.uxAnswerText.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxAnswerText.Border.LeftColor = System.Drawing.Color.Black;
			this.uxAnswerText.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxAnswerText.Border.RightColor = System.Drawing.Color.Black;
			this.uxAnswerText.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxAnswerText.Border.TopColor = System.Drawing.Color.Black;
			this.uxAnswerText.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxAnswerText.DataField = "Answer";
			this.uxAnswerText.Height = 0.1875F;
			this.uxAnswerText.HyperLink = null;
			this.uxAnswerText.Left = 0.1875F;
			this.uxAnswerText.Name = "uxAnswerText";
			this.uxAnswerText.Style = "";
			this.uxAnswerText.Text = "Answer Text";
			this.uxAnswerText.Top = 0.4375F;
			this.uxAnswerText.Width = 6F;
			// 
			// SimpleReport
			// 
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.Sections.Add( this.pageHeader );
			this.Sections.Add( this.detail );
			this.Sections.Add( this.pageFooter );
			this.StyleSheet.Add( new DDCssLib.StyleSheetRule( "font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ", "Normal" ) );
			this.StyleSheet.Add( new DDCssLib.StyleSheetRule( "font-size: 16pt; font-weight: bold; ", "Heading1", "Normal" ) );
			this.StyleSheet.Add( new DDCssLib.StyleSheetRule( "font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
						"lic; ", "Heading2", "Normal" ) );
			this.StyleSheet.Add( new DDCssLib.StyleSheetRule( "font-size: 13pt; font-weight: bold; ", "Heading3", "Normal" ) );
			( (System.ComponentModel.ISupportInitialize)( this.uxQuestionText ) ).EndInit( );
			( (System.ComponentModel.ISupportInitialize)( this.uxAnswerText ) ).EndInit( );
			( (System.ComponentModel.ISupportInitialize)( this ) ).EndInit( );

		}
		#endregion

		private DataDynamics.ActiveReports.Label uxQuestionText;
		private DataDynamics.ActiveReports.Label uxAnswerText;
	}
}
