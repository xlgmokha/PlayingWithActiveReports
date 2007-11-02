namespace PlayingWithActiveReports.Core.Reports
{
	/// <summary>
	/// Summary description for ResultsSection.
	/// </summary>
	partial class ResultsSection
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager( typeof( ResultsSection ) );
			this.pageHeader = new DataDynamics.ActiveReports.PageHeader( );
			this.detail = new DataDynamics.ActiveReports.Detail( );
			this.pageFooter = new DataDynamics.ActiveReports.PageFooter( );
			this.uxQuestionTextBox = new DataDynamics.ActiveReports.Label( );
			this.uxAnswerTextBox = new DataDynamics.ActiveReports.Label( );
			( (System.ComponentModel.ISupportInitialize)( this.uxQuestionTextBox ) ).BeginInit( );
			( (System.ComponentModel.ISupportInitialize)( this.uxAnswerTextBox ) ).BeginInit( );
			( (System.ComponentModel.ISupportInitialize)( this ) ).BeginInit( );
			// 
			// pageHeader
			// 
			this.pageHeader.Height = 0F;
			this.pageHeader.Name = "pageHeader";
			// 
			// detail
			// 
			this.detail.ColumnSpacing = 0F;
			this.detail.Controls.AddRange( new DataDynamics.ActiveReports.ARControl[] {
            this.uxQuestionTextBox,
            this.uxAnswerTextBox} );
			this.detail.Height = 0.7916667F;
			this.detail.Name = "detail";
			// 
			// pageFooter
			// 
			this.pageFooter.Height = 0F;
			this.pageFooter.Name = "pageFooter";
			// 
			// uxQuestionTextBox
			// 
			this.uxQuestionTextBox.Border.BottomColor = System.Drawing.Color.Black;
			this.uxQuestionTextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxQuestionTextBox.Border.LeftColor = System.Drawing.Color.Black;
			this.uxQuestionTextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxQuestionTextBox.Border.RightColor = System.Drawing.Color.Black;
			this.uxQuestionTextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxQuestionTextBox.Border.TopColor = System.Drawing.Color.Black;
			this.uxQuestionTextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxQuestionTextBox.DataField = "Text";
			this.uxQuestionTextBox.Height = 0.1979167F;
			this.uxQuestionTextBox.HyperLink = null;
			this.uxQuestionTextBox.Left = 0.125F;
			this.uxQuestionTextBox.Name = "uxQuestionTextBox";
			this.uxQuestionTextBox.Style = "";
			this.uxQuestionTextBox.Text = "label1";
			this.uxQuestionTextBox.Top = 0.0625F;
			this.uxQuestionTextBox.Width = 1F;
			// 
			// uxAnswerTextBox
			// 
			this.uxAnswerTextBox.Border.BottomColor = System.Drawing.Color.Black;
			this.uxAnswerTextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxAnswerTextBox.Border.LeftColor = System.Drawing.Color.Black;
			this.uxAnswerTextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxAnswerTextBox.Border.RightColor = System.Drawing.Color.Black;
			this.uxAnswerTextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxAnswerTextBox.Border.TopColor = System.Drawing.Color.Black;
			this.uxAnswerTextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.uxAnswerTextBox.DataField = "Answer";
			this.uxAnswerTextBox.Height = 0.1979167F;
			this.uxAnswerTextBox.HyperLink = null;
			this.uxAnswerTextBox.Left = 0.125F;
			this.uxAnswerTextBox.Name = "uxAnswerTextBox";
			this.uxAnswerTextBox.Style = "";
			this.uxAnswerTextBox.Text = "label2";
			this.uxAnswerTextBox.Top = 0.3125F;
			this.uxAnswerTextBox.Width = 1F;
			// 
			// ResultsSection
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
			( (System.ComponentModel.ISupportInitialize)( this.uxQuestionTextBox ) ).EndInit( );
			( (System.ComponentModel.ISupportInitialize)( this.uxAnswerTextBox ) ).EndInit( );
			( (System.ComponentModel.ISupportInitialize)( this ) ).EndInit( );

		}
		#endregion

		private DataDynamics.ActiveReports.Label uxQuestionTextBox;
		private DataDynamics.ActiveReports.Label uxAnswerTextBox;
	}
}
